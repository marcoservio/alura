from fastapi import FastAPI, Query
import requests

app = FastAPI()
# http://127.0.0.1:5000/docs => documentação api swagger


@app.get("/api/hello")
def hello_world():
    """
    Endpoint que exibe uma mensagem incrivel do mundo da programação
    """
    return {"Hello": "World"}


@app.get("/api/restaurantes/")
# http://127.0.0.1:5000/api/restaurantes/?restaurante=McDonald's
def get_restaurantes(restaurante: str = Query(None)):
    """
    Endpoint para ver os cardapios dos restaurantes
    """
    url = "https://guilhermeonrails.github.io/api-restaurantes/restaurantes.json"
    response = requests.get(url)

    if response.status_code == 200:
        dados_jason = response.json()
        if restaurante is None:
            return {"Dados": dados_jason}

        dados_restaurante = []
        for item in dados_jason:
            if item["Company"] == restaurante:
                dados_restaurante.append(
                    {
                        "item": item["Item"],
                        "price": item["price"],
                        "description": item["description"],
                    }
                )
        return {"Restaurante": restaurante, "Cardapio": dados_restaurante}
    else:
        return {"Erro:" f"{response.status_code} - {response.text}"}
