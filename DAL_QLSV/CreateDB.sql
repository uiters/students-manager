/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/



USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QuanLySinhVien')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QuanLySinhVien') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QuanLySinhVien]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QuanLySinhVien]
GO

USE [QuanLySinhVien]
GO



----------------------SUMMARY----------------------------
--tables
--Sinh viên
--Điểm
--ĐKMH
--Môn học
--Lớp
--Ngành
--Khoa
--Giáo viên
-- User
----------------------------------------------------------

-- dạng ngày/tháng/năm--
set dateformat dmy

-- Sinh Viên --
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create table SinhVien
(

MaSinhVien varchar(50) primary key,
HoTen nvarchar(150) not null,
QueQuan nvarchar(350) not null,
NgaySinh smalldatetime not null,
NoiSinh nvarchar(400) not null,
GioiTinh nvarchar(5) not null,
Hinh nvarchar(150) not null,

MaLop varchar(50),
MaNganh varchar(50),
)
go

USE [QuanLySinhVien]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--Điểm--
create table Diem
(
MaMonHoc varchar(50)  ,
MaSinhVien varchar(50) ,
SoDiem float  null,
Lanthi int  null,

primary key (MaMonHoc,MaSinhVien),

)
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--ĐKMH
create table DKMH
(
MaSinhVien varchar(50),
MaMonHoc varchar(50),

primary key (MaSinhVien,MaMonHoc)
)
go

--Môn Học--
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table MonHoc
(
MaMonHoc varchar(50) primary key,
TenMonHoc nvarchar(50) not null,
LoaiMonHoc bit , --1:bắt buộc hay 0:tự chọn
TinChiLyThuyet int null,
TinChiThucHanh int null,

MaKhoa varchar(50),
)
GO

--Lớp--
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table Lop
(
MaLop varchar(50) primary key,
TenLop nvarchar(50) not null,
LoaiLop bit, --1:lớp clc hay 0:lớp đt
NienKhoa varchar(50) not null,
NgayBatDau smalldatetime not null,
NgayKetThuc smalldatetime null,

MaMonHoc varchar(50),
MaGiaoVien varchar(50)

)
go
--Học--
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table Hoc
(
MaSinhVien varchar(50),
MaLop varchar(50),

primary key (MaSinhVien,MaLop)
)
-- Ngành --
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Nganh
(
MaNganh varchar(50) primary key,
TenNganh nvarchar(50) not null,
GhiChu nvarchar(500) ,

MaKhoa varchar(50),
)
go

--Khoa--
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table Khoa
(
MaKhoa varchar(50) primary key,
TenKhoa nvarchar(50) not null,
GhiChu varchar(500),

Username nvarchar(50) null

)
GO

--Giáo Viên--
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table GiaoVien
(
MaGiaoVien varchar(50) primary key,
TenGiaoVien nvarchar(50) not null,
GhiChu nvarchar(500),

MaKhoa varchar(50),

)
go


