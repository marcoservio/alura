db.clientes.insertOne({
    "nome": "Marco Sérvio Almeida Capanema",
    "cpf": "106.064.356.11",
    "data_nascimento": "31/07/1997",
    "genero": "Masculino",
    "profissao": "Desenvolvedor",
    "endereco": "Av Marte 948 Apto 203 Bloco 33 Jardim Riacho Contagem MG",
    "status_civil": "Casado(a)"
})

db.clientes.find()
db.contas.find()

db.contas.insertOne({
    "numero_conta": "04938-1",
    "agencia": "5575",
    "tipo": "Conta salário",
    "cpf": "106.064.356.11",
    "valor": "300"
})

db.clientes.insertOne({
    "nome": "Caue Luan da Paz",
    "cpf": "312.145.123.23",
    "data_nascimento": "31/08/1997",
    "genero": "Masculino",
    "profissao": "Desenvolvedor",
    "endereco": "Av Marte 948 Apto 203 Bloco 33 Jardim Riacho Contagem MG",
    "status_civil": "Casado(a)"
})

db.contas.insertOne({
    "numero_conta": "0591238-1",
    "agencia": "0987",
    "tipo": "Conta salário",
    "cpf": "312.145.123.23",
    "valor": "1341"
})