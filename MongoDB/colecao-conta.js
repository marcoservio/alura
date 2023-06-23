db.createCollection("contas", {
    validator: {
        $jsonSchema: {
            bsonType: "object",
            required: ["numero_conta", "tipo", "cpf"],
            properties: {
                numero_conta: {
                    bsonType: "string",
                    description: "Informe corretamento o nome da conta"  
                },
                tipo: {
                    bsonType: "string",
                    enum: ["Conta corrente", "Conta poupança", "Canta salário"],
                    description: "Informe corretamento o tipo da conta"  
                },
                cpf: {
                    bsonType: "string",
                    description: "Informe corretamento o cpf do cliente na conta"  
                }
            }
        }
    }
})