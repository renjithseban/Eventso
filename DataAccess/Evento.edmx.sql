
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/11/2017 11:48:53
-- Generated from EDMX file: E:\Projects\MyProject\Evento\DataAccess\Evento.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Evento];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[Admin].[FK_Categories_Categories_ParentCategory]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Categories] DROP CONSTRAINT [FK_Categories_Categories_ParentCategory];
GO
IF OBJECT_ID(N'[Admin].[FK_Categories_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Categories] DROP CONSTRAINT [FK_Categories_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Categories_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Categories] DROP CONSTRAINT [FK_Categories_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewCategory_Categories]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewCategory] DROP CONSTRAINT [FK_CrewCategory_Categories];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewCategory_Crews]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewCategory] DROP CONSTRAINT [FK_CrewCategory_Crews];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewCategory_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewCategory] DROP CONSTRAINT [FK_CrewCategory_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewCategory_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewCategory] DROP CONSTRAINT [FK_CrewCategory_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Crews_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Crews] DROP CONSTRAINT [FK_Crews_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Crews_Users_CrewOwner]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Crews] DROP CONSTRAINT [FK_Crews_Users_CrewOwner];
GO
IF OBJECT_ID(N'[Admin].[FK_Crews_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Crews] DROP CONSTRAINT [FK_Crews_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewViewership_Crews]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewViewership] DROP CONSTRAINT [FK_CrewViewership_Crews];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewViewership_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewViewership] DROP CONSTRAINT [FK_CrewViewership_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewViewership_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewViewership] DROP CONSTRAINT [FK_CrewViewership_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_CrewViewership_Users_ViewedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[CrewViewership] DROP CONSTRAINT [FK_CrewViewership_Users_ViewedUser];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[Admin].[FK_Districts_States_State]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Districts] DROP CONSTRAINT [FK_Districts_States_State];
GO
IF OBJECT_ID(N'[Admin].[FK_Districts_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Districts] DROP CONSTRAINT [FK_Districts_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Districts_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Districts] DROP CONSTRAINT [FK_Districts_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_OfficeAddresses_Crews]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[OfficeAddresses] DROP CONSTRAINT [FK_OfficeAddresses_Crews];
GO
IF OBJECT_ID(N'[Crew].[FK_OfficeAddresses_Districts]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[OfficeAddresses] DROP CONSTRAINT [FK_OfficeAddresses_Districts];
GO
IF OBJECT_ID(N'[Crew].[FK_OfficeAddresses_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[OfficeAddresses] DROP CONSTRAINT [FK_OfficeAddresses_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_OfficeAddresses_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[OfficeAddresses] DROP CONSTRAINT [FK_OfficeAddresses_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Roles_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Roles] DROP CONSTRAINT [FK_Roles_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Roles_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Roles] DROP CONSTRAINT [FK_Roles_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_States_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[States] DROP CONSTRAINT [FK_States_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_States_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[States] DROP CONSTRAINT [FK_States_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_Testimonial_Crews]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[Testimonials] DROP CONSTRAINT [FK_Testimonial_Crews];
GO
IF OBJECT_ID(N'[Crew].[FK_Testimonial_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[Testimonials] DROP CONSTRAINT [FK_Testimonial_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Crew].[FK_Testimonial_Users_TestimonialUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[Testimonials] DROP CONSTRAINT [FK_Testimonial_Users_TestimonialUser];
GO
IF OBJECT_ID(N'[Crew].[FK_Testimonial_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Crew].[Testimonials] DROP CONSTRAINT [FK_Testimonial_Users_UpdatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Users_Users_CreatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Users] DROP CONSTRAINT [FK_Users_Users_CreatedUser];
GO
IF OBJECT_ID(N'[Admin].[FK_Users_Users_UpdatedUser]', 'F') IS NOT NULL
    ALTER TABLE [Admin].[Users] DROP CONSTRAINT [FK_Users_Users_UpdatedUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[Admin].[Categories]', 'U') IS NOT NULL
    DROP TABLE [Admin].[Categories];
GO
IF OBJECT_ID(N'[Admin].[Crews]', 'U') IS NOT NULL
    DROP TABLE [Admin].[Crews];
GO
IF OBJECT_ID(N'[Admin].[Districts]', 'U') IS NOT NULL
    DROP TABLE [Admin].[Districts];
GO
IF OBJECT_ID(N'[Admin].[Roles]', 'U') IS NOT NULL
    DROP TABLE [Admin].[Roles];
GO
IF OBJECT_ID(N'[Admin].[States]', 'U') IS NOT NULL
    DROP TABLE [Admin].[States];
GO
IF OBJECT_ID(N'[Admin].[Users]', 'U') IS NOT NULL
    DROP TABLE [Admin].[Users];
GO
IF OBJECT_ID(N'[Crew].[CrewCategory]', 'U') IS NOT NULL
    DROP TABLE [Crew].[CrewCategory];
GO
IF OBJECT_ID(N'[Crew].[CrewViewership]', 'U') IS NOT NULL
    DROP TABLE [Crew].[CrewViewership];
GO
IF OBJECT_ID(N'[Crew].[OfficeAddresses]', 'U') IS NOT NULL
    DROP TABLE [Crew].[OfficeAddresses];
GO
IF OBJECT_ID(N'[Crew].[Testimonials]', 'U') IS NOT NULL
    DROP TABLE [Crew].[Testimonials];
GO
IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[EventoStoreContainer].[TopFiveCrews]', 'U') IS NOT NULL
    DROP TABLE [EventoStoreContainer].[TopFiveCrews];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [CategoryName] varchar(100)  NOT NULL,
    [CategoryDescription] varchar(max)  NULL,
    [ParentCategoryId] int  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'Crews'
CREATE TABLE [dbo].[Crews] (
    [CrewId] int IDENTITY(1,1) NOT NULL,
    [CrewName] varchar(200)  NOT NULL,
    [CrewEmail] varchar(200)  NOT NULL,
    [CrewContactNo] varchar(20)  NOT NULL,
    [CrewWebsiteURI] varchar(200)  NULL,
    [CrewFacebook] varchar(200)  NULL,
    [CrewTwitter] varchar(200)  NULL,
    [CrewDescription] varchar(max)  NOT NULL,
    [CrewOwnerUserId] int  NOT NULL,
    [CrewAlternateContactNo] varchar(20)  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'Districts'
CREATE TABLE [dbo].[Districts] (
    [DistrictId] int IDENTITY(1,1) NOT NULL,
    [DistrictName] varchar(100)  NOT NULL,
    [StateId] int  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [RoleId] int IDENTITY(1,1) NOT NULL,
    [RoleName] varchar(50)  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'States'
CREATE TABLE [dbo].[States] (
    [StateId] int IDENTITY(1,1) NOT NULL,
    [StateName] varchar(100)  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(100)  NOT NULL,
    [LastName] varchar(100)  NOT NULL,
    [UserEmail] varchar(100)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [PasswordSalt] nvarchar(max)  NULL,
    [ContactNo] varchar(20)  NOT NULL,
    [IsEmailVerified] bit  NOT NULL,
    [IsMobileVerified] bit  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'OfficeAddresses'
CREATE TABLE [dbo].[OfficeAddresses] (
    [OfficeAddressId] int IDENTITY(1,1) NOT NULL,
    [CrewId] int  NOT NULL,
    [OfficeLandmark] varchar(500)  NULL,
    [OfficeStreet] varchar(500)  NULL,
    [OfficeArea] varchar(500)  NULL,
    [OfficeLocality] varchar(500)  NULL,
    [OfficeCity] varchar(200)  NULL,
    [OfficeDistrictId] int  NULL,
    [Pincode] varchar(20)  NULL,
    [IsHeadOffice] bit  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'Testimonials'
CREATE TABLE [dbo].[Testimonials] (
    [TestimonialId] int IDENTITY(1,1) NOT NULL,
    [CrewId] int  NOT NULL,
    [Testimonials] varchar(max)  NOT NULL,
    [UserId] int  NULL,
    [Rating] smallint  NULL,
    [IsGenuine] bit  NULL,
    [ImageFolderPath] varchar(max)  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'CrewCategories'
CREATE TABLE [dbo].[CrewCategories] (
    [CrewId] int  NOT NULL,
    [CategoryId] int  NOT NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'CrewViewerships'
CREATE TABLE [dbo].[CrewViewerships] (
    [CrewViewershipId] int  NOT NULL,
    [CrewId] int  NULL,
    [ViewDate] datetime  NULL,
    [ViewedBy] int  NULL,
    [HasSentMail] bit  NULL,
    [HasSentSMS] bit  NULL,
    [CreatedBy] int  NULL,
    [CreatedDate] datetime  NULL,
    [UpdatedBy] int  NULL,
    [UpdatedDate] datetime  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'TopFiveCrews'
CREATE TABLE [dbo].[TopFiveCrews] (
    [CrewId] int  NOT NULL,
    [CrewName] varchar(200)  NOT NULL,
    [CrewEmail] varchar(200)  NOT NULL,
    [CrewContactNo] varchar(20)  NOT NULL,
    [CrewWebsiteURI] varchar(200)  NULL,
    [CrewFacebook] varchar(200)  NULL,
    [CrewTwitter] varchar(200)  NULL,
    [CrewDescription] varchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [CrewOwner] varchar(201)  NOT NULL,
    [NetScore] int  NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [CrewId] in table 'Crews'
ALTER TABLE [dbo].[Crews]
ADD CONSTRAINT [PK_Crews]
    PRIMARY KEY CLUSTERED ([CrewId] ASC);
GO

-- Creating primary key on [DistrictId] in table 'Districts'
ALTER TABLE [dbo].[Districts]
ADD CONSTRAINT [PK_Districts]
    PRIMARY KEY CLUSTERED ([DistrictId] ASC);
GO

-- Creating primary key on [RoleId] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [StateId] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [PK_States]
    PRIMARY KEY CLUSTERED ([StateId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [OfficeAddressId] in table 'OfficeAddresses'
ALTER TABLE [dbo].[OfficeAddresses]
ADD CONSTRAINT [PK_OfficeAddresses]
    PRIMARY KEY CLUSTERED ([OfficeAddressId] ASC);
GO

-- Creating primary key on [TestimonialId] in table 'Testimonials'
ALTER TABLE [dbo].[Testimonials]
ADD CONSTRAINT [PK_Testimonials]
    PRIMARY KEY CLUSTERED ([TestimonialId] ASC);
GO

-- Creating primary key on [CrewId], [CategoryId] in table 'CrewCategories'
ALTER TABLE [dbo].[CrewCategories]
ADD CONSTRAINT [PK_CrewCategories]
    PRIMARY KEY CLUSTERED ([CrewId], [CategoryId] ASC);
GO

-- Creating primary key on [CrewViewershipId] in table 'CrewViewerships'
ALTER TABLE [dbo].[CrewViewerships]
ADD CONSTRAINT [PK_CrewViewerships]
    PRIMARY KEY CLUSTERED ([CrewViewershipId] ASC);
GO

-- Creating primary key on [CrewId], [CrewName], [CrewEmail], [CrewContactNo], [CrewDescription], [UserId], [CrewOwner] in table 'TopFiveCrews'
ALTER TABLE [dbo].[TopFiveCrews]
ADD CONSTRAINT [PK_TopFiveCrews]
    PRIMARY KEY CLUSTERED ([CrewId], [CrewName], [CrewEmail], [CrewContactNo], [CrewDescription], [UserId], [CrewOwner] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ParentCategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_Categories_Categories_ParentCategory]
    FOREIGN KEY ([ParentCategoryId])
    REFERENCES [dbo].[Categories]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Categories_Categories_ParentCategory'
CREATE INDEX [IX_FK_Categories_Categories_ParentCategory]
ON [dbo].[Categories]
    ([ParentCategoryId]);
GO

-- Creating foreign key on [CreatedBy] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_Categories_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Categories_Users_CreatedUser'
CREATE INDEX [IX_FK_Categories_Users_CreatedUser]
ON [dbo].[Categories]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_Categories_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Categories_Users_UpdatedUser'
CREATE INDEX [IX_FK_Categories_Users_UpdatedUser]
ON [dbo].[Categories]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Crews'
ALTER TABLE [dbo].[Crews]
ADD CONSTRAINT [FK_Crews_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Crews_Users_CreatedUser'
CREATE INDEX [IX_FK_Crews_Users_CreatedUser]
ON [dbo].[Crews]
    ([CreatedBy]);
GO

-- Creating foreign key on [CrewOwnerUserId] in table 'Crews'
ALTER TABLE [dbo].[Crews]
ADD CONSTRAINT [FK_Crews_Users_CrewOwner]
    FOREIGN KEY ([CrewOwnerUserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Crews_Users_CrewOwner'
CREATE INDEX [IX_FK_Crews_Users_CrewOwner]
ON [dbo].[Crews]
    ([CrewOwnerUserId]);
GO

-- Creating foreign key on [UpdatedBy] in table 'Crews'
ALTER TABLE [dbo].[Crews]
ADD CONSTRAINT [FK_Crews_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Crews_Users_UpdatedUser'
CREATE INDEX [IX_FK_Crews_Users_UpdatedUser]
ON [dbo].[Crews]
    ([UpdatedBy]);
GO

-- Creating foreign key on [StateId] in table 'Districts'
ALTER TABLE [dbo].[Districts]
ADD CONSTRAINT [FK_Districts_States_State]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[States]
        ([StateId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Districts_States_State'
CREATE INDEX [IX_FK_Districts_States_State]
ON [dbo].[Districts]
    ([StateId]);
GO

-- Creating foreign key on [CreatedBy] in table 'Districts'
ALTER TABLE [dbo].[Districts]
ADD CONSTRAINT [FK_Districts_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Districts_Users_CreatedUser'
CREATE INDEX [IX_FK_Districts_Users_CreatedUser]
ON [dbo].[Districts]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'Districts'
ALTER TABLE [dbo].[Districts]
ADD CONSTRAINT [FK_Districts_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Districts_Users_UpdatedUser'
CREATE INDEX [IX_FK_Districts_Users_UpdatedUser]
ON [dbo].[Districts]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK_Roles_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Roles_Users_CreatedUser'
CREATE INDEX [IX_FK_Roles_Users_CreatedUser]
ON [dbo].[Roles]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [FK_Roles_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Roles_Users_UpdatedUser'
CREATE INDEX [IX_FK_Roles_Users_UpdatedUser]
ON [dbo].[Roles]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [FK_States_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_States_Users_CreatedUser'
CREATE INDEX [IX_FK_States_Users_CreatedUser]
ON [dbo].[States]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [FK_States_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_States_Users_UpdatedUser'
CREATE INDEX [IX_FK_States_Users_UpdatedUser]
ON [dbo].[States]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Users_CreatedUser'
CREATE INDEX [IX_FK_Users_Users_CreatedUser]
ON [dbo].[Users]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Users_UpdatedUser'
CREATE INDEX [IX_FK_Users_Users_UpdatedUser]
ON [dbo].[Users]
    ([UpdatedBy]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [CrewId] in table 'OfficeAddresses'
ALTER TABLE [dbo].[OfficeAddresses]
ADD CONSTRAINT [FK_OfficeAddresses_Crews]
    FOREIGN KEY ([CrewId])
    REFERENCES [dbo].[Crews]
        ([CrewId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfficeAddresses_Crews'
CREATE INDEX [IX_FK_OfficeAddresses_Crews]
ON [dbo].[OfficeAddresses]
    ([CrewId]);
GO

-- Creating foreign key on [CrewId] in table 'Testimonials'
ALTER TABLE [dbo].[Testimonials]
ADD CONSTRAINT [FK_Testimonial_Crews]
    FOREIGN KEY ([CrewId])
    REFERENCES [dbo].[Crews]
        ([CrewId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Testimonial_Crews'
CREATE INDEX [IX_FK_Testimonial_Crews]
ON [dbo].[Testimonials]
    ([CrewId]);
GO

-- Creating foreign key on [OfficeDistrictId] in table 'OfficeAddresses'
ALTER TABLE [dbo].[OfficeAddresses]
ADD CONSTRAINT [FK_OfficeAddresses_Districts]
    FOREIGN KEY ([OfficeDistrictId])
    REFERENCES [dbo].[Districts]
        ([DistrictId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfficeAddresses_Districts'
CREATE INDEX [IX_FK_OfficeAddresses_Districts]
ON [dbo].[OfficeAddresses]
    ([OfficeDistrictId]);
GO

-- Creating foreign key on [CreatedBy] in table 'OfficeAddresses'
ALTER TABLE [dbo].[OfficeAddresses]
ADD CONSTRAINT [FK_OfficeAddresses_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfficeAddresses_Users_CreatedUser'
CREATE INDEX [IX_FK_OfficeAddresses_Users_CreatedUser]
ON [dbo].[OfficeAddresses]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'OfficeAddresses'
ALTER TABLE [dbo].[OfficeAddresses]
ADD CONSTRAINT [FK_OfficeAddresses_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfficeAddresses_Users_UpdatedUser'
CREATE INDEX [IX_FK_OfficeAddresses_Users_UpdatedUser]
ON [dbo].[OfficeAddresses]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Testimonials'
ALTER TABLE [dbo].[Testimonials]
ADD CONSTRAINT [FK_Testimonial_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Testimonial_Users_CreatedUser'
CREATE INDEX [IX_FK_Testimonial_Users_CreatedUser]
ON [dbo].[Testimonials]
    ([CreatedBy]);
GO

-- Creating foreign key on [UserId] in table 'Testimonials'
ALTER TABLE [dbo].[Testimonials]
ADD CONSTRAINT [FK_Testimonial_Users_TestimonialUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Testimonial_Users_TestimonialUser'
CREATE INDEX [IX_FK_Testimonial_Users_TestimonialUser]
ON [dbo].[Testimonials]
    ([UserId]);
GO

-- Creating foreign key on [UpdatedBy] in table 'Testimonials'
ALTER TABLE [dbo].[Testimonials]
ADD CONSTRAINT [FK_Testimonial_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Testimonial_Users_UpdatedUser'
CREATE INDEX [IX_FK_Testimonial_Users_UpdatedUser]
ON [dbo].[Testimonials]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CategoryId] in table 'CrewCategories'
ALTER TABLE [dbo].[CrewCategories]
ADD CONSTRAINT [FK_CrewCategory_Categories]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewCategory_Categories'
CREATE INDEX [IX_FK_CrewCategory_Categories]
ON [dbo].[CrewCategories]
    ([CategoryId]);
GO

-- Creating foreign key on [CrewId] in table 'CrewCategories'
ALTER TABLE [dbo].[CrewCategories]
ADD CONSTRAINT [FK_CrewCategory_Crews]
    FOREIGN KEY ([CrewId])
    REFERENCES [dbo].[Crews]
        ([CrewId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CreatedBy] in table 'CrewCategories'
ALTER TABLE [dbo].[CrewCategories]
ADD CONSTRAINT [FK_CrewCategory_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewCategory_Users_CreatedUser'
CREATE INDEX [IX_FK_CrewCategory_Users_CreatedUser]
ON [dbo].[CrewCategories]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'CrewCategories'
ALTER TABLE [dbo].[CrewCategories]
ADD CONSTRAINT [FK_CrewCategory_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewCategory_Users_UpdatedUser'
CREATE INDEX [IX_FK_CrewCategory_Users_UpdatedUser]
ON [dbo].[CrewCategories]
    ([UpdatedBy]);
GO

-- Creating foreign key on [CrewId] in table 'CrewViewerships'
ALTER TABLE [dbo].[CrewViewerships]
ADD CONSTRAINT [FK_CrewViewership_Crews]
    FOREIGN KEY ([CrewId])
    REFERENCES [dbo].[Crews]
        ([CrewId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewViewership_Crews'
CREATE INDEX [IX_FK_CrewViewership_Crews]
ON [dbo].[CrewViewerships]
    ([CrewId]);
GO

-- Creating foreign key on [CreatedBy] in table 'CrewViewerships'
ALTER TABLE [dbo].[CrewViewerships]
ADD CONSTRAINT [FK_CrewViewership_Users_CreatedUser]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewViewership_Users_CreatedUser'
CREATE INDEX [IX_FK_CrewViewership_Users_CreatedUser]
ON [dbo].[CrewViewerships]
    ([CreatedBy]);
GO

-- Creating foreign key on [UpdatedBy] in table 'CrewViewerships'
ALTER TABLE [dbo].[CrewViewerships]
ADD CONSTRAINT [FK_CrewViewership_Users_UpdatedUser]
    FOREIGN KEY ([UpdatedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewViewership_Users_UpdatedUser'
CREATE INDEX [IX_FK_CrewViewership_Users_UpdatedUser]
ON [dbo].[CrewViewerships]
    ([UpdatedBy]);
GO

-- Creating foreign key on [ViewedBy] in table 'CrewViewerships'
ALTER TABLE [dbo].[CrewViewerships]
ADD CONSTRAINT [FK_CrewViewership_Users_ViewedUser]
    FOREIGN KEY ([ViewedBy])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CrewViewership_Users_ViewedUser'
CREATE INDEX [IX_FK_CrewViewership_Users_ViewedUser]
ON [dbo].[CrewViewerships]
    ([ViewedBy]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------