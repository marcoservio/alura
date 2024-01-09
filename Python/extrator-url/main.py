def main():
    url = (
        "https://bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&quantidade=100"
    )

    url = url.strip()

    if url == "":
        raise ValueError("A URL está vazia!")

    indice_interrogacao = url.find("?")

    if indice_interrogacao != -1:
        url_base = url[:indice_interrogacao]

        url_parametros = url[indice_interrogacao + 1 :]
        print(url_parametros)

        parametro_busca = "moedaDestino"
        indice_parametro = url_parametros.find(parametro_busca)
        indice_valor = indice_parametro + len(parametro_busca) + 1
        indice_e_comercial = url_parametros.find("&", indice_valor)
        if indice_e_comercial == -1:
            valor = url_parametros[indice_valor:]
        else:
            valor = url_parametros[indice_valor:indice_e_comercial]

        print(valor)


if __name__ == "__main__":
    main()
