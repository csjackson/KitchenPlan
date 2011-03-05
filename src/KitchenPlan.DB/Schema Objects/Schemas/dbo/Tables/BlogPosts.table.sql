CREATE TABLE [dbo].[BlogPosts](
	[BlogPostId] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[PostTitle] varchar(max) NULL,
	[PostDate] date NOT NULL,
	[PostText] text NULL
	)