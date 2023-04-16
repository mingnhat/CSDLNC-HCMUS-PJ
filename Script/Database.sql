create database DB_DO_AN
go
use DB_DO_AN
go



create table NHANVIEN
(
	MaTK nvarchar(10),
	MaSoNhanVien nvarchar(10),
	HoTen nvarchar(50) NOT NULL, 
	EmailNV nvarchar(30) NOT NULL,
	SoDienThoaiNV int NOT NULL,
	DiaChiNhanVien nvarchar(50) NOT NULL,
	
	MaSoHopDong nvarchar(10),

	constraint PK_NHANVIEN 
	primary key(MaSoNhanVien)
)


create table HOPDONG
(
	MaSoHopDong nvarchar(10),
	
	MaSoThueDoiTac nvarchar(15)NOT NULL,
	SoChiNhanhDangKi int NOT NULL,
	DiaChiChiNhanh nvarchar(50) NOT NULL,
	SoTaiKhoan int NOT NULL,
	NganHang nvarchar(6) NOT NULL,
	ChiNhanhNganHang nvarchar(20) NOT NULL,
	PhiHoaHong decimal(10,2) NOT NULL,
	NgayLapHopDong date NOT NULL,
	NgayKetThuc date NOT NULL,
	ThoiGianHieuLuc int NOT NULL,
	DaDuyet int NOT NULL,

	MaSoDoiTac nvarchar(10),

	constraint PK_HOPDONG
	primary key (MaSoHopDong)

)




create table DOITAC
(
	MaTK nvarchar(10),
	MaSoDoiTac nvarchar(10),
	TenDoiTac nvarchar(50) NOT NULL,
	EmailDT nvarchar(30) NOT NULL,
	TenQuan nvarchar(25) NOT NULL,
	NguoiDaiDien nvarchar(10)NOT NULL,
	ThanhPho nvarchar(30)NOT NULL,
	Quan nvarchar(10) NOT NULL,
	SoLuongChiNhanh int NOT NULL,
	SoLuongDonHang int NOT NULL,
	LoaiAmThuc nvarchar(20) NOT NULL,
	DiaChiKinhDoanh nvarchar(50) NOT NULL,
	SoDienThoaiDT int NOT NULL, 
	

	constraint PK_DOITAC
	primary key (MaSoDoiTac)
)


create table CUAHANG
(
	MaSoCuaHang nvarchar(10) NOT NULL,
	ThoiGianMoCua time NOT NULL,
	ThoiGianDongCua time NOT NULL,
	TinhTrangCuaHang nvarchar(20) NOT NULL,
	
	MaSoDoiTac nvarchar(10),


	constraint PK_CUAHANG
	primary key(MaSoCuaHang)
)


create table KHACHHANG

(	
	MaTK nvarchar(10),
	MaSoKhachHang nvarchar(10),
	HoTenKhachHang nvarchar(50) NOT NULL,
	SoDienThoaiKH int NOT NULL, 
	DiaChiKH nvarchar(50) NOT NULL,
	EmailKH nvarchar(30) NOT NULL,


	constraint PK_KHACHHANG
	primary key(MaSoKhachHang)

)


create table DONHANG
(
	MaSoDonHang nvarchar(10),
	NgayDatHang nvarchar(10) NOT NULL,
	DiaChiGiaoHang nvarchar(50 )NOT NULL,
	SoDienThoaiKH int NOT NULL, 
	HinhThucThanhToan nvarchar(20) NOT NULL,
	PhiSanPham int NOT NULL, 
	PhiVanChuyen int NOT NULL,
	TrangThaiDonHang int NOT NULL,

	MaSoDoiTac nvarchar(10),
	MaSoMonAn  nvarchar(10),
	MaSoKhachHang nvarchar(10),
	MaSoTaiXe nvarchar(10),

	constraint PK_DONHANG
	primary key(MaSoDonHang)

)


create table CT_DONHANG
(
	MaSoDonHang nvarchar(10),
	MaSoMonAn nvarchar(10),
	SoLuongMon int NOT NULL,
	TongTien int NOT NULL,

	CONSTRAINT PK_CT_DONHANG
	PRIMARY KEY (MaSoDonHang, MaSoMonAn)
)

create table THUCDON
(
	MaSoMonAn nvarchar(10),
	TenMon nvarchar(20) NOT NULL,
	MieuTaMonAn nvarchar(30) NOT NULL,
	Gia int NOT NULL, 
	TinhTrangMonAn int NOT NULL, 
	TuyChonRieng int NOT NULL,
	SoLuong int NOT NULL,

	MaSoDoiTac nvarchar(10),

	constraint PK_THUCDON
	primary key(MaSoMonAn)


)

