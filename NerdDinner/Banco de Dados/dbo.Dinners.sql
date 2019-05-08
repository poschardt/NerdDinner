CREATE TABLE [dbo].[Table]
(
	[DinnerID] INT NOT NULL PRIMARY KEY, 
    [Title] NCHAR(50) NOT NULL, 
    [EventDate] DATETIME NOT NULL, 
    [Description] NCHAR(256) NULL, 
    [HostedBy] NCHAR(20) NULL, 
    [ContactPhone] NCHAR(20) NULL, 
    [Address] NCHAR(50) NULL, 
    [Country] NCHAR(30) NULL, 
    [Latitude] FLOAT NULL, 
    [Longitude] FLOAT NULL
)