-- tài khoản người dùng, user--
USE [QuanLySinhVien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table tb_User 
(
Usertype bit not null, --1:admin hay 0:user
Username nvarchar(50) primary key,
Pass nvarchar(50)
)
go
USE [QuanLySinhVien]
GO


-- khoá ngoại điểm
alter table Diem add constraint FK_Diem_MonHoc foreign key (MaMonHoc) references MonHoc(MaMonHoc) 
alter table Diem add constraint FK_Diem_SinhVien foreign key (MaSinhVien) references SinhVien(MaSinhVien) 
--khoá ngoại ĐKMH
alter table DKMH add constraint FK_DKMH_MH foreign key (MaMonHoc) references MonHoc(MaMonHoc) 
alter table DKMH add constraint FK_DKMH_SV foreign key (MaSinhVien) references SinhVien(MaSinhVien) 
--khoá ngoại giáo viên
alter table GiaoVien add constraint FK_GV_Khoa foreign key (MaKhoa) references Khoa(MaKhoa) ON DELETE SET NULL
-- khoá ngoại Lớp
alter table Lop add constraint Fk_Lop_MonHoc foreign key (MaMonHoc) references MonHoc(MaMonHoc) ON DELETE SET NULL
alter table Lop add constraint FK_Lop_GiaoVien foreign key (MaGiaoVien) references GiaoVien(MaGiaoVien) ON DELETE SET NULL
-- Khóa ngoại Học
alter table Hoc add constraint FK_Hoc_Lop foreign key (MaLop) references Lop(MaLop) --ON DELETE SET NULL
alter table Hoc add constraint FK_Hoc_SinhVien foreign key (MaSinhVien) references SinhVien(MaSinhVien)-- ON DELETE SET NULL
--khoá ngoại Môn Học
alter table MonHoc add constraint FK_MonHoc_Khoa foreign key (MaKhoa) references Khoa(MaKhoa) ON DELETE SET NULL
--Khoá ngoại SinhVien
alter table SinhVien add constraint FK_SV_Nganh foreign key(MaNganh) references Nganh(MaNganh) ON DELETE SET NULL
 alter table sinhvien add constraint FK_SV_Lop foreign key(Malop) references Lop(MaLop) ON DELETE SET NULL
---Khóa ngoại Ngành
alter table Nganh add constraint FK_Nganh_Khoa foreign key(MaKhoa) references Khoa(MaKhoa) ON DELETE SET NULL
--Khóa ngoại user
alter table tb_User add constraint FK_User foreign key (Username) references tb_User(Username)-- ON DELETE SET NULL
--khóa ngoại Khoa
alter table Khoa add constraint FK_User_Khoa foreign key (Username) references tb_User(Username) ON DELETE SET NULL
go



USE [QuanLySinhVien]
GO

--tài khoản--
insert into tb_User (Usertype,Username,Pass) values(1,'admin','GaKFQUS2Oo92F6byJQGbEg==')
insert into tb_User (Usertype,Username,Pass) values (0,'user','nOS1h58/y1qYQlR76+GR4Q==')



--Khoa--
USE [QuanLySinhVien]
GO
insert into Khoa (MaKhoa,TenKhoa,GhiChu,Username) values ('KA0000000',N'Công nghệ thông tin','CNTT','admin')
insert into Khoa (MaKhoa,TenKhoa,GhiChu,Username) values ('KA0000001',N'Công nghệ phần mềm','CNPM',null)
insert into Khoa (MaKhoa,TenKhoa,GhiChu,Username) values ('KA0000002',N'Kỹ thuật máy tính','KTMT',null)
insert into Khoa (MaKhoa,TenKhoa,GhiChu,Username) values ('KA0000003',N'Truyền thông và mạng máy tính','TT&MTT',null)
insert into Khoa (MaKhoa,TenKhoa,GhiChu,Username) values ('KA0000004',N'Khoa học máy tính','KHMT',null)



--Giáo viên--
USE [QuanLySinhVien]
GO
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000000',N'Trần Thị Nụ','','KA0000000')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000001',N'Hồ Đá Lớn','','KA0000000')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000002',N'Nguyễn Công Hoan','','KA0000001')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000003',N'Nguyễn Tuấn Nam','','KA0000001')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000004',N'Nguyễn Thị Thanh Trúc','','KA0000001')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000005',N'Trần Đại Dương','','KA0000002')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000006',N'Trần Thị Hoa','','KA0000002')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000007',N'Đoàn Duy','','KA0000002')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000008',N'Nguyễn Hữu Lượng','','KA0000002')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000009',N'Đoàn Hiển','','KA0000002')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000010',N'Nguyễn Thanh Bình','','KA0000003')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000011',N'Xyân Hùng','','KA0000003')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000012',N'Nguyễn Hồ Duy Trí','','KA0000003')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000013',N'Hồ Đá Bé','','KA0000004')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000014',N'Hồ Thị Liễu','','KA0000004')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000015',N'Hồ Quang Hiếu','','KA0000004')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000016',N'Minh Hằng','','KA0000004')
insert into GiaoVien (MaGiaoVien,TenGiaoVien,GhiChu,MaKhoa) values ('GV0000017',N'Trang Cao','','KA0000004')


--Ngành--
USE [QuanLySinhVien]
GO
insert into Nganh (MaNganh,TenNganh,GhiChu,MaKhoa) values ('NG0000000',N'Công nghệ thông tin','','KA0000000')
insert into Nganh (MaNganh,TenNganh,GhiChu,MaKhoa) values ('NG0000001',N'Kỹ thuật phần mềm','','KA0000001')
insert into Nganh (MaNganh,TenNganh,GhiChu,MaKhoa) values ('NG0000002',N'An toàn thông tin','','KA0000003')
insert into Nganh (MaNganh,TenNganh,GhiChu,MaKhoa) values ('NG0000003',N'Kỹ thuật máy tính','','KA0000002')
insert into Nganh (MaNganh,TenNganh,GhiChu,MaKhoa) values ('NG0000004',N'Hệ thống thông tin','','KA0000003')
insert into Nganh (MaNganh,TenNganh,GhiChu,MaKhoa) values ('NG0000005',N'Khoa học máy tính','','KA0000004')


