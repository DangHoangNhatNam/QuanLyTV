CREATE DATABASE QuanLyThuVien
GO

USE QuanLyThuVien
GO

--Sach--
CREATE TABLE Sach
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL,
	tacgia nvarchar (100) NOT NULL,
	nxb nvarchar (100) NOT NULL,
	theloai nvarchar(100) NOT NULL,
	trangthai nvarchar (50) NOT NULL --con hay het--	
)
GO
--Account(NhanVien)--
CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL,
	pass nvarchar(100) NOT NULL
)
GO
--KhachThue--
CREATE TABLE KhachThue
(
	id INT PRIMARY KEY,
	name nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	gioitinh nvarchar (50) NOT NULL,
	diachi nvarchar(300) NOT NULL,
	sdt INT NOT NULL
)
GO
--HoaDon--
CREATE TABLE HoaDon
(
	id INT IDENTITY PRIMARY KEY,
	ngaythue date NOT NULL DEFAULT GETDATE(),
	ngaytra date NOT NULL,
	idKhachThue INT NOT NULL,
	trangthai nvarchar (50)NOT NULL DEFAULT N'Chưa thanh toán' -- thanh toan hay chua--
	
	FOREIGN KEY (idKhachThue) REFERENCES dbo.KhachThue(id)
)
GO
--ThongTinHoaDon--
CREATE TABLE ThongTinHoaDon
(
	id INT IDENTITY PRIMARY KEY,
	idHoaDon INT NOT NULL,
	idSach INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idSach) REFERENCES dbo.Sach(id),
	FOREIGN KEY (idHoaDon) REFERENCES dbo.HoaDon(id)
)
GO