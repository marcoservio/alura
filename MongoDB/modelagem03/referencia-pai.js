db.Pai.insertMany([
    {_id:"Colaborador01" , parent:"Supervisor02"},
    {_id:"Colaborador02" , parent:"Supervisor02"},
    {_id:"Supervisor02", parent:"Gerente"},
    {_id:"Supervisor01", parent:"Gerente"},
    {_id:"Gerente", parent:"Gerente geral"},
    {_id:"Gerente geral", parent: null}
])

db.Pai.findOne({_id:"Gerente"}).parent