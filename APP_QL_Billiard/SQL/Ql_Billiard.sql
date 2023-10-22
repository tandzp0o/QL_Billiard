 --use master 
 --go
 --alter database [Ql_Billiard] set single_user with rollback immediate

 --drop database [Ql_Billiard]

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
	TenBan nvarchar(20)  null,
	LoaiBan nvarchar(20)  null,
    TrangThai int  null,
	Gia float,
    GioBatDau DATETIME,
    GioKetThuc DATETIME,

    CONSTRAINT chk_Gia CHECK (Gia > 0),
    constraint chk_TrangThai check(TrangThai >0 and TrangThai <4)
)

CREATE TABLE ThucDon
(
    MaThucDon CHAR(5) PRIMARY KEY NOT NULL,
    TenThucDon NVARCHAR(50) NOT NULL,
    DonViTinh NVARCHAR(10) NOT NULL,
    SoLuong int NOT NULL default 0,
    Gia FLOAT NOT NULL,
    Hinh nvarchar(max), 
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
    ThoiGianChoi INT,
    ThanhToan FLOAT,
    IsMember BIT, 
    TongTien FLOAT,
    CONSTRAINT fk_hoadon_ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
    CONSTRAINT chk_GioChoi CHECK (ThoiGianChoi > 0),
    CONSTRAINT chk_GioKetThuc CHECK (GioBatDau < GioKetThuc),
    CONSTRAINT chk_TongTien CHECK (TongTien > 0)
)

create TABLE ChiTietHoaDon
(
    MaHoaDon int NOT NULL,
    MaThucDon CHAR(5) NOT NULL,
    SoLuongDat int not null,
    CONSTRAINT pk_chitiethd PRIMARY KEY (MaHoaDon, MaThucDon),
    CONSTRAINT fk_chitiet_hd FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT fk_chitiet_td FOREIGN KEY (MaThucDon) REFERENCES ThucDon(MaThucDon)
)

CREATE TABLE KhachHang
(
    Id int IDENTITY PRIMARY KEY NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    Phone CHAR(10) NOT NULL CHECK (Phone LIKE '%[0-9]%')
)

CREATE TABLE DatTruoc
(
    Id int NOT NULL,
    MaBan CHAR(3) NOT NULL,
    ThoiGianToi time not null, --nếu tới giờ thì hiện thông báo 
	NgayDat datetime not null,
    CONSTRAINT pk_DatTruoc PRIMARY KEY (Id,MaBan),
    CONSTRAINT fk_DatTruoc_kh FOREIGN KEY (Id) REFERENCES KhachHang(Id),
    CONSTRAINT fk_DatTruoc_ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
)

CREATE TABLE LapHoaDon
(
    TaiKhoan VARCHAR(20) NOT NULL,
    MaHoaDon int NOT NULL,
    CONSTRAINT pk_LapHoaDon PRIMARY KEY (TaiKhoan, MaHoaDon),
    CONSTRAINT fk_LapHoaDon_acc FOREIGN KEY (TaiKhoan) REFERENCES Account(TaiKhoan),
    CONSTRAINT fk_LapHoaDon_hd FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
)

CREATE TABLE PhieuNhap
(
	MaPN INT IDENTITY not null primary key,
	NgayNhap date not null,
	ThanhTien float
)

CREATE TABLE ChiTietPhieuNhap
(
	MaPN INT not null,
	MaThucDon CHAR(5) NOT NULL,
	SoLuong int,
	DonGia float,
	TongTien float,
	constraint PK_CTPN primary key (MaPN,MaThucDon),
	constraint FK_CTPN_PN foreign key (MaPN) references PhieuNhap(MaPN),
	constraint FK_CTPN_TD foreign key (MaThucDon) references ThucDon(MaThucDon)
)

--Triger

--Chuyển bàn và thanh toán thành công sst bàn = 2

--Khi thêm thực đơn vào bill thì giảm số lượng trong thực đơn

--số lượng đặt trong thực đơn <= số lượng tồn kho trong thực đơn

--PhieuNhap(ThanhTien) = Sum(ChiTietPhieuNhap(TongTien))
go
CREATE TRIGGER trg_TinhThanhTien
ON ChiTietPhieuNhap
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE PhieuNhap
    SET ThanhTien = (SELECT SUM(TongTien) FROM ChiTietPhieuNhap WHERE MaPN = inserted.MaPN)
    FROM PhieuNhap
    INNER JOIN inserted ON PhieuNhap.MaPN = inserted.MaPN
END
--ChiTietPhieuNhap(TongTien) = ChiTietPhieuNhap(SoLuong) * ChiTietPhieuNhap(DonGia)
go
CREATE trigger trg_TinhTongTien on ChiTietPhieuNhap
after insert
as
begin
	update ChiTietPhieuNhap
	set TongTien = i.SoLuong * i.DonGia
	FROM ChiTietPhieuNhap ctpn
    INNER JOIN inserted i ON ctpn.MaPN = i.MaPN and ctpn.MaThucDon = i.MaThucDon
