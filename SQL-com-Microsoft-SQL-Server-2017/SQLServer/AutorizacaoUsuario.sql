SELECT * FROM SYS.fn_builtin_permissions('') WHERE CLASS_DESC = 'SERVER'

USE SUCOS_VENDAS

CREATE LOGIN jorge WITH PASSWORD = 'jorge@123'
CREATE USER jorge FOR LOGIN jorge

USE SUCOS_VENDAS
EXEC sp_addrolemember 'db_datareader', 'jorge'
EXEC sp_addrolemember 'db_datawriter', 'jorge'