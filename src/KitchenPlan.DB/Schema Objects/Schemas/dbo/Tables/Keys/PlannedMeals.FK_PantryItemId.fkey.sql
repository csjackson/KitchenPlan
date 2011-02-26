ALTER TABLE [dbo].[PlannedMeals]
	ADD CONSTRAINT [FK_PlannedMeals_To_PantryItems] 
	FOREIGN KEY (PantryItemId)
	REFERENCES PantryItems (PantryItemId)	

