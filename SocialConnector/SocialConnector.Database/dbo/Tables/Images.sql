CREATE TABLE [dbo].[Images] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [GroupId] INT            NULL,
    [Path]    NVARCHAR (MAX) NULL,
    [UserId]  INT            NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Images_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id]),
    CONSTRAINT [FK_Images_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Images_GroupId]
    ON [dbo].[Images]([GroupId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Images_UserId]
    ON [dbo].[Images]([UserId] ASC);

