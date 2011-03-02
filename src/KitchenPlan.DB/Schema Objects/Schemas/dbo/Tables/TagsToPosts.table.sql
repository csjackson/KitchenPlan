CREATE TABLE [dbo].[TagsToPosts]
(
	TagToPostId int identity (1,1) NOT NULL PRIMARY KEY, 
	TagId int NOT NULL,
	BlogPostId int NOT NULL,
)
