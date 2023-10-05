create  database QLNH
go

use QLNH
go

-- Food
-- TableFood
-- TableOrder
-- Kitchen
-- FoodCategory
-- Account
-- Bill
-- BillInfo

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa có tên',
	status nvarchar(100) not null default N'Empty'-- Trong|Co nguoi
)
go

create table TableOrder
(
	id int identity primary key,
	idTable int,
	tablename nvarchar(100),
	dateCheck datetime not null,
	status nvarchar(100) not null default N'Order'

	foreign key(idTable) references dbo.TableFood(id)
)
go

create table Account(
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) not null default N'NHL',
	PassWord nvarchar(1000) not null default 0,
	Type int not null default 0, -- 1 admin 0 staff
	Images nvarchar(100) default null
)
go

create table FoodCategory(
	id int identity primary key,
	name nvarchar(100) default N'Chưa đặt tên',
	image nvarchar(100) default null
)
go

create table Food(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0,
	image nvarchar(100) default null

	foreign key(idCategory) references dbo.FoodCategory(id)
)
go

create table Kitchen
(
	id int identity primary key,
	idTable int,
	idFood int,
	dateCheckIn date not null,
	count int,
	status nvarchar(100) not null default N'not yet' -- already | not yet

	foreign key(idFood) references dbo.Food(id),
	foreign key(idTable) references dbo.TableFood(id)
)
go

create table Bill(
	id int identity primary key,
	DateCheckIn datetime not null,
	DateCheckOut DATE,
	idTable int not null,
	status int not null default 0, --1 da thanh toan|0 chua thanh toan
	discount int default 0,
	totalPrice float

	foreign key(idTable) references dbo.TableFood(id)
)
go

create table BillInfo(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key(idBill) references dbo.Bill(id),
	foreign key(idFood) references dbo.Food(id)
)
go

use QLNH
go
delete from Account
go

insert into Account(Username, DisplayName, PassWord, Type, Images)
values (N'admin', N'admin', N'1962026656160185351301320480154111117132155', 1, N'profile.png')
insert into Account(Username, DisplayName, PassWord, Type)
values (N'staff', N'staff', N'20720532132149213101239102231223249249135100218', 2)
insert into Account(Username, DisplayName, PassWord, Type)
values (N'receptionist', N'receptionist', N'20720532132149213101239102231223249249135100218', 3)
insert into Account(Username, DisplayName, PassWord, Type)
values (N'chef', N'chef', N'20720532132149213101239102231223249249135100218', 4)
go

--pass 0: 20720532132149213101239102231223249249135100218
--pass 1: 1962026656160185351301320480154111117132155

create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from Account where UserName = @userName
end
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from Account where UserName = @userName and PassWord = @passWord
end
go

