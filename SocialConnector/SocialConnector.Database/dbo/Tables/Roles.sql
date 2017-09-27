CREATE TABLE [dbo].[Roles] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [RoleTitle] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

