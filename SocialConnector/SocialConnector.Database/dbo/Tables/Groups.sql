CREATE TABLE [dbo].[Groups] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [OwnerId]     INT            NOT NULL,
    [Title]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Groups_Users_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Groups_OwnerId]
    ON [dbo].[Groups]([OwnerId] ASC);

