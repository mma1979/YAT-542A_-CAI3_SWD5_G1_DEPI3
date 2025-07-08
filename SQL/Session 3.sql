ALTER View vw_OrderTotals
AS
select c.Name, o.Id, OrderDate, sum(oi.Quntity *  oi.Price) Total, Avg(oi.Quntity *  oi.Price) Avrege
from Customers c
join Orders o on  c.id=o.CustomerId
join OrderItems oi on o.id=oi.orderId

group by c.Name, o.Id, OrderDate

select * from vw_OrderTotals where orderdate >= '2025-07-01'


Alter Proc usp_OrderTotals
@StartDate datetime,
@EndDate DateTime
AS
select c.Name, o.Id, OrderDate, sum(oi.Quntity *  oi.Price) Total, Avg(oi.Quntity *  oi.Price) Avrege
from Customers c
join Orders o on  c.id=o.CustomerId
join OrderItems oi on o.id=oi.orderId
where orderdate >= @StartDate and OrderDate < @EndDate
group by c.Name, o.Id, OrderDate

exec usp_OrderTotals '2025-05-01','2025-06-15'


create table Ctegories
(
Id int identity primary key,
Name nvarchar(50),
ParentId int null)


Insert Into Ctegories (name, parentId) values
('Category 1', null),
('Category 2', null),
('Category 1_1', 1),
('Category 1_2', 1),
('Category 2_1', 2),
('Category 2_2', 2);

select c1.Id ParenrId, c1.Name ParentName, c2.Id SubCategoryId,c2.Name SubCategoryName 
from Ctegories c1
join Ctegories c2 on c2.ParentId=c1.Id


--==============================================================================================

select OrderId, dbo.fn_MyCount(Quntity) QuntityCoutn
from OrderItems

select * from 
dbo.fn_tabledFunction( '2025-05-01','2025-06-15') f
join Orders c on f.orderid = c.Id