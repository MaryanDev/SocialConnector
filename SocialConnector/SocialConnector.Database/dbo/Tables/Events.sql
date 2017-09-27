CREATE TABLE [dbo].[Events] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [AuthorId]    INT            NOT NULL,
    [CategoryId]  INT            NOT NULL,
    [DateStarted] DATETIME2 (7)  NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [ImageId]     INT            NULL,
    [Title]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Events_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]),
    CONSTRAINT [FK_Events_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [dbo].[Images] ([Id]),
    CONSTRAINT [FK_Events_Users_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Events_AuthorId]
    ON [dbo].[Events]([AuthorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Events_CategoryId]
    ON [dbo].[Events]([CategoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Events_ImageId]
    ON [dbo].[Events]([ImageId] ASC);