create table TAIXE
(
	MaTK nvarchar(10),
	MaSoTaiXe nvarchar(10),
	HoTenTaiXe nvarchar(50) NOT NULL,
	CMND int NOT NULL,
	SoDienThoaiTX int NOT NULL,
	BienSoXe nvarchar(9) NOT NULL,
	KhuVucHoatDong nvarchar(10) NOT NULL,
	EmailTX nvarchar(30) NOT NULL,
	TaiKHoanNganHang int NOT NULL

	constraint PK_TAIXE
	primary key(MaSoTaiXe)
)

CREATE TABLE XULY_DONHANG
(	
	MaSoDonHang nvarchar(10),
	MaSoTaiXe nvarchar(10),
	NgayTaiXeNhan DATE NOT NULL,
	NgayKhNhan DATE NOT NULL

	CONSTRAINT PK_XULI_DONHANG
	PRIMARY KEY (MaSoDonHang)
)

create table TAIKHOAN
(
	MaTK nvarchar(10),
	TenDangNhap nvarchar(30) NOT NULL,
	MatKhau nvarchar(30) NOT NULL, 
	LoaiTK int NOT NULL,

	constraint PK_TAIKHOAN
	primary key (MaTK)

)



alter table NHANVIEN
add	
	constraint FK_NHANVIEN_TAIKHOAN
	foreign key (MaTK) references TAIKHOAN(MaTK)

alter table KHACHHANG
add
	constraint FK_KHACHHANG_TAIKHOAN
	foreign key (MaTK) references TAIKHOAN(MaTK)

alter table TAIXE
add
	constraint FK_TAIXE_TAIKHOAN
	foreign key (MaTK) references TAIKHOAN(MaTK)

alter table DOITAC
add
	constraint FK_DOITAC_TAIKHOAN
	foreign key (MaTK) references TAIKHOAN(MaTK)


alter table NHANVIEN
add
	constraint FK_NHANVIEN_HOPDONG 
	foreign key (MaSoHopDong) references HOPDONG(MaSoHopDong)



alter table HOPDONG
add 
	constraint FK_HOPDONG_DOITAC 
	foreign key (MaSoDoiTac) references DOITAC(MaSoDoiTac)

alter table CUAHANG
add 
	constraint FK_CUAHANG_DOITAC
	foreign key (MaSoDoiTac) references DOITAC(MaSoDoiTac)

alter table THUCDON
add
	constraint FK_THUCDON_DOITAC
	foreign key(MaSoDoiTac) references DOITAC (MaSoDoiTac)

alter table DONHANG
add		
	constraint FK_DONHANG_DOITAC
	foreign key (MaSoDoiTac) references DOITAC(MaSoDoiTac)
alter table DONHANG
add	
	constraint FK_DONHANG_KHACHHANG
	foreign key (MaSoKhachHang) references KHACHHANG(MaSoKhachHang)

alter table CT_DONHANG
add
	constraint FK_CTDH_THUCDON
	foreign key (MaSoMonAn) references  THUCDON(MaSoMonAn),

	constraint FK_CTDH_DH
	foreign key(MaSoDonHang) references DONHANG(MaSoDonHang)

alter table XULY_DONHANG
add 
	constraint FK_XLDH_DH
	foreign key (MaSoDonHang) references DONHANG(MaSoDonHang),

	constraint FK_XLDH_TX
	foreign key(MaSoTaiXe) references TAIXE(MaSoTaiXe)
GO 

	
-- insert dữ liệu
INSERT INTO DOITAC(MaTK,MaSoDoiTac, TenDoiTac, NguoiDaiDien, ThanhPho, Quan, SoLuongChiNhanh, SoLuongDonHang,
LoaiAmThuc, DiaChiKinhDoanh, SoDienThoaiDT, EmailDT,TenQuan)
VALUES
	('DT001', 'DT001', N'Cơm tấm ba ghiền', N'Độ', N'Hà Nội', N'Yên Lãng', 3, 100, 'com tam', N'123 Yên Lãng, Tp. Hà Nội', 
	'0123456789', 'do@gmail.com','Do cơm tấm'),
	('DT111', 'DT111', N'Cơm gà nha trang', N'trang', N'Hồ Chí Minh', N'1', 100, 500, 'com ga', N'1 F1, Q1, Tp. HCM', 
	'0147852369', 'trang@gmail.com','cơm trang' ),
	('DT222', 'DT222', N'Cơm sườn', N'Đức', N'Nha Trang', N'1', 100, 500, 'Com sường', N'1 F1, Q1, Tp. HCM', 
	'0147852369', 'Duc@gmail.com','cơm sườn ngon')
GO

