CREATE TABLE [dbo].[Page]
(
	[PageId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Id] UNIQUEIDENTIFIER NOT NULL, 
    [TemplateId] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Title] NVARCHAR(50) NULL,
    [Description] NVARCHAR(MAX) NULL, 
	[ParentPageId] INT NULL,
    [IsEnabled] BIT NOT NULL, 
    [IsPublished] BIT NOT NULL, 
    [IsDeleted] BIT NULL, 
    [ScopeId] INT NOT NULL,
    [CreatedOn] DATETIMEOFFSET NOT NULL, 
    [ModifiedOn] DATETIMEOFFSET NOT NULL, 
    [MetaKeywords] NVARCHAR(256) NULL, 
    [MetaDescription] NVARCHAR(MAX) NULL, 
    [MetaTitle] NVARCHAR(50) NULL
    
)

GO

CREATE INDEX [IX_Page_Name] ON [dbo].[Page] ([Name])
