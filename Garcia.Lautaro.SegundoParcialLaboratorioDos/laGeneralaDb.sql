USE [master]
GO
/****** Object:  Database [SegundoParcial_LaGenerala]    Script Date: 6/21/2023 1:25:02 AM ******/
CREATE DATABASE [SegundoParcial_LaGenerala]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SegundoParcial_LaGenerala', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SegundoParcial_LaGenerala.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SegundoParcial_LaGenerala_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SegundoParcial_LaGenerala_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SegundoParcial_LaGenerala].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ARITHABORT OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET RECOVERY FULL 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET  MULTI_USER 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SegundoParcial_LaGenerala', N'ON'
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET QUERY_STORE = ON
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SegundoParcial_LaGenerala]
GO
/****** Object:  Table [dbo].[jugadores]    Script Date: 6/21/2023 1:25:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jugadores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[partidasGanadas] [int] NOT NULL,
	[partidasEmpatadas] [int] NOT NULL,
	[partidasPerdidas] [int] NOT NULL,
	[puntajeTotal] [int] NOT NULL,
 CONSTRAINT [PK_jugadores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 6/21/2023 1:25:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[jugadores] ON 

INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (1, N'lautaro', N'garcia', 1, 0, 0, 54)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (2, N'martin', N'perez', 0, 0, 1, 11)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (3, N'pablo', N'gonzalez', 2, 0, 2, 226)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (4, N'maria', N'abila', 0, 0, 1, 40)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (5, N'juana', N'fernandez', 1, 0, 0, 34)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (6, N'franco', N'gonzalez', 1, 0, 1, 118)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (7, N'julian', N'perez', 2, 0, 2, 178)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (8, N'romina', N'espina', 1, 0, 0, 74)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (9, N'facundo', N'estero', 1, 0, 2, 180)
INSERT [dbo].[jugadores] ([id], [nombre], [apellido], [partidasGanadas], [partidasEmpatadas], [partidasPerdidas], [puntajeTotal]) VALUES (10, N'emanuel', N'vazquez', 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[jugadores] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombreUsuario], [contrasenia]) VALUES (1, N'juanperez', N'juan123')
INSERT [dbo].[usuarios] ([id], [nombreUsuario], [contrasenia]) VALUES (2, N'martinAlfin', N'mar456')
INSERT [dbo].[usuarios] ([id], [nombreUsuario], [contrasenia]) VALUES (3, N'lautiGar', N'utn17')
INSERT [dbo].[usuarios] ([id], [nombreUsuario], [contrasenia]) VALUES (4, N'pedroLm', N'pedro567')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [SegundoParcial_LaGenerala] SET  READ_WRITE 
GO
