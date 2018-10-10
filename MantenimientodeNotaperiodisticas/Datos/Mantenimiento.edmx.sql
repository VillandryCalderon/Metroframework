
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/08/2018 12:46:53
-- Generated from EDMX file: C:\Users\Alexis\Desktop\PRUEBAS\Mantenimiento_Notas\MantenimientodeNotaperiodisticas\Datos\Mantenimiento.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CrudNotas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tipo_UsuarioSet'
CREATE TABLE [dbo].[Tipo_UsuarioSet] (
    [Id_TipoUsuario] int IDENTITY(1,1) NOT NULL,
    [Tipo_usuario] nvarchar(max)  NOT NULL,
    [UsuarioUSR_idusuario] int  NOT NULL,
    [UsuarioUSR_idusuario1] int  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [USR_idusuario] int IDENTITY(1,1) NOT NULL,
    [USR_Username] nvarchar(max)  NOT NULL,
    [USR_Pass] nvarchar(max)  NOT NULL,
    [USR_Id_TipoUsuario] int  NOT NULL,
    [Tipo_UsuarioId_TipoUsuario] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_TipoUsuario] in table 'Tipo_UsuarioSet'
ALTER TABLE [dbo].[Tipo_UsuarioSet]
ADD CONSTRAINT [PK_Tipo_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id_TipoUsuario] ASC);
GO

-- Creating primary key on [USR_idusuario] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([USR_idusuario] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioUSR_idusuario1] in table 'Tipo_UsuarioSet'
ALTER TABLE [dbo].[Tipo_UsuarioSet]
ADD CONSTRAINT [FK_UsuarioTipo_Usuario]
    FOREIGN KEY ([UsuarioUSR_idusuario1])
    REFERENCES [dbo].[UsuarioSet]
        ([USR_idusuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioTipo_Usuario'
CREATE INDEX [IX_FK_UsuarioTipo_Usuario]
ON [dbo].[Tipo_UsuarioSet]
    ([UsuarioUSR_idusuario1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------