--MônHọc--
USE [QuanLySinhVien]
GO
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000000',N'Phương pháp mô hình hóa',1,4,0,'KA0000001')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000001',N'Đặc tả hình thức',1,4,0,'KA0000001')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000002',N'Đồ án 1',1,2,0,'KA0000001')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000003',N'Đồ án 2',1,2,0,'KA0000001')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000004',N'Công nghệ phần mềm chuyên sâu',1,3,1,'KA0000001')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000005',N'Công nghệ phần mềm',1,3,1,'KA0000001')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000006',N'Giải tích',1,4,0,'KA0000000')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000007',N'Nhập môn mạch số',1,4,0,'KA0000000')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000008',N'Giáo dục thể chất',1,4,0,'KA0000000')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000009',N'Anh văn',1,4,0,'KA0000000')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000010',N'Tin học',0,4,0,'KA0000000')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000012',N'Thiêt kế luận lý số',0,4,0,'KA0000002')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000011',N'Thiết kế vi mạch số',0,2,0,'KA0000003')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000013',N'Thiết kế hệ thống nhúng',0,4,0,'KA0000002')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000014',N'Lập trình hệ thống',0,4,0,'KA0000003')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000015',N'Đồ Họa máy tính',1,4,0,'KA0000002')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000016',N'Trí tuệ nhân tạo',1,4,0,'KA0000003')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000017',N'Biểu diễn thi trức và suy luận',1,2,2,'KA0000002')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000018',N'Mạng nerual và giải phẫu di truyền',1,2,2,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000019',N'Nhận dạng',1,4,0,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000020',N'Xây dựng các HTTT trên framework',0,4,0,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000021',N'Khai thác dữ liệu',0,3,0,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000022',N'Phân tích dữ liệu kinh doanh',0,4,0,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000023',N'Hệ điều hành',1,3,1,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000024',N'Giới thiệu ngành',0,2,0,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000025',N'Nhập môn lập trình',1,3,1,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000026',N'Hướng đối tượng',1,2,2,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000027',N'Cấu trúc dữ liệu và giải thuật',1,2,2,'KA0000004')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000028',N'Cấu trúc rời rạc',1,3,0,'KA0000002')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000029',N'Truyền dữ liệu',0,3,1,'KA0000003')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000030',N'Lập trình mạng căn bản',0,4,0,'KA0000000')
insert into MonHoc (MaMonHoc,TenMonHoc,LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) values('MH0000031',N'Truyền dữ liệu',0,4,0,'KA0000003')




--Lớp--
USE [QuanLySinhVien]
GO
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000000','e21',0,'2017','08/08/2017','05/05/2018','MH0000000','GV0000002')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000001','e21',0,'2017','08/08/2017','05/05/2018','MH0000001','GV0000002')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000002','e22',0,'2018','08/08/2018','05/05/2019','MH0000002','GV0000001')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000003','e23',0,'2018','08/08/2018','05/05/2019','MH0000003','GV0000001')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000004','e24',0,'2018','08/08/2018','05/05/2019','MH0000004','GV0000003')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000005','e25',0,'2018','08/08/2018','05/05/2019','MH0000005','GV0000004')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000006','e26',0,'2018','08/08/2018','05/05/2019','MH0000006','GV0000005')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000007','e27',0,'2018','08/08/2018','05/05/2019','MH0000007','GV0000006')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000008','e28',0,'2018','08/08/2018','05/05/2019','MH0000008','GV0000007')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000009','e29',0,'2018','08/08/2018','05/05/2019','MH0000009','GV0000008')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000010','e30',0,'2019','08/08/2019','05/05/2020','MH0000010','GV0000009')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000011','e31',0,'2019','08/08/2019','05/05/2020','MH0000011','GV0000010')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000012','e22',0,'2019','08/08/2019','05/05/2020','MH0000011','GV0000011')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000013','e32',0,'2019','08/08/2019','05/05/2020','MH0000000','GV0000012')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000014','e32',0,'2019','08/08/2019','05/05/2020','MH0000009','GV0000012')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000015','e24',0,'2019','08/08/2019','05/05/2020','MH0000008','GV0000002')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000016','e25',0,'2019','08/08/2019','05/05/2020','MH0000007','GV0000013')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000017','e31',0,'2019','08/08/2019','05/05/2020','MH0000006','GV0000014')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000018','e33',0,'2017','08/08/2017','05/05/2018','MH0000005','GV0000015')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000019','e32',0,'2017','08/08/2017','05/05/2018','MH0000004','GV0000017')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000020','e24',0,'2017','08/08/2017','05/05/2018','MH0000003','GV0000017')
insert into Lop (MaLop,TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) values ('LP0000021','e34',0,'2017','08/08/2017','05/05/2018','MH0000001','GV0000006')


