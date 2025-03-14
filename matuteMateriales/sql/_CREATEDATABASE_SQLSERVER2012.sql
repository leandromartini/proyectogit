USE [master]
GO

/****** Object:  Database [MatuteMateriales]    Script Date: 09/05/2019 11:10:33 ******/
CREATE DATABASE [MatuteMateriales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MatuteMateriales', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESSDOS\MSSQL\DATA\MatuteMateriales.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MatuteMateriales_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESSDOS\MSSQL\DATA\MatuteMateriales_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [MatuteMateriales] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MatuteMateriales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MatuteMateriales] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MatuteMateriales] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MatuteMateriales] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MatuteMateriales] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MatuteMateriales] SET ARITHABORT OFF 
GO

ALTER DATABASE [MatuteMateriales] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MatuteMateriales] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [MatuteMateriales] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MatuteMateriales] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MatuteMateriales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MatuteMateriales] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MatuteMateriales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MatuteMateriales] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MatuteMateriales] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MatuteMateriales] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MatuteMateriales] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MatuteMateriales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MatuteMateriales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MatuteMateriales] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MatuteMateriales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MatuteMateriales] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MatuteMateriales] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MatuteMateriales] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MatuteMateriales] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [MatuteMateriales] SET  MULTI_USER 
GO

ALTER DATABASE [MatuteMateriales] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MatuteMateriales] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MatuteMateriales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MatuteMateriales] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [MatuteMateriales] SET  READ_WRITE 
GO


