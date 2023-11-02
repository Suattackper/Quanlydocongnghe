USE QUAN_LY_BAN_HANG;
GO

create or alter proc sp_checkLogin(@sodienthoai nvarchar(50),@matkhau nvarchar(50),@maquyen int)
as 
begin
	select * from TAIKHOAN where SoDienThoai = @sodienthoai and MatKhau = @matkhau and MaQuyen = @maquyen;
end

execute sp_checkLogin 'admin','admin',1;



create or alter proc sp_getTongDoanhThu
as
begin
	select sum(tongtien) tong from donmua
end
go
exec sp_getTongDoanhThu

create or alter proc sp_getTongKhachHang
as
begin
	select count(makhachhang) tongkh from khachhang
end
go
exec sp_getTongKhachHang

create or alter proc sp_getTongSanPham
as
begin
	SELECT SUM(tong_soluong) AS tong_tat_ca
	FROM (
		SELECT SUM(soluong) AS tong_soluong FROM chitietdonmua
		UNION ALL -- hợp 2 bảng thảnh 1
		SELECT SUM(soluong) AS tong_soluong FROM chitietphieuxuat
	) AS combined_data; --AS combined_data tạo bảng tạm thời để truy vấn
end
go
exec sp_getTongSanPham
