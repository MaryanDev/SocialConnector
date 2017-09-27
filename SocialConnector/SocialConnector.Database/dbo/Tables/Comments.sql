CREATE TABLE [dbo].[Comments] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [AuthorId]    INT            NOT NULL,
    [PostId]      INT            NOT NULL,
    [PublishDate] DATETIME2 (7)  NOT NULL,
    [Text]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comments_Posts_PostId] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([Id]),
    CONSTRAINT [FK_Comments_Users_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_AuthorId]
    ON [dbo].[Comments]([AuthorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Comments_PostId]
    ON [dbo].[Comments]([PostId] ASC);

