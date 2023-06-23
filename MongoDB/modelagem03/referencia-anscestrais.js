db.Ancestrais.insertMany([
    {_id:"Colaborador01", ancestors:["Gerente Geral", "Gerente", "Supervisor02"], parent: "Supervisor02"},
    {_id:"Colaborador02", ancestors:["Gerente Geral", "Gerente", "Supervisor02"], parent: "Supervisor02"},
    {_id:"Supervidor01", ancestors:["Gerente Geral", "Gerente"], parent: "Gerente"},
    {_id:"Supervidor02", ancestors:["Gerente Geral", "Gerente"], parent: "Gerente"},
    {_id:"Gerente", ancestors:["Gerente Geral"], parent: "Gerente Geral"},
    {_id:"Gerente Geral", ancestors:[], parent: null}
])

db.Ancestrais.findOne({_id:"Colaborador01"}).ancestors
db.Ancestrais.findOne({_id:"Colaborador01"}).parent