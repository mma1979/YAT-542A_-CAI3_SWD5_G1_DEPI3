

-- while
declare @x int = 0;
WHILE @x <= 5
BEGIN
print(@x)
set @x+=1;
END;


declare @count int = (select count(1) from Cities)
While @count <> 0
BEGIN
Select top (@count) * from Cities
set @count-=1;
END;


-- =============================================================================================

-- cursor

DECLARE my_cursor cursor for 
select id, Name from Cities where id > 5

DECLARE @id int;
DECLARE @Name nvarchar(100)

open my_cursor

FETCH NEXT FROM my_cursor into @id, @name

WHILE @@FETCH_STATUS = 0
BEGIN
print(cast(@id  as nvarchar) + ' ' + @name); -- cast  convert
-- print(convert(nvarchar, @id, format) + ' ' + @name); -- cast  convert

FETCH NEXT FROM my_cursor into @id, @name
END;

CLOSE my_cursor;
DEALLOCATE my_cursor

--============================================================================

declare @d datetime = getdate()

select @d, convert(nvarchar, @d, 101)