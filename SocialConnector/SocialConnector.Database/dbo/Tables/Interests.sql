CREATE TABLE [dbo].[Interests] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CategoryId] INT            NULL,
    [Title]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Interests] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Interests_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Interests_CategoryId]
    ON [dbo].[Interests]([CategoryId] ASC);

