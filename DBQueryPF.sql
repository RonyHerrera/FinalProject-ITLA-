USE [master]
GO
/****** Object:  Database [ProyectoFinal]    Script Date: 5/8/2021 10:30:48 a. m. ******/
CREATE DATABASE [ProyectoFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoFinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoFinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectoFinal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoFinal] SET RECOVERY FULL 
GO
ALTER DATABASE [ProyectoFinal] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoFinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoFinal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoFinal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProyectoFinal', N'ON'
GO
ALTER DATABASE [ProyectoFinal] SET QUERY_STORE = OFF
GO
USE [ProyectoFinal]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 5/8/2021 10:30:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NULL,
	[IdDoctor] [int] NULL,
	[FechaYHoraDeLaCita] [date] NULL,
	[CausaDeLaCita] [varchar](150) NULL,
	[EstadoDeLaCita] [int] NULL,
 CONSTRAINT [PK__Citas__3214EC079CFA128E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctores]    Script Date: 5/8/2021 10:30:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Apellido] [varchar](150) NULL,
	[Correo] [varchar](150) NULL,
	[Telefono] [varchar](15) NULL,
	[Cedula] [varchar](20) NULL,
	[Foto] [varchar](1) NULL,
 CONSTRAINT [PK__Doctores__3214EC07B77FD020] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 5/8/2021 10:30:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Apellido] [varchar](150) NULL,
	[Telefono] [varchar](15) NULL,
	[Direccion] [varchar](150) NULL,
	[Cedula] [varchar](20) NULL,
	[FechaDeNacimiento] [date] NULL,
	[Fumador] [bit] NULL,
	[Alegias] [varchar](150) NULL,
	[Foto] [varchar](1) NULL,
 CONSTRAINT [PK__Paciente__3214EC0783F2379A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PruebasDeLaboratorio]    Script Date: 5/8/2021 10:30:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PruebasDeLaboratorio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
 CONSTRAINT [PK__PruebasD__3214EC073F2E788A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultadosDeLaboratorio]    Script Date: 5/8/2021 10:30:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultadosDeLaboratorio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCita] [int] NULL,
	[IdPacientes] [int] NULL,
	[IdPruebaDeLaboratorio] [int] NULL,
	[IdDoctor] [int] NULL,
	[ResultadoDeLaPrueba] [varchar](1) NULL,
	[EstadoDelResultado] [int] NULL,
 CONSTRAINT [PK__Resultad__3214EC07CB8F9E34] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 5/8/2021 10:30:50 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Apellido] [varchar](150) NULL,
	[Correo] [varchar](100) NULL,
	[Contraseña] [varchar](100) NULL,
	[TipoDeUsuario] [int] NULL,
 CONSTRAINT [PK__Usuarios__3214EC07AB7309FD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK__Citas__EstadoDeL__2A4B4B5E] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([Id])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK__Citas__EstadoDeL__2A4B4B5E]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK__Citas__IdDoctor__2B3F6F97] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Doctores] ([Id])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK__Citas__IdDoctor__2B3F6F97]
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio]  WITH CHECK ADD  CONSTRAINT [FK__Resultado__Estad__300424B4] FOREIGN KEY([IdCita])
REFERENCES [dbo].[Citas] ([Id])
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio] CHECK CONSTRAINT [FK__Resultado__Estad__300424B4]
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio]  WITH CHECK ADD  CONSTRAINT [FK__Resultado__IdDoc__32E0915F] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Doctores] ([Id])
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio] CHECK CONSTRAINT [FK__Resultado__IdDoc__32E0915F]
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio]  WITH CHECK ADD  CONSTRAINT [FK__Resultado__IdPac__30F848ED] FOREIGN KEY([IdPacientes])
REFERENCES [dbo].[Pacientes] ([Id])
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio] CHECK CONSTRAINT [FK__Resultado__IdPac__30F848ED]
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio]  WITH CHECK ADD  CONSTRAINT [FK__Resultado__IdPru__31EC6D26] FOREIGN KEY([IdPruebaDeLaboratorio])
REFERENCES [dbo].[PruebasDeLaboratorio] ([Id])
GO
ALTER TABLE [dbo].[ResultadosDeLaboratorio] CHECK CONSTRAINT [FK__Resultado__IdPru__31EC6D26]
GO
USE [master]
GO
ALTER DATABASE [ProyectoFinal] SET  READ_WRITE 
GO
