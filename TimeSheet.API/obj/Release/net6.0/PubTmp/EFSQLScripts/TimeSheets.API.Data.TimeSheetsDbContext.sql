IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220802104340_sanju')
BEGIN
    CREATE TABLE [TimeSheets] (
        [ID] int NOT NULL IDENTITY,
        [EmployeeID] int NOT NULL,
        [EmployeeName] nvarchar(max) NOT NULL,
        [ProjectName] nvarchar(max) NOT NULL,
        [Activity] nvarchar(max) NOT NULL,
        [Task] nvarchar(max) NOT NULL,
        [Date] nvarchar(max) NOT NULL,
        [WorkHours] int NOT NULL,
        CONSTRAINT [PK_TimeSheets] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220802104340_sanju')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220802104340_sanju', N'6.0.6');
END;
GO

COMMIT;
GO

