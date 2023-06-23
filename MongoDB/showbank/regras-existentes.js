db.getCollectionInfos({name:"clientes"})
db.getCollectionInfos({name:"contas"})

db.runCommand({listCollections: 1, filter:{name: "contas"}})
db.runCommand({listCollections: 2})