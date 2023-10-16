-- use master 
-- go
-- alter database [Ql_Billiard] set single_user with rollback immediate

-- drop database [Ql_Billiard]

create database Ql_Billiard
go

use Ql_Billiard
go

create table Account
(
	TaiKhoan varchar(20) primary key not null,
	MatKhau varchar(50) not null,
	IsAdmin bit
)

create table Ban
(
	MaBan char(3) primary key not null,
	TenBan nvarchar(20) not null,
	LoaiBan nvarchar(20) not null,
	Gia float,
    CONSTRAINT chk_Gia CHECK (Gia > 0)
)

CREATE TABLE ThucDon
(
    MaThucDon CHAR(5) PRIMARY KEY NOT NULL,
    TenThucDon NVARCHAR(50) NOT NULL,
    DonViTinh NVARCHAR(10) NOT NULL,
    SoLuong int NOT NULL,
    Gia FLOAT NOT NULL,
    GhiChu NVARCHAR(100),
    CONSTRAINT chk_GiaThucDon CHECK (Gia > 0),
    CONSTRAINT chk_SoLuong CHECK (SoLuong > 0)
)

CREATE TABLE HoaDon
(
    MaHoaDon int IDENTITY  PRIMARY KEY NOT NULL,
    MaBan CHAR(3) NOT NULL,
    GioBatDau DATETIME,
    GioKetThuc DATETIME,
    ThoiGianChoi INT NOT NULL,
    ThanhToan FLOAT NOT NULL,
    IsMember BIT, 
    TongTien FLOAT NOT NULL, 
    CONSTRAINT fk_hoadon_ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
    CONSTRAINT chk_GioChoi CHECK (ThoiGianChoi > 0),
    CONSTRAINT chk_GioKetThuc CHECK (GioBatDau < GioKetThuc),
    CONSTRAINT chk_TongTien CHECK (TongTien > 0)
)

create TABLE ChiTietHoaDon
(
    MaHoaDon int NOT NULL,
    MaThucDon CHAR(5) NOT NULL,
    CONSTRAINT pk_chitiethd PRIMARY KEY (MaHoaDon, MaThucDon),
    CONSTRAINT fk_chitiet_hd FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT fk_chitiet_td FOREIGN KEY (MaThucDon) REFERENCES ThucDon(MaThucDon)
)

CREATE TABLE KhachHang
(
    Id int IDENTITY PRIMARY KEY NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    Phone CHAR(10) NOT NULL CHECK (Phone LIKE '%[^0-9]%')
)

CREATE TABLE LichSuThanhToan
(
    Id int NOT NULL,
    MaHoaDon int NOT NULL,
    CONSTRAINT pk_LichSuTT PRIMARY KEY (Id,MaHoaDon),
    CONSTRAINT fk_LichSu_kh FOREIGN KEY (Id) REFERENCES KhachHang(Id),
    CONSTRAINT fk_LichSu_hd FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
)

CREATE TABLE DatTruoc
(
    Id int NOT NULL,
    MaBan CHAR(3) NOT NULL,
    CONSTRAINT pk_DatTruoc PRIMARY KEY (Id,MaBan),
    CONSTRAINT fk_DatTruoc_kh FOREIGN KEY (Id) REFERENCES KhachHang(Id),
    CONSTRAINT fk_DatTruoc_ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
)

CREATE TABLE LapHoaDon
(
    TaiKhoan VARCHAR(20) NOT NULL,
    MaHoaDon int NOT NULL,
    CONSTRAINT pk_LapHoaDon PRIMARY KEY (TaiKhoan, MaHoaDon),
    CONSTRAINT fk_LapHoaDon_acc FOREIGN KEY (TaiKhoan) REFERENCES Account(TaiKhoan),
    CONSTRAINT fk_LapHoaDon_hd FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
)
