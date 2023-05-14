CREATE DATABASE Pharmacity
GO

USE Pharmacity
GO

/***** CREATE TABLE *****/
/* Create Table Vitri */
CREATE TABLE ViTri(
	ID VARCHAR(10) NOT NULL, 
	TEN NVARCHAR(100) NOT NULL
);
ALTER TABLE Vitri ADD CONSTRAINT PK_Vitri PRIMARY KEY(ID) 

/* Create Table Nhanvien */
CREATE TABLE Nhanvien(
	IDNV VARCHAR(10) NOT NULL, 
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH NVARCHAR(7) NOT NULL,
	DOB DATETIME NOT NULL,
	QUEQUAN NVARCHAR(50) NOT NULL,
	SDT VARCHAR(12) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	IDVitri VARCHAR(10) NOT NULL
);
ALTER TABLE Nhanvien ADD CONSTRAINT PK_NV PRIMARY KEY(IDNV) 
ALTER TABLE Nhanvien ADD CONSTRAINT FK_NV FOREIGN KEY(IDVitri) REFERENCES Vitri(ID) 

/* Create Table Taikhoan */
CREATE TABLE Taikhoan(
	ID VARCHAR(100) NOT NULL, 
	TENDANGNHAP VARCHAR(10) NOT NULL,
	MATKHAU VARCHAR(50) NOT NULL,
	QUYEN INT NOT NULL
);
ALTER TABLE Taikhoan ADD CONSTRAINT PK_TK PRIMARY KEY(ID) 
ALTER TABLE Taikhoan ALTER COLUMN TENDANGNHAP VARCHAR(50) NOT NULL

/* Create Table Khachhang */
--IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Khachhang')
--	DROP TABLE Khachhang
--GO
CREATE TABLE Khachhang(
	IDKH VARCHAR(10) NOT NULL, 
	HOTEN NVARCHAR(100) NOT NULL,
	GIOITINH NVARCHAR(7) NOT NULL,
	DOB DATETIME NOT NULL,
	QUEQUAN NVARCHAR(50) NOT NULL,
	SDT VARCHAR(12) NOT NULL,
	SONHA NVARCHAR (40),
	DUONG NVARCHAR (50),
	PHUONG NVARCHAR (50),
	QUAN NVARCHAR (50),
	THANHPHO NVARCHAR (50),
	CONSTRAINT PK_KH PRIMARY KEY(IDKH) 
);

/* ---------------------------------- Warehouse ------------------------------------ */
/* Thể loại thuốc */
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Theloaisp')
	DROP TABLE Theloaisp
GO
CREATE TABLE Theloaisp (
	ID_THELOAI VARCHAR (7) PRIMARY KEY,
	TEN_THELOAI NVARCHAR(500) NOT NULL
)

/* Thông tin thuốc */
-- Kẹo, khẩu trang, bánh, băng keo cá nhân, dược phẫm
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Sanpham')
	DROP TABLE Sanpham
GO
CREATE TABLE Sanpham (
	ID_SP VARCHAR (10) PRIMARY KEY,
	TEN_SP NVARCHAR(500) NOT NULL,
	HSD_SP DATE NOT NULL,
	
	XUATXU_SP NVARCHAR (500) NOT NULL,	--Combobox
	DVSX_SP NVARCHAR (500), 
	CHUNGNHAN_SP NVARCHAR (50),

	CONGDUNG_SP NVARCHAR(MAX),
	PHANUNGPHU_SP NVARCHAR (MAX),
	LUUY_SP NVARCHAR (MAX),
	
	LIEULUONG_SP NVARCHAR (10),  -- Default mg
	THANHPHAN_SP NVARCHAR (MAX),

	SOLUOTBAN BIGINT DEFAULT 0,			--Sẽ được làm mới sau mỗi năm
	DONVITINH NVARCHAR (500) NOT NULL,	-- H: hộp, lọ, chai ; V:vỉ,tuýp; VI: viên (đơn vị bán). 
										-- 1H: 2V: 30vi
)

/* Thông tin thuốc và thể loại*/
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'SP_Theloai')		
	DROP TABLE SP_Theloai
GO
--Thuốc, đồ dùng, đồ ăn
CREATE TABLE SP_Theloai (
	ID_SP VARCHAR (10),
	ID_THELOAI VARCHAR (7),
	CONSTRAINT PK_ThuocTheloai PRIMARY KEY (ID_SP,ID_THELOAI),
	CONSTRAINT FK_ThuocTL FOREIGN KEY (ID_SP) REFERENCES Sanpham(ID_SP),
	CONSTRAINT FK_TheloaiTL FOREIGN KEY (ID_THELOAI) REFERENCES Theloaisp(ID_THELOAI)
)

/* Thông tin thuốc trong kho*/
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'SP_Kho')
	DROP TABLE SP_Kho
