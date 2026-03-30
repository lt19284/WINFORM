----------------------CREATE_DB---------1:06PM 27/03/26----------------------------
Create database QLCF
go
Use QLCF
go
----------------------CREATE_TABLE-----1:06PM 27/03/26----------------------------
CREATE TABLE Ban
(
	id INT IDENTITY PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL DEFAULT N'Bàn Chưa Có Tên',
	TrangThai Nvarchar(100) NOT NULL DEFAULT N'Trống'
	
)
GO

CREATE TABLE TaiKhoan
(
	TenNguoiDung NVARCHAR(100) NOT NULL DEFAULT N'Lâm Trí Thức',
	TenDangNhap NVARCHAR(100) PRIMARY KEY, --- KEY
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTaiKhoan INT NOT NULL DEFAULT 0 -- 1 admin : 0 Staff
)
GO

CREATE TABLE DanhSachMon
(
	id INT IDENTITY PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt Tên'
)
GO

CREATE TABLE Mon
(
	id INT IDENTITY PRIMARY KEY,
	TenMon NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt Tên',
	idDanhSachMon INT NOT NULL,
	Gia FLOAT NOT NULL

	FOREIGN KEY (idDanhSachMon) REFERENCES dbo.DanhSachMon(id) -- idDanhSachMon Trỏ Tới dbo.DanhSachMon
)
GO

CREATE TABLE HoaDon
(
	id INT IDENTITY PRIMARY KEY,
	CheckIn DATE NOT NULL DEFAULT GETDATE(),
	CheckOut DATE,
	idBan INT NOT NULL,
	TrangThai INT NOT NULL DEFAULT 0, -- Trang Thai Thanh Toan hoac Chua Thanh Toan

	FOREIGN KEY (idBan) REFERENCES dbo.Ban(id) -- idBan Trỏ Tới dbo.Ban
)
GO

CREATE TABLE ThongTinHoaDon 
(
	id INT IDENTITY PRIMARY KEY,
	idHoaDon INT NOT NULL,
	idMon INT NOT NULL,
	SoLuong INT NOT NULL DEFAULT 0

	FOREIGN KEY (idHoaDon) REFERENCES dbo.HoaDon(id),-- idHoaDon Trỏ Tới dbo.HoaDon
	FOREIGN KEY (idMon) REFERENCES dbo.Mon(id), -- idMon Trỏ Tới dbo.Mon

)

-------------------------11:15 30/03/26----------------------------------------------
	
INSERT INTO dbo.TaiKhoan(
	TenDangNhap, TenNguoiDung, MatKhau, LoaiTaiKhoan
)
VALUES (
	N'admin', --Username -Nvarchar(100)
	N'admin', --DisplayName(100)
	N'admin', --Password -nvarchar(100)
	1 --type
)

INSERT INTO dbo.TaiKhoan(
	TenDangNhap, TenNguoiDung, MatKhau, LoaiTaiKhoan
)
VALUES (
	N'staff', --Username -Nvarchar(100)
	N'staff', --DisplayName(100)
	N'staff', --Password -nvarchar(100)
	0 --type
)