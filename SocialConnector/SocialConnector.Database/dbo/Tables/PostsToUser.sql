CREATE TABLE [dbo].[PostsToUser] (
    [PostId] INT NOT NULL,
    [UserId] INT NULL,
    CONSTRAINT [PK_PostsToUser] PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_PostsToUser_Posts_PostId] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([Id]),
    CONSTRAINT [FK_PostsToUser_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_PostsToUser_UserId]
    ON [dbo].[PostsToUser]([UserId] ASC);

