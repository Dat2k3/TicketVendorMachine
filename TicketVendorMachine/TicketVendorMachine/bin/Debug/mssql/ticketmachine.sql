create database bankingSystem
go
use bankingSystem
go


create table banking (
	cardID varchar(16) primary key,
	pin varchar(10)
)

create table user_customer (
	id varchar(5) primary key,
	name nvarchar(30),
	phone varchar(11),
	destination varchar(20),
	time varchar(10),
	price varchar(10)
)
go

insert into banking 
values ('123456789','123'),
	   ('987654321','123')

create function insert_IDUser()
returns varchar(5)
as
begin
	declare @id varchar(5)
	if(select count(id) from user_customer) = 0
		set @id = '0'
	else
		select @id = max(right(id,3)) from user_customer
		select @id = case
			when @id >= 0 and @id < 9 then 'U00' + convert(char, convert(int, @id) + 1)
			when @id >= 9 then 'U0' + convert(char, convert(int, @id) + 1)
		end
	return @id
end
go

create procedure insert_userCustomer(
	@name nvarchar(30),
	@phone varchar(11),
	@destination varchar(20),
	@time varchar(10),
	@price varchar(10)
)
as
begin
	insert into user_customer(id,name,phone,destination,time,price)
	values (dbo.insert_IDUser(),@name,@phone,@destination,@time,@price)
end
go

select * from banking

select * from user_customer
