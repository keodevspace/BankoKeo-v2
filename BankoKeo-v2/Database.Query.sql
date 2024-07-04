CREATE DATABASE [Bankokeo]
GO

DROP DATABASE [Bankokeo]
GO

CREATE TABLE [User] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(80) NOT NULL,
    [Login] VARCHAR(50) NOT NULL,
    [Password] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_User_Id] PRIMARY KEY([Id])
)
GO

CREATE TABLE [Account] (
    [Number] INT NOT NULL IDENTITY(1, 1),
    [UserId] INT NOT NULL,
    [Balance] INT NOT NULL,
    [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT [PK_Account_Number] PRIMARY KEY([Number]),
    CONSTRAINT [FK_Account_UserId] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
GO

INSERT INTO [User] ([Name], [Login], [Password])
VALUES ('Keo', 'keo', 'senha123')
GO

-- Insiro um dado na tabela Account
-- Primeiro, recupero o UserId inserido na tabela User
DECLARE @UserId INT
SELECT @UserId = [Id] FROM [User] WHERE [Login] = 'keo'

-- Agora insiro um dado na tabela Account associando com o UserId
INSERT INTO [Account] ([UserId], [Balance])
VALUES (@UserId, 1000)
GO
