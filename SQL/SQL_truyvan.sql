USE QUAN_LY_BAN_HANG;
GO

select s.masanpham,s.tensanpham,l.tenloaihang,s.giaban
from sanpham s
inner join loaihang l on l.maloaihang=s.maloaihang

select MaSanPham,Anh from SANPHAM