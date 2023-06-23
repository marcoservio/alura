use showbank

db.createCollection("clientes", {
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["nome", "cpf", "status_civil", "data_nascimento", "endereco"],
            properties: {
                nome: {
                    bsonType: "string",
                    description: "Informe corretamento o nome do cliente"  
                },
                cpf: {
                    bsonType: "string",
                    description: "Informe corretamento o cpf do cliente"  
                },
                status_civil: {
                    bsonType: "string",
                    enum: ["Solteiro(a)", "Casado(a)", "Separado(a)", "Divorciado(a)", "Viúvo(a)"],
                    description: "Informe corretamento o status_civil do cliente"
                },
                data_nascimento: {
                    bsonType: "string",
                    description: "Informe corretamento o data de nascimento do cliente"  
                },
                endereco: {
                    bsonType: "string",
                    description: "Informe corretamento o endereco do cliente"  
                }
            }
        }
    }
})