GO
CREATE TABLE SP_Kho (					-- Coi lại về quản lý số lượng
	ID_SP VARCHAR (10) PRIMARY KEY,
	VITRI_KHO VARCHAR (50) NOT NULL,
	VITRI_CUAHANG VARCHAR (50) NOT NULL,

	NGAYNHAP SMALLDATETIME DEFAULT GETDATE(),

	QUYCACHDONGGOI NVARCHAR (100),		-- 1 hộp / 30 vỉ / 50 viên, 1 lọ/ 50 viên * Nhập hàng chỉ cần nhập cái này, những cái sau sẽ tự tính
	SL_DVDONGGOI BIGINT,			-- 30 hộp, 30 lọ
	DONGIA_DONGGOI MONEY,		-- 1 hộp : 100k		
	TIENGOC_DONGGOI MONEY NOT NULL,		--Tính theo quy cách đóng gói

	DONVIBAN NVARCHAR (100),			-- viên
	SL_DVBAN BIGINT,
	DONGIA_DVBAN MONEY,
	TIENGOC_DVB MONEY NOT NULL,		--Tính theo quy cách đóng gói
	CONSTRAINT FK_ThuocKho FOREIGN KEY (ID_SP) REFERENCES Sanpham(ID_SP)
)


/* Thông tin đơn đặt và xuất hàng*/
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Donxuathang')
	DROP TABLE Donxuathang
