db.Filho.insertMany([
    {_id:"Colaborador01" , children: []},
    {_id:"Colaborador02" , children: []},
    {_id:"Supervisor02", children: []},
    {_id:"Supervisor01", children: ["Colaborador01","Colaborador02"]},
    {_id:"Gerente", children: ["Supervisor01","Supervisor02"]},
    {_id:"Gerente geral", children: ["Gerente"]}
])

db.Filho.findOne({_id:"Supervisor01"}).children