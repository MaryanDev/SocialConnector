CREATE TABLE [dbo].[Messages] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [FromUserId] INT            NOT NULL,
    [SendDate]   DATETIME2 (7)  NOT NULL,
    [Text]       NVARCHAR (MAX) NULL,
    [ToUserId]   INT            NOT NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Messages_Users_FromUserId] FOREIGN KEY ([FromUserId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Messages_Users_ToUserId] FOREIGN KEY ([ToUserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Messages_FromUserId]
    ON [dbo].[Messages]([FromUserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Messages_ToUserId]
    ON [dbo].[Messages]([ToUserId] ASC);

