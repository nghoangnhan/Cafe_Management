DROP DATABASE CafeManager
CREATE DATABASE CafeManager
GO
USE CafeManager
GO
CREATE TABLE Employees (E_ID nvarchar(15) primary key, E_Name nvarchar(50), E_Phone nvarchar(11), E_Address nvarchar(50), E_Salary int, E_Position nvarchar(10))
Go
CREATE TABLE Customer (C_ID int IDENTITY (1, 1) primary key, C_Name nvarchar(50), C_Phone nvarchar(11) unique, C_Address nvarchar(50), C_TotalPay int)
GO
CREATE TABLE Item (It_ID nvarchar(10), It_Name nvarchar(20) primary key , It_Cost int)
GO
CREATE TABLE _Order (O_Num int primary key, O_Description nvarchar(50))
GO
CREATE TABLE Order_Item (O_Num int references _Order(O_Num), It_Name nvarchar(20) references Item(It_Name), It_Quantity int, primary key clustered(O_Num,It_Name))
GO
CREATE TABLE CHECKING(E_ID nvarchar(15) references Employees(E_ID), DAY_ID int, DAY_CHECK int, MONTH_ID int, primary key clustered(E_ID,DAY_ID,MONTH_ID))
GO
CREATE TABLE LO_GIN_Manager(username nvarchar(15) primary key,pass_word nvarchar(15))
GO
CREATE TABLE LO_GIN_Employee(username nvarchar(15) primary key,pass_word nvarchar(15))
GO
CREATE TABLE Bill (
B_Num int IDENTITY(1, 1) primary key, 
O_Num int References _Order(O_Num), 
E_ID nvarchar(15) references Employees(E_ID),
C_ID int references Customer(C_ID),
B_Date DateTime, 
B_Total int, 
B_Description nvarchar(50))
GO

 INSERT INTO Employees VALUES ('e000' 	, N'Lê Hoàng Lâm' 	, '0938591504' 	, N'Thủ Đức' 	,20000000		 ,N'Quản lý')
 INSERT INTO Employees VALUES ('e001' 	, N'Nguyễn Hoàng Nhân' 	, '0798931234' 	, N'Thủ Đức' 	,20000000		 ,N'Quản lý')
 INSERT INTO Employees VALUES ('e002' 	, N'Tạ Hoài Nam' 	, '0909232603' 	, N'Thủ Đức' 	,10000000		 ,N'Pha chế')
 INSERT INTO Employees VALUES ('e003' 	, N'Nguyễn Văn Hơn' 	, '0953536346' 	, N'Quận 1' 	,8000000		 ,N'Pha chế')
 INSERT INTO Employees VALUES ('e004' 	, N'Vũ Trọng Nhân' 	, '0921424142' 	, N'Quận 10' 	,8000000		 ,N'Pha chế')
 INSERT INTO Employees VALUES ('e005' 	, N'Nguyễn Hoàng Nhật Nam' 	, '0909252673' 	, N'Thủ Đức' 	,6000000		, N'Thu ngân')
 INSERT INTO Employees VALUES ('e006' 	, N'Nguyễn Việt Anh' 	, '0734345352' 	, N'Quận 2' 	,5500000		, N'Thu ngân')

 INSERT INTO Employees VALUES ('e009' 	, N'Nguyễn Huỳnh Thanh Toàn' 		, '0926266222' 	, N'Bình Dương' 	,8000000		, N'Bồi bàn')
 INSERT INTO Employees VALUES ('e010' 	, N'Trần Minh Gia Khánh' 			, '0943536256' 	, N'Quận 9' 	,8000000		, N'Bồi bàn')
 INSERT INTO Employees VALUES ('e011' 	, N'Lê Tấn Lộc' 	, '0935642158' 		, N'Quận 2' 	,8000000		, N'Bồi bàn')
 INSERT INTO Employees VALUES ('e012' 	, N'Lê Khánh Linh' 	, '0926263637' 	, N'Thủ Đức' 	,8000000		, N'Bồi bàn')
 INSERT INTO Employees VALUES ('e013' 	, N'Lý Hồng Khanh' 	, '0987562415' 	, N'Thủ Đức' 	,8000000		, N'Bồi bàn')
 INSERT INTO Employees VALUES ('e014' 	, N'Lê Y Thiện' 	, '0921578112' 		, N'Thủ Đức' 	,8000000		, N'Bồi bàn')

 INSERT INTO Item VALUES ('i001' 	, 'Expresso' 		,30000 )
 INSERT INTO Item VALUES ('i002' 	, 'Cafe Americano' 	,35000)
 INSERT INTO Item VALUES ('i003' 	, 'Cafe Capuccino' 	,35000)
 INSERT INTO Item VALUES ('i004' 	, 'Cafe Latte' 		,35000)
 INSERT INTO Item VALUES ('i005' 	, 'Chocolate' 		,35000)
 INSERT INTO Item VALUES ('i006' 	, 'Choco Cafe' 		,40000)
 INSERT INTO Item VALUES ('i007' 	, 'Caramel Cafe' 	,40000)
 INSERT INTO Item VALUES ('i008' 	, 'Black Cafe' 		,30000)
 INSERT INTO Item VALUES ('i009' 	, 'Rich Milk Cafe' 	,33000)
 INSERT INTO Item VALUES ('i010' 	, 'Black Milk Tea' 	,35000)
 INSERT INTO Item VALUES ('i011' 	, 'Olong Milk Tea' 	,35000)
 INSERT INTO Item VALUES ('i012' 	, 'Peach Black Tea' ,40000)
 INSERT INTO Item VALUES ('i013' 	, 'Lemon Black Tea' ,30000)
 INSERT INTO Item VALUES ('i014' 	, 'Green Tea Latte' ,35000)
 INSERT INTO Item VALUES ('i015' 	, 'Lychee Tea'		,45000)
 INSERT INTO Item VALUES ('i016' 	, 'Longan Tea' 		,45000)
 INSERT INTO Item VALUES ('i017' 	, 'Peach Milk Tea' 	,40000)
 INSERT INTO Item VALUES ('i018' 	, 'Forest Jasmine Tea' 	,50000)
 INSERT INTO Item VALUES ('i019' 	, 'Oreo Ice Blend' 	,40000)
 INSERT INTO Item VALUES ('i020' 	, 'Matcha Ice Blend',40000)

 INSERT INTO _Order VALUES (1, '2x Lychee Tea')
 INSERT INTO _Order VALUES (2, '1x Caramel Cafe')
 INSERT INTO _Order VALUES (3, '1x Matcha Ice Blend, 1x Lemon Black Tea')
 INSERT INTO _Order VALUES (4, '2x Oreo Ice Blend, 1x Caramel Cafe,1x Longan Tea')
 INSERT INTO _Order VALUES (5, '2x Longan Tea')
 INSERT INTO _Order VALUES (6, '1x Choco Cafe, 1x Caramel Cafe')
 INSERT INTO _Order VALUES (7, '1x Caramel Cafe')
 INSERT INTO _Order VALUES (8, '1x Expresso')
 INSERT INTO _Order VALUES (9, '1x Peach Black Tea')
 INSERT INTO _Order VALUES (10, '1x Oreo Ice Blend, 1x Lychee Tea')