--SinhViên--
USE [QuanLySinhVien]
GO


insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000000',N'Tung Bay Lắc',N'Hầm Bom','20/09/2000',N'Hầm Bom',N'Nam','','LP0000013','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000001',N'Đặng Tuấn Anh',N'Đồng Nai','20/08/2000',N'Hầm Bom',N'Nam','','LP0000013','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000002',N'Hoàng Đức Anh',N'Vườn Xoài','20/07/2000',N'Hầm Bom',N'Nam','','LP0000013','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000003',N'Lưu Trang Anh',N'Biên Hòa','20/10/2000',N'Hầm Bom',N'Nam','','LP0000012','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000004',N'Phạm Hoàng Anh',N'Nha Trang','20/06/2000',N'Hầm Bom',N'Nam','','LP0000012','NG0000002')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000005',N'Phạm Thị Hiền Anh',N'Vũng Tàu','20/05/2000',N'Hầm Bom',N'Nam','','LP0000012','NG0000002')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000006',N'Phạm Khắc Việt Anh',N'Hầm Nội','20/04/2000',N'Hầm Bom',N'Nam','','LP0000011','NG0000002')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000007',N'Tung Thị Bình',N'Hà Nội','20/03/2000',N'Hầm Bom',N'Nam','','LP0000011','NG0000002')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000008',N'Trần An Dương',N'Nội Bài','20/02/2000',N'Hầm Bom',N'Nam','','LP0000011','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000009',N'Nguyễn Bình Đương',N'Tân Sơn Nhất','20/01/2000',N'Hầm Bom',N'Nam','','LP0000011','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000010',N'Mạc Trung Đức',N'Tân Bình','20/010/2000',N'Hầm Bom',N'Nam','','LP0000010','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000011',N'Vũ Hương Giang',N'Bình Thạnh','21/09/2000',N'Hầm Bom',N'Nam','','LP0000010','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000012',N'Nguyễn Thị Ngân Hà',N'Tân Sơn Nhì','20/09/2000',N'Hầm Bom',N'Nam','','LP0000010','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000013',N'Phạm Xuân Hòa',N'Long An','22/09/2000',N'Hầm Bom',N'Nam','','LP0000002','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000014',N'Tần Hoàng',N'Long Xuyên','23/05/2000',N'Hầm Bom',N'Nam','','LP0000009','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000015',N'Phạm Hưng',N'Sài Gòn','21/02/2000',N'Hầm Bom',N'Nam','','LP0000009','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000016',N'Tống Lắc',N'Hà Nội','22/06/2000',N'Hầm Bom',N'Nam','','LP0000009','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000017',N'T Loan',N'Hà Tây','26/01/2000',N'Hầm Bom',N'Nam','','LP0000009','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000018',N'Đỗ Phạm Liễu',N'Biên Hòa','21/04/2000',N'Hầm Bom',N'Nam','','LP0000008','NG0000000')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000019',N'Nguyễn Công Thành',N'Đồng Bom','12/04/2000',N'Hầm Bom',N'Nam','','LP0000008','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000020',N'Bùi Phương Thảo',N'Đồng Nai','25/09/2000',N'Hầm Bom',N'Nam','','LP0000008','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000021',N'Nguyễn Hương Thảo',N'Sài Gòn','11/09/2000',N'Hầm Bom',N'Nữ','','LP0000007','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000022',N'Tô Diệu Thảo',N'Trung Bom','01/09/2000',N'Hầm Bom',N'Nữ','','LP0000007','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000023',N'Vũ Phương Thảo',N'Hầm Đồng','02/09/2000',N'Hầm Bom',N'Nữ','','LP0000007','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000024',N'Vũ Phương Thảo',N'Campu','20/05/2000',N'Hầm Bom',N'Nữ','','LP0000004','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000025',N'Đặng Huyền Thi',N'Phanda','20/05/2000',N'Hầm Bom',N'Nữ','','LP0000006','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000026',N'Đặng Huyền Thiên',N'Tàu Uống','20/05/2000',N'Hầm Bom',N'Nữ','','LP0000006','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000027',N'Đặng Thành Trung',N'Vũng Tàu','20/05/2000',N'Hầm Bom',N'Nữ','','LP0000005','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000035',N'Đặng Thành Trung',N'Vũng Tàu','20/05/2000',N'Hầm Bom',N'Nữ','','LP0000005','NG0000001')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000028',N'Lê Thị Phương Vy',N'Đà Lạt','20/09/2000',N'Hầm Bom',N'Nữ','','LP0000004','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000029',N'Trần Thị Phương Vy',N'Đắc Lắc','23/06/2000',N'Hầm Bom',N'Nữ','','LP0000004','NG0000003')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000030',N'Nguyễn Thị Phương Vy',N'Tây Nguyên','28/06/2000',N'Hầm Bom',N'Nữ','','LP0000003','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000031',N'Phạm Thị Phương Vy',N'Lâm Đồng','28/06/2000',N'Hầm Bom',N'Nữ','','LP0000000','NG0000004')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000032',N'Tống Thị Phương Vy',N'Hội An','28/06/2000',N'Hầm Bom',N'Nữ','','LP0000002','NG0000005')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000033',N'Lê Thị Phương Vy',N'Huế','28/06/2000',N'Hầm Bom',N'Nữ','','LP0000000','NG0000000')
insert into SinhVien(MaSinhVien,HoTen,QueQuan,NgaySinh,NoiSinh,GioiTinh,Hinh,MaLop,MaNganh) values ('SV0000034',N'Phương Vy',N'Nghệ An','28/04/2000',N'Hầm Bom',N'Nữ','','LP0000001','NG0000000')






