CREATE TABLE [dbo].[Users] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Avatar]        NVARCHAR (MAX) NULL,
    [DateOfBirth]   DATETIME2 (7)  NULL,
    [DateStarted]   DATETIME2 (7)  NULL,
    [Email]         NVARCHAR (MAX) NULL,
    [FirstName]     NVARCHAR (MAX) NULL,
    [GenderId]      INT            NOT NULL,
    [LastName]      NVARCHAR (MAX) NULL,
    [NationalityId] INT            NULL,
    [Password]      NVARCHAR (MAX) NULL,
    [PlaceOfBirth]  NVARCHAR (MAX) NULL,
    [ReligionId]    INT            NULL,
    [RoleId]        INT            NOT NULL,
    [UserName]      NVARCHAR (MAX) NULL,
    [WorkPlace]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Genders_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders] ([Id]),
    CONSTRAINT [FK_Users_Nationalities_NationalityId] FOREIGN KEY ([NationalityId]) REFERENCES [dbo].[Nationalities] ([Id]),
    CONSTRAINT [FK_Users_Religions_ReligionId] FOREIGN KEY ([ReligionId]) REFERENCES [dbo].[Religions] ([Id]),
    CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Users_GenderId]
    ON [dbo].[Users]([GenderId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Users_NationalityId]
    ON [dbo].[Users]([NationalityId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Users_ReligionId]
    ON [dbo].[Users]([ReligionId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Users_RoleId]
    ON [dbo].[Users]([RoleId] ASC);

