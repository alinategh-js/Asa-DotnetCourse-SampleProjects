CREATE TABLE [dbo].[expense]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [title] NVARCHAR(20) NOT NULL, 
    [category_id] int NOT NULL, 
    [from] DATETIME NOT NULL, 
    [to] DATETIME NOT NULL, 
    [cost] DECIMAL NOT NULL,
    CONSTRAINT [PK_expense] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_expense_expense_category] FOREIGN KEY ([category_id]) REFERENCES [dbo].[expense_category]([Id]),
)
