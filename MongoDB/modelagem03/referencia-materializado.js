db.Materializados.insertMany([
    {_id:"Gerente Geral", path: null},    
    {_id:"Gerente", path: "Gerente Geral"},    
    {_id:"Supervisor01", path: "Gerente Geral, Gerente"},    
    {_id:"Supervisor02", path: "Gerente Geral, Gerente"},    
    {_id:"Colaborador01", path: "Gerente Geral, Gerente, Supervisor02"},    
    {_id:"Colaborador02", path: "Gerente Geral, Gerente, Supervisor02"},    
])

db.Materializados.findOne({path:"Gerente Geral"})