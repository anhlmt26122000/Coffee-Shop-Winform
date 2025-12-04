create database QuanLyQuanCafe
GO	

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id int identity primary key,
	[name] nvarchar(100) not null default N'Chưa đặt tên',
	[status] nvarchar(100) not null default N'Trống' -- Trống || Có người 
)
GO

CREATE TABLE Account
(
	Username nvarchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Chưa đặt tên',
	[Password] Nvarchar(1000) not null default 0,
	[Type] int not null default 0 -- 1:admin, 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id int identity primary key,
	[name] nvarchar(100) default N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id int identity primary key,
	[name] nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0

	foreign key (idCategory) references dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id int identity primary key,
	DateCheckin Date not null default getdate(),
	DateCheckout Date,
	idTable int not null,
	status int not null default 0 -- 1 : da thanh toan, 0: chua thanh toan

	foreign key (idTable) references dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
GO

INSERT INTO dbo.Account
(
	Username,
	DisplayName,
	Password,
	Type
)
values 
(
	N'admin',
	N'Admin',
	N'admin',
	1
)

INSERT INTO dbo.Account
(
	Username,
	DisplayName,
	Password,
	Type
)
values 
(
	N'staff1',
	N'Staff1',
	N'123',
	0
)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from dbo.Account where Username = @userName
end
go

exec dbo.USP_GetAccountByUserName @userName='admin'
go

--them ban
Declare @i int=0
while @i<=20
begin
	INSERT dbo.TableFood
	(name)
	values (N'Bàn '+ cast(@i as nvarchar(100)))
	set @i = @i+1
end
go

create proc USP_GetTableList
as select * from dbo.TableFood
go

update dbo.TableFood set status = N'Có người' where id =9
exec dbo.USP_GetTableList

--them category
INSERT dbo.FoodCategory
(name)
values (N'Hải sản')
INSERT dbo.FoodCategory
(name)
values (N'Nông sản')
INSERT dbo.FoodCategory
(name)
values (N'Lâm sản')
INSERT dbo.FoodCategory
(name)
values (N'Sản sản')
INSERT dbo.FoodCategory
(name)
values (N'Nước')
go

-- them food
INSERT dbo.Food
(name, idCategory,price)
values (N'Mực một nắng nướng sa tế',1,120000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Ngao hấp xả',1,50000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Thịt dải',2,60000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Nầm nướng',2,60000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Thịt dê',3,180000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Heo rừng nướng',3,180000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Cơm chiên',4,150000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Coca',5,20000)
INSERT dbo.Food
(name, idCategory,price)
values (N'Cafe',5,30000)

--them bill
INSERT dbo.Bill
(DateCheckin, DateCheckout,idTable,status)
values (GETDATE(),null,1,0)
INSERT dbo.Bill
(DateCheckin, DateCheckout,idTable,status)
values (GETDATE(),null,2,0)
INSERT dbo.Bill
(DateCheckin, DateCheckout,idTable,status)
values (GETDATE(),GETDATE(),2,1)
-- them bill info
INSERT dbo.BillInfo
(idBill, idFood,count)
values (1,1,2)
INSERT dbo.BillInfo
(idBill, idFood,count)
values (1,3,4)
INSERT dbo.BillInfo
(idBill, idFood,count)
values (1,5,1)
INSERT dbo.BillInfo
(idBill, idFood,count)
values (2,6,2)
INSERT dbo.BillInfo
(idBill, idFood,count)
values (3,5,2)
go

Create proc usp_insertBill
@idTable int
as
begin
	Insert dbo.Bill
	(DateCheckin,DateCheckout,idTable,status)
	values (GETDATE(),null,@idTable,0)
end
go

alter proc USP_InsertBillInfo
@idBill int, @idFood int , @count int 
as
begin
	Declare @isExistBillInfo int 
	Declare @foodCount int = 1

	select @isExistBillInfo = id,@foodCount = count From dbo.BillInfo where idBill = @idBill and idFood = @idFood

	IF(@isExistBillInfo>0)
	Begin 
		Declare @newCount int = @foodCount + @count
		if(@newCount >0)
			Update dbo.BillInfo set count =@foodCount + @count where idBill = @idBill and idFood = @idFood 
		else
			Delete dbo.BillInfo where idBill = @idBill and idFood = @idFood
	END
	ELSE IF (@count >0)
	BEGIN
		Insert dbo.BillInfo
		(idBill,idFood,count)
		values (@idBill,@idFood,@count)
	end
END
go

create proc USP_Checkout
@idBill int 
as
begin 
	Update dbo.Bill set [status] = 1, DateCheckout= GETDATE() where id= @idBill
end
go

create trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert, update
as
begin
	declare @idbill int
	select @idbill = idbill from inserted

	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idbill and status = 0

	update dbo.TableFood set status = N'Có người' where id = @idTable
end
go

create trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idbill int
	select @idbill = id from inserted

	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idbill 

	declare @count int =0 
	select @count = count(*) from dbo.Bill where idTable= @idTable and status = 0

	if(@count =0)
	update dbo.TableFood set status = N'Trống' where id = @idTable
end
go

select * from dbo.TableFood
select * from bill where status=0
select * from dbo.BillInfo 

Delete from BillInfo
Delete from Bill