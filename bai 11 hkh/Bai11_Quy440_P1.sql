use master
go
if (exists (select * from sys.databases where name = 'QLBanHang')) drop database QLBanHang
go

create database QLBanHang
go

use QLBanHang
go

create table KhachHang (
	MaKH char(4) Primary key,
	TenKH nvarchar(50),
	SoDT nvarchar(12),
	DiaChi nvarchar(50)
)

create table NguoiDung (
	TenDangNhap varchar(10) primary key,
	MatKhau varchar(10),
	HoTen nvarchar(50)
)

create table HoaDon (
	MaHD char(4) not null Primary Key,
	NgayLap date,
	MaKH char(4),
	constraint fkKH Foreign key (MaKH) references KhachHang,
	NguoiLap nvarchar(50),
)

create table LoaiSanPham ( 
	MaLoai char(3) primary key,
	TenLoai nvarchar(50) not null
)

create table SanPham(
	MaSP char(4) primary key,
	TenSP nvarchar(50) not null,
	MaLoai char(3),
	constraint fkl foreign key (MaLoai) references LoaiSanPham,
	SoLuong int,
	DonGia int
)

create table HoaDonChiTiet(
	MaHD char(4),
	MaSP char(4),
	constraint pk Primary key (MaHD, MaSP),
	constraint fk1 Foreign key (MaHD) references HoaDon,
	constraint fk2 Foreign Key (MaSP) references SanPham,
	SoLuongMua int
)

insert into KhachHang values ('kh01', N'Dương Minh Quân', '093849394', N'Hà Nội'),
							 ('kh02', N'Lã Huỳnh Đức', '0284938493', N'Hải DƯơng'),
							 ('kh03', N'Trần Trọng Khải', '0843848399', N'Hà Nội')

insert into NguoiDung values ('tendn1', 'matkhau1', N'Dương Minh Quân'),
                             ('tendn2', 'matkhau2', N'Lã Huỳnh Đức'),
							 ('tendn3', 'matkhau3', N'Trần Trọng Khải')

insert into LoaiSanPham values ('l01', N'Samsung'),
							   ('l02', N'Iphone'),
							   ('l03', N'Xiaomi')

insert into HoaDon values ('hd01', '2022-02-02', 'kh01', 'Duong'),
                          ('hd02', '2022-02-01', 'kh02', 'Duong'),
						  ('hd03', '2022-02-03', 'kh03', 'Duong')

insert into SanPham values ('sp01', N'SamSung z fold 5', 'l01', 10, 10000000),
						   ('sp02', N'Iphone 15', 'l02', 1, 12000000),
						   ('sp03', N'Xiaomi 10', 'l03', 2, 20000000)

insert into HoaDonChiTiet values ('hd01', 'sp01', 10),
								 ('hd02', 'sp02', 20),
								 ('hd03', 'sp03', 99)

