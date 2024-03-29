SELECT COUNT(*) FROM [NOTAS FISCAIS] WHERE CPF = '19290992743'
AND YEAR(DATA) = 2016

SELECT SUM(QUANTIDADE * [PRE�O]) FROM [ITENS NOTAS FISCAIS] B
INNER JOIN [NOTAS FISCAIS] A ON A.NUMERO = B.NUMERO
WHERE CPF = '19290992743'
AND YEAR(DATA) = 2016

CREATE PROCEDURE RetornaValores 
@CPF AS VARCHAR(12), 
@ANO AS INT, 
@NUM_NOTAS AS INT OUTPUT,
@FATURAMENTO AS FLOAT OUTPUT
AS
BEGIN
	SELECT @NUM_NOTAS = COUNT(*) FROM [NOTAS FISCAIS] 
	WHERE CPF = @CPF
	AND YEAR(DATA) = @ANO

	SELECT @FATURAMENTO = SUM(QUANTIDADE * [PRE�O]) FROM [ITENS NOTAS FISCAIS] B
	INNER JOIN [NOTAS FISCAIS] A ON A.NUMERO = B.NUMERO
	WHERE CPF = @CPF
	AND YEAR(DATA) = @ANO
END

DECLARE @NUMERO_NOTAS INT, @FATURAMENTO FLOAT
DECLARE @CPF VARCHAR(12), @ANO INT

SET @CPF = '19290992743'
SET @ANO = 2016

EXEC RetornaValores @CPF, @ANO, @NUMERO_NOTAS OUTPUT, @FATURAMENTO OUTPUT

SELECT @NUMERO_NOTAS, @FATURAMENTO



SELECT COUNT(*) FROM [NOTAS FISCAIS] WHERE DATA = '20170101'

CREATE PROCEDURE NumNotasSP
@DATA AS DATE,
@NUMNOTAS AS INT OUTPUT
AS
BEGIN
	DECLARE @NUM_NOTAS_LOCAL INT
	SELECT @NUM_NOTAS_LOCAL = COUNT(*) FROM [NOTAS FISCAIS] WHERE DATA = @DATA
	SET @NUMNOTAS = @NUMNOTAS + @NUM_NOTAS_LOCAL
END 

DECLARE @DATA DATE, @NUMNOTAS INT

SET @DATA = '20170101'
SET @NUMNOTAS = 0

EXEC NumNotasSP @DATA, @NUMNOTAS OUTPUT
SELECT @NUMNOTAS;
SET @DATA = '20170101'
EXEC NumNotasSP @DATA, @NUMNOTAS OUTPUT
SELECT @NUMNOTAS;