INSERT INTO Customer VALUES(  N'Nguyễn Văn A' 	 , '0121321342' 	 , N'Thủ Đức' 	 , '90000' )
INSERT INTO Customer VALUES(  N'Lê Văn B' 	 , '0242343414' 	 , N'Thủ Đức' 	 , '40000') 
INSERT INTO Customer VALUES(N'Trần Văn C' 	 , '0947375352' 	 , N'Quan 2' 	 , '75000' )
INSERT INTO Customer VALUES(  N'Nguyễn Thị D' 	 , '0235232253' 	 , N'Quận 9' 	 , '125000' )
INSERT INTO Customer VALUES(  N'Dương Văn F' 	 , '0634622642' 	 , N'Thủ Đức' 	 , '90000' )
INSERT INTO Customer VALUES(  N'Lê Thị E' 	 , '0545357723' 	 , N'Thủ Đức' 	 , '80000' )
INSERT INTO Customer VALUES(  N'Nguyễn Hoàng G' 	 , '0997876663' 	 , N'Quận 2' 	 , '40000' )
INSERT INTO Customer VALUES(  N'Nguyễn Huỳnh H' 	 , '0132423532' 	 , N'Thủ Đức' 	 , '30000' )
INSERT INTO Customer VALUES(  N'Lý Hoàng L' 	 , '0723525244' 	 , N'Thủ Đức' 	 , '40000' )
INSERT INTO Customer VALUES(  N'Bùi Tuấn K' 	 , '0141242535' 	 , N'Quận 1' 	 , '85000' )


 INSERT INTO Order_Item VALUES('1'  ,'Lychee Tea'			,2)
 INSERT INTO Order_Item VALUES('2' 	,'Caramel Cafe' 		,1)
 INSERT INTO Order_Item VALUES('3' 	,'Matcha Ice Blend'		,1)
 INSERT INTO Order_Item VALUES('3' 	,'Lemon Black Tea'	,1)
 INSERT INTO Order_Item VALUES('4' 	,'Oreo Ice Blend'		,2)
 INSERT INTO Order_Item VALUES('4' 	,'Caramel Cafe' 	,1)
 INSERT INTO Order_Item VALUES('4' 	,'Longan Tea'			,1)
 INSERT INTO Order_Item VALUES('5' 	,'Longan Tea' 		,2)
 INSERT INTO Order_Item VALUES('6' 	,'Choco Cafe'			,1)
 INSERT INTO Order_Item VALUES('6' 	,'Caramel Cafe' 		,1)
 INSERT INTO Order_Item VALUES('7' 	,'Caramel Cafe'		,1)
 INSERT INTO Order_Item VALUES('8' 	,'Expresso'			,1)
 INSERT INTO Order_Item VALUES('9' 	,'Peach Black Tea'		,1)
 INSERT INTO Order_Item VALUES('10' ,'Oreo Ice Blend'		,1)
 INSERT INTO Order_Item VALUES('10' ,'Lychee Tea'		,1)

 
 INSERT INTO Bill VALUES(1  ,'e005'  ,'1', '02/12/2022' 		, 90000  	,'2x Lychee Tea' 									) 
 INSERT INTO Bill VALUES(2	,'e005'  ,'2', '02/12/2022'  	, 40000  	,'1x Caramel Cafe' 									 ) 
 INSERT INTO Bill VALUES(3	,'e005'  ,'3', '02/12/2022'		,  75000	,'1x Matcha Ice Blend, 1x Lemon Black Tea'			)  
 INSERT INTO Bill VALUES(4	,'e005'  ,'4', '02/12/2022'		,  125000	,'2x Oreo Ice Blend, 1x Caramel Cafe,1x Longan Tea' ) 
 INSERT INTO Bill VALUES(5	,'e005'  ,'5', '02/12/2022' 		,  90000	,'2x Longan Tea' 									 ) 
 INSERT INTO Bill VALUES(6	,'e006'  ,'6', '02/14/2022' 		,  80000	,'1x Choco Cafe, 1x Caramel Cafe' 					 ) 
 INSERT INTO Bill VALUES(7	,'e006'  ,'7', '02/15/2022' 		, 40000		,'1x Caramel Cafe' 									 ) 
 INSERT INTO Bill VALUES(8	,'e006'  ,'8', '02/16/2022' 		,  30000	,'1x Expresso' 										) 
 INSERT INTO Bill VALUES(9	,'e006'  ,'9', '02/17/2022' 		, 40000		,'1x Peach Black Tea' 								 ) 
 INSERT INTO Bill VALUES(10 ,'e006'  ,'10', '02/18/2022' 		,  85000	,'1x Oreo Ice Blend, 1x Lychee Tea' 				) 

 INSERT INTO LO_GIN_Manager VALUES ('m' , 'm')
 INSERT INTO LO_GIN_Employee VALUES ('e' , 'e');

 --Employee Management
 --Add Employee
 CREATE PROC Add_Employee
 @eid	nvarchar(15),
 @ename	nvarchar(50),
 @eaddr	nvarchar(50),
 @ephone	nvarchar(11),
 @esalary	int,
 @eposition	nvarchar(15)
 AS
 BEGIN
 INSERT INTO Employees (E_ID, E_Name, E_Phone, E_Address, E_Salary, E_Position) VALUES (@eid, @ename, @ephone, @eaddr,  @esalary, @eposition)
 END
 GO

 CREATE PROC Dismiss
 @E_id	nvarchar(15),
 @E_name	nvarchar(50),
 @E_addr	nvarchar(50),
 @E_phone	int,
 @E_salary	int,
 @E_position	nvarchar(15)
 AS
 BEGIN
