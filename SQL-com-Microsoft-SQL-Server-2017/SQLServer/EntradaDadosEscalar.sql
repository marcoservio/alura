CREATE PROCEDURE BuscarNotasClientes
@CPF AS VARCHAR(12),
@DATA_INICIAL AS DATETIME = '20160101',
@DATA_FINAL AS DATETIME = '20161231'
AS
BEGIN
	SELECT * FROM [NOTAS FISCAIS] WHERE CPF = @CPF AND DATA >= @DATA_INICIAL AND DATA <= @DATA_FINAL;
END;

SELECT * FROM [TABELA DE CLIENTES];

EXEC BuscarNotasClientes @CPF = '19290992743';

EXEC BuscarNotasClientes @CPF = '19290992743', @DATA_INICIAL = '20161201';

EXEC BuscarNotasClientes @CPF = '19290992743', @DATA_FINAL = '20160131';

EXEC BuscarNotasClientes  @DATA_FINAL = '20160131', @CPF = '19290992743', @DATA_INICIAL = '20160101';

EXEC BuscarNotasClientes '19290992743';

EXEC BuscarNotasClientes '19290992743', '20160101', '20160131';