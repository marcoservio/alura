db.runCommand( { collMod: "clientes", 
    validator: {
        $jsonSchema: {
            bsonType: "object",
            "additionalProperties": false,
            required: ["_id", "nome", "cpf", "status_civil", "data_nascimento", "endereco", "genero", "profissao"],
            properties: {
                _id: {
                    bsonType: "objectId",
                    description: "Informe corretamento o ID do cliente" 
                },
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
                    bsonType: "string",
                    description: "Informe corretamento o endereco do cliente"  
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
    },
    validationAction: "warn"
})