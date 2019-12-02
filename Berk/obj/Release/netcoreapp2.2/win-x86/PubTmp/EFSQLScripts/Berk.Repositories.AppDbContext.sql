IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE TABLE [Locations] (
        [LocationID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        CONSTRAINT [PK_Locations] PRIMARY KEY ([LocationID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE TABLE [Member] (
        [MemberID] int NOT NULL IDENTITY,
        [IsAdmin] bit NOT NULL,
        [Name] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Joined] datetime2 NOT NULL,
        [becameAdmin] datetime2 NOT NULL,
        CONSTRAINT [PK_Member] PRIMARY KEY ([MemberID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE TABLE [VIPs] (
        [VIPID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Reason] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        [IsAlive] bit NOT NULL,
        CONSTRAINT [PK_VIPs] PRIMARY KEY ([VIPID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE TABLE [Comments] (
        [CommentID] int NOT NULL IDENTITY,
        [CommentText] nvarchar(max) NULL,
        [TimeStamp] datetime2 NOT NULL,
        [MemberNameMemberID] int NULL,
        [Sender] nvarchar(max) NULL,
        [LocationID] int NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([CommentID]),
        CONSTRAINT [FK_Comments_Locations_LocationID] FOREIGN KEY ([LocationID]) REFERENCES [Locations] ([LocationID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Comments_Member_MemberNameMemberID] FOREIGN KEY ([MemberNameMemberID]) REFERENCES [Member] ([MemberID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE TABLE [Message] (
        [MessageID] int NOT NULL IDENTITY,
        [MessageText] nvarchar(max) NULL,
        [Sent] datetime2 NOT NULL,
        [MemberName] nvarchar(max) NULL,
        [MemberID] int NULL,
        CONSTRAINT [PK_Message] PRIMARY KEY ([MessageID]),
        CONSTRAINT [FK_Message_Member_MemberID] FOREIGN KEY ([MemberID]) REFERENCES [Member] ([MemberID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE INDEX [IX_Comments_LocationID] ON [Comments] ([LocationID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE INDEX [IX_Comments_MemberNameMemberID] ON [Comments] ([MemberNameMemberID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    CREATE INDEX [IX_Message_MemberID] ON [Message] ([MemberID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191127183755_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191127183755_initial', N'2.2.6-servicing-10079');
END;

GO

