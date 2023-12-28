module "Homologacao" {
  source    = "../../infra"
  nome      = "homologacao"
  descricao = "aplicacao-homologacao"
  max       = 3
  maquina   = "t2.micro"
  ambiente  = "ambiente-homologacao"
}
