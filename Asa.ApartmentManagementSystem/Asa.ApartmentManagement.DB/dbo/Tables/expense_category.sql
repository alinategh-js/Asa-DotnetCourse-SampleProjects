CREATE TABLE [dbo].[expense_category]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(20) NOT NULL, 
    [formula] CHAR(10) NOT NULL
)
