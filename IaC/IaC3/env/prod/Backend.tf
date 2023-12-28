terraform {
  backend "s3" {
    bucket = "nomebucket"
    key    = "prod/terraform.tfstate"
    region = "us-west-2"
  }
}
