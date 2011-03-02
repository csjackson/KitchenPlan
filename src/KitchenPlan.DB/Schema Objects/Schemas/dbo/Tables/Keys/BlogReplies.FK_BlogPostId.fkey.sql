ALTER TABLE [dbo].[BlogReplies]
	ADD CONSTRAINT [FK_BlogReplies_To_BlogPosts] 
	FOREIGN KEY (BlogPostId)
	REFERENCES BlogPosts (BlogPostId)	

