-- UNION

select name, 'Custoemrs' [Type] from Customers
Union
select name, 'Cities' [Type] from Cities
Union
select name , 'Categories' [Type] from Ctegories

-- ==========================================================

select o.id, o.total, c.Name, od.Total
from Orders o
join Customers c on c.Id=o.CustomerId
cross  apply(
  select orderid, total from OrderItems
  where OrderId=o.Id) as od

with cte1 as (  select orderid, total from OrderItems)
select o.id, o.total, c.Name, od.Total
from Orders o
join Customers c on c.Id=o.CustomerId
join cte1 od on od.OrderId=o.Id 

--================================================================================

select 10000+5000+null
GO
--IIF
Declare @amount int = 200
select 10000+5000+IIF(@amount is null, 0, @amount)
GO
--COALESCE
Declare @amount int = 500
select COALESCE(@amount, 200, 0)

-- elect total, COALESCE(tax, vat) as tax

select Id, Name, 
CASE
  WHEN Name like 'M%' THEN 0.20
  WHEN Name like 'N%' THEN 0.15
  WHEN Name like 'D%' THEN 0.05
  WHEN Id > 3 THEN 0.50
  ELSE 0.0
END as Discount

from Customers

--============================================================================

Declare @str nvarchar(5) = 'M00'
IF @str = 'M'
BEGIN
select * from Customers where Name not Like '%M%'
END
ELSE
BEGIN
select * from Customers where Name  Like '%M%'
END

-- ================================================================================
IF EXISTS (select * from sys.tables where name='Customers')
  Drop TAble Customers
 GO
Create Table Customers(
Id int identity primary key,
Name nvarchar(150))
GO


select * from sys.tables where name='Customers'
select OBJECT_ID('Customers')
GO
IF OBJECT_ID('Customers') is not null
DROP TAble Customers
GO 

-- ==================================================================================

IF NOT EXISTS (select * from Customers where Name='Amgad')
-- Insert Into ....

-- ====================================================================================

drop table if exists Table_1

select top 2 * from customers 


--==========================================================================================

-- try >> catch
-- ERROR_MESSAGE(),ERROR_NUMBER(), ERROR_STATE(), ERROR_SEVERITY(),ERROR_LINE()

begin try
 insert into Cities values (1, 'Giza');

 select 1 / 0;
end try
begin catch
 print(ERROR_MESSAGE())
 
 end catch

 GO

 begin try
 BEGIN TRANSACTION

 insert into Cities values (2, 'Giza 2');

 select 1 / 0;

 COMMIT TRANSACTION
 end try
 begin catch
  ROLLBACK TRANSACTION
  -- Insert errors into log table
 end catch


