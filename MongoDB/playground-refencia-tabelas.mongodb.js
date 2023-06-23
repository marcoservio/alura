use("modelagem02")

original_id = ObjectId()

db.clientes.insertOne({
    "_id": original_id,
    "nome": "Gustavo Marcos dos Santos",
    "cpf": "426.239.760-23",
    "data_nascimento": "16/02/1967",
    "genero": "Masculino",
    "profissao": "Gerente de vendas",
    "status_civil": "Casado(a)"
})

db.contas.insertOne({
    "_id": ObjectId(),
    "creator": {
        "$ref": "clientes",
        "$id": original_id,
        "$db": "modelagem02"
    },
    "numero_conta": "0265177-7",
    "agencia": "5575",
    "tipo": "Conta salário",
    "cpf": "426.239.760-23",
    "valor": 1.411
})

db.endereco.insertOne({
    "creator": {
        "$ref": "clientes",
        "$id": original_id,
        "$db": "modelagem02"
    },
    "rua": "Vinte e Quatro",
    "numero": 121,
    "bairro": "Três Vendas",
    "cidade": "Pelotas",
    "estado": "RS",
    "cep": "96071-380"
})

//6491ba5b3d1e48a9c7d3b4b7
//6491ba5b3d1e48a9c7d3b4b7

use("modelagem02")
db.contas.find()