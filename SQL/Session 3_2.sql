-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE TRIGGER dbo.Trigger_CategoryInsert 
   ON  dbo.Ctegories 
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	insert into dbo.log (OldValue, NewValue) Values
	((select Name from deleted), (select Name from inserted))
	

END
GO

Set Identity on Ctegories off

insert into Ctegories values (10,'Category 3_3', 8)

Set Identity on Ctegories on


update Ctegories set Name='Category 3 Updated', parentid = 1 where id=7

delete from Ctegories  where id=7
