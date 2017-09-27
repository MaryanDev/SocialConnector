CREATE TABLE [dbo].[Relationships] (
    [Id]                 INT           IDENTITY (1, 1) NOT NULL,
    [DateOfConfirmation] DATETIME2 (7) NULL,
    [FriendId]           INT           NOT NULL,
    [IsConfirmed]        BIT           NOT NULL,
    [SendDate]           DATETIME2 (7) NOT NULL,
    [UserId]             INT           NOT NULL,
    CONSTRAINT [PK_Relationships] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Relationships_Users_FriendId] FOREIGN KEY ([FriendId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Relationships_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Relationships_FriendId]
    ON [dbo].[Relationships]([FriendId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Relationships_UserId]
    ON [dbo].[Relationships]([UserId] ASC);

