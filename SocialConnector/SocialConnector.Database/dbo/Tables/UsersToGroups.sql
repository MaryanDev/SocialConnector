CREATE TABLE [dbo].[UsersToGroups] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [GroupId]   INT NOT NULL,
    [IsContact] BIT NOT NULL,
    [UserId]    INT NOT NULL,
    CONSTRAINT [PK_UsersToGroups] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UsersToGroups_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id]),
    CONSTRAINT [FK_UsersToGroups_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_UsersToGroups_GroupId]
    ON [dbo].[UsersToGroups]([GroupId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UsersToGroups_UserId]
    ON [dbo].[UsersToGroups]([UserId] ASC);