INSERT INTO HOPDONG(MaSoHopDong,NgayLapHopDong, SoChiNhanhDangKi, DiaChiChiNhanh, SoTaiKhoan, NganHang, ChiNhanhNganHang,PhiHoaHong,NgayKetThuc, ThoiGianHieuLuc,
MaSoDoiTac,MaSoThueDoiTac,DaDuyet)
VALUES
	('HD001','11/22/2008',1, N'123 Yên Lãng, Tp. Hà Nội','11111','acb','q5',20, '11/22/2020', 3, 'DT001','MST001',0),
	('HD111','11/22/2007',2, N'123 nguyen van cu, Tp.Hcm','22222','vcb','q1',22, '12/22/2020', 3, 'DT111','MST111',1),
	('HD222','11/22/2006',3, N'123 Yên Lãng, Tp. Hà Nội','11111','acb','q5',20, '11/22/2020', 3, 'DT001','MST222',1)
GO

INSERT INTO CUAHANG(MaSoCuaHang,MaSoDoiTac,ThoiGianMoCua,ThoiGianDongCua,TinhTrangCuaHang)
VALUES
	('CH001','DT001','8:00:00','10:00','Dang Mo'),
	('CH111','DT111','9:00:00','10:00','Dang tu sua')
GO



INSERT INTO THUCDON(MaSoMonAn, MaSoDoiTac, TenMon, MieuTaMonAn,Gia, TinhTrangMonAn,TuyChonRieng,SoLuong)
VALUES
	('MA001','DT001','Com Ga','lam tu ga',40000,1,1,1),
	('MA111','DT111','Com bo','lam tu bo',20000,1,2,1)
GO

INSERT INTO KHACHHANG(MaTK, MaSoKhachHang, HoTenKhachHang, SoDienThoaiKH, DiaChiKH, EmailKH)
VALUES
	('KH001','KH001',N'qthang', '0157482369','Q7, SG','qthang@gmail.com'),
	('KH111','KH111',N'giabao','0235698741','Hàng Mã, Hà Nội','giabao@gmail.com')
GO

INSERT INTO DONHANG(MaSoDonHang,MaSoDoiTac,MaSoKhachHang,DiaChiGiaoHang,SoDienThoaiKH,HinhThucThanhToan, PhiSanPham, PhiVanChuyen, TrangThaiDonHang
,MaSoMonAn,MaSoTaiXe,NgayDatHang)
VALUES
	('DH001','DT001','KH001',N'Trần Phú, F3, Tp.Đà Lạt','123456789',2,200000,40000,1,'MA001','TX001','2002-18-02'),
	('DH002','DT111','KH111',N'Nhà Chung, F3, Tp. Đà Lạt','234567890',1,30000,40000,0,'MA111','TX111','2002-18-02')
GO


INSERT INTO CT_DONHANG(MaSoDonHang, MaSoMonAn, SoLuongMon, TongTien)
VALUES
	('DH001','MA001',5,200000),
	('DH002','MA111',2,30000)
GO
select * from TAIXE

INSERT INTO TAIXE(MaTK,MaSoTaiXe,HoTenTaiXe,CMND,SoDienThoaiTX,BienSoXe,KhuVucHoatDong,EmailTX,TaiKHoanNganHang)
VALUES
	('TX001','TX001',N'qthangggg','251211111','0125478369','16F111638', N'Hải Phòng','qthang@gmail.com',001),
	('TX111','TX111',N'GiaBao','251222222','0245187369', '49B102868', N'Tp.Đà Lạt','giabao@gmail.com',111)
GO

INSERT INTO XULY_DONHANG(MaSoDonHang,MaSoTaiXe,NgayTaiXeNhan, NgayKhNhan)
VALUES
	('DH001','TX111','11/19/2021','11/20/2022')
GO

INSERT INTO NHANVIEN(MaTK, MaSoNhanVien, HoTen, EmailNV, SoDienThoaiNV, DiaChiNhanVien,MaSoHopDong)
VALUES 
	('NV001','NV001',N'trang','trang@gmail.com','0124853679',N'Tp.HCM','HD001'),
	('NV111','NV111',N'ngan','ngan@gmail.com','0123587496',N'Tp. Hà Nội','HD111' )
GO

INSERT INTO TAIKHOAN(MaTK, TenDangNhap, MatKhau, LoaiTK)
VALUES
	('DT001','abc','12345',1),
	('DT111','bcd','12345',1),
	('DT222','eee',12345,1),
	('NV001','bao','1',4),
	('NV111','conrua','12345',4),
	('KH001','him','12345',2),
	('KH111','her','12345',2),
	('TX001','eric','12345',3),
	('TX111','elly','12345',3),
	('AD001','shawn','12345',0),
	('AD111','mono','12345',0),
	('ACC222','naruto','12345',0)
GO


--create index

CREATE NONCLUSTERED INDEX IX_DonHang
ON dbo.DONHANG(NgayDatHang, DiaChiGiaoHang, SoDienThoaiKH, HinhThucThanhToan, PhiSanPham, PhiVanChuyen, TrangThaiDonHang)
GO









