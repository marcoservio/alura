INSERT INTO [dbo].[PRODUTOS]
([CODIGO_PRO], [NOME_PRO], [EMBALAGEM], [TAMANHO], [SABOR], [PRECO_LISTA])
VALUES
('788975', 'Peda�os de Frutas - 1,5 Litros - Ma�a', 'PET', '1,5 Litros', 'Ma�a', 18.01);

ALTER TABLE [dbo].[PRODUTOS] 
ADD CONSTRAINT PK_PRODUTOS
PRIMARY KEY CLUSTERED (CODIGO_PRO);

ALTER TABLE [dbo].[PRODUTOS]
ALTER COLUMN [CODIGO_PRO]
NVARCHAR(10) NOT NULL