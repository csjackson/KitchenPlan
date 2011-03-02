CREATE TABLE [dbo].[BlogReplies](
	[BlogReplyId] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[BlogPostId] [int] NOT NULL,
	[ReplyBy] [varchar](max) NOT NULL,
	[BlogReplyText] [varchar](max) NOT NULL
	)

