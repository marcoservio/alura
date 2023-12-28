module "Producao" {
  source    = "../../infra"
  nome      = "producao"
  descricao = "aplicacao-producao"
  max       = 5
  maquina   = "t2.micro"
  ambiente  = "ambiente-producao"
}