GO
CREATE TABLE Donxuathang (											--Mỗi lần xuất hàng sẽ cộng vào tiền hàng trong bảng
	ID_DONXUATHANG VARCHAR (15) PRIMARY KEY,						--Tự động, xóa sau 1 năm
	HINHTHUC INTEGER,												--0 là mua onl, 1 là mua off
	TRATRUOC INT DEFAULT 0,											--1: Trả trc, 0: Mua bthg
	MOTA_DONXUATHANG NVARCHAR (MAX) NOT NULL,
	NGAYXUATHANG SMALLDATETIME DEFAULT GETDATE(),					--Tự động
	
	ID_NVLD VARCHAR(10) NOT NULL,									--từ ID lấy tên NV
	ID_KH VARCHAR(10),												--giữ ID khách hàng, lấy địa chỉ sdt (ONL)
	TONGGT_DH MONEY NOT NULL DEFAULT 0,		 

	TIENHANG MONEY NOT NULL,

	TIENNHAN MONEY NOT NULL,
	TIENTRA MONEY DEFAULT 0,

	CONSTRAINT FK_DXH_KH FOREIGN KEY (ID_KH) REFERENCES Khachhang(IDKH),
	CONSTRAINT FK_DXH_NV FOREIGN KEY (ID_NVLD) REFERENCES Nhanvien(IDNV)
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Chitiethoadon')
	DROP TABLE Chitiethoadon
GO
CREATE TABLE Chitiethoadon (
	ID_DONXUATHANG VARCHAR (15),					--Tự động
	ID_SP VARCHAR (10),
	DVMUA NVARCHAR (20),				
	SOLUONG BIGINT,							--Trừ sản phẩm theo đơn vị bán (viên hay vỉ: trừ viên, hộp thì trừ viên trừ vỉ)
	SPTL INT DEFAULT 0,						--Là sản phẩm thanh lý thì là 1	
	CONSTRAINT PK_CTHD PRIMARY KEY (ID_SP,ID_DONXUATHANG),
	CONSTRAINT FK_CTHDSP FOREIGN KEY (ID_SP) REFERENCES Sanpham(ID_SP),
	CONSTRAINT FK_CTHDD FOREIGN KEY (ID_DONXUATHANG) REFERENCES Donxuathang(ID_DONXUATHANG)
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Donnhaphang')
	DROP TABLE Donnhaphang
GO
CREATE TABLE Donnhaphang (
	ID_DONNHAPHANG VARCHAR (15) PRIMARY KEY,	--Tự động
	MOTA_DONNHAPHANG NVARCHAR (MAX) NOT NULL,
	NGAYNHAPHANG SMALLDATETIME NOT NULL DEFAULT GETDATE(),		

	ID_NV VARCHAR(10) NOT NULL, 
	ID_NVKT VARCHAR (10) NOT NULL,

	DONVIVANCHUYEN VARCHAR (100) NOT NULL,
	GIATRINHAPHANG MONEY NOT NULL,
	TIENVANCHUYEN MONEY NOT NULL,
	GHICHU NVARCHAR (MAX),									--Ghi chú đơn hàng
	CONSTRAINT FK_DNH FOREIGN KEY (ID_NV) REFERENCES Nhanvien(IDNV)
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Chitietdonnhap')
	DROP TABLE Chitietdonnhap
GO
CREATE TABLE Chitietdonnhap (
	ID_DONNHAPHANG VARCHAR (15),							
	ID_SP VARCHAR (10),
	SOLUONG BIGINT,							-- Mặc định là đơn vị đóng gói
	CONSTRAINT PK_CTHDNH PRIMARY KEY (ID_SP,ID_DONNHAPHANG),
	CONSTRAINT FK_CTHDTNH FOREIGN KEY (ID_SP) REFERENCES Sanpham(ID_SP),
	CONSTRAINT FK_CTHDDNH FOREIGN KEY (ID_DONNHAPHANG) REFERENCES Donnhaphang(ID_DONNHAPHANG)
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Thanhly')
	DROP TABLE Thanhly
GO
CREATE TABLE Thanhly (
	ID_SPTL VARCHAR (10) UNIQUE,	--Auto
	ID_SP VARCHAR (10),
	GIATHANHLY MONEY,
	SL_THANHLY BIGINT,			--Tính theo quy cách đóng gói
	PRIMARY KEY (ID_SPTL, ID_SP),
	CONSTRAINT FK_TLSP FOREIGN KEY (ID_SP) REFERENCES Sanpham(ID_SP)
)

--Tiền vốn ban đầu của cửa hàng, 1 dòng duy nhất
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Ngansach')
	DROP TABLE Ngansach
GO
CREATE TABLE Ngansach (
	ID_NS VARCHAR (10) PRIMARY KEY,		
	TIEN_NS MONEY,   
	NGAY_CAPNHATNS SMALLDATETIME DEFAULT GETDATE(),  
	ID_NV VARCHAR(10) NOT NULL,
	DOANHTHU MONEY,							--Doanh thu sau mỗi năm
	LOINHUAN MONEY,							--Số dương: lời, âm: lỗ
	CONSTRAINT FK_NS FOREIGN KEY (ID_NV) REFERENCES Nhanvien(IDNV)
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Doanhthungay')
	DROP TABLE Doanhthungay
GO
CREATE TABLE Doanhthungay (
	ID_DTN DATE PRIMARY KEY DEFAULT GETDATE(),
	TONGDOANHTHU_OFF MONEY NOT NULL,				-- Hóa đơn online sẽ tự động cộng trong bảng vận chuyển
	SOLUONG_DONMUAHANG BIGINT NOT NULL,			-- Cộng trong hoadonxuathang count	
	TIENHANG MONEY NOT NULL	
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Doanhthuthang')
	DROP TABLE Doanhthuthang
GO
CREATE TABLE Doanhthuthang (				--Có thể in và in ra biểu đồ: Ngày 2	8 hàng tháng sẽ tổng kết
	ID_DTT DATE PRIMARY KEY DEFAULT GETDATE(),
	TONGHOADON_OFF MONEY NOT NULL,	--Tự động tính bằng cách chạy trong bảng Doanhthungay
	TONGHOADON_ONL MONEY NOT NULL,	--Tính trong bảng vận chuyển
	TONGDOANHTHU MONEY,				-- Tự động tính		

	TIENHANG_DABAN MONEY,			-- Tiền hàng gốc của những hàng hóa được xuất kho
	TONGTIENVANCHUYEN MONEY,		-- Tiền vận chuyển, tiền vận chuyển nhập hàng
	TIENNHAPHANG MONEY,				-- Nhập hàng thành công sẽ cập nhật
	TIEN_CHIPHI MONEY,

	LOINHUAN MONEY,					-- Tổng doanh thu trừ đi
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Doanhthunam')
	DROP TABLE Doanhthunam
GO
CREATE TABLE Doanhthunam (
	ID_DTT VARCHAR (10) PRIMARY KEY,
	TONGHOADON_OFF MONEY NOT NULL,
	TONGHOADON_ONL MONEY NOT NULL,
	TONGDOANHTHU MONEY,			-- Tự động tính		

	TIENHANG_DABAN MONEY,		-- Tiền hàng gốc của những hàng hóa được xuất kho
	TONGTIENVANCHUYEN MONEY,		-- Cộng hóa đơn sẽ tự động cập nhật
	TIENNHAPHANG MONEY,			-- Nhập hàng thành công sẽ cập nhật
	TIEN_CHIPHI MONEY,			-- Tiền lương, tiền mặt bằng
	LOINHUAN MONEY
)

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'Bangvanchuyen')
	DROP TABLE Bangvanchuyen
GO
CREATE TABLE Bangvanchuyen (
	MAVANDON VARCHAR (15) PRIMARY KEY,
	IDKH VARCHAR(10) NOT NULL,	

	TINHTRANGVANCHUYEN INTEGER,		--0 : thất bại (hàng trả về kho), 1 : thành công, 2: Thanh lý, 3: Nhập lại kho, 4: Bỏ hàng
	GHICHU NVARCHAR(MAX),
	TIENHANG MONEY,					-- Tiền phải thu = tổng tiền hàng + tiền vận chuyển
	TIENNHAN MONEY,					-- Tien thu được => doanh thu
	TIENVANCHUYEN MONEY,

	CONSTRAINT FK_BVC_KH FOREIGN KEY (IDKH) REFERENCES Khachhang(IDKH),
	CONSTRAINT FK_DXH_MVD FOREIGN KEY (MAVANDON) REFERENCES Donxuathang(ID_DONXUATHANG)
)

INSERT INTO Theloaisp VALUES 
	('TPCN',N'Thực phẩm chức năng'),
	('TVTM',N'Vitamin và khoáng chất'),
	('TKSM',N'Thuốc kháng sinh'),
	('TGDM',N'Thuốc giảm đau'),
	('TTDM',N'Thuốc dành cho người tiểu đường'),
	('TKVM',N'Thuốc kháng viêm'),
	('TDUM',N'Thuốc dị ứng'),
	('TTMM',N'Thuốc tim mạch'),
	('TBTM',N'Thuốc bao tử'),
	('VDCN',N'Đồ dùng cá nhân'),
	('DDTP',N'Thực phẩm')

INSERT INTO Sanpham VALUES
('SP00000001', N'Paracetamol', '2024-05-01', N'Việt Nam', N'Việt Nam Pharmaceutical Corporation', N'FDA', N'Giảm đau, hạ sốt', N'Không có phản ứng phụ đáng kể', N'Không sử dụng quá liều lượng', N'500 mg', N'Paracetamol 500mg', 1000, N'20 viên/hộp'),
('SP00000002', N'Ibuprofen', '2023-12-01', N'Úc', N'Johnson & Johnson', N'FDA', N'Giảm đau, kháng viêm', N'Đau dạ dày, buồn nôn, ói mửa', N'Không sử dụng cho trẻ em dưới 6 tuổi', N'400 mg', N'Ibuprofen 400mg', 500, N'30 viên/hộp'),
('SP00000003', N'Cetirizin', '2025-03-01', N'Pháp', N'Sanofi', N'FDA', N'Giảm triệu chứng dị ứng', N'Mệt mỏi, buồn ngủ', N'Tránh lái xe hoặc vận hành máy móc nguy hiểm', N'10 mg', N'Cetirizin dihydrochloride', 200, N'10 viên/vỉ'),
('SP00000004', N'Acetaminophen', '2024-11-30', N'USA', N'ABC Pharmaceutical', N'FDA', N'Giảm đau, hạ sốt', N'Buồn nôn, phát ban, dị ứng', N'Bảo quản ở nhiệt độ phòng, tránh xa ầm tay trẻ em', N'500mg', N'Acetaminophen 500mg', 10000, N'40 viên/hộp'),
('SP00000005', N'Amoxicillin', '2023-06-30', N'UK', N'DEF Pharmaceutical', N'FDA', N'Kháng viêm', N'Tiêu chảy, phát ban, dị ứng', N'Bảo quản ở nhiệt độ phòng, tránh xa tầm tay trẻ em', N'250mg', N'Amoxicillin 500mg', 9000, N'30 viên/hộp'),
('SP00000006', N'Aspirin', '2025-02-28', N'Germany', N'LMN Drug Company', N'FDA', N'Giảm đau, Làm loãng máu, Phòng ngừa đau tim', N'Buồn nôn, chảy máu dạ dày, dị ứng, ù tai', N'Bảo quản ở nhiệt độ phòng, tránh xa tầm tay trẻ em', N'250mg', N'Aspirin 81mg', 15000, N'50 viên/hộp'),
('SP00000007', N'Metformin', '2023-09-30', N'India', N'PQR Pharmaceutical', N'FDA', N'Tiểu đường tuýp 2', N'Buồn nôn, Tiêu chảy, Hạ đường huyết, Nhiễm axit lactic', N'Bảo quản ở nhiệt độ phòng, tránh xa tầm tay trẻ em', N'500mg', N'Metformin hydrochloride 500mg', 5000, N'20 viên/hộp'),
('SP00000008', N'Simvastatin', '2024-05-31', N'Canada', N'RST Pharmaceutical', N'FDA', N'Cholesterol cao, Phòng ngừa bệnh tim', N'Buồn nôn, Tiêu chảy, Đau cơ, Dị ứng', N'Bảo quản ở nhiệt độ phòng, tránh xa tầm tay trẻ em', N'20mg', N'Simvastatin 20mg', 7000, N'30 viên/hộp'),
('SP00000009', N'Omeprazole', '2023-12-31', N'USA', N'UVW Pharmaceutical', N'FDA', N'Bệnh trào ngược dạ dày thực quản, Loét dạ dày', N'Tiêu chảy, Buồn nôn, Nhức đầu, Phát ban', N'Bảo quản ở nhiệt độ phòng, tránh xa tầm tay trẻ em', N'20mg', N'Omeprazole 20mg', 8000, N'20 viên/hộp')

-- ID tự tăng: Đơn nhập hàng, đơn xuất hàng, doanh thu năm
GO
CREATE FUNCTION AUTO_DNH()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @id VARCHAR(15)
	IF (SELECT COUNT(ID_DONNHAPHANG) FROM Donnhaphang) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(ID_DONNHAPHANG, 5)) FROM Donnhaphang
		SELECT @id = CASE
			WHEN @id = 99999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DN00001'
			WHEN @id >= 0 and @id < 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DN0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DN000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 99 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DN00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DN0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DN' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO

CREATE FUNCTION AUTO_DXH()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @id VARCHAR(15)
	IF (SELECT COUNT(ID_DONXUATHANG) FROM Donxuathang) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(ID_DONXUATHANG, 5)) FROM Donxuathang
		SELECT @id = CASE
			WHEN @id = 99999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DX00001'
			WHEN @id >= 0 and @id < 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DX0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DX000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 99 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DX00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DX0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'DX' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO

CREATE FUNCTION AUTO_DTN()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @id VARCHAR(15)
	SELECT @id = CONVERT(VARCHAR,YEAR(GETDATE()),112)
	RETURN @id
END
GO

CREATE FUNCTION AUTO_IDSP()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	IF (SELECT COUNT(ID_SP) FROM Sanpham) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(ID_SP, 8)) FROM Sanpham
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'SP0000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'SP000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 THEN 'SP00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 THEN 'SP0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 THEN 'SP000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 THEN 'SP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999999 THEN 'SP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999999 THEN 'SP' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
------ Procedure --------
-- **** Đơn nhập hàng
CREATE PROC nhapHang 
(@MOTA_DONNHAPHANG NVARCHAR (MAX), @ID_NV VARCHAR(10),@ID_NVKT VARCHAR (10), @DONVIVANCHUYEN VARCHAR (100), @GIATRINHAPHANG MONEY, @TIENVANCHUYEN MONEY, @GHICHU NVARCHAR (MAX),
@ID_NH  VARCHAR(15) OUTPUT)
AS
BEGIN
	DECLARE @ID VARCHAR(15)
	SET @ID = dbo.AUTO_DNH()
	SELECT @ID_NH = @ID
	INSERT INTO Donnhaphang (ID_DONNHAPHANG, MOTA_DONNHAPHANG, ID_NV, ID_NVKT, DONVIVANCHUYEN, GIATRINHAPHANG, TIENVANCHUYEN,GHICHU) VALUES (@ID, @MOTA_DONNHAPHANG,@ID_NV,@ID_NVKT, @DONVIVANCHUYEN,@GIATRINHAPHANG,@TIENVANCHUYEN,@GHICHU)
END
GO
DECLARE @TMP VARCHAR(15)
EXEC nhapHang N'Nhập các mặt hàng thức ăn','NV000','NV000','ExpressLogistic', 10000000,2000000,N'Hàng dễ vỡ', @TMP OUTPUT
EXEC nhapHang N'Nhập thuốc kháng sinh','NV000','NV001','ExpressLogistic', 12500750,3200000,N'Hàng dễ vỡ',  @TMP OUTPUT
SELECT * FROM Donnhaphang
-- **** Đơn xuất hàng
GO

CREATE PROC xuatHang 
@HINHTHUC INT, @MOTA_DONXUATHANG NVARCHAR (MAX),@ID_NVLD VARCHAR(10), @ID_KH VARCHAR(10), @TONGGT_DH MONEY,
@ID_XH  VARCHAR(15) OUTPUT
AS
BEGIN
	DECLARE @ID VARCHAR(15)
	SET @ID = dbo.AUTO_DXH()
	SELECT @ID_XH = @ID
	INSERT INTO Donxuathang (ID_DONXUATHANG, HINHTHUC, MOTA_DONXUATHANG, ID_NVLD,ID_KH, TONGGT_DH) VALUES (@ID,@HINHTHUC, @MOTA_DONXUATHANG,@ID_NVLD,  @ID_KH,@TONGGT_DH)
END
GO


-- KHI NHẬP VAÒ THỰC HIỆN GỌI BIẾN
DECLARE @A VARCHAR(15)
EXEC xuatHang N'1',N'Kẹo kitkat','NV001',NULL, 12500750, @A OUTPUT
EXEC xuatHang N'0',N'Collagens 250mg','NV001','KH0001', 3000030, @A OUTPUT
PRINT @A

-- **** Trigger

-- **** Doanh thu ngày, doanh thu năm, doanh thu tháng !!!!!!!!!!!!!!!!!!!!!!!!
GO
--CREATE PROC tongDoanhThuNgay 
--AS
--BEGIN
--	DECLARE @COUNT_DM BIGINT, @DOANHTHU MONEY, @TIENHANG MONEY
--	SELECT @COUNT_DM = COUNT(*) FROM Donxuathang
--	SELECT @DOANHTHU = SUM(TONGGT_DH) FROM Donxuathang
--	INSERT INTO Doanhthungay (TONGDOANHTHU_OFF, SOLUONG_DONMUAHANG) VALUES (@DOANHTHU,@COUNT_DM)
--END
--GO


--CREATE tongDoanhThuThang 
--AS
--BEGIN
--	DECLARE @DOANHTHU_OFF MONEY, @DT_ONL MONEY
--	SELECT @DOANHTHU_OFF = SUM(TONGDOANHTHU_OFF) FROM Doanhthungay
--	SELECT @DT_ONL = SUM(TIENHAG)
--END
--GO

INSERT INTO Khachhang VALUES 
	('KH0001',N'Trần Thế Chiến',N'Nam','2023-12-12',N'Bình Định','0987654321','123/45',N'Thống Nhất',N'17',N'Tân Phú',N'Vũng Tảu')
/***** CREATE FUNCTION & PROCEDURE *****/
/***** Vi tri *****/
CREATE PROCEDURE INSERT_VT
(@ID VARCHAR(10), @TEN NVARCHAR(100))
AS
BEGIN
	INSERT INTO Vitri VALUES (@ID, @TEN)
END
GO

CREATE PROCEDURE UPDATE_VT
(@ID VARCHAR(10), @TEN NVARCHAR(100))
AS
BEGIN
	UPDATE Vitri SET TEN = @TEN WHERE ID = @ID 
END
GO

/***** Nhan vien *****/
/* Lay ra so dem ID */
CREATE FUNCTION LAST_ID()
RETURNS INT
AS
BEGIN
	DECLARE @COUNT INT
	SELECT @COUNT =  (SELECT COUNT(IDNV) FROM Nhanvien WHERE IDNV LIKE '%NV%')
	RETURN @COUNT
END

/* Lay ra ID */
CREATE FUNCTION GET_ID()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	RETURN  (SELECT TOP 1 IDNV FROM Nhanvien WHERE IDNV LIKE '%NV%' ORDER BY IDNV DESC)
END

/* Tu dong tang ID */	
																							/*mở rộng tài khoản nhân viên*/

CREATE FUNCTION AUTO_IDNV()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	DECLARE @NID VARCHAR(10)
	SET @ID = dbo.GET_ID()
	DECLARE @COUNT INT 
	SET @COUNT = dbo.LAST_ID()
	IF (@COUNT) = 0
		SET @NID = 'NV000'
	ELSE 
		SET @NID = CASE 
			WHEN @COUNT > 0 AND @COUNT < 9 THEN 'NV00' + CONVERT(CHAR, (CAST(SUBSTRING(@ID, LEN(@ID), 3) AS INT) + 1 ))
			WHEN @COUNT >= 9 THEN 'NV0' + CONVERT(CHAR, (CAST(SUBSTRING(@ID, LEN(@ID), 3) AS INT) + 1 ))
		END
	RETURN @NID		
END

/* Insert NV */
CREATE PROCEDURE INSERT_NV
(@HOTEN NVARCHAR(100), @GIOITINH NVARCHAR(7), @DOB DATETIME, 
 @QUEQUAN NVARCHAR(50), @SDT VARCHAR(12), @EMAIL VARCHAR(50), @IDVitri VARCHAR(10))
AS
BEGIN
	DECLARE @IDNV VARCHAR(10)
	SET @IDNV = dbo.AUTO_IDNV()
	INSERT INTO Nhanvien VALUES (@IDNV, @HOTEN , @GIOITINH , @DOB , 
								 @QUEQUAN, @SDT , @EMAIL , @IDVitri)
END
GO

/* Insert TK */
CREATE PROCEDURE INSERT_TK
(@TENDANGNHAP VARCHAR(50) , @MATKHAU VARCHAR(50), @QUYEN INT)
AS
BEGIN
DECLARE @ID VARCHAR(10)
	SET @ID = dbo.GET_ID()
	INSERT INTO Taikhoan VALUES (@ID, @TENDANGNHAP , @MATKHAU , @QUYEN)
END

/* Update NV */ 
CREATE PROCEDURE UPDATE_NV
(@IDNV VARCHAR(10), @HOTEN NVARCHAR(100), @GIOITINH NVARCHAR(7), @DOB DATETIME, 
 @QUEQUAN NVARCHAR(50), @SDT VARCHAR(12), @EMAIL VARCHAR(50), @IDVitri VARCHAR(10))
AS
BEGIN
	UPDATE Nhanvien SET 
	HOTEN = @HOTEN,
	GIOITINH = @GIOITINH, 
	DOB = @DOB, 
	QUEQUAN = @QUEQUAN,
	SDT = @SDT, 
	EMAIL = @EMAIL, 
	IDVitri = @IDVitri
	WHERE IDNV = @IDNV
END
GO

/* Update TKNV */
CREATE PROCEDURE UPDATE_TKNV
(@ID VARCHAR(10), @TENDANGNHAP VARCHAR(100) , @MATKHAU VARCHAR(50), @QUYEN INT)
AS
BEGIN
	UPDATE Taikhoan SET 
	TENDANGNHAP = @TENDANGNHAP,
	MATKHAU = @MATKHAU, 
	QUYEN = @QUYEN
	WHERE ID = @ID 
END


/***** INSERT *****/
/* Insert Vi tri */ 
INSERT INTO Vitri VALUES
('AD', N'Quản lý'), 
('BH', N'Nhân viên bán hàng'), 
('KHO', N'Nhân viên kho'), 
('TN', N'Nhân viên thu ngân')
/* Insert NV*/ 
INSERT INTO Nhanvien VALUES ('ADMIN', N'Phạm Huỳnh Anh Thư', N'Nữ', '07/03/2002', N'Đồng Tháp', '0946020824', 'phamthushame2002@gmail.com', 'AD')

/* Insert Account*/ 
INSERT INTO Taikhoan VALUES ('ADMIN', 'admin', '12345678', 2)
SELECT * FROM Taikhoan
EXEC INSERT_NV N'Nguyễn Ngọc Giàu', N'Nữ', '03/07/2003', N'Tiền Giang', '0946020123', 'ngocgiau@gmail.com', 'BH'
EXEC INSERT_NV N'Đỗ Nhựt Khả Vy', N'Nữ', '09/15/2003', N'Tiền Giang', '92783436612', 'khavy@gmail.com', 'TN'
EXEC INSERT_TK 'ngocgiau', '12345678', 1



/* DELETE FROM Customer WHERE ID = 'KH000' */
/* Drop
DROP FUNCTION [dbo].[LAST_ID]
DROP FUNCTION [dbo].[GET_ID]
DROP FUNCTION [dbo].[AUTO_IDNV] 
DROP PROCEDURE [dbo].[INSERT_NV]
DROP PROCEDURE [dbo].[INSERT_ACCOUNT]
DROP PROCEDURE [dbo].[UPDATE_NV]
DROP PROCEDURE [dbo].[UPATE_ACCOUNT]

DROP FUNCTION [dbo].[LAST_IDKH]
DROP FUNCTION [dbo].[AUTO_IDKH] 
DROP PROCEDURE [dbo].[INSERT_KH]
DROP PROCEDURE [dbo].[INSERT_ACCOUNTKH]
*/

/* 
DELETE FROM Employee WHERE ID_EMPLOYEE LIKE '%NV%'
DELETE FROM Account WHERE ID LIKE '%NV%'
*/

/*----------------------------------- TƯ VẤN KHÁCH HÀNG -------------------------------------------------*/

CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
)
ALTER TABLE Category ADD CONSTRAINT PK_C PRIMARY KEY(CategoryID) 
/***** INSERT *****/
INSERT INTO Category(CategoryName) VALUES ('Medical')
INSERT INTO Category(CategoryName) VALUES ('Pharmacy')

/*Lưu trữ thông tin về các câu hỏi*/
CREATE TABLE Question (
	QuestionID VARCHAR (15) PRIMARY KEY,
	QuestionContent NVARCHAR(MAX) NOT NULL DEFAULT '',
	IDKH VARCHAR (10),
	CreatedTime DATETIME NOT NULL DEFAULT(GETDATE()),
	BeAnswered INT DEFAULT 0,
	CategoryID INT NOT NULL,
	CONSTRAINT FK_KHQS FOREIGN KEY (IDKH) REFERENCES Khachhang(IDKH)
)
ALTER TABLE Question ADD CONSTRAINT FK_Q FOREIGN KEY(CategoryID) REFERENCES Category(CategoryID) 
/*Lưu trữ thông tin về các câu trả lời cho các câu hỏi*/
CREATE TABLE Answer (
    AnswerID VARCHAR (15) PRIMARY KEY,
    AnswerContent NVARCHAR(MAX) NOT NULL,
    QuestionID VARCHAR (15) NOT NULL,
	IDNV VARCHAR (10),
    AnsweredTime DATETIME NOT NULL DEFAULT(GETDATE()),
	CONSTRAINT FK_A FOREIGN KEY(QuestionID) REFERENCES Question(QuestionID),
)
ALTER TABLE Answer ADD	CONSTRAINT FK_NVA FOREIGN KEY(IDNV) REFERENCES Nhanvien(IDNV) 

/***********FUNCTION******************/

/*Kiểm tra xem một câu hỏi đã được trả lời hay chưa*/
GO
CREATE FUNCTION CheckAnswered(@questionID VARCHAR (15))
RETURNS BIT
AS
BEGIN
    DECLARE @result BIT
    IF EXISTS(SELECT * FROM Answer WHERE QuestionID = @questionID)
        SET @result = 1
    ELSE
        SET @result = 0
    RETURN @result
END
GO
/*Tự động cập nhật thông tin thời gian khi câu hỏi được thêm mới vào database*/
CREATE TRIGGER AddQuestionTrigger
ON Question
AFTER INSERT
AS
BEGIN
    UPDATE Question SET CreatedTime = GETDATE() WHERE QuestionID = (SELECT QuestionID FROM INSERTED)
END
GO
/*Tự động xóa các câu trả lời của câu hỏi khi câu hỏi bị xóa khỏi database*/
CREATE TRIGGER DeleteQuestionTrigger
ON Question
INSTEAD OF DELETE
AS
BEGIN
    DELETE FROM Answer WHERE QuestionID =  (SELECT QuestionID FROM DELETED)
    DELETE FROM Question WHERE QuestionID =  (SELECT QuestionID FROM DELETED)
END
GO



CREATE FUNCTION AUTO_IDQUESTION()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @id VARCHAR(15)
	IF (SELECT COUNT(QuestionID) FROM Question) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(QuestionID, 5)) FROM Question
		SELECT @id = CASE
			WHEN @id = 99999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'QT00001'
			WHEN @id >= 0 and @id < 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'QT0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'QT000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 99 THEN CONVERT(VARCHAR,GETDATE(),112) + 'QT00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'QT0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'QT' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO
CREATE FUNCTION AUTO_IDANS()
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @id VARCHAR(15)
	IF (SELECT COUNT(AnswerID) FROM Answer) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(AnswerID, 5)) FROM Answer
		SELECT @id = CASE
			WHEN @id = 99999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'AS00001'
			WHEN @id >= 0 and @id < 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'AS0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN CONVERT(VARCHAR,GETDATE(),112) + 'AS000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 99 THEN CONVERT(VARCHAR,GETDATE(),112) + 'AS00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'AS0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9999 THEN CONVERT(VARCHAR,GETDATE(),112) + 'AS' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO
