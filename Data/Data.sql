CREATE DATABASE MayPOS
GO

USE MayPOS
GO

-- Tài khoản nhân viên
-- Thể loại món
-- Thực đơn
-- Hóa đơn
-- Chi tiết hóa đơn

-- Tài khoản nhân viên
CREATE TABLE tb_taikhoan
(
	Username NVARCHAR(100) PRIMARY KEY,
	TenNV NVARCHAR(100) NOT NULL,
	Pass NVARCHAR(200) NOT NULL,
	Capbac INT NOT NULL DEFAULT 0, -- Nhân viên: 0, Quản lý: 1
	Hinh NVARCHAR(100),
	DiemThuong INT
)
GO

-- Thể loại món
CREATE TABLE tb_theloaimon
(
	ID_theloaimon INT IDENTITY PRIMARY KEY,
	Tentheloai NVARCHAR(100),
	Hinhtheloai NVARCHAR(100),
	Hinhbanner NVARCHAR(100)
)
GO

-- Thực đơn
CREATE TABLE tb_thucdon
(
	ID_monan INT IDENTITY PRIMARY KEY,
	Tenmonan NVARCHAR(100) NOT NULL,
	ID_theloaimon INT,
	Gia FLOAT NOT NULL DEFAULT 0,
	Mota NVARCHAR(100) NOT NULL,
	Hinhmonan NVARCHAR(100) NOT NULL,

	FOREIGN KEY (ID_theloaimon) REFERENCES dbo.tb_theloaimon(ID_theloaimon)
)
GO

-- Hóa đơn
CREATE TABLE tb_hoadon
(
	ID_hoadon INT IDENTITY PRIMARY KEY,
	Thoigianlapdon TIME(0) NOT NULL,
	Ngaylapdon DATE NOT NULL DEFAULT GETDATE()
);
GO

-- Chi tiết hóa đơn
CREATE TABLE tb_chitiethoadon
(
	ID_chitiethoadon INT IDENTITY PRIMARY KEY,
	ID_hoadon INT NOT NULL,
	ID_monan INT NOT NULL,
	Soluong INT NOT NULL,
	Dongia INT NOT NULL,
	Username NVARCHAR(100),
	FOREIGN KEY (ID_hoadon) REFERENCES dbo.tb_hoadon(ID_hoadon),
	FOREIGN KEY (ID_monan) REFERENCES dbo.tb_thucdon(ID_monan),
	FOREIGN KEY (Username) REFERENCES dbo.tb_taikhoan(Username)
);
GO

-- Thuế
CREATE TABLE tb_thue
(
	Thue INT
);
GO 

INSERT INTO tb_thue
(
	Thue
)
VALUES
(
	8
);
GO

INSERT INTO tb_taikhoan
(	
	Username ,
	TenNV ,
	Pass ,
	Capbac,
	Hinh,
	DiemThuong
)

VALUES
(
	N'lychidung' ,
	N'Lý Chí Dũng' ,
	N'2005' ,
	1,
	N'ChiDung.jpg',
	0
);
GO

INSERT INTO tb_taikhoan
(	
	Username ,
	TenNV ,
	Pass ,
	Capbac,
	Hinh,
	DiemThuong
)
VALUES
(
	N'tranthanhphat',
	N'Trần Thành Phát',
	N'2005',
	0,
	N'ThanhPhat.png',
	0
);
GO

INSERT INTO tb_taikhoan
(	
	Username ,
	TenNV ,
	Pass ,
	Capbac,
	Hinh,
	DiemThuong
)
VALUES
(
	N'nguyendientriminh',
	N'Nguyễn Điển Trí Minh',
	N'2005',
	0,
	N'TriMinh.jpg',
	0
);
GO

INSERT INTO tb_theloaimon
(
	Tentheloai,
	Hinhtheloai,
	Hinhbanner
)
VALUES
(
	N'Gà Rán - Gà Quay',
	N'ga-ran-ga-quay.png',
	N'Chicken.jpg'
	
),
(
	N'Burger',
	N'hamburger.png',
	N'Burger.jpg'
),
(
	N'Thức Ăn Nhẹ',
	N'thuc-an-nhe.png',
	N'French-fries.jpg'
),
(
	N'Thức Uống - Tráng Miệng',
	N'thuc-uong-trang-mieng.png',
	N'Drink.jpg'
),
(
	N'Món Phụ',
	N'mon-phu.png',
	N'Pasta.jpg'
);
GO

INSERT INTO dbo.tb_thucdon
(
	Tenmonan,
	ID_theloaimon,
	Gia,
	Mota,
	Hinhmonan
) VALUES
(
	N'1 Miếng Gà Rán',
	1,
	36000,
	N'1 Miếng Gà Giòn Cay/Gà Truyền Thống/Gà Giòn Không Cay',
	N'1-mieng-ga-ran.jpg'
),
(
	N'2 Miếng Gà Rán',
	1,
	71000,
	N'2 Miếng Gà Giòn Cay/Gà Truyền Thống/Gà Giòn Không Cay',
	N'2-mieng-ga-ran.jpg'
),
(
	N'3 Miếng Gà Rán',
	1,
	105000,
	N'3 Miếng Gà Giòn Cay/Gà Truyền Thống/Gà Giòn Không Cay',
	N'3-mieng-ga-ran.jpg'
),
(
	N'6 Miếng Gà Rán',
	1,
	205000,
	N'6 Miếng Gà Giòn Cay/Gà Truyền Thống/Gà Giòn Không Cay',
	N'6-mieng-ga-ran.jpg'
),
(
	N'1 Miếng Đùi Gà Quay',
	1,
	75000,
	N'1 Miếng Đùi Gà Quay Giấy Bạc/Đùi Gà Quay Tiêu',
	N'1-mieng-dui-ga-quay.jpg'
),
(
	N'1 Miếng Phi-lê Gà Quay',
	1,
	39000,
	N'1 Miếng Phi-lê Gà Quay Flava/Phi-lê Gà Quay Tiêu',
	N'1-mieng-phi-le-ga-quay.jpg'
),
(
	N'3 Cánh Gà Hot Wings',
	1,
	55000,
	N'3 Cánh Gà Hot Wings',
	N'3-canh-ga-hot-wings.jpg'
),
(
	N'5 Cánh Gà Hot Wings',
	1,
	85000,
	N'5 Cánh Gà Hot Wings',
	N'5-canh-ga-hot-wings.jpg'
),
(
	N'Gà Viên (Vừa)',
	1,
	39000,
	N'Gà Viên (Vừa)',
	N'ga-vien-vua.jpg'
),
(
	N'Gà Viên (Lớn)',
	1,
	64000,
	N'Gà Viên (Lớn)',
	N'ga-vien-lon.jpg'
),
(
	N'3 Gà Miếng Nuggets',
	1,
	27000,
	N'3 Gà Miếng Nuggets',
	N'3-ga-mieng-nuggets.jpg'
),
(
	N'5 Gà Miếng Nuggets',
	1,
	41000,
	N'5 Gà Miếng Nuggets',
	N'5-ga-mieng-nuggets.jpg'
),
(
	N'10 Gà Miếng Nuggets',
	1,
	76000,
	N'10 Gà Miếng Nuggets',
	N'10-ga-mieng-nuggets.jpg'
),
(
	N'Burger Zinger',
	2,
	55000,
	N'1 Burger Zinger',
	N'burger-zinger.jpg'
),
(
	N'Burger Tôm',
	2,
	45000,
	N'1 Burger Tôm',
	N'burger-tom.jpg'
),
(
	N'Burger Gà Quay Flava',
	2,
	55000,
	N'1 Burger Gà Quay Flava',
	N'burger-ga-quay-flava.jpg'
),
(
	N'Cơm Gà Xiên Que',
	5,
	46000,
	N'1 Cơm Gà Xiên Que',
	N'com-ga-xien-que.jpg'
),
(
	N'Cơm Xiên Gà Tenderods',
	5,
	46000,
	N'1 Cơm Xiên Gà Tenderods',
	N'com-xien-ga-tenderods.jpg'
),
(
	N'Cơm Gà Teriyaki',
	5,
	46000,
	N'1 Cơm Gà Teriyaki',
	N'com-ga-teriyaki.jpg'
),
(
	N'Cơm Gà Bít-tết',
	5,
	46000,
	N'1 Cơm Gà Bít-tết',
	N'com-ga-bit-tet.jpg'
),
(
	N'Mì Ý Xốt Cà Xúc Xích Gà Viên',
	5,
	41000,
	N'1 Mì Ý Xốt Cà Xúc Xích Gà Viên',
	N'my-y-xot-ca-xuc-xich-ga-vien.jpg'
),
(
	N'Mì Ý Xốt Cà Xúc Xích Gà Zinger',
	5,
	61000,
	N'1 Mì Ý Xốt Cà Xúc Xích Gà Zinger',
	N'my-y-xot-ca-xuc-xich-ga-zinger.jpg'
),
(
	N'Cơm Gà Rán',
	5,
	46000,
	N'1 Cơm Gà Rán',
	N'com-ga-ran.jpg'
),
(
	N'Cơm Phi-lê Gà Quay',
	5,
	46000,
	N'1 Cơm Phi-lê Gà Quay',
	N'com-phi-le-ga-quay.jpg'
),
(
	N'Salad Hạt',
	3,
	36000,
	N'1 Salad Hạt',
	N'salad-hat.jpg'
),
(
	N'Salad Pop',
	3,
	39000,
	N'1 Salad Hạt Gà Viên Popcorn',
	N'salad-pop.jpg'
),
(
	N'3 Cá Thanh',
	3,
	39000,
	N'3 Cá Thanh',
	N'3-ca-thanh.jpg'
),
(
	N'2 Xiên Que',
	3,
	41000,
	N'2 Xiên Que',
	N'2-xien-que.jpg'
),
(
	N'2 Xiên Tenderods',
	3,
	41000,
	N'2 Xiên Tenderods',
	N'2-xien-tenderods.jpg'
),
(
	N'4 Phô Mai Viên',
	3,
	35000,
	N'4 Phô Mai Viên',
	N'4-pho-mai-vien.jpg'
),
(
	N'6 Phô Mai Viên',
	3,
	45000,
	N'6 Phô Mai Viên',
	N'6-pho-mai-vien.jpg'
),
(
	N'3 Mashies Nhân Rau Củ',
	3,
	29000,
	N'3 Mashies Nhân Rau Củ',
	N'3-mashies-nhan-rau-cu.jpg'
),
(
	N'5 Mashies Nhân Rau Củ',
	3,
	39000,
	N'5 Mashies Nhân Rau Củ',
	N'5-mashies-nhan-rau-cu.jpg'
),
(
	N'Khoai Tây Chiên (Vừa)',
	3,
	19000,
	N'Khoai Tây Chiên (Vừa)',
	N'khoai-tay-chien-vua.jpg'
),
(
	N'Khoai Tây Chiên (Lớn)',
	3,
	29000,
	N'Khoai Tây Chiên (Lớn)',
	N'khoai-tay-chien-lon.jpg'
),
(
	N'Khoai Tây Chiên (Đại)',
	3,
	39000,
	N'Khoai Tây Chiên (Đại)',
	N'khoai-tay-chien-dai.jpg'
),
(
	N'Khoai Tây Nghiền (Vừa)',
	3,
	12000,
	N'Khoai Tây Nghiền (Vừa)',
	N'khoai-tay-nghien-vua.jpg'
),
(
	N'Khoai Tây Nghiền (Lớn)',
	3,
	22000,
	N'Khoai Tây Nghiền (Lớn)',
	N'khoai-tay-nghien-lon.jpg'
),
(
	N'Khoai Tây Nghiền (Đại)',
	3,
	32000,
	N'Khoai Tây Nghiền (Đại)',
	N'khoai-tay-nghien-dai.jpg'
),
(
	N'Bắp Cải Trộn (Vừa)',
	3,
	12000,
	N'Bắp Cải Trộn (Vừa)',
	N'bap-cai-tron-vua.jpg'
),
(
	N'Bắp Cải Trộn (Lớn)',
	3,
	22000,
	N'Bắp Cải Trộn (Lớn)',
	N'bap-cai-tron-lon.jpg'
),
(
	N'Bắp Cải Trộn (Đại)',
	3,
	32000,
	N'Bắp Cải Trộn (Đại)',
	N'bap-cai-tron-dai.jpg'
),
(
	N'Súp Rong Biển',
	3,
	17000,
	N'Súp Rong Biển',
	N'sup-rong-bien.jpg'
),
(
	N'1 Bánh Trứng',
	4,
	18000,
	N'1 Bánh Trứng',
	N'1-banh-trung.jpg'
),
(
	N'4 Bánh Trứng',
	4,
	59000,
	N'4 Bánh Trứng',
	N'4-banh-trung.jpg'
),
(
	N'2 Viên Khoai Môn Kim Sa',
	4,
	26000,
	N'2 Viên Khoai Môn Kim Sa',
	N'2-vien-khoai-mon-kim-sa.jpg'
),
(
	N'3 Viên Khoai Môn Kim Sa',
	4,
	35000,
	N'3 Viên Khoai Môn Kim Sa',
	N'3-vien-khoai-mon-kim-sa.jpg'
),
(
	N'5 Viên Khoai Môn Kim Sa',
	4,
	55000,
	N'5 Viên Khoai Môn Kim Sa',
	N'5-vien-khoai-mon-kim-sa.jpg'
),
(
	N'2 Thanh Bí Phô Mai',
	4,
	29000,
	N'2 Thanh Bí Phô Mai',
	N'2-thanh-bi-pho-mai.jpg'
),
(
	N'3 Thanh Bí Phô Mai',
	4,
	39000,
	N'3 Thanh Bí Phô Mai',
	N'3-thanh-bi-pho-mai.jpg'
),
(
	N'5 Thanh Bí Phô Mai',
	4,
	59000,
	N'5 Thanh Bí Phô Mai',
	N'5-thanh-bi-pho-mai.jpg'
),
(
	N'Pepsi Lon',
	4,
	17000,
	N'Pepsi Lon',
	N'pepsi-lon.jpg'
),
(
	N'7Up Lon',
	4,
	17000,
	N'7Up Lon',
	N'7up-lon.jpg'
),
(
	N'Aquafina 500ml',
	4,
	15000,
	N'Aquafina 500ml',
	N'aquafina-500ml.jpg'
),
(
	N'Trà Đào',
	4,
	24000,
	N'Trà Đào',
	N'tra-dao.jpg'
),
(
	N'Pepsi Black Lime Lon',
	4,
	17000,
	N'Pepsi Black Lime Lon',
	N'pepsi-black-lime-lon.jpg'
),
(
	N'Milo Hộp',
	4,
	20000,
	N'Milo Hộp',
	N'milo-hop.jpg'
),
(
	N'Mirinda Cam Lon',
	4,
	17000,
	N'Mirinda Cam Lon',
	N'mirinda-cam-lon.jpg'
),
(
	N'Trà Chanh Lipton (Lớn)',
	4,
	17000,
	N'Trà Chanh Lipton (Lớn)',
	N'tra-chanh-lipton-lon.jpg'
),
(
	N'Trà Chanh Lipton (Vừa)',
	4,
	10000,
	N'Trà Chanh Lipton (Vừa)',
	N'tra-chanh-lipton-vua.jpg'
);
GO

