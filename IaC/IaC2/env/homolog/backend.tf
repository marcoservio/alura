terraform {
  backend "s3" {
    bucket = "nomebucket"
    key    = "homolog/terraform.tfstate"
    region = "us-west-2"
  }
}
