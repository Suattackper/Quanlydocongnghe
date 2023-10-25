USE QUAN_LY_BAN_HANG;
GO

create proc sp_checkLogin(@sodienthoai nvarchar(50),@matkhau nvarchar(50),@maquyen int)
as 
begin
	select * from TAIKHOAN where SoDienThoai = @sodienthoai and MatKhau = @matkhau and MaQuyen = @maquyen;
end

execute sp_checkLogin 'admin','admin',1;
