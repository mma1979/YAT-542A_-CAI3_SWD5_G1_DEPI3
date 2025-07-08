create sequence dbo.CitySeq as INT start With 1 increment by 1;

select next value for dbo.CitySeq

Create Table Cities (
Id int primary key,
Name nvarchar(75))


--Declare @id int = (select next value for dbo.CitySeq)
insert into cities values (3, 'Alex')

select * from cities