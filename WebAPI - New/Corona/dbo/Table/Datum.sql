CREATE TABLE [dbo].[Datum]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITy(1, 1),
    [CountryCode] NCHAR(50) NULL, 
    [Date] NVARCHAR(50) NULL, 
    [Cases] NVARCHAR(50) NULL, 
    [Deaths] NVARCHAR(50) NULL, 
    [Recovered] NVARCHAR(50) NULL
)
