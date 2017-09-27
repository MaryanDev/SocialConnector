CREATE TABLE [dbo].[Posts] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [AuthorId]      INT            NOT NULL,
    [ImageId]       INT            NULL,
    [PublishedDate] DATETIME2 (7)  NOT NULL,
    [Text]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Posts_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [dbo].[Images] ([Id]),
    CONSTRAINT [FK_Posts_Users_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Posts_AuthorId]
    ON [dbo].[Posts]([AuthorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Posts_ImageId]
    ON [dbo].[Posts]([ImageId] ASC);

