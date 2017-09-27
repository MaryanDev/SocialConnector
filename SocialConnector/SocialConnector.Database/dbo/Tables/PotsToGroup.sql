CREATE TABLE [dbo].[PotsToGroup] (
    [PostId]  INT NOT NULL,
    [GroupId] INT NOT NULL,
    CONSTRAINT [PK_PotsToGroup] PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_PotsToGroup_Groups_GroupId] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id]),
    CONSTRAINT [FK_PotsToGroup_Posts_PostId] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_PotsToGroup_GroupId]
    ON [dbo].[PotsToGroup]([GroupId] ASC);