--Điểm--
USE [QuanLySinhVien]
GO
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000000',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000000',2,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000000',3,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000000',4,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000000',4,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000000',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000000',7,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000000',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000000',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000000',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000000',10,4)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000034',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000034',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000033',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000033',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000033',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000033',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000033',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000033',8,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000033',7,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000033',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000033',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000033',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000033',6,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000032',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000032',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000031',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000031',10,4)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000031',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000031',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000031',10,2)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000030',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000030',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000030',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000030',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000030',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000030',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000030',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000030',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000030',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000030',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000030',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000029',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000029',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000029',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000029',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000029',9,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000029',8,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000029',7,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000029',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000029',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000029',6,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000029',6,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000028',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000028',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000028',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000028',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000028',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000028',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000028',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000028',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000028',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000028',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000028',10,1)


insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000027',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000027',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000027',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000027',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000027',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000027',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000027',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000027',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000027',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000027',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000027',10,1)


insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000026',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000026',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000026',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000026',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000026',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000026',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000026',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000026',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000026',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000026',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000026',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000025',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000025',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000025',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000025',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000025',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000025',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000025',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000025',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000025',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000025',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000025',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000024',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000024',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000024',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000024',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000024',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000024',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000024',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000024',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000024',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000024',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000024',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000023',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000023',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000023',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000023',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000023',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000023',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000023',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000023',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000023',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000023',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000023',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000022',10,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000022',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000021',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000021',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000021',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000021',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000021',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000021',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000021',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000021',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000021',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000021',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000021',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000020',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000020',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000020',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000020',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000020',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000020',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000020',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000020',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000020',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000020',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000020',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000019',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000019',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000019',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000019',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000019',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000019',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000019',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000019',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000019',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000019',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000019',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000018',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000018',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000018',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000018',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000018',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000018',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000018',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000018',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000018',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000018',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000018',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000017',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000017',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000017',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000017',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000017',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000017',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000017',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000017',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000017',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000017',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000017',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000016',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000016',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000016',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000016',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000016',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000016',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000016',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000016',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000016',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000016',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000016',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000015',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000015',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000015',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000015',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000015',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000015',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000015',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000015',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000015',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000015',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000015',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000014',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000014',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000014',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000014',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000014',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000014',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000014',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000014',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000014',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000014',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000014',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000013',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000013',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000013',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000013',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000013',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000013',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000013',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000013',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000013',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000013',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000013',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000012',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000012',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000012',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000012',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000012',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000012',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000012',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000012',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000012',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000012',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000012',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000011',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000011',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000011',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000011',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000011',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000011',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000011',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000011',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000011',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000011',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000011',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000010',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000010',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000010',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000010',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000010',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000010',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000010',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000010',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000010',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000010',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000010',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000009',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000009',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000009',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000009',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000009',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000009',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000009',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000009',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000009',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000009',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000009',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000008',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000008',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000008',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000008',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000008',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000008',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000008',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000008',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000008',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000008',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000008',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000007',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000007',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000007',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000007',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000007',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000007',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000007',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000007',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000007',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000007',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000007',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000006',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000006',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000006',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000006',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000006',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000006',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000006',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000006',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000006',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000006',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000006',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000005',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000005',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000005',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000005',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000005',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000005',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000005',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000005',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000005',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000005',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000005',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000004',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000004',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000004',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000004',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000004',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000004',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000004',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000004',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000004',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000004',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000004',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000003',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000003',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000003',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000003',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000003',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000003',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000003',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000003',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000003',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000003',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000003',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000002',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000002',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000002',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000002',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000002',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000002',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000002',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000002',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000002',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000002',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000002',10,1)

insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000000','SV0000001',10,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000001','SV0000001',5,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000002','SV0000001',4,3)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000003','SV0000001',4,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000004','SV0000001',5,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000005','SV0000001',6,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000006','SV0000001',10,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000007','SV0000001',2,2)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000008','SV0000001',1,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000009','SV0000001',0,1)
insert into Diem (MaMonHoc,MaSinhVien,SoDiem,Lanthi) values ('MH0000010','SV0000001',10,1)




--ĐKMH--
USE [QuanLySinhVien]
GO
--insert into DKMH (MaMonHoc,MaSinhVien) values ('01MH','001SV')

--Học--
USE [QuanLySinhVien]
GO
--insert into Hoc (MaSinhVien,MaLop) values ('001SV','01ML')




--------------------------Sinh Viên----------------------
USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_CapNhatSinhVien]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(	@MaSinhVien varchar(50),
		@Hoten nvarchar(150),
		@Quequan nvarchar(350),
		@NgaySinh smalldatetime,
		@NoiSinh nvarchar(400),
		@GioiTinh nvarchar(5),
		@MaNganh varchar(50),
		@Hinh nvarchar(150),
		@MaLop varchar(50)
		
	)
AS
begin
	/* SET NOCOUNT ON */
	Update SinhVien Set MaSinhVien = @MaSinhVien, Hoten = @Hoten, QueQuan = @Quequan , Ngaysinh = @Ngaysinh, NoiSinh = @NoiSinh, Gioitinh = @Gioitinh,Hinh = @Hinh,MaLop=@MaLop, MaNganh = @MaNganh  Where MaSinhVien = @MaSinhVien
	RETURN
end
	go
USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_ThemSinhVien]
	(
		@MaSinhVien varchar(50),
		@Hoten nvarchar(150),
		@Quequan nvarchar(350),
		@NgaySinh smalldatetime,
		@NoiSinh nvarchar(400),
		@GioiTinh nvarchar(5),
		@MaNganh varchar(50),
		@Hinh nvarchar(150),
		@MaLop varchar(50)
		
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into SinhVien(MaSinhVien, Hoten, Quequan, NgaySinh, NoiSinh,Gioitinh,Hinh,MaLop, MaNganh) Values (@MaSinhVien, @Hoten, @Quequan, @Ngaysinh, @NoiSinh,@Gioitinh, @Hinh,@MaLop,@MaNganh)
	RETURN
end
go
USE [QuanLySinhVien]
GO	
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_XoaSinhVien]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
		@MaSinhVien varchar(50)
		
AS
begin
	/* SET NOCOUNT ON */
	Delete From SinhVien Where MaSinhVien = @MaSinhVien
	RETURN
end
go
---------------------------Điểm-----------------------------------------------
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_CapNhatDiem]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonHoc varchar(50),
		@MaSinhVien varchar(50),
		@SoDiem float,		
		@LanThi int

	)
AS
begin
	/* SET NOCOUNT ON */
	Update Diem set MaMonHoc = @MaMonHoc, MaSinhVien = @MaSinhVien, SoDiem = @SoDiem,LanThi = @LanThi Where MaMonHoc = @MaMonHoc and MaSinhVien = @MaSinhVien
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_NhapDiem]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonHoc varchar(50),
		@MaSinhVien varchar(50),
		@SoDiem float,		
		@LanThi int
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into Diem(MaMonHoc, MaSinhVien, SoDiem, LanThi ) Values(@MaMonHoc, @MaSinhVien, @SoDiem, @LanThi)
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_XoaDiem]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	@MaMonHoc varchar(50),
	@MaSinhVien varchar(50)
