create database QUANLIKHONGUYENLIEU
USE quanlikhonguyenlieu
create table NGUYENLIEU ( MANGUYENLIEU varchar(6) not null primary key, TENNGUYENLIEU varchar(30) not null, TENDONVI varchar(10) not null,
MADONVI varchar(6) not null )

create table NHAPKHO ( MANHAPKHO varchar(6) not null primary key, NGAYNHAPKHO date not null, SOLUONG int , 
MANGUYENLIEU varchar(6) not null) 

create table XUATKHO (MAXUATKHO varchar(6) not null primary key, NGAYXUATKHO date not null, SOLUONG int,
 MANGUYENLIEU varchar(6) not null)

create table BANGTONKHO ( MAPHIEUTONKHO varchar(6) not null primary key, SOLUONGHANGTONKHO int, MANGUYENLIEU varchar(6) not null,
LUONGTHIEUHUT int, KIEMTHUCONG int )

create table KHO ( MAKHO varchar(6) not null primary key, TENKHO varchar(30) not null,  MANGUYENLIEU varchar(6) not null, 
MAXUATKHO varchar(6) not null, MANHAPKHO varchar(6) not null, MAPHIEUTONKHO varchar(6) not null)

alter table KHO 
ADD CONSTRAINT FK_NGUYENLIEU FOREIGN KEY (MANGUYENLIEU) REFERENCES NGUYENLIEU (MANGUYENLIEU),
CONSTRAINT FK_NHAPKHO FOREIGN KEY (MANHAPKHO) REFERENCES NHAPKHO (MANHAPKHO),
CONSTRAINT FK_XUATKHO FOREIGN KEY (MAXUATKHO) REFERENCES XUATKHO (MAXUATKHO),
CONSTRAINT FK_BANGTONKHO FOREIGN KEY (MAPHIEUTONKHO) REFERENCES BANGTONKHO (MAPHIEUTONKHO)
--Q: TOP 5 S?N PH?M BÁN CH?Y NH?T
SELECT TOP 5* FROM XUATKHO
ORDER BY SOLUONG ASC
--Q2: TÍNH L??NG THI?U H?T
set LUONGTHIEUHUT = SOLUONGHANGTONKHO - KIEMTHUCONG
--Q3: 
