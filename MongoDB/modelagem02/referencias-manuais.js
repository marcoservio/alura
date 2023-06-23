use modelagem02

db.createCollection("clientes",
{ 
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["nome", "cpf", "status_civil", "data_nascimento", "genero", "profissao"],
            properties: {
                nome: {
                    bsonType: "string",
                    maxLength: 150,
                    description: "Informe corretamento o nome do cliente"  
                },
                cpf: {
                    bsonType: "string",
                    minLength: 14,
                    maxLength: 14,
                    description: "Informe corretamento o cpf do cliente"  
                },
                status_civil: {
                    bsonType: "string",
                    enum: ["Solteiro(a)", "Casado(a)", "Separado(a)", "Divorciado(a)", "Viúvo(a)"],
                    description: "Informe corretamento o status_civil do cliente"
                },
                data_nascimento: {
                    bsonType: ["string", "null"],
                    description: "Informe corretamento o data de nascimento do cliente"  
                },
                genero: {
                    bsonType: "string",
                    description: "Informe corretamento o genero do cliente"
                },
                profissao: {
                    bsonType: "string",
                    description: "Informe corretamento o profissao do cliente"
                }
            }
        }
    }
})


db.createCollection("contas",
{
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["numero_conta", "tipo", "cpf", "valor", "agencia"],
            properties: {
                numero_conta: {
                    bsonType: "string",
                    description: "Informe corretamento o nome da conta"  
                },
                tipo: {
                    bsonType: "string",
                    enum: ["Conta corrente", "Conta poupança", "Conta salário"],
                    description: "Informe corretamento o tipo da conta"  
                },
                cpf: {
                    bsonType: "string",
                    minLength: 14,
                    maxLength: 14,
                    description: "Informe corretamento o cpf do cliente na conta"  
                },
                valor: {
                    bsonType: "double",
                    description: "Informe corretamento o valor da conta"    
                },
                agencia: {
                    bsonType: "string",
                    description: "Informe corretamento a agencia"  
                }
            }
        }
    }
})


db.createCollection("endereco",
{
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["rua", "numero", "bairro", "cidade", "estado", "cep"],
            properties: {
                rua: {
                    bsonType: "string"
                },
                numero: {
                    bsonType: "int"
                },
                bairro: {
                    bsonType: "string"
                },
                cidade: {
                    bsonType: "string"
                },
                estado: {
                    bsonType: "string"
                },
                cep: {
                    bsonType: "string"
                }
            }
        }
    }
})


db.clientes.insertOne({
"_id":1,
"nome": "Alana Luan da Paz",
 "cpf": "426.239.760-23",
 "data_nascimento": "16/02/1967",
 "genero": "Masculino", 
 "profissao": "Vendedor em comércio atacadista",
 "status_civil": "Casado(a)"
 })
 
 db.clientes.find()
 
 db.contas.insertOne({
    "_id": 4,
    "id_clientes": 1,
    "numero_conta": "0265177-7", 
    "agencia": "5575", 
    "tipo": "Conta salário", 
    "cpf": "426.239.760-23", 
    "valor": 1.411
 })
 
 db.contas.find()
 
 db.endereco.insertOne({
    "_id": 3,
    "id_clientes": 1,
    "rua":"Vinte e Quatro", 
    "numero": 121, 
    "bairro": "Três Vendas", 
    "cidade":"Pelotas", 
    "estado":"RS", 
    "cep": "96071-380"
 })
 
 db.endereco.find()