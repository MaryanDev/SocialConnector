CREATE TABLE [dbo].[InterestsToUsers] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [InterestId] INT NULL,
    [UserId]     INT NULL,
    CONSTRAINT [PK_InterestsToUsers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_InterestsToUsers_Interests_InterestId] FOREIGN KEY ([InterestId]) REFERENCES [dbo].[Interests] ([Id]),
    CONSTRAINT [FK_InterestsToUsers_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_InterestsToUsers_InterestId]
    ON [dbo].[InterestsToUsers]([InterestId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_InterestsToUsers_UserId]
    ON [dbo].[InterestsToUsers]([UserId] ASC);

