db.runCommand({ collMod: "clientes",
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["nome", "cpf", "status_civil", "data_nascimento", "endereco", "genero", "profissao", "contas"],
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
                endereco: {
                    bsonType: "array",
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
                },
                genero: {
                    bsonType: "string",
                    description: "Informe corretamento o genero do cliente"
                },
                profissao: {
                    bsonType: "string",
                    description: "Informe corretamento o profissao do cliente"
                },
                contas: {
                    bsonType: "object",
                    required: ["numero_conta", "tipo", "cpf", "valor", "agencia"],
                    properties: {
                        numero_conta: {
                            bsonType: "string"
                        },
                        tipo: {
                            bsonType: "string",
                            enum: ["Conta corrente", "Conta poupança", "Conta salário"]
                        },
                        cpf: {
                            bsonType: "string",
                            minLength: 14,
                            maxLength: 14
                        },
                        valor: {
                            bsonType: "double"
                        },
                        agencia: {
                            bsonType: "string"
                        }
                    }
                }
            }
        }
    }
})


db.clientes.insertOne({
"_id": 3,
"nome": "Luan Caio da Silva",
"cpf": "520.233.763-94",
"data_nascimento": "14/10/1949",
"genero": "Masculino",
"profissao": "Atendente de farmácia",
"endereco": [{
    "rua": "João Alberto",
    "numero": 224,
    "bairro": "Santa Clara",
    "cidade": "São Luís",
    "estado": "MA",
    "cep": "65058-623"
    },
    {
    "rua": "Rua das Camelias",
    "numero": 333,
    "bairro": "Santa Tereza",
    "cidade": "São Luís",
    "estado": "MA",
    "cep": "65058-623"
    }],
"contas": {
    "numero_Conta": "67314-4",
    "agencia": "5575",
    "tipo": "Conta poupança",
    "cpf": "520.233.763-94",
    "valor": 2.860
    },
"status_civil": "Casado(a)"
})

db.clientes.find()