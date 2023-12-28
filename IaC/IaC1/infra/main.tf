terraform {
  required_providers {
    aws = {
      source  = "hashicorp/aws"
      version = "~> 3.27"
    }
  }

  required_version = ">= 0.14.9"
}

provider "aws" {
  profile = "default"
  region  = var.regiao_aws
}

# resource "aws_instance" "app-server" {
#   ami           = "ami-053b0d53c279acc90"
#   instance_type = var.instancia
#   key_name      = var.chave
#   tags = {
#     Name = "Terraform Ansible Python"
#   }
# }

resource "aws_launch_template" "maquina" {
  image_id      = "ami-053b0d53c279acc90"
  instance_type = var.instancia
  key_name      = var.chave
  tags = {
    Name = "Terraform Ansible Python"
  }
  security_group_names = [var.grupo_seguranca]
  user_data            = var.producao ? filebase64("ansible.sh") : ""
}

resource "aws_key_pair" "chaveSSH" {
  key_name   = var.chave
  public_key = file("${var.chave}.pub")
}

# output "IP_publico" {
#   value = aws_instance.app-server.public_ip
# }

resource "aws_autoscaling_group" "grupo" {
  availability_zones = ["${var.regiao_aws}a", "${var.regiao_aws}b"]
  name               = var.nome_grupo
  max_size           = var.maximo
  min_size           = var.minimo
  target_group_arns  = var.producao ? [aws_lb_target_group.alvoLoadBalancer[0].arn] : []
  launch_template {
    id      = aws_launch_template.maquina.id
    version = "$Latest"
  }
}

resource "aws_default_subnet" "subnet_1" {
  availability_zones = "${var.regiao_aws}a"
}

resource "aws_default_subnet" "subnet_2" {
  availability_zones = "${var.regiao_aws}b"
}

resource "aws_lb" "loadBalancer" {
  internal = false
  subnets  = [aws_default_subnet.subnet_1.id, aws_default_subnet.subnet_2.id]
  count    = var.producao ? 1 : 0
}

resource "aws_default_vpc" "default" {

}

resource "aws_lb_target_group" "alvoLoadBalancer" {
  name     = "maquinasAlvo"
  port     = "8000"
  protocol = "HTTP"
  vpc_id   = aws_default_vpc.default.id
  count    = var.producao ? 1 : 0
}

resource "aws_lb_listener" "entradaLoadBalancer" {
  load_balancer_arn = aws_lb.loadBalancer[0].arn
  port              = "8000"
  protocol          = "HTTP"
  default_action {
    type             = "forward"
    target_group_arn = aws_lb_target_group.alvoLoadBalancer[0].arn
  }
  count = var.producao ? 1 : 0
}

resource "aws_autoscaling_policy" "escala-Producao" {
  name                   = "terraform-escala"
  autoscaling_group_name = var.nome_grupo
  policy_type            = "TargetTrackingScaling"
  target_tracking_configuration {
    predefined_metric_specification {
      predefined_metric_type = "ASGAverageCPUUtilization"
    }
    target_value = 50.0
  }
  count = var.producao ? 1 : 0
}
