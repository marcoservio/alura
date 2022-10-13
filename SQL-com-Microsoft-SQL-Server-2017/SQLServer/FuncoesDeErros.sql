CREATE PROCEDURE [dbo].[TrataErroZeroTry2]
@CPF AS VARCHAR(12), 
@ANO AS INT,
@DENOMINADOR AS INT,
@MENSAGEM VARCHAR(MAX) OUTPUT
AS
BEGIN
	BEGIN TRY
		SELECT SUM(A.QUANTIDADE * A.[PRE�O]) AS FATURAMENTO,
		SUM(A.QUANTIDADE * A.[PRE�O]) / @DENOMINADOR AS COMISSAO
		FROM [ITENS NOTAS FISCAIS] A INNER JOIN [NOTAS FISCAIS] B
		ON A.NUMERO = B.NUMERO
		WHERE B.CPF = @CPF
		AND YEAR(B.DATA) = @ANO;
	END TRY
	BEGIN CATCH
		SET @MENSAGEM = 'Houve um erro n�mero: ' + CONVERT(VARCHAR(10), ERROR_NUMBER()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Menssagem: ' + ERROR_MESSAGE() + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Grau de severidade do erro: ' + CONVERT(VARCHAR(10), ERROR_SEVERITY()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Estado do erro: ' + CONVERT(VARCHAR(10), ERROR_STATE()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'N�mero da linha: ' + CONVERT(VARCHAR(10), ERROR_LINE()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Procedure: ' + ERROR_PROCEDURE() + '.'
	END CATCH
END

DECLARE @DENOMINADOR INT
DECLARE @CPF VARCHAR(12)
DECLARE @ANO INT
DECLARE @MENSAGEM VARCHAR(MAX)

SET @CPF = '1471156710'
SET @DENOMINADOR = 0
SET @ANO = 2016
SET @MENSAGEM = ''

EXEC [TrataErroZeroTry2] @CPF, @ANO, @DENOMINADOR, @MENSAGEM OUTPUT

IF @MENSAGEM <> ''
	PRINT @MENSAGEM

SELECT * FROM [TABELA DE CLIENTES]



CREATE PROCEDURE [dbo].[InclusaoVendedor4]
@MATRICULA AS VARCHAR(5), @NOME AS VARCHAR(100), @PERCENTUAL AS FLOAT,
@DATAADMISSAO AS DATE, @FERIAS AS BIT, @BAIRRO AS VARCHAR(50),
@MENSAGEM VARCHAR(MAX) OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO [TABELA DE VENDEDORES] (MATRICULA, NOME, [PERCENTUAL COMISS�O], [DATA ADMISS�O], [DE FERIAS], BAIRRO)
		VALUES (@MATRICULA, @NOME, @PERCENTUAL, @DATAADMISSAO, @FERIAS, @BAIRRO)
	END TRY
	BEGIN CATCH
		SET @MENSAGEM = 'Houve um erro n�mero: ' + CONVERT(VARCHAR(10), ERROR_NUMBER()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Menssagem: ' + ERROR_MESSAGE() + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Grau de severidade do erro: ' + CONVERT(VARCHAR(10), ERROR_SEVERITY()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Estado do erro: ' + CONVERT(VARCHAR(10), ERROR_STATE()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'N�mero da linha: ' + CONVERT(VARCHAR(10), ERROR_LINE()) + ' - '
		SET @MENSAGEM = @MENSAGEM + 'Procedure: ' + ERROR_PROCEDURE() + '.'
	END CATCH
END

DECLARE @MENSAGEM VARCHAR(MAX)
SET @MENSAGEM = ''

EXEC InclusaoVendedor4 '00235','Pericles Alves',0.11,'20160821',0,'Santo Amaro', @MENSAGEM OUTPUT

IF @MENSAGEM <> ''
	PRINT @MENSAGEM

SELECT * FROM [TABELA DE VENDEDORES]