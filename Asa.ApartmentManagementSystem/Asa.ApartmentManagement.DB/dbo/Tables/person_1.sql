﻿CREATE TABLE [dbo].[person] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [full_name]    NVARCHAR (50) NOT NULL,
    [phone_number] NVARCHAR (15) NOT NULL,
    [unit_id] INT NOT NULL, 
    CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_person_units] FOREIGN KEY ([unit_id]) REFERENCES [dbo].[Units] ([Id])
);