DELETE FROM Employees WHERE E_ID=@E_id 
END
GO

 CREATE PROC Edit
 @E_id	nvarchar(15),
 @E_name	nvarchar(50),
 @E_addr	nvarchar(50),
 @E_phone	int,
 @E_salary	int,
 @E_position	nvarchar(15)
 AS
 BEGIN
UPDATE Employees SET E_Name=@E_name, E_Address= @E_addr,E_Phone= @E_phone,E_Salary= @E_salary,E_Position= @E_position WHERE E_ID=@E_id 
END
GO

 CREATE PROC CHAM
 @E_id	nvarchar(15),
 @DAY_id	int,
 @DAY_check	int,
 @MONTH_id	int
 AS
 BEGIN
INSERT INTO CHECKING (E_ID,DAY_ID,DAY_CHECK,MONTH_ID) VALUES (@E_id,@DAY_id,@DAY_check,@MONTH_id)
END
GO

--CoffeeShop Management
CREATE PROC Add_OrderItem
@onum int,
@itname nvarchar(25),
@quan int
AS 
BEGIN 
INSERT INTO Order_Item(O_Num, It_Name, It_Quantity) VALUES (@onum, @itname, @quan)
END
GO


CREATE PROC Add_Order
@onum int
AS 
BEGIN 
INSERT INTO _Order (O_Num) VALUES (@onum)
END
GO

