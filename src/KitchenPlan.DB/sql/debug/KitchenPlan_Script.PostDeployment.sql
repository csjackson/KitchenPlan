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
