db.runCommand({collMod:"contas", 
    validator: {
        $jsonSchema: {
            bsonType: "object",
            "additionalProperties": false,
            required: ["_id", "numero_conta", "tipo", "cpf", "valor"],
            properties: {
                _id: {
                    bsonType: "objectId",
                    description: "Informe corretamento o ID da conta" 
                },
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
                }
            }
        }
    },
    validationLevel: "moderate"
})