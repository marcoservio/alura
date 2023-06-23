db.clientes. insertOne({
    "_id": 3,
    "nome": "Marcos Benedito Rodrigues",
    "cpf": "099.632.834-38",
    "data_nascimento": "18/10/1972",
    "genero": "Masculino",
    "profissao": "Professor do EJA ensino fundamental",
    "status_civil": "Casado(a)"
})

db.endereco.insertMany([
    {"_id": 1,
    "creator" : {
        "$ref": "clientes",
        "$id":3,
        "$db": "modelagem02"},
    "rua": "Rua das Acácias",
    "numero": 287,
    "bairro":"Centro",
    "cidade": "Parnamirim",
    "estado":"RN",
    "cep":"59140-030"
},{
    "_id": 2,
    "creator" : {
        "Sref": "clientes",
        "$id":3,
        "$db": "modelagem02"},
    "rua": "Rua das Acácias",
    "numero": 287,
    "bairro":"Centro",
    "cidade": "Parnamirim",
    "estado": "RN",
    "cep":"59140-030"
    }])

db.contas. insertOne({
    "_id": 1,
    "creator" : {
        "$ref": "clientes",
        "$id":3,
        "$db": "modelagem02"},
    "numero_conta": "1095052-4",
    "agencia": "5575",
    "tipo": "Conta poupança",
    "cpf": "099.632.834-38",
    "valor": 9.855
})

db.endereco.find()