CREATE PROC Update_OrderItem
@onum int, 
@itname nvarchar(25),
@quan int 
AS
BEGIN
UPDATE Order_Item SET It_Quantity = @quan WHERE O_Num = @onum AND It_Name = @itname
END
GO


CREATE PROC Delete_OrderItem
@onum int, 
@itname nvarchar(25)
AS
BEGIN 
DELETE Order_Item WHERE O_Num = @onum AND It_Name = @itname
END 
GO

CREATE PROC DeleteOrder
@onum int
AS
BEGIN 
DELETE _Order WHERE O_Num = @onum
END
GO

CREATE PROC DeleteBill
@onum int
AS
BEGIN 
DELETE Bill WHERE O_Num = @onum
END
GO

CREATE PROC addBill
@ordernum int, 
@eid nvarchar(10),
@cid int,
@date datetime,
@price int,
@des nvarchar(50)
AS
BEGIN 
	INSERT INTO Bill(O_Num, E_ID, C_ID, B_Date, B_Total, B_Description) VALUES (@ordernum, @eid, @cid, @date, @price, @des)
END
GO



--Customer Manage
CREATE PROC addCustomer
@cname nvarchar(50),
@phone nvarchar(11),
@address nvarchar(50),
@totalpay int
AS
BEGIN
SET @totalpay = 0
INSERT INTO Customer (C_Name, C_Phone, C_Address, C_TotalPay) VALUES (@cname, @phone, @address, @totalpay)
END
GO

CREATE PROC DeleteCustomer
@C_ID	int,
 @C_Name	nvarchar(50),
 @C_Address nvarchar(50),
 @C_Phone	int,
 @C_TotalPay	int
AS 
BEGIN 
	DELETE FROM Customer WHERE C_ID=@C_ID
END
GO

CREATE PROC checkCustomer
@phone nvarchar(11)
AS 
BEGIN 
	SELECT * 
	FROM Customer
	WHERE C_Phone = @phone
END
GO