end
--Tự động tăng số lượng khong thực đơn khi thêm chi tiết hoá đơn
go
CREATE TRIGGER update_so_luong
ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
    UPDATE ThucDon
    SET SoLuong = ThucDon.SoLuong + inserted.SoLuong
    FROM ThucDon
    INNER JOIN inserted ON ThucDon.MaThucDon = inserted.MaThucDon;
END;
go
--Check

--Insert dữ liệu
--Account
INSERT INTO Account VALUES ('admin','14',1)
INSERT INTO Account VALUES ('user','14',0)

----------------------------------------------------------------------Trần Thành Luân----------------------------------------------------------------------
--Trigger tính thời gian chơi(ThoiGianChoi) trong bảng hoá đơn(HoaDon)
Go
Create trigger trg_CapNhatThoiGianChoi on HoaDon
for insert, update
as
begin
    update HoaDon
    set ThoiGianChoi = datediff(minute, GioBatDau, GioKetThuc)
    where MaHoaDon in (select MaHoaDon from inserted)
end;
Go

--Trigger tính thanh toán(Thành tiền) trong bảng hoá đơn(HoaDon) 
Go
Create trigger trg_CapNhatThanhToan on ChiTietHoaDon
for insert, update
as
begin
    update HoaDon
    set ThanhToan = (select sum(SoLuongDat * Gia)
					 from ChiTietHoaDon 
					 inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
					 where ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon)

                    + (select datediff(minute, GioBatDau, GioKetThuc) / 60.0 * Gia
					   from HoaDon
					   inner join Ban on HoaDon.MaBan = Ban.MaBan
					   where HoaDon.MaHoaDon in (select MaHoaDon from inserted))
    where MaHoaDon in (select MaHoaDon from inserted)
end;
Go

--Trigger tính tổng tiền(TongTien) trong bảng hoá đơn(HoaDon)
Go
Create trigger trg_CapNhatTongTien on HoaDon
for insert, update
as
begin
    if update(ThanhToan)
    begin
        update HoaDon
        set TongTien = case 
            when IsMember is null then ThanhToan 
            when IsMember = 0 then ThanhToan * 0.8 
            when IsMember = 1 then ThanhToan * 0.75 
            end 
        where MaHoaDon in (select MaHoaDon from inserted)
    end
end;
Go

--Trigger tính tổng tiền(TongTien) sau khi thay đổi giá trị IsMember trong bảng hoá đơn(HoaDon)
Go
Create trigger trg_CapNhatTTKhiThayDoiMember on HoaDon
for insert, update
as
begin
    if update(IsMember)
    begin
        update HoaDon
        set ThanhToan = (select sum(SoLuongDat * Gia) 
		                 from ChiTietHoaDon 
						 inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon 
						 where ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon)

                        + (select datediff(minute, GioBatDau, GioKetThuc) / 60.0 * Gia 
						   from HoaDon 
						   inner join Ban on HoaDon.MaBan = Ban.MaBan 
						   where HoaDon.MaHoaDon in (select MaHoaDon from inserted))
        where MaHoaDon in (select MaHoaDon from inserted)
    end
end;
Go
-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (Ten, Phone) VALUES (N'Nguyen Van A', '0123456789');
INSERT INTO KhachHang (Ten, Phone) VALUES (N'Tran Thi B', '0987654321');

-- Thêm dữ liệu vào bảng Ban 
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('A01', N'Ban 1', N'Lỗ', 3, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('A02', N'Ban 2', N'Lip', 2, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('B01', N'Ban 3', N'Lỗ', 1, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('B02', N'Ban 4', N'Lip', 3, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('C01', N'Ban 5', N'Carom', 1, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('C02', N'Ban 6', N'Lỗ', 2, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('D01', N'Ban 7', N'Carom', 1, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('D02', N'Ban 8', N'Lỗ', 3, 200000);

-- Thêm dữ liệu vào bảng DatTruoc
INSERT INTO DatTruoc (Id, MaBan, NgayDat, ThoiGianToi) VALUES (1, 'B01', '2023-10-17T17:00:00', '18:00:00');
INSERT INTO DatTruoc (Id, MaBan, NgayDat, ThoiGianToi) VALUES (2, 'B02', '2023-10-17T17:00:00', '19:00:00');

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaBan, GioBatDau, GioKetThuc, IsMember) VALUES ('B01', '2023-10-17T17:00:00', '2023-10-17T18:00:00', null);
INSERT INTO HoaDon (MaBan, GioBatDau, GioKetThuc, IsMember) VALUES ('B02', '2023-10-17T18:30:00', '2023-10-17T19:30:00', null);

-- Thêm dữ liệu vào bảng ThucDon
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD01', N'Mon 1', 'Dia', 10, 50000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD02', N'Mon 2', 'Ly', 20, 30000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD03', N'Mon 3', 'Noi', 10, 50000);

-- Thêm dữ liệu vào bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD01', 2);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD03', 3);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (2, 'TD02', 3);







--------------------------------------------------------------------Thien
go
CREATE PROC USP_GetTableList
AS SELECT * FROM Ban
Go

EXECUTE USP_GetTableList