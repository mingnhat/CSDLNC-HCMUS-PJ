-- store proceduce NHANVIEN

CREATE 
--alter
PROC SP_LayThongTinNV
	@TenDangNhap nvarchar(30),
	@MatKhau nvarchar(30)
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN		
	DECLARE @MaTK nvarchar(10)
	SET @MaTK= 'NULL'
	SET @MaTK = (SELECT TAIKHOAN.MaTK           
                FROM TAIKHOAN, NHANVIEN  
                WHERE TAIKHOAN.TENDANGNHAP = @TenDangNhap 
                AND TAIKHOAN.MATKHAU =   @MatKhau 
                AND TAIKHOAN.MaTK = NHANVIEN.MaTK)

	--kiểm tra tài khoản có tồn tại hay không
	IF (@MaTK = 'NULL')
	BEGIN
		PRINT N'Tài Khoản Không Tồn Tại'
		ROLLBACK TRAN
	
	END	

	-- xử lí lấy thông tin
	 SELECT TenDangNhap,  HoTen, DiaChiNhanVien, SoDienThoaiNV, EmailNV FROM TAIKHOAN, NHANVIEN 
	 WHERE TAIKHOAN.TenDangNhap =@TenDangNhap
	and	TAIKHOAN.MatKhau = @MatKhau
	and TAIKHOAN.MaTK = NHANVIEN.MaTK
               
	
	
		
	
COMMIT TRAN
GO



select * from TaiKhoan
create
--alter
proc SP_DOIMK
	@MaTK nvarchar(10),
	@MatKhau nvarchar(10)
as
begin tran
	if not exists (select * from TaiKhoan where MaTK = @MaTK)

	begin
		print N'Mã tài khoản không tồn tại'
		rollback tran
		return 
	end

	update TaiKhoan
	set MatKhau = @MatKhau
	where MaTK = @MaTK

	if @@ERROR = NULL
		print N'lỗi hệ thống'

commit tran



select * from NHANVIEN
create 
--alter
proc SP_DOITHONGTIN_NV
	@MaSoNhanVien nvarchar(10),
	@HoTen nvarchar(50),
	@EmailNV nvarchar(30),
	@SoDienThoaiNV char(10),
	@DiaChiNhanVien nvarchar(50)

as
begin tran
	if not exists (select * from NHANVIEN where MaSoNhanVien = @MaSoNhanVien)
	begin
		print N'Mã nhân viên không tồn tại'
		rollback tran
		return 
	end


	update NHANVIEN
	set HoTen = @HoTen ,
		EmailNV = @EmailNV,
		SoDienThoaiNV = @SoDienThoaiNV,
		DiaChiNhanVien = @DiaChiNhanVien
	where MaSoNhanVien = @MaSoNhanVien
commit tran


select * from HOPDONG
create
--alter
proc SP_DUYETHOPDONG
	@MaSoNhanVien nvarchar(10),
	@MaSoHopDong nvarchar(10),
	@NgayLapHopDong date,
	@NgayKetThuc date
as
	begin tran
	if not exists (select * from HOPDONG where MaSoHopDong = @MaSoHopDong )
	begin
		print N'Không có mã số hợp đồng'
	end


	if not exists (select * from NHANVIEN where MaSoNhanVien = @MaSoNhanVien)
	begin
		print N'Không có mã số nhân viên'
	end

	declare @DaDuyet int	
	set @DaDuyet = (select DaDuyet from HOPDONG where MaSoHopDong = @MaSoHopDong)
	if @DaDuyet != 0
	begin 
		print N'Hợp đồng đã được duyệt'
		rollback tran
		return
	end

	set @DaDuyet =1
	update HOPDONG
	set DaDuyet =1 , NgayLapHopDong = @NgayLapHopDong, NgayKetThuc = @NgayKetThuc
	where MaSoHopDong = @MaSoHopDong

commit tran



create 
--alter 
proc SP_LOAIHOPDONG
	@MaSoHopDong nvarchar(10),
	@MaSoNhanVien nvarchar(10)

as
begin tran
	if not exists (select * from HOPDONG where MaSoHopDong = @MaSoHopDong)
	begin
		print N'Không có mã số hợp đồng'
		rollback tran
		return
	end

	if not exists (select * from NHANVIEN where MaSoNhanVien = @MaSoNhanVien)
	begin
		print N'Không có mã số nhân viên'
		rollback tran
		return
	end

	declare @DaDuyet int
	set @DaDuyet = (select DaDuyet  from HOPDONG where MaSoHopDong = @MaSoHopDong)
	if @DaDuyet != 0
	begin
		print N'Hợp Đồng đã được xử lý'
		rollback tran
		return
	end


	set @DaDuyet =2
	update HOPDONG
	set DaDuyet=2 
	where MaSoHopDong = @MaSoHopDong
commit tran

USE [DB_DO_AN]
GO
/****** Object:  StoredProcedure [dbo].[SP_KHMUASP]    Script Date: 12/24/2022 5:24:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER 
--ALTER
PROC [dbo].[SP_KHMUASP]
	@MaSoMonAn nvarchar(10),
	@soluong INT
AS
	DECLARE @SOLUONGTON INT = (SELECT SoLuong
							FROM THUCDON 
							WHERE MaSoMonAn = @MaSoMonAn)
	IF (@SOLUONGTON >= @SOLUONG)
	BEGIN
		SET @SOLUONGTON = @SOLUONGTON - @SOLUONG
	END
		ELSE
	BEGIN
		PRINT N'SỐ LƯỢNG SẢN PHẨM CÒN LẠI KHÔNG ĐỦ'
		RETURN 0;
	END
	
	BEGIN
		UPDATE THUCDON
		SET SOLUONG = @SOLUONGTON
		WHERE MaSoMonAn = @MaSoMonAn
		
	END
GO

--Dang Nhap
CREATE PROC SP_DANGNHAP
	@TenDangNhap NVARCHAR(30),
	@MatKhau NVARCHAR(30),
	@MaTK NVARCHAR(10) OUTPUT,
	@LoaiTK INT OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT MaTK
				FROM TAIKHOAN 
				WHERE TenDangNhap = @TENDANGNHAP 
				AND MatKhau = @MatKhau)
	BEGIN
		PRINT N'Sai tên đăng nhập hoặc mật khẩu'
		RETURN 0
	END
	
	-- lấy mã tài khoản
	SET @MaTK = (SELECT MaTK
				FROM TAIKHOAN
				WHERE TenDangNhap = @TenDangNhap
				AND MatKhau = @MatKhau)

	-- lấy loại tài khoản
	SET @LoaiTK = (SELECT LoaiTK
				FROM TAIKHOAN
				WHERE TenDangNhap = @TenDangNhap
				AND MatKhau = @MatKhau)

	-- xử lí đăng nhập thành công
	IF (@MaTK != 'NULL')
	BEGIN
		PRINT N'Đăng nhập thành công'
		RETURN 1
	END
	ELSE RETURN 0	
END
GO














