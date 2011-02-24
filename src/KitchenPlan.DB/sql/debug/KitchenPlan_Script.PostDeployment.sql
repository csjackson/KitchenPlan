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
Truncate Table PantryItems
INSERT INTO PantryItems values ('Rigatonni');
INSERT INTO PantryItems values ('Lasagna');
INSERT INTO PantryItems values ('Banana');
INSERT INTO PantryItems values ('Oreos');
INSERT INTO PantryItems values ('MiszpelldWerds');
