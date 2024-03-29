﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
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

CREATE TABLE [Classes] (
    [Standard] nvarchar(450) NOT NULL,
    [Section] nvarchar(max) NULL,
    CONSTRAINT [PK_Classes] PRIMARY KEY ([Standard])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240206131827_ClassesMig', N'6.0.26');
GO

COMMIT;
GO

