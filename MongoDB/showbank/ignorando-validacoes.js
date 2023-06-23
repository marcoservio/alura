db.runCommand({insert: "contas",
    documents: [
            {
                "numero_conta": "04938-1",
                "agencia": "5575",
                "tipo": "conta salario",
                "cpf": "106.064.356.11",
                "valor": "300"
            }],
        bypassDocumentValidation: true
})

db.contas.find()
   .projection({})
   .sort({_id:-1})
   .limit(100)