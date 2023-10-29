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
	HoTen nvarchar(50),
	SDT CHAR(10) NOT NULL CHECK (SDT LIKE '%[0-9]%'),
	TinhTrang nvarchar(50) check(TinhTrang in (N'Đang làm việc', N'Nghỉ việc')),
	QuanLy bit,
)

create table Ban
(
	MaBan char(4) primary key not null,
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
    MaBan CHAR(4) NOT NULL,
    GioBatDau DATETIME,
    GioKetThuc DATETIME,
    ThoiGianChoi INT,
    ThanhToan FLOAT,
    IsMember BIT, 
    TongTien FLOAT,
	TaiKhoan varchar(20),
    CONSTRAINT fk_hoadon_ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
	CONSTRAINT fk_hoadon_Account FOREIGN KEY (TaiKhoan) REFERENCES Account(TaiKhoan),
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
    Phone CHAR(10) PRIMARY KEY CHECK (Phone LIKE '%[0-9]%' and len(Phone) = 10),
    Ten NVARCHAR(50) NOT NULL
)

CREATE TABLE DatTruoc
(
	MaDatTruoc int identity not null,
    Phone CHAR(10) NOT NULL,
    MaBan char(4) NOT NULL,
    ThoiGianToi datetime not null, --nếu tới giờ thì hiện thông báo 
	NgayDat datetime not null,
	TrangThai int not null,
    CONSTRAINT pk_DatTruoc PRIMARY KEY (MaDatTruoc),
    CONSTRAINT fk_DatTruoc_kh FOREIGN KEY (Phone) REFERENCES KhachHang(Phone),
    CONSTRAINT fk_DatTruoc_ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
	CONSTRAINT chk_ThoiGianToi CHECK (ThoiGianToi <= DATEADD(hour, 3, GETDATE()) and ThoiGianToi >= GETDATE()),
	constraint chk_TrangThaiDatTruoc check (TrangThai >= 0 and TrangThai <= 2)
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

--Procedure nếu giờ tới mà khách chưa checkin thì set trạng thái bàn thành 2
GO
CREATE PROCEDURE [dbo].[TrangThaiBan]
AS
BEGIN

    SELECT
    DatTruoc.Phone,
    DatTruoc.MaBan,
    DatTruoc.ThoiGianToi,
    DatTruoc.TrangThai,
    Ban.TrangThai
	FROM
		DatTruoc
	INNER JOIN
		Ban
	ON
		DatTruoc.MaBan = Ban.MaBan
	WHERE
		DatTruoc.ThoiGianToi <= GETDATE()
	AND
		DatTruoc.TrangThai = 0

	IF @@ROWCOUNT > 0
	BEGIN
		-- Cập nhật trạng thái của bàn
		UPDATE
			Ban
		SET
			TrangThai = 2
		WHERE
			MaBan IN (
				SELECT
					DatTruoc.MaBan
				FROM
					DatTruoc
				WHERE
					DatTruoc.ThoiGianToi <= GETDATE()
				AND
					DatTruoc.TrangThai = 0
			)
		UPDATE
			DatTruoc
		SET
			TrangThai = 2
		WHERE
			MaBan IN (
				SELECT
					DatTruoc.MaBan
				FROM
					DatTruoc
				WHERE
					DatTruoc.ThoiGianToi <= GETDATE()
				AND
					DatTruoc.TrangThai = 0
			)
	END

END
go
exec dbo.TrangThaiBan
go
--Triger
-- update trạng thái bàn


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

--function tính tỉ lệ đặt bàn
go
CREATE FUNCTION dbo.TinhTyLeDatBan()
RETURNS TABLE
AS
RETURN
(
    SELECT DISTINCT LoaiBan, ROUND(1.0 * (SELECT COUNT(*) FROM HoaDon h, Ban b WHERE h.MaBan = b.MaBan AND bn.LoaiBan = b.LoaiBan) / (SELECT COUNT(*) FROM HoaDon), 2) AS TyLeDatBan
    FROM Ban bn
)
go
--Function tính doanh thu theo tháng
CREATE FUNCTION dbo.DoanhThuThang(@Thang INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @DoanhThu FLOAT;
    SELECT @DoanhThu = SUM(TongTien)
    FROM HoaDon
    WHERE MONTH(GioBatDau) = @Thang and YEAR(GioBatDau) = YEAR(GETDATE());
    RETURN @DoanhThu;
END;
go
--Function tính chi theo tháng
CREATE FUNCTION dbo.ChiThang(@Thang INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Chi FLOAT;
    SELECT @Chi = SUM(ThanhTien)
    FROM PhieuNhap
    WHERE MONTH(NgayNhap) = @Thang and YEAR(NgayNhap) = YEAR(GETDATE());
    RETURN @Chi;
END;
go
--function trả về doanh thu theo từng tháng
CREATE FUNCTION dbo.DoanhThu()
RETURNS TABLE
AS
RETURN (
    SELECT Thang, dbo.DoanhThuThang(Thang) AS DoanhThu
    FROM (
        VALUES (1), (2), (3), (4), (5), (6),
               (7), (8), (9), (10), (11), (12)
    ) AS Thang(Thang)
);
go
--function trả về chi theo tháng
CREATE FUNCTION dbo.Chi()
RETURNS TABLE
AS
RETURN (
    SELECT Thang, dbo.ChiThang(Thang) AS Chi
    FROM (
        VALUES (1), (2), (3), (4), (5), (6),
               (7), (8), (9), (10), (11), (12)
    ) AS Thang(Thang)
);
go
--Check

--Insert dữ liệu
--Account
INSERT INTO Account VALUES ('admin','14', N'Tấn', '0123456789', N'Đang làm việc', 1);
INSERT INTO Account VALUES ('user','14',  N'Tấn', '9876543210', N'Đang làm việc', 0);

--trigger đổi trạng thái bàn khi đặt trước
go
CREATE trigger trg_CapNhatTrangThaiDatTruoc on DatTruoc
after insert, update
as
begin
	if((select TrangThai from inserted) = 0) -- 0: mới đặt, 1: đã checkin, 2: bỏ
	begin
		update Ban
		set TrangThai = 3
		FROM Ban b
		INNER JOIN inserted i ON b.MaBan = i.MaBan
	end
	else if((select TrangThai from inserted) = 1)
	begin
		update Ban
		set TrangThai = 1, GioBatDau = getdate()
		FROM Ban b
		INNER JOIN inserted i ON b.MaBan = i.MaBan
	end
	else
	begin
		update Ban
		set TrangThai = 2, GioBatDau = null
		FROM Ban b
		INNER JOIN inserted i ON b.MaBan = i.MaBan
	end
end
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

                    + (select datediff(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0 * Gia
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

                        + (select datediff(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0 * Gia 
						   from HoaDon 
						   inner join Ban on HoaDon.MaBan = Ban.MaBan 
						   where HoaDon.MaHoaDon in (select MaHoaDon from inserted))
        where MaHoaDon in (select MaHoaDon from inserted)
    end
end;
Go

-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (Ten, Phone) VALUES (N'Nguyễn Văn A', '0123456789');
INSERT INTO KhachHang (Ten, Phone) VALUES (N'Lê An Tuyết', '0000000000');
INSERT INTO KhachHang (Ten, Phone) VALUES (N'Tấn Đẹp chai', '1111111111');

-- Thêm dữ liệu vào bảng Ban
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Lo01', N'Bàn Lỗ 1', N'Lỗ', 2, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Lo02', N'Bàn Lỗ 2', N'Lỗ', 2, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Lo03', N'Bàn Lỗ 3', N'Lỗ', 2, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Lo04', N'Bàn Lỗ 4', N'Lỗ', 2, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Li01', N'Bàn Lip 1', N'Lip', 2, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Li02', N'Bàn Lip 2', N'Lip', 2, 200000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Ca01', N'Bàn Carom 1', N'Carom', 2, 100000);
INSERT INTO Ban (MaBan, TenBan, LoaiBan, TrangThai, Gia) VALUES ('Ca02', N'Bàn Carom 2', N'Carom', 2, 100000);

-- Thêm dữ liệu vào bảng DatTruoc
INSERT INTO DatTruoc (Phone, MaBan, ThoiGianToi, TrangThai, NgayDat) VALUES ('1111111111', 'Lo01', dateadd(hour,2,getdate()), 0, GETDATE());
INSERT INTO DatTruoc (Phone, MaBan, ThoiGianToi, TrangThai, NgayDat) VALUES ('0000000000', 'Li02', dateadd(hour,2,getdate()), 0, GETDATE());

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaBan, GioBatDau, GioKetThuc, IsMember, TaiKhoan) VALUES ('Lo01', '2023-10-17T17:00:00', '2023-10-17T17:30:00', null, 'user');
INSERT INTO HoaDon (MaBan, GioBatDau, GioKetThuc, IsMember, TaiKhoan) VALUES ('Li02', '2023-10-17T18:00:00', '2023-10-17T19:30:00', null, 'user');

-- Thêm dữ liệu vào bảng ThucDon
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD01', N'Món 1', N'Đĩa', 10, 50000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD02', N'Món 2', N'Ly', 20, 30000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD03', N'Món 3', N'Nồi', 10, 50000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD04', N'Món 4', N'Bịch', 10, 20000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD05', N'Món 5', N'Chén', 10, 35000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD06', N'Món 6', N'Lon', 10, 15000);
INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia) VALUES ('TD07', N'Món 7', N'Két', 10, 100000);
-- Thêm dữ liệu vào bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD01', 2);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD03', 3);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (2, 'TD02', 3);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD02', 3);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD04', 3);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD05', 1);
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES (1, 'TD06', 3);








--------------------------------------------------------------------Thien
go
CREATE PROC USP_GetTableList
AS SELECT * FROM Ban
go

go
CREATE PROC USP_GetMenuList
AS SELECT * FROM ThucDon
go

---------------------------------------------------------------CỤC NÀY ALWAY NẰM DƯỚI CÙNG
exec dbo.TrangThaiBan

----------------Không để dòng lệnh nào dưới này-------------------
