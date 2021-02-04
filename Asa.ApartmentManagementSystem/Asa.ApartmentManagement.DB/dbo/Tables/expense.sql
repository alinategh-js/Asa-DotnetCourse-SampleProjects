CREATE TABLE [dbo].[expense]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [title] NVARCHAR(20) NOT NULL, 
    [category] CHAR(10) NOT NULL, 
    [from] DATETIME NOT NULL, 
    [to] DATETIME NOT NULL, 
    [cost] DECIMAL NOT NULL
)
