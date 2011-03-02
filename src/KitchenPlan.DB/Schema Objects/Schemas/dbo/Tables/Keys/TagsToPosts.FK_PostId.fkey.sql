ALTER TABLE [dbo].[TagsToPosts]
	ADD CONSTRAINT [FK_PostId] 
	FOREIGN KEY (BlogPostId)
	REFERENCES BlogPosts (BlogPostId)	

