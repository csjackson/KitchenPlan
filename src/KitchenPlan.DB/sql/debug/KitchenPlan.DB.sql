/*
Deployment script for KitchenPlan
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "KitchenPlan"
:setvar DefaultDataPath "c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\"
:setvar DefaultLogPath "c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\"

GO
USE [master]

GO
:on error exit
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'The state of the target database, %s, is not set to ONLINE. To deploy to this database, its state must be set to ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO

IF NOT EXISTS (SELECT 1 FROM [master].[dbo].[sysdatabases] WHERE [name] = N'$(DatabaseName)')
BEGIN
    RAISERROR(N'You cannot deploy this update script to target BESTEGER\SQLEXPRESS. The database for which this script was built, KitchenPlan, does not exist on this server.', 16, 127) WITH NOWAIT
    RETURN
END

GO

IF (@@servername != 'BESTEGER\SQLEXPRESS')
BEGIN
    RAISERROR(N'The server name in the build script %s does not match the name of the target server %s. Verify whether your database project settings are correct and whether your build script is up to date.', 16, 127,N'BESTEGER\SQLEXPRESS',@@servername) WITH NOWAIT
    RETURN
END

GO

IF CAST(DATABASEPROPERTY(N'$(DatabaseName)','IsReadOnly') as bit) = 1
BEGIN
    RAISERROR(N'You cannot deploy this update script because the database for which it was built, %s , is set to READ_ONLY.', 16, 127, N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
USE [$(DatabaseName)]

GO
/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF ((SELECT 1 FROM PantryItems WHERE [Description] = 'Rigatonni') IS NULL)
INSERT INTO PantryItems values ('Rigatonni');
IF ((SELECT 1 FROM PantryItems WHERE [Description] = 'Lasagna') IS NULL)
INSERT INTO PantryItems values ('Lasagna');
IF ((SELECT 1 FROM PantryItems WHERE [Description] = 'Banana') IS NULL)
INSERT INTO PantryItems values ('Banana');
IF ((SELECT 1 FROM PantryItems WHERE [Description] = 'Oreos') IS NULL)
INSERT INTO PantryItems values ('Oreos');
IF ((SELECT 1 FROM PantryItems WHERE [Description] = 'MiszpelldWerds') IS NULL)
INSERT INTO PantryItems values ('MiszpelldWerds');

IF ((SELECT 1 FROM BlogPosts WHERE [PostTitle] = 'Sample') IS NULL)
INSERT INTO BlogPosts values ('Sample', '10/10/2010', 'This is some sample text.');
IF ((SELECT 1 FROM BlogReplies WHERE [ReplyBy] = 'Tester') IS NULL)
INSERT INTO BlogReplies values ('1', 'Tester', 'This is a sample reply');
IF ((SELECT 1 FROM BlogReplies WHERE [ReplyBy] = 'Tester2') IS NULL)
INSERT INTO BlogReplies values ('2', 'Tester2', 'I needed another sample reply');
IF ((SELECT 1 FROM BlogReplies WHERE [ReplyBy] ='Tester3') IS NULL)
INSERT INTO BlogReplies values ('1', 'Tester3', 'Second reply to First Post');
IF ((Select 1 from Tags where TagName = 'ExampleTag') is null)
insert into Tags values ('ExampleTag');

GO
