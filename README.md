# EF_Core_Code_First_V1
para a execução é necessário após os comandos
Add-Migration Initial
Add-Migration Update

Em seguida incluir valores na tabela
insert into [dbo].[Orders] (CustomerID, EmployeeID, OrderDate) values(1,1,CURRENT_TIMESTAMP)
