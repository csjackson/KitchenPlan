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
