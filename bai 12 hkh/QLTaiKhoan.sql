use master
go

if (exists(select * from sys.databases where name = 'QLTaiKhoan')) drop database QLTaiKhoan
go

create database QLTaiKhoan
go 

use QLTaiKhoan
go

create table TaiKhoan (
	TenDangNhap varchar(128) primary key,
	MatKhau varchar(128)
)

create table HoaDon (
	SoHoaDon varchar(10) primary key,
	SDT varchar(13),
	HoTen nvarchar(50) not null, 
	NgayLap date,
	TenDangNhap varchar(128),
	constraint fk foreign key (TenDangNhap) references TaiKhoan
)

create table HangMua (
	MaHang varchar(10) primary key,
	TenHang nvarchar(128) not null,
	SoLuong int not null,
	DonGia money not null
)

insert into TaiKhoan values ('test', '123456'), ('test2', '123456')

select * from TaiKhoan
