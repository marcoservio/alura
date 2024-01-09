from acesso_cep import BuscaEndereco
import requests


def main():
    cep = 32241395
    obj = BuscaEndereco(cep)
    bairro, cidade, uf = obj.acessa_via_cep()
    print(bairro, cidade, uf)


if __name__ == "__main__":
    main()