--Function
CREATE FUNCTION checkTotalPay (@cid int)
RETURNS int
AS
BEGIN
DECLARE @total int
SELECT @total = C_TotalPay FROM Customer
WHERE Customer.C_ID = @cid
RETURN @total
END
GO

CREATE FUNCTION CheckPrice (@itemname nvarchar(25))
RETURNS int
AS
BEGIN 
	DECLARE @price int
	SELECT @price = It_Cost
	FROM Item
	WHERE @itemname = It_Name
	return @price
END
GO


--Trigger
CREATE TRIGGER TrigggerOrder
ON _Order
INSTEAD OF DELETE
AS
Declare @num nvarchar(20);
SELECT @num = deleted.O_Num FROM deleted
DELETE FROM Order_Item 
WHERE Order_Item.O_Num = @num
DELETE FROM _Order WHERE _Order.O_Num = @num
GO

CREATE TRIGGER TriggerBill
ON Bill
FOR INSERT
AS
DECLARE 
@total int,
@cid int,
@totalpay int,
@bnum int
SELECT @total = inserted.B_Total, @cid = inserted.C_ID, @bnum = inserted.B_Num FROM inserted
SELECT @totalpay = dbo.checkTotalPay(@cid)
if(@totalpay >= 1000000) SET @total = @total * 0.9
UPDATE Bill SET B_Total = @total WHERE B_Num = @bnum
UPDATE Customer SET C_TotalPay = @totalpay + @total WHERE @cid = C_ID
GO

CREATE TRIGGER TriggerAddOrder_Item
ON Order_Item
INSTEAD OF INSERT
AS 
DECLARE
@onum int,
@itname nvarchar(50),
@quan int
SET @quan = 1
SELECT @onum = inserted.O_Num, @itname = inserted.It_Name FROM inserted
SELECT @quan = It_Quantity FROM Order_Item WHERE O_Num = @onum AND It_Name = @itname
IF( NOT EXISTS(Select * FROM Order_Item WHERE O_Num = @onum AND It_Name = @itname))
	INSERT INTO Order_Item (O_Num, It_Name, It_Quantity) VALUES (@onum, @itname, 1)
ELSE 
	SET @quan = @quan +	1
UPDATE Order_Item SET It_Quantity = @quan WHERE O_Num = @onum AND It_Name = @itname
GO

CREATE TRIGGER TriggerCustomer
ON Customer
INSTEAD OF DELETE
AS
Declare 
 @C_ID	int,
 @C_Name	nvarchar(50),
 @C_Address nvarchar(50),
 @C_Phone	int,
 @C_TotalPay	int
SELECT @C_ID = deleted.C_ID FROM deleted
DELETE FROM Bill 
WHERE Bill.C_ID = @C_ID
DELETE FROM Customer WHERE Customer.C_ID = @C_id
GO

CREATE TRIGGER TriggerDescription
ON Bill
AFTER INSERT
AS
Declare 
 @O_Num int,
 @B_Description nvarchar(50)
SELECT @O_Num =inserted.O_Num,  @B_Description= inserted.B_Description FROM inserted
UPDATE _Order SET O_Description=@B_Description WHERE O_Num=@O_Num
GO

CREATE TRIGGER TriggerDeleteBill
ON Bill
AFTER DELETE
AS
DECLARE
@onum int
SELECT @onum=deleted.O_Num FROM deleted
EXECUTE DeleteOrder @onum
GO

--Transaction


CREATE TRIGGER TriggerEmployee
ON Employees
INSTEAD OF DELETE
AS
BEGIN TRANSACTION
DECLARE @E_id	nvarchar(15),
 @E_name	nvarchar(50),
 @E_addr	nvarchar(50),
 @E_phone	int,
 @E_salary	int,
 @E_position	nvarchar(15)
SELECT @E_id = deleted.E_ID FROM deleted
DELETE FROM CHECKING 
WHERE CHECKING.E_ID = @E_id
DELETE FROM Employees WHERE Employees.E_ID = @E_id
  
IF (@@ERROR <> 0)
BEGIN
RAISERROR(N'Failed To Delete Employee', 16, 1)
 
ROLLBACK TRANSACTION
RETURN
END
COMMIT TRANSACTION
GO






