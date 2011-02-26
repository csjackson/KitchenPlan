CREATE TABLE [dbo].[PlannedMeals](
	[PlannedMealID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Date] [date] NULL,
	[PantryItemID] [int] NULL,
)