CREATE PROC createQuestion @QuestionContent NVARCHAR(MAX), @IDKH VARCHAR (10), @CategoryID INT
AS
BEGIN
	DECLARE @id VARCHAR (15)
	SET @id = DBO.AUTO_IDQUESTION()
	INSERT INTO Question (QuestionID,QuestionContent,IDKH,CategoryID) VALUES (@id, @QuestionContent,@IDKH,@CategoryID)
END
GO

CREATE PROC createAns @AnswerContent NVARCHAR(MAX), @QuestionID VARCHAR (15), @IDNV VARCHAR (10)
AS
BEGIN
	DECLARE @id VARCHAR (15)
	SET @id = DBO.AUTO_IDANS()
	INSERT INTO Answer (AnswerID,AnswerContent,QuestionID,IDNV) VALUES (@id, @AnswerContent, @QuestionID,@IDNV)
	UPDATE Question SET BeAnswered = 1 WHERE QuestionID = @QuestionID
END
GO

CREATE PROC deleteAns @AnswerID VARCHAR (15)
AS
BEGIN
	DECLARE @QuestionID VARCHAR(15)
	SELECT @QuestionID = QuestionID FROM Answer WHERE AnswerID = @AnswerID
	DELETE FROM Answer WHERE AnswerID = @AnswerID
	IF(DBO.CheckAnswered(@QuestionID)=0)
	BEGIN
		UPDATE Question SET BeAnswered = 0 WHERE QuestionID = @QuestionID
	END
END
GO


/***** INSERT *****/

/*Insert vào bảng Question*/
EXEC createQuestion 'What are the symptoms of Covid-19?', 'KH0001', 1
EXEC createQuestion 'What is the difference between a tablet and a capsule?',  'KH0001',2
EXEC createQuestion 'How can I lower my blood pressure naturally?', 'KH0001', 1
EXEC createQuestion 'What are the side effects of taking antibiotics?',  'KH0001',2

/*Insert vào bảng Answer*/
EXEC createAns 'The symptoms of Covid-19 include fever, cough, and difficulty breathing.', '20230514QT00001', 'NV000'
EXEC createAns 'Tablets are solid forms of medication, while capsules are made up of gelatin shells filled with powder or liquid medication.', '20230514QT00002','NV000'
EXEC createAns 'There are many natural ways to lower blood pressure, including exercise, reducing sodium intake, and managing stress.','20230514QT00004', 'NV001'
EXEC createAns 'Để biết thêm chit iết vui lòng liên hệ vào số 1901287.','20230514QT00004', 'NV001'

/*Select các trigger và function*/
SELECT * FROM Question /*Kiểm tra trigger AddQuestionTrigger*/
SELECT * FROM Answer /*Kiểm tra trigger DeleteQuestionTrigger*/



