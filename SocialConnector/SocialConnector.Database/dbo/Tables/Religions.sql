CREATE TABLE [dbo].[Religions] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Religions] PRIMARY KEY CLUSTERED ([Id] ASC)
);