AS
begin
	/* SET NOCOUNT ON */
	Delete From Diem where MaMonHoc = @MaMonHoc and MaSinhVien = @MaSinhVien
	RETURN
end

go
----------------------------ĐKMH---------------------------------------
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_CapNhatDKMH]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonHoc varchar(50),
		@MaSinhVien varchar(50)

	)
AS
begin
	/* SET NOCOUNT ON */
	Update DKMH set MaSinhVien = @MaSinhVien,MaMonHoc = @MaMonHoc Where MaMonHoc = @MaMonHoc and MaSinhVien = @MaSinhVien
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_NhapDKMH]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonHoc varchar(50),
		@MaSinhVien varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into DKMH(MaMonHoc, MaSinhVien ) Values(@MaMonHoc, @MaSinhVien)
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_XoaDKMH]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
		@MaMonHoc varchar(50),
		@MaSinhVien varchar(50)
AS
begin
	/* SET NOCOUNT ON */
	Delete From DKMH where MaMonHoc = @MaMonHoc and MaSinhVien = @MaSinhVien
	RETURN
end

go
------------------Giáo viên -------------------------------------------
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_CapNhatGiaoVien]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaGiaoVien varchar(50),
		@TenGiaoVien nvarchar(150),
		@MaKhoa varchar(50),
		@GhiChu nvarchar(500)
	)
AS
begin
	/* SET NOCOUNT ON */
	Update GiaoVien Set MaGiaoVien = @MaGiaoVien, TenGiaoVien = @TenGiaoVien, GhiChu= @Ghichu , MaKhoa = @MaKhoa Where MaGiaoVien = @MaGiaoVien
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_ThemGiaoVien]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaGiaoVien varchar(50),
		@TenGiaoVien nvarchar(150),
		@MaKhoa varchar(50),
		@GhiChu nvarchar(500)
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into GiaoVien(MaGiaoVien, TenGiaoVien, GhiChu, MaKhoa) Values(@MaGiaoVien, @TenGiaoVien,@GhiChu, @MaKhoa)
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_XoaGiaoVien]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaGiaoVien varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Delete From GiaoVien Where MaGiaoVien = @MaGiaoVien
	RETURN
end

go

	----------------------Khoa--------------------------
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_CapNhatKhoa]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaKhoa varchar(50),
		@TenKhoa nvarchar(50),
		@GhiChu nvarchar(500),
		@Username varchar(50) 
	)
AS
begin
	/* SET NOCOUNT ON */
	Update Khoa Set MaKhoa = @MaKhoa, TenKhoa = @TenKhoa, GhiChu = @GhiChu, Username=@Username Where MaKhoa = @MaKhoa
	RETURN
end

	go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_ThemKhoa]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaKhoa varchar(50),
		@TenKhoa nvarchar(50),
		@GhiChu nvarchar(500),
		@Username varchar(50) 
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into Khoa(MaKhoa, TenKhoa, Ghichu,Username) Values(@MaKhoa, @TenKhoa, @GhiChu,@Username)
	RETURN
end	
go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_XoaKhoa]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	@MaKhoa varchar(50)
AS
begin
	/* SET NOCOUNT ON */
	Delete From Khoa Where MaKhoa = @MaKhoa
	RETURN
end
go
	-------------------------- Lớp -------------------------------------
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_CapNhatLop]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaLop varchar(50),
		@TenLop nvarchar(50),
		@LoaiLop bit,
		@NienKhoa varchar(50),
		@NgayBatDau smalldatetime,
		@NgayKetThuc smalldatetime,
		@MaGiaoVien varchar(50),
		@MaMonHoc varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Update Lop Set MaLop = @MaLop, TenLop = @TenLop,LoaiLop = @LoaiLop, NienKhoa= @NienKhoa, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc,MaGiaoVien = @MaGiaoVien,MaMonHoc = @MaMonHoc Where MaLop = @MaLop
	RETURN
end
go


USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_ThemLop]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaLop varchar(50),
		@TenLop nvarchar(50),
		@LoaiLop bit,
		@NienKhoa varchar(50),
		@NgayBatDau smalldatetime,
		@NgayKetThuc smalldatetime,
		@MaGiaoVien varchar(50),
		@MaMonHoc varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into Lop(MaLop, TenLop,LoaiLop,NienKhoa,NgayBatDau,NgayKetThuc,MaMonHoc,MaGiaoVien) Values(@MaLop, @TenLop,@LoaiLop,@NienKhoa,@NgayBatDau,@NgayKetThuc,@MaMonHoc,@MaGiaoVien)
	RETURN
end	
go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_XoaLop]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaLop varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Delete From Lop where MaLop  = @MaLop
	RETURN
end

	go

	--------------------------------------------Môn Học-----------------------------------
	USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_CapNhatMonHoc]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonHoc varchar(50),
		@TenMonHoc nvarchar(50),
		@MaKhoa varchar(50),
		@TinChiLyThuyet int,
		@TinChiThucHanh int,
		@LoaiMonHoc bit
	)
AS
begin
	/* SET NOCOUNT ON */
	Update MonHoc Set MaMonHoc = @MaMonHoc, TenMonHoc = @TenMonHoc, LoaiMonHoc = @LoaiMonHoc,TinChiLyThuyet = @TinChiLyThuyet,TinChiThucHanh = @TinChiThucHanh,  MaKhoa = @MaKhoa where MaMonHoc = @MaMonHoc
	RETURN
end	
	go
	USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_ThemMonHoc]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonHoc varchar(50),
		@TenMonHoc nvarchar(50),
		@MaKhoa varchar(50),
		@TinChiLyThuyet int,
		@TinChiThucHanh int,
		@LoaiMonHoc bit
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into MonHoc(MaMonHoc, TenMonHoc, LoaiMonHoc,TinChiLyThuyet,TinChiThucHanh,MaKhoa) Values(@MaMonHoc, @TenMonHoc,@LoaiMonHoc,@TinChiLyThuyet,@TinChiThucHanh, @MaKhoa)
	RETURN
end
	go
	USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_XoaMonHoc]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	@MaMonHoc varchar(50)
AS
begin
	/* SET NOCOUNT ON */
	Delete From MonHoc Where MaMonHoc = @MaMonHoc
	RETURN
end
	go

	------------------ Ngành-----------------------
	USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_CapNhatNganh]
	(
		@MaNganh varchar(50),
		@TenNganh nvarchar(50),
		@GhiChu nvarchar(500),
		@MaKhoa varchar(50)

	)
AS
begin
	Update Nganh Set MaNganh = @MaNganh, TenNganh = @TenNganh, GhiChu = @GhiChu, MaKhoa= @MaKhoa Where MaNganh = @MaNganh
	RETURN
end
	go
	USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_ThemNganh]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaNganh varchar(50),
		@TenNganh nvarchar(50),
		@GhiChu nvarchar(500),
		@MaKhoa varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into Nganh(MaNganh,  TenNganh,MaKhoa,GhiChu) Values(@MaNganh, @TenNganh,@MaKhoa, @GhiChu)
	RETURN
end

	go
	USE [QuanLySinhVien]
GO
	SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
	create PROCEDURE [dbo].[qlsv_XoaNganh]
	(
	@MaNganh varchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Delete From Nganh Where MaNganh = @MaNganh
	RETURN
end
	go



------------------------------------------user------------------------------
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_AddNewUser]
	(
		@Usertype bit ,
		@Username nvarchar(50),
		@Pass nvarchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into tb_User( Usertype, Username,Pass) Values( @Usertype,@Username, @Pass)
	RETURN
end

go

--
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO

create PROCEDURE [dbo].[qlsv_DeleteUser]
	
	(		
		@Username nvarchar(50)	
	)
AS
begin
	/* SET NOCOUNT ON */
	Delete from tb_User Where Username = @Username
	
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_SelectUser]
	@Usertype bit,
	@Username nvarchar(50),
	@Pass nvarchar(50)
	
AS
begin
	/* SET NOCOUNT ON */
	Select Username From tb_User Where Username=@Username
	RETURN
end

go
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON	
GO
SET QUOTED_IDENTIFIER ON 
GO
create PROCEDURE [dbo].[qlsv_UpdateUser]
	(
		@Usertype bit,
		@Username nvarchar(50),
		@Pass nvarchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Update tb_User Set Usertype = @Usertype ,Username = @Username, Pass = @Pass Where Username = @Username
	RETURN
end

	
