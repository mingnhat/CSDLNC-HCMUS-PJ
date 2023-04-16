EXEC sp_addlogin 'DB_DO_AN_KHACHHANG', '12345', 'DB_DO_AN';  
GO

CREATE USER KHACHHANG FOR LOGIN DB_DO_AN_KHACHHANG
GO

select * from KHACHHANG
GRANT SELECT, INSERT, UPDATE ON KHACHHANG TO KHACHHANG
GRANT SELECT ON DOITAC(MaSoDoiTac,TenDoiTac,DiaChiKinhDoanh,SoLuongChiNhanh,LoaiAmThuc,SoDienThoaiDT) TO KHACHHANG
GRANT SELECT ON THUCDON TO KHACHHANG
GRANT SELECT, INSERT ON DONHANG TO KHACHHANG
GRANT SELECT, INSERT ON CT_DONHANG TO KHACHHANG
GRANT SELECT ON XULY_DONHANG TO KHACHHANG
GRANT SELECT ON CUAHANG TO KHACHHANG
GRANT SELECT ON TAIXE(HoTenTaiXe,SoDienThoaiTX) TO KHACHHANG



GRANT EXECUTE ON OBJECT::SP_KHMUASP TO KHACHHANG



EXEC   sp_addlogin 'DB_DO_AN_TAIXE', '12345', 'DB_DO_AN';  
GO

CREATE USER TAIXE FOR LOGIN DB_DO_AN_TAIXE
GO

GRANT SELECT, INSERT ON TAIXE TO TAIXE
GRANT SELECT ON DONHANG TO TAIXE
GRANT SELECT ON CT_DONHANG TO TAIXE
GRANT SELECT ON KHACHHANG(MaSoKhachHang,HoTenKhachHang,SoDienThoaiKH) TO TAIXE
GRANT SELECT,UPDATE ON XULY_DONHANG TO TAIXE
GRANT UPDATE ON XULY_DONHANG(MaSoTaiXe,NgayTaiXeNhan,NgayKhNhan) TO TAIXE
GO



EXEC sp_addlogin 'DB_DO_AN_NHANVIEN', '12345', 'DB_DO_AN';  
GO

CREATE USER NHANVIEN FOR LOGIN DB_DO_AN_NHANVIEN
GO

GRANT SELECT, INSERT ON NHANVIEN TO NHANVIEN 
GRANT SELECT ON DOITAC TO NHANVIEN 
GRANT SELECT ON HOPDONG TO NHANVIEN 
GRANT UPDATE ON HOPDONG(DaDuyet,NgayLapHopDong,NgayKetThuc) TO NHANVIEN 
GRANT SELECT ON TAIKHOAN(MaTK, TenDangNhap, MatKhau) TO NHANVIEN
GRANT UPDATE ON TaiKhoan(MatKhau) TO NHANVIEN
GRANT SELECT ON NHANVIEN(MaTK) TO NHANVIEN
GRANT SELECT, UPDATE ON NHANVIEN(HoTen, SoDienThoaiNV, DiaChiNhanVien, EmailNV) TO NHANVIEN
GO

EXEC sp_addlogin 'DB_DO_AN_ADMIN', 'admin', 'DB_DO_AN';  
GO

EXEC sp_addsrvrolemember 'DB_DO_AN_ADMIN', 'sysadmin';  
GO

EXEC sp_addlogin 'DB_DO_AN_DOITAC', '123456', 'DB_DO_AN';  
GO

CREATE USER DOITAC FOR LOGIN DB_DO_AN_DOITAC
GO

EXEC sp_addlogin 'DB_DO_AN_NGUOILA', '12345', 'DB_DO_AN';  
GO

CREATE USER NGUOILA FOR LOGIN DB_DO_AN_NGUOILA
GO

GRANT SELECT, INSERT ON TAIKHOAN TO NGUOILA 
GO

GRANT EXECUTE ON OBJECT::SP_DANGNHAP TO NGUOILA

EXEC sp_addlogin 'DB_DO_AN_DOITAC', '12345', 'DB_DO_AN';  
GO

CREATE USER DOITAC FOR LOGIN DB_DO_AN_DOITAC
GO

GRANT SELECT, INSERT, UPDATE ON DOITAC TO DOITAC
GRANT SELECT, INSERT ON HOPDONG TO DOITAC
GRANT SELECT, INSERT, UPDATE, DELETE ON SANPHAM TO DOITAC
GRANT SELECT ON DONHANG TO DOITAC
GRANT SELECT ON CT_DONHANG TO DOITAC
GRANT UPDATE ON DONHANG(TrangThaiDonHang) TO DOITAC
GRANT SELECT ON XULY_DONHANG TO DOITAC
GRANT SELECT ON TAIXE(HoTenTaiXe, SoDienThoaiTX) TO DOITAC
GRANT SELECT, INSERT, UPDATE,DELETE ON CUAHANG TO DOITAC
GRANT SELECT ON KHACHHANG(HoTenKhachHang, SoDienThoaiKH) TO DOITAC
GO






