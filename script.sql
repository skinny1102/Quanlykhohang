USE [master]
GO
/****** Object:  Database [QuanLyKhoNhapMon]    Script Date: 10/26/2021 11:21:07 AM ******/
CREATE DATABASE [QuanLyKhoNhapMon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhoNhapMon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhoNhapMon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhoNhapMon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhoNhapMon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhoNhapMon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET QUERY_STORE = OFF
GO
USE [QuanLyKhoNhapMon]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 10/26/2021 11:21:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[username] [nvarchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[code] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[dob] [datetime] NULL,
	[gender] [bit] NULL,
	[phoneNumber] [varchar](11) NULL,
	[dayOne] [datetime] NULL,
	[identify] [varchar](15) NOT NULL,
	[flag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[addUser]    Script Date: 10/26/2021 11:21:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[addUser]
@username nvarchar(20),
	@password varchar(20) ,
	@code varchar(10) ,
	@name varchar(50) ,
	@dob datetime,
	@gender bit ,
	@phoneNumber varchar(11) ,
	@dayOne datetime ,
	@identify varchar(15) ,
	@flag bit
as 
begin	
INSERT INTO employee(username,password,code,name,dob,gender,phoneNumber,dayOne,identify,flag)
	Values(@username,@password,@code,@name,@dob,@gender,@phoneNumber,@dayOne,@identify,@flag)
end
GO
/****** Object:  StoredProcedure [dbo].[flagging]    Script Date: 10/26/2021 11:21:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[flagging]
@username nvarchar(10)
AS
BEGIN
	 update employee
	 set flag =0 
	 where username = @username
END
GO
/****** Object:  StoredProcedure [dbo].[selectUserNotFlag]    Script Date: 10/26/2021 11:21:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectUserNotFlag]
as
begin
select username from dbo.employee where flag = 1 and username != 'admin'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatMK]    Script Date: 10/26/2021 11:21:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_CapNhatMK]
@username nvarchar(20), @password nvarchar(20), @newPass nvarchar(20)
AS
BEGIN
	update employee set password = @newPass
	 WHERE username = @username AND password = @password
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 10/26/2021 11:21:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[SP_Login]
@username nvarchar(20), @password nvarchar(20)
AS
BEGIN
	SELECT * FROM employee WHERE username = @username AND password = @password
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhoNhapMon] SET  READ_WRITE 
GO
