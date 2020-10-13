create database QLVATLIEU
go
use QLVATLIEU
go
create table KHACHHANG
(
	MaKH nvarchar(10) primary key,
	TenKH nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(50),
	Sdt nvarchar(11),
	GioiTinh nvarchar(50)
)
create table NHACUNGCAP
(
	MaNCC nvarchar(10) primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	SoDT nvarchar(50),
	Email nvarchar(50)
)
create table NHANVIEN
(
	MaNV nvarchar(10) primary key,
	MatKhau nvarchar(50),
	quyentruycap nvarchar(50), 
	TenNV nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT nvarchar(50),
	gioitinh bit
)
create table HOADON
(
	MaKH nvarchar(10),
	MaNV nvarchar(10),
	ngayban date default GETDATE(),
	MaHH nvarchar(10),
	TenHH nvarchar(10),
	DonGia float,
	soluong int,
	ThanhTien float, 
	TinhTrang nvarchar(10)
)

create table HANGHOA
(
	MaHH nvarchar(10) primary key,
	TenHH nvarchar(50),
	MaNCC nvarchar(10),
	LoaiHang nvarchar(50),
	NhanHieu nvarchar(50),
	DonGia float default 0,
	DonGiaNhap float default 0,
	SoLuongcon int default 0,
	MoTa nvarchar(50)
)

create table GIOHANG
(
	STT int Identity primary key,
	MaHH nvarchar(10),
	MaNV nvarchar(10),
	TenHH nvarchar(50),
	SoLuong int,
	Thanhtien float,
)
go
create table nhaphang(
	STT int Identity primary key,
	MaNV nvarchar(10),
	ngaynhap date default GETDATE(),
	MaHH nvarchar(10),
	TenHH nvarchar(10),
	DonGia float,
	soluong int,
	ThanhTien float
)

go
--

alter table HOADON
add
foreign key (MAKH) references KHACHHANG(MAKH)
on delete cascade
on update cascade
go

alter table nhaphang
add
foreign key (MaNV) references NHANVIEN(MaNV)
on delete cascade
on update cascade
go
--
alter table HoaDon
add
foreign key (MaNV) references NHANVIEN(MaNV)
on delete cascade
on update cascade
go
--
alter table GIOHANG
add
foreign key (MaHH) references HANGHOA(MAHH)
on delete cascade
on update cascade
--
alter table GIOHANG
add
foreign key (MaNV) references NHANVIEN(MaNV)
on delete cascade
on update cascade
--

alter table HANGHOA
add
foreign key (MaNCC) references NHACUNGCAP(MaNCC)
on delete cascade
on update cascade




-- nhap du lieu 
-- du lieu bang nhan vien

insert into NHANVIEN(MaNV,MatKhau,TenNV,quyentruycap,NgaySinh,SDT,DiaChi,gioitinh) values('admin','123456',N'nguyễ văn thắng',N'admin','1995/02/16','01664561995','ha nội',1)
insert into NHANVIEN(MaNV,MatKhau,TenNV,quyentruycap,NgaySinh,SDT,DiaChi,gioitinh) values('admin1','123456',N'nguyễ văn thắng',N'admin','1995/02/16','01664561995','ha nội',0)
insert into NHANVIEN(MaNV,MatKhau,TenNV,quyentruycap,NgaySinh,SDT,DiaChi,gioitinh) values('admin2','123456',N'nguyễ văn thắng',N'admin','1995/02/16','01664561995','ha nội',1)
insert into NHANVIEN(MaNV,MatKhau,TenNV,quyentruycap,NgaySinh,SDT,DiaChi,gioitinh) values('admin3','123456',N'nguyễ văn thắng',N'admin','1995/02/16','01664561995','ha nội',1)

go

insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH1',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH2',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH3',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH4',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH5',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH6',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH7',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH8',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('KH9',N'Nguyễn văn thắng',N'Nam',N'thanh hóa','01664561995','1996/12/12')
go

insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,Email,SoDT) values('NCC1','sony1','thanh hoa','katothang@gmail.com','01664561995')
insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,Email,SoDT) values('NCC2','sony2','thanh hoa','katothang@gmail.com','01664561995')
insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,Email,SoDT) values('NCC3','sony3','thanh hoa','katothang@gmail.com','01664561995')
insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,Email,SoDT) values('NCC4','sony4','thanh hoa','katothang@gmail.com','01664561995')
insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,Email,SoDT) values('NCC5','sony5','thanh hoa','katothang@gmail.com','01664561995')
insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,Email,SoDT) values('NCC6','sony6','thanh hoa','wapegovit@gmail.com','01664561995')

go

insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH1','NCC1','ram','linh kien','sony','khong')
insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH2','NCC2','ram','linh kien','sony','khong')
insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH3','NCC3','ram','linh kien','sony','khong')
insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH4','NCC4','ram','linh kien','sony','khong')
insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH5','NCC5','ram','linh kien','sony','khong')
insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH6','NCC6','ram','linh kien','sony','khong')
insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,MoTa) values('HH8','NCC1','linh kien','linh kien','sony','khong')
go



select MaNV,TenNV,quyentruycap,NgaySinh,DiaChi,SDT from NHANVIEN

GO
create proc thongtinhoadon
@makh nvarchar(10)
as
select KHACHHANG.MaKH, TenKH,NgaySinh,DiaChi,Sdt,GioiTinh,MaNV,mahh,tenhh,soluong,ngayban,ThanhTien, TinhTrang from KHACHHANG join HOADON on KHACHHANG.MaKH = HOADON.MaKH where KHACHHANG.MaKH = @makh and DAY(ngayban) = DAY(GETDATE()) and MONTH(ngayban) = MONTH(GETDATE()) and YEAR(ngayban) = YEAR(GETDATE())



GO
create proc inthongtinhoadon
@makh nvarchar(10), @day date
as
select KHACHHANG.MaKH, TenKH,NgaySinh,DiaChi,Sdt,GioiTinh,MaNV,mahh,tenhh,soluong,ngayban,ThanhTien, TinhTrang from KHACHHANG join HOADON on KHACHHANG.MaKH = HOADON.MaKH where KHACHHANG.MaKH = @makh and DAY(ngayban) = DAY(@day) and MONTH(ngayban) = MONTH(@day) and YEAR(ngayban) = YEAR(@day)


exec thongtinhoadon '1234567'

select * from khachhang
