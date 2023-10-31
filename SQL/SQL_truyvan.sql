USE QUAN_LY_BAN_HANG;
GO

select s.masanpham,s.tensanpham,l.tenloaihang,s.giaban
from sanpham s
inner join loaihang l on l.maloaihang=s.maloaihang

select MaSanPham,Anh from SANPHAM

select n.manhanvien,n.hoten,q.tenquyen,n.cccd,n.sodienthoai
,n.diachi,n.email,n.ngayvao
from nhanvien n, quyen q
where n.maquyen=q.maquyen

select s.masanpham,s.tensanpham,l.tenloaihang,SUM(pn.soluongnhap) soluong
from sanpham s 
inner join chitietphieunhap pn on s.masanpham=pn.masanpham
inner join loaihang l on l.maloaihang = s.maloaihang
group by s.masanpham,s.tensanpham,l.tenloaihang

select * from PHIEUNHAPKHO order by SoPhieuNhapKho desc

SELECT * FROM CHITIETPHIEUNHAP where masanpham = '1' order by sophieunhapkho

select k.masanpham,s.tensanpham,l.tenloaihang,k.soluong from kho k inner join sanpham s on s.masanpham = k.masanpham inner join loaihang l on l.maloaihang = s.maloaihang

select * from kho

update KHO set soluong = soluong+1 where masanpham = 1 ;

select k.masanpham,s.tensanpham,l.tenloaihang,k.soluong from kho k 
inner join sanpham s on s.masanpham = k.masanpham inner join loaihang l on l.maloaihang = s.maloaihang

select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien from donmua d
inner join khachhang k on d.makhachhang=k.makhachhang
inner join chitietdonmua c on c.madonmua=d.madonmua


