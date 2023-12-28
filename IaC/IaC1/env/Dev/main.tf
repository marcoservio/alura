module "aws-dev" {
  source          = "../../infra"
  instancia       = "t2.micro"
  regiao_aws      = "us-west-2"
  chave           = "IaC-DEV"
  grupo_seguranca = "DEV"
  minimo          = 0
  maximo          = 1
  nome_grupo      = "DEV"
  producao        = false
}

# output "IP" {
#   value = module.aws-dev.IP_publico
# }
