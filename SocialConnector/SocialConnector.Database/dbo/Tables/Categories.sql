﻿CREATE TABLE [dbo].[Categories] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);

