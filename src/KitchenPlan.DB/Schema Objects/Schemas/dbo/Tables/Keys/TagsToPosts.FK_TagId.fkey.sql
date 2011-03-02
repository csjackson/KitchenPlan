ALTER TABLE [dbo].[TagsToPosts]
	ADD CONSTRAINT [FK_TagsToPosts_To_Tags] 
	FOREIGN KEY (TagId)
	REFERENCES Tags (TagId)	