INSERT INTO tb_hoadon (Ngaylapdon, Thoigianlapdon)
VALUES 
	('2023-06-27','09:11:00'),
	('2023-06-27','09:28:00'),
	('2023-06-27','10:42:00'),
	('2023-06-28','14:15:00'),
	('2023-06-28','15:22:00'),
	('2023-06-28','16:37:00'),
	('2023-06-29','07:42:00'),
	('2023-06-29','08:18:00'),
	('2023-06-29','11:19:00');
GO

INSERT INTO tb_chitiethoadon (ID_hoadon, ID_monan, Soluong, Dongia, Username)
VALUES 
	(1, 1, 2, 36000, N'tranthanhphat'),
	(1, 3, 1, 105000, N'tranthanhphat'),
	(2, 2, 3, 71000, N'tranthanhphat'),
	(2, 4, 2, 205000, N'tranthanhphat'),
	(3, 5, 4, 75000, N'tranthanhphat'),
	(4, 1, 2, 36000, N'lychidung'),
	(4, 2, 1, 71000, N'lychidung'),
	(5, 3, 3, 105000, N'lychidung'),
	(5, 4, 2, 205000, N'lychidung'),
	(6, 5, 4, 75000, N'lychidung'),
	(7, 1, 2, 36000, N'nguyendientriminh'),
	(7, 2, 1, 71000, N'nguyendientriminh'),
	(8, 3, 3, 105000, N'nguyendientriminh'),
	(8, 4, 2, 205000, N'nguyendientriminh'),
	(9, 5, 4, 75000, N'nguyendientriminh');
GO

CREATE PROC USP_Login
@userName nvarchar(100), @pass nvarchar(200)
AS
BEGIN
	SELECT * FROM dbo.tb_taikhoan WHERE UserName = @userName AND Pass = @pass 
END
GO

CREATE PROC USP_GetMenuList		
AS SELECT * FROM dbo.tb_thucdon
GO

CREATE PROC USP_GetTheLoaiList
AS SELECT * FROM dbo.tb_theloaimon
GO

CREATE PROC USP_TheLoaiMon
AS SELECT * FROM dbo.tb_theloaimon
GO

CREATE PROC USP_ThucDon
AS 
SELECT * FROM dbo.tb_thucdon
GO

ALTER PROC USP_ThucDon
AS 
SELECT ID_monan AS [ID], Tenmonan AS [Tên Món Ăn], ID_theloaimon AS [ID Thể Loại], Gia AS [Đơn Giá], Mota AS [Mô Tả], Hinhmonan AS [Hình Ảnh] FROM dbo.tb_thucdon
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1]
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
 SET @COUNTER = @COUNTER +1
 END
 SET @strInput = replace(@strInput,' ','-')
 RETURN @strInput
END