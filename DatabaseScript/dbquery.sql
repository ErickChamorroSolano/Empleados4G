USE [master]
GO
/****** Object:  Database [4GDB]    Script Date: 17/02/2025 4:58:23 a. m. ******/
CREATE DATABASE [4GDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'4GDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\4GDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'4GDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\4GDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [4GDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [4GDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [4GDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [4GDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [4GDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [4GDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [4GDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [4GDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [4GDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [4GDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [4GDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [4GDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [4GDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [4GDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [4GDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [4GDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [4GDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [4GDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [4GDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [4GDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [4GDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [4GDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [4GDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [4GDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [4GDB] SET RECOVERY FULL 
GO
ALTER DATABASE [4GDB] SET  MULTI_USER 
GO
ALTER DATABASE [4GDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [4GDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [4GDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [4GDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [4GDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [4GDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'4GDB', N'ON'
GO
ALTER DATABASE [4GDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [4GDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [4GDB]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](125) NOT NULL,
	[Cedula] [int] NOT NULL,
	[TipoSangre] [varchar](5) NOT NULL,
	[Telefono] [int] NULL,
	[Salario] [int] NOT NULL,
	[EPS] [varchar](50) NULL,
	[PorcentajeEPS] [smallint] NULL,
	[ARL] [varchar](50) NULL,
	[PorcentajeARL] [smallint] NULL,
	[Pensiones] [varchar](50) NULL,
	[PorcentajePensiones] [smallint] NULL,
	[TotalSalario] [int] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Contrasenia] [varchar](30) NOT NULL,
	[Rol] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Cedula], [TipoSangre], [Telefono], [Salario], [EPS], [PorcentajeEPS], [ARL], [PorcentajeARL], [Pensiones], [PorcentajePensiones], [TotalSalario]) VALUES (5, N'empleado dos', 123467890, N'O+', 0, 4200000, N'SURA', 10, N'Seleccione', 0, N'OmbiaPensiones', 1, 3738000)
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Cedula], [TipoSangre], [Telefono], [Salario], [EPS], [PorcentajeEPS], [ARL], [PorcentajeARL], [Pensiones], [PorcentajePensiones], [TotalSalario]) VALUES (6, N'empleado tres', 3235827, N'A+', 0, 5600000, N'Nueva EPS', 16, N'AXA', 1, N'Porvenir', 5, 4368000)
GO
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Id], [Usuario], [Contrasenia], [Rol]) VALUES (1, N'Admin', N'MTIzNA==', N'Administrador')
GO
INSERT [dbo].[Usuario] ([Id], [Usuario], [Contrasenia], [Rol]) VALUES (2, N'Usuario', N'NDMyMQ==', N'Empleado')
GO
INSERT [dbo].[Usuario] ([Id], [Usuario], [Contrasenia], [Rol]) VALUES (3, N'admin2', N'admin123', N'Empleado')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Usuario]    Script Date: 17/02/2025 4:58:24 a. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Usuario] ON [dbo].[Usuario]
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_Salario]  DEFAULT ((0)) FOR [Salario]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_PorcentajeEPS]  DEFAULT ((0)) FOR [PorcentajeEPS]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_PorcentajeARL]  DEFAULT ((0)) FOR [PorcentajeARL]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_PorcentajePensiones]  DEFAULT ((0)) FOR [PorcentajePensiones]
GO
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [DF_Empleado_TotalSalario]  DEFAULT ((0)) FOR [TotalSalario]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEmpleado]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarEmpleado]
(
	@Id as int,
	@Nombre as varchar(50),
	@Cedula as int,
	@Telefono as int,
	@TipoSangre as varchar(5),
	@Salario as int,
	@EPS as varchar(50),
	@prcEPS as smallint,
	@ARL as varchar(50),
	@prcARL as smallint,
	@Pensiones as varchar(50),
	@prcPensiones as smallint,
	@TotalSalario as int
)
AS
BEGIN
	IF EXISTS (SELECT 1 from Empleado where Id = @Id)
	BEGIN
		UPDATE Empleado set
		Nombre = @Nombre,
		Cedula = @Cedula,
		Telefono = @Telefono,
		TipoSangre = @TipoSangre,
		Salario = @Salario,
		EPS = @EPS,
		PorcentajeEPS = @prcEPS,
		ARL = @ARL,
		PorcentajeARL = @prcARL,
		Pensiones = @Pensiones,
		PorcentajePensiones = @prcPensiones,
		TotalSalario = @TotalSalario
		where Id = @Id
	END
	ELSE
	BEGIN
		RAISERROR('el empleado que desea actualizar no existe en la base de datos.',16,1)
		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarEmpleado]
(
	@Id as int
)
AS
BEGIN
	IF EXISTS (select 1 from Empleado where Id = @Id)
	BEGIN
		DELETE FROM [dbo].[Empleado] where Id = @Id
	END
	ELSE
	BEGIN
		RAISERROR('el empleado que desea actualizar no existe en la base de datos.',16,1)
		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarEmpleado]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarEmpleado]
(
	@Nombre as varchar(50),
	@Cedula as int,
	@Telefono as int,
	@TipoSangre as varchar(5),
	@Salario as int,
	@EPS as varchar(50),
	@prcEPS as smallint,
	@ARL as varchar(50),
	@prcARL as smallint,
	@Pensiones as varchar(50),
	@prcPensiones as smallint,
	@TotalSalario as int
)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 from Empleado where Cedula = @Cedula)
	BEGIN
		INSERT INTO Empleado (Nombre, Cedula, TipoSangre, Telefono, Salario, EPS, PorcentajeEPS, ARL, PorcentajeARL, Pensiones, PorcentajePensiones, TotalSalario) 
		VALUES (@Nombre, @Cedula, @TipoSangre, @Telefono, @Salario, @EPS, @prcEPS, @ARL, @prcARL, @Pensiones, @prcPensiones, @TotalSalario)
	END
	ELSE
	BEGIN
		RAISERROR('Ya existe un empleado con este número de cédula.',16,1)
		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarUsuario]
(
	@Usuario as varchar(30),
	@Password as varchar(20),
	@Rol as varchar(20)
)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Usuario WHERE Usuario = @USUARIO)
	BEGIN
		INSERT INTO USUARIO (USUARIO, CONTRASENIA, ROL) VALUES (@Usuario, @Password, @Rol)
	END
	ELSE
	BEGIN
		RAISERROR('ESTE NOMBRE DE USUARIO YA EXISTE.', 16, 1)
		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[RecuperarEmpleadoPorID]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RecuperarEmpleadoPorID]
(
	@Id as int
)
AS
BEGIN
	SELECT [Id]
      ,[Nombre]
      ,[Cedula]
      ,[Telefono]
      ,[TipoSangre]
	  ,[Salario]
      ,[EPS]
	  ,[PorcentajeEPS]
      ,[ARL]
	  ,[PorcentajeARL]
      ,[Pensiones]
	  ,[PorcentajePensiones]
      ,[TotalSalario]
  FROM [dbo].[Empleado]
  where Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[RecuperarEmpleados]    Script Date: 17/02/2025 4:58:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RecuperarEmpleados]
AS
BEGIN
	SELECT [Id]
      ,[Nombre]
      ,[Cedula]
      ,[TipoSangre]
      ,[Telefono]
      ,[Salario]
      ,[EPS]
	  ,[PorcentajeEPS]
      ,[ARL]
	  ,[PorcentajeARL]
      ,[Pensiones]
	  ,[PorcentajePensiones]
	  ,[totalSalario]
  FROM [dbo].[Empleado]
END
GO
USE [master]
GO
ALTER DATABASE [4GDB] SET  READ_WRITE 
GO
