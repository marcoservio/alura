SELECT CONVERT(VARCHAR, GETDATE(), 1)

SELECT CONVERT(VARCHAR, GETDATE(), 101)

SELECT CONVERT(VARCHAR, GETDATE(), 102)

SELECT CONVERT(VARCHAR, GETDATE(), 103)

SELECT CONVERT(VARCHAR, GETDATE(), 106)

SELECT CONVERT(VARCHAR, GETDATE(), 109)

SELECT CONVERT(VARCHAR, GETDATE(), 113)

SELECT CONVERT(VARCHAR, GETDATE(), 130)

SELECT CONVERT(decimal(10,5), 193.57)

SELECT CONVERT(decimal(10,2), 193.57)

SELECT * FROM [TABELA DE PRODUTOS]

SELECT 'O pre�o do produto ' + [NOME DO PRODUTO] + ' � ' +  [PRE�O DE LISTA] 
FROM [TABELA DE PRODUTOS] --ERRO

SELECT 'O pre�o do produto ' + [NOME DO PRODUTO] + ' � ' +  CONVERT(VARCHAR, [PRE�O DE LISTA]) 
FROM [TABELA DE PRODUTOS]

SELECT * FROM [TABELA DE CLIENTES]

SELECT * FROM [NOTAS FISCAIS]

SELECT * FROM [ITENS NOTAS FISCAIS]

SELECT CONCAT('O Cliente ', C.[NOME], ' faturou ', 
CONVERT(VARCHAR, CONVERT(DECIMAL(15,2), (SUM(INF.QUANTIDADE * INF.PRE�O)))), ' no ano de ', CONVERT(VARCHAR, YEAR(NF.DATA)))
FROM [TABELA DE CLIENTES] C
INNER JOIN [NOTAS FISCAIS] NF ON C.CPF = NF.CPF
INNER JOIN [ITENS NOTAS FISCAIS] INF ON NF.NUMERO = INF.NUMERO
WHERE YEAR(NF.DATA) = 2016
GROUP BY C.NOME, YEAR(NF.DATA);