declare @i int = 0
while @i <= 10
begin
	insert TableFood(name) values (N'A0' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end
go

declare @i int = 0
while @i <= 10
begin
	insert TableFood(name) values (N'B0' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end
go

declare @i int = 0
while @i <= 10
begin
	insert TableFood(name) values (N'C0' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end
go

create proc USP_GetTablelist
as select * from TableFood
go

insert FoodCategory(name, image) values (N'Hải sản', N'haisan.ico')
insert FoodCategory(name, image) values (N'Thịt', N'thit.ico')
insert FoodCategory(name, image) values (N'Soup', N'soup.ico')
insert FoodCategory(name, image) values (N'Salad', N'salad.ico')
insert FoodCategory(name, image) values (N'Trái cây', N'traicay.ico')
insert FoodCategory(name, image) values (N'Bánh', N'banh.ico')
insert FoodCategory(name, image) values (N'Nước', N'nuoc.ico')
go

insert Food(name, idCategory, price, image) values (N'Mực sào sa tế', 1, 99000, N'mucxaosate.png')
insert Food(name, idCategory, price, image) values (N'Mực Sữa Chiên Nước Mắm', 1, 99000, N'mucsuachiennuocmam.png')--
insert Food(name, idCategory, price, image) values (N'Hàu nướng phô mai', 1, 99000, N'haunuongphomai.png')
insert Food(name, idCategory, price, image) values (N'Cá phile sốt chanh dây', 1, 99000, N'caphilesotchanhday.png')--
insert Food(name, idCategory, price, image) values (N'Cơm chiên hải sản', 1, 99000, N'comchienhaisan.png')--

insert Food(name, idCategory, price, image) values (N'Heo nướng mọi', 2, 99000, N'heonuongmoi.png')
insert Food(name, idCategory, price, image) values (N'Sườn nướng BBQ', 2, 99000, N'suonnuongBBQ.png')
insert Food(name, idCategory, price, image) values (N'Sườn Cây Sốt Mật Ong', 2, 99000, N'suoncaysotmatong.png')--
insert Food(name, idCategory, price, image) values (N'Gà Ta Quay Lu', 2, 99000, N'gataquaylu.png')--
insert Food(name, idCategory, price, image) values (N'Gà Mái Dầu Nướng Muối Ớt', 2, 99000, N'gamaidaunuongmuoiot.png')--

insert Food(name, idCategory, price, image) values (N'Soup cua trứng cút', 3, 99000, N'supcuatrungcut.png')
insert Food(name, idCategory, price, image) values (N'Soup gà nấm đông cô', 3, 99000, N'supganamdongco.png')
insert Food(name, idCategory, price, image) values (N'Soup cà chua', 3, 99000, N'soupcachua.png')--
insert Food(name, idCategory, price, image) values (N'Soup khoai tây', 3, 99000, N'soupkhoaitay.png')--
insert Food(name, idCategory, price, image) values (N'Soup cua bắp mỹ', 3, 99000, N'soupcuabapmy.png')--

insert Food(name, idCategory, price, image) values (N'Salad hoa quả', 4, 99000, N'saladhoaqua.png')
insert Food(name, idCategory, price, image) values (N'Salad cá ngừ', 4, 99000, N'saladcangu.png')
insert Food(name, idCategory, price, image) values (N'Salad hoa quả sốt mè rang', 4, 99000, N'saladhoaquasotmerang.png')--
insert Food(name, idCategory, price, image) values (N'Salad hoa quả sốt mayonnaise', 4, 99000, N'saladhoaquasotmayonnaise.png')--
insert Food(name, idCategory, price, image) values (N'Salad hoa quả sốt sữa chua', 4, 99000, N'saladhoaquasotsuachua.png')--

insert Food(name, idCategory, price, image) values (N'Chôm Chôm', 5, 39000, N'chomchom.png')
insert Food(name, idCategory, price, image) values (N'Vải', 5, 39000, N'vai.png')
insert Food(name, idCategory, price, image) values (N'Thơm', 5, 39000, N'thom.png')--
insert Food(name, idCategory, price, image) values (N'Dưa hấu', 5, 39000, N'duahau.png')--
insert Food(name, idCategory, price, image) values (N'Trái Cây Theo Mùa', 5, 59000, N'traicaytheomua.png')--

insert Food(name, idCategory, price, image) values (N'Bánh su kem', 6, 29000, N'banhsukem.png')
insert Food(name, idCategory, price, image) values (N'Caramen', 6, 29000, N'caramen.png')
insert Food(name, idCategory, price, image) values (N'Bánh mì bơ tỏi', 6, 29000, N'banhmibotoi.png')--
insert Food(name, idCategory, price, image) values (N'Chè Long Nhãn', 6, 29000, N'chelongnhan.png')--
insert Food(name, idCategory, price, image) values (N'Rau Câu Trái Cây', 6, 29000, N'raucautraicay.png')--

insert Food(name, idCategory, price, image) values (N'Sữa đậu nành', 7, 19000, N'suadaunanh.png')
insert Food(name, idCategory, price, image) values (N'Pepsi', 7, 19000, N'pepsi.png')
insert Food(name, idCategory, price, image) values (N'Rượu quê', 7, 149000, N'ruouque.png')--
insert Food(name, idCategory, price, image) values (N'Vodka', 7, 149000, N'vodka.png')--
insert Food(name, idCategory, price, image) values (N'Strongbow', 7, 29000, N'strongbow.png')--

go

create proc USP_InsertBill
@idTable int
as
begin
	insert Bill(DateCheckIn, DateCheckOut, idTable, status, discount) values (getdate(), null, @idTable, 0, 0)
end 
go

create proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
begin
	declare @isExitsBillInfo int
	declare @foodCount int = 1
	
	select @isExitsBillInfo = id, @foodCount = b.count from BillInfo as b where idBill = @idBill and idFood = @idFood

	if(@isExitsBillInfo > 0)
	begin
		declare @newCount int = @foodCount + @count
		if (@newCount > 0)
			update BillInfo set count = @foodCount + @count where idFood = @idFood
		else
			delete BillInfo where idBill = @idBill and idFood = @idFood
	end
	else
	begin
		insert BillInfo(idBill, idFood, count) values(@idBill, @idFood, @count)
	end
end 
go

create trigger UTG_UpdateBillInfo
on BillInfo for insert, update
as
begin
	declare @idBill int

	select @idBill = idBill from Inserted

	declare @idTable int

	select @idTable = idTable from Bill where id = @idBill and status = 0

	declare @count int

	select @count = count(*) from BillInfo where idBill = @idBill

	if (@count > 0)
		update TableFood set status = N'Full' where id = @idTable
	else
		update TableFood set status = N'Empty' where id = @idTable
end
go

create trigger UTG_UpdateBill
on Bill for update
as
begin
	declare @idBill int

	select @idBill = id from Inserted

	declare @idTable int

	select @idTable = idTable from Bill where id = @idBill

	declare @count int = 0

	select @count = count(*) from Bill where @idTable = idTable and status = 0

	if(@count = 0)
		update TableFood set status = N'Empty' where id = @idTable
end
go

create proc USP_SwitchTable
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int

	declare @idSecondBill int

	declare @isFirstTableEmpty int = 1

	declare @isSecondTableEmpty int = 1

	select @idSecondBill = id from Bill where idTable = @idTable2 and status = 0

	select @idFirstBill = id from Bill where idTable = @idTable1 and status = 0

	if (@idFirstBill is null)
	begin
		insert Bill(DateCheckIn, DateCheckOut, idTable, status) values(getdate(), null, @idTable1, 0)

		select @idFirstBill = max(id) from Bill where idTable = @idTable1 and status = 0
	end

	select @isFirstTableEmpty = count(*) from BillInfo where idBill = @idFirstBill

	if (@idSecondBill is null)
	begin
		insert Bill(DateCheckIn, DateCheckOut, idTable, status) values(getdate(), null, @idTable2, 0)

		select @idSecondBill = max(id) from Bill where idTable = @idTable2 and status = 0
	end

	select @isSecondTableEmpty = count(*) from BillInfo where idBill = @idSecondBill

	select id into IDBillInfoTable from BillInfo where idBill = @idSecondBill

	update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill

	update BillInfo set idBill = @idFirstBill where id in (select * from IDBillInfoTable)

	drop table IDBillInfoTable

	if (@isFirstTableEmpty = 0)
		update TableFood set status = N'Empty' where id = @idTable2

	if (@isSecondTableEmpty = 0)
		update TableFood set status = N'Empty' where id = @idTable1
end
go

create proc USP_MergeTable
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int

	declare @idSecondBill int

	declare @isFirstTableEmpty int = 1

	declare @isSecondTableEmpty int = 1

	select @idSecondBill = id from Bill where idTable = @idTable2 and status = 0

	select @idFirstBill = id from Bill where idTable = @idTable1 and status = 0

	if (@idFirstBill is null)
	begin
		insert Bill(DateCheckIn, DateCheckOut, idTable, status) values(getdate(), null, @idTable1, 0)

		select @idFirstBill = max(id) from Bill where idTable = @idTable1 and status = 0
	end

	select @isFirstTableEmpty = count(*) from BillInfo where idBill = @idFirstBill

	if (@idSecondBill is null)
	begin
		insert Bill(DateCheckIn, DateCheckOut, idTable, status) values(getdate(), null, @idTable2, 0)

		select @idSecondBill = max(id) from Bill where idTable = @idTable2 and status = 0
	end

	select @isSecondTableEmpty = count(*) from BillInfo where idBill = @idSecondBill

	update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill

	update TableFood set status = N'Empty' where id = @idTable1
end
go

create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.Name as [Table Name], b.totalPrice as [Total price], DateCheckIn as [Date check in], DateCheckOut as [Date check out], discount as [Discount]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go

create proc USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows
	declare @exceptRow int = (@page-1) * @pageRows

	;with BillShow as (select b.id, t.Name as [Table Name], b.totalPrice as [Total price], DateCheckIn as [Date check in], DateCheckOut as [Date check out], discount as [Discount]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable )

	select top(@selectRows) * from BillShow where id not in (select top (@exceptRow) id from BillShow)
end
go

create proc USP_GetNumBillByDate
@checkIn date, @checkOut date
as
begin
	select count(*)
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go

create proc USP_GetTotalBillByDate
@checkIn date, @checkOut date
as
begin
	select sum(b.totalPrice) as [Total price]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go

create proc USP_GetTotalBillByYear
@checkIn date, @checkOut date
as
begin
	select sum(b.totalPrice) as [Total price]
	from Bill as b, TableFood as t
	where YEAR(DateCheckIn) >= YEAR(@checkIn) and YEAR(DateCheckOut) <= YEAR(@checkOut) and b.status = 1 and t.id = b.idTable
end
go

create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100), @image nvarchar(100)
as
begin
	declare @isRightPass int = 0

	select @isRightPass = count(*) from Account where userName = @userName and PassWord = @password

	if (@isRightPass = 1)
	begin
		if (@newPassword = null or @newPassword = '')
		begin
			update Account set DisplayName = @displayName, Images = @image where UserName = @userName
		end
		else
			update Account set DisplayName = @displayName, Images = @image, PassWord = @newPassword where UserName = @userName
			
	end
end
go

create trigger UTG_DeleteBillInfo
on BillInfo for delete
as
begin
	declare @idBillInfo int

	declare @idBill int

	select @idBillInfo = id, @idBill = id from Deleted

	declare @idTable int

	select @idTable = idTable from Bill where id = @idBill

	declare @count int = 0

	select @count = count(*) from BillInfo as bi, Bill as b where b.id = bi.idBill and b.id = @idBill and b.status = 0

	if (@count = 0)
		Update TableFood set status = N'Empty' where id = @idTable
		
end
go

CREATE FUNCTION fuChuyenCoDauThanhKhongDau
(
      @strInput NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN  
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế
                  ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý
                  ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ
                  ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'
                  +NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee
                  iiiiiooooooooooooooouuuuuuuuuuyyyyy
                  AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII
                  OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN
      SET @COUNTER1 = 1
      --Tìm trong chuỗi mẫu
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1))
            = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN        
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
              + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1)
              +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
              + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
              BREAK
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tìm tiếp
       SET @COUNTER = @COUNTER +1
    END
    SET @strInput = replace(@strInput,' ','-')
    RETURN @strInput
END
go

create proc USP_InsertTableOrder
@idTable int, @dateCheck datetime
as
begin
	declare @name nvarchar(100) = (select name from TableFood where id = @idTable)
	insert TableOrder(idTable, tableName, DateCheck, status) values (@idTable, @name, @dateCheck, N'Order')
end 
go

create proc USP_DeleteTableOrder
@idTable int, @dateCheck datetime
as
begin
	delete from TableOrder where idTable = @idTable and dateCheck = @dateCheck
end 
go

create proc USP_DeleteTableOrderInDate
@dateCheck datetime
as
begin
	delete from TableOrder where Year(dateCheck) = Year(@dateCheck) and Month(dateCheck) = Month(@dateCheck) and Day(dateCheck) = Day(@dateCheck)
end 
go

create proc USP_GetStatusById
@idTable int, @dateCheck datetime
as
begin
	select count(*) from TableOrder where idTable = @idTable and Year(dateCheck) = Year(@dateCheck) and Month(dateCheck) = Month(@dateCheck) and Day(dateCheck) = Day(@dateCheck) and status = N'Order'
end 
go

create proc USP_GetTimeByIdAndDate
@idTable int, @dateCheck datetime
as
begin
	select * from TableOrder where idTable = @idTable and Year(dateCheck) = Year(@dateCheck) and Month(dateCheck) = Month(@dateCheck) and Day(dateCheck) = Day(@dateCheck)
end 
go

create proc USP_SearchForLoadTableOrder
@name nvarchar, @dateCheck datetime
as
begin
	select * from TableFood
	where TableFood.name not like N'Cart' and ( dbo.fuChuyenCoDauThanhKhongDau(name) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(@name) + '%' 
		or dbo.fuChuyenCoDauThanhKhongDau(status) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(@name) + '%' )
end 
go

create proc USP_DeleteOrderLastDate
as
begin
	delete from TableOrder where Year(dateCheck) < Year(GETDATE()) and Month(dateCheck) < Month(GETDATE()) and Day(dateCheck) < Day(GETDATE())
end 
go

create proc USP_GetListTableOrderOnDate
as
begin
	select TableFood.id, name, TableFood.status from TableFood, TableOrder where TableFood.id = TableOrder.idTable
		and Year(TableOrder.dateCheck) = Year(getdate())
		and Month(TableOrder.dateCheck) = Month(getdate())
		and Day(TableOrder.dateCheck) = Day(getdate())
end 
go

create proc USP_GetListTableOrderByDate
@month int, @year int
as
begin
	select * from TableOrder where Year(dateCheck) = @year and Month(dateCheck) = @month
end 
go