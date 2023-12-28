module "ecs" {
  source             = "terraform-aws-modules/ecs/aws"
  name               = var.ambiente
  container_insights = true
  capacity_providers = ["FARGATE"]
  fargate_capacity_providers = [
    {
      capacity_providers = "FARGATE"
    }
  ]
}

resource "aws_ecs_task_definition" "django-api" {
  family                   = "django-api"
  requires_compatibilities = ["FARGATE"]
  network_mode             = "awsvpc"
  cpu                      = 256
  memory                   = 512
  execution_role_arn       = aws_iam_role.cargo.arn
  container_definitions = jsonencode(
    [
      {
        "name"      = "producao"
        "image"     = "mcr.microsoft.com/windows/servercore/iis"
        "cpu"       = 256
        "memory"    = 512
        "essential" = true
        "portMappings" = [
          {
            "containerPort" = 8000
            "hostPort"      = 8000
          }
        ]
      }
    ]
  )
}

resource "aws_ecs_service" "django-api" {
  name            = "django-api"
  cluster         = module.ecs.ecs_cluster_id
  task_definition = aws_ecs_task_definition.django-api.arn
  desired_count   = 3

  load_balancer {
    target_group_arn = aws_lb_target_group.alvo.arn
    container_name   = "producao"
    container_port   = 8000
  }

  network_configuration {
    subnets         = module.vpc.private_subnets
    security_groups = [aws_security_group.privado.id]
  }

  capacity_provider_strategy {
    capacity_provider = "FARGATE"
    weight            = 1
  }
}
