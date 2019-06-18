USE [master]
GO
/****** Object:  Database [DbXMedicina]    Script Date: 05/12/2014 13:57:33 ******/
CREATE DATABASE [DbXMedicina] ON  PRIMARY 
( NAME = N'DbXMedicina', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DbXMedicina.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbXMedicina_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DbXMedicina_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbXMedicina] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbXMedicina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbXMedicina] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DbXMedicina] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DbXMedicina] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DbXMedicina] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DbXMedicina] SET ARITHABORT OFF
GO
ALTER DATABASE [DbXMedicina] SET AUTO_CLOSE ON
GO
ALTER DATABASE [DbXMedicina] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DbXMedicina] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DbXMedicina] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DbXMedicina] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DbXMedicina] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DbXMedicina] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DbXMedicina] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DbXMedicina] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DbXMedicina] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DbXMedicina] SET  ENABLE_BROKER
GO
ALTER DATABASE [DbXMedicina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DbXMedicina] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DbXMedicina] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DbXMedicina] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DbXMedicina] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DbXMedicina] SET READ_COMMITTED_SNAPSHOT ON
GO
ALTER DATABASE [DbXMedicina] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DbXMedicina] SET  READ_WRITE
GO
ALTER DATABASE [DbXMedicina] SET RECOVERY SIMPLE
GO
ALTER DATABASE [DbXMedicina] SET  MULTI_USER
GO
ALTER DATABASE [DbXMedicina] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DbXMedicina] SET DB_CHAINING OFF
GO
USE [DbXMedicina]
GO
/****** Object:  Table [dbo].[ObraSocial]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ObraSocial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Abreviatura] [varchar](250) NULL,
 CONSTRAINT [PK_ObraSocial] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GrupoSanguineo]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GrupoSanguineo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Codigo] [int] NOT NULL,
 CONSTRAINT [PK_GrupoSanguineo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Formulario]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formulario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Descripcion] [varchar](250) NULL,
	[DescripcionLarga] [varchar](250) NULL,
 CONSTRAINT [PK_Formulario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Especialidad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dosis]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dosis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Dosis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConfiguracionSeguridad]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConfiguracionSeguridad](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PasswordDefecto] [varchar](250) NOT NULL,
	[RequerirCambioPassword] [bit] NOT NULL,
	[CantMaximoCaracteres] [int] NOT NULL,
	[CantMinimoCaracteres] [int] NOT NULL,
	[CantMayusculas] [int] NOT NULL,
	[CantMinusculas] [int] NOT NULL,
	[CantNumeros] [int] NOT NULL,
	[CantSimbolos] [int] NOT NULL,
 CONSTRAINT [PK_ConfiguracionSeguridad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConfiguracionMail]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConfiguracionMail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](250) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[UsaSSL] [bit] NOT NULL,
	[SMTPServer] [varchar](250) NOT NULL,
	[OutPort] [int] NOT NULL,
	[DireccionEnvia] [varchar](250) NOT NULL,
	[EnviarCrearUsuario] [bit] NOT NULL,
	[EnviarCumplirPaciente] [bit] NOT NULL,
	[EnviarCancelarTurno] [bit] NOT NULL,
 CONSTRAINT [PK_ConfiguracionMail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [nvarchar](250) NOT NULL,
	[NombreFantasia] [nvarchar](250) NOT NULL,
	[FechaInicioActividades] [datetime] NOT NULL,
	[CuitCuil] [nvarchar](20) NOT NULL,
	[IngresosBrutos] [nvarchar](max) NULL,
	[Direccion] [nvarchar](400) NOT NULL,
	[Telefono] [nvarchar](20) NULL,
	[Logo] [varbinary](max) NULL,
 CONSTRAINT [PK_dbo.Empresa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacuna]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacuna](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Abreviatura] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Vacunas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Perfil_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patologia]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patologia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Patologia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PerfilFormulario]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilFormulario](
	[FormularioId] [int] NOT NULL,
	[PerfilId] [int] NOT NULL,
 CONSTRAINT [PK_PerfilFormulario] PRIMARY KEY CLUSTERED 
(
	[FormularioId] ASC,
	[PerfilId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SexoId] [int] NOT NULL,
	[GrupoSanguineoId] [int] NOT NULL,
	[ObraSocialId] [int] NOT NULL,
	[Apellido] [varchar](250) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Dni] [varchar](9) NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Domicilio] [varchar](400) NULL,
	[Telefono] [varchar](20) NULL,
	[Celular] [varchar](20) NULL,
	[Mail] [varchar](250) NULL,
	[Foto] [image] NOT NULL,
	[EsDown] [bit] NOT NULL,
	[PlanObraSocial] [varchar](250) NULL,
	[NumeroAfiliado] [varchar](50) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](250) NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
	[Dni] [nvarchar](8) NULL,
	[Telefono] [nvarchar](20) NULL,
	[Celular] [nvarchar](20) NULL,
	[MatriculaProvincial] [nvarchar](10) NULL,
	[MatriculaNacional] [nvarchar](10) NULL,
	[EspecialidadId] [int] NOT NULL,
	[FotoEmpleado] [image] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Mail] [varchar](250) NULL,
 CONSTRAINT [PK_dbo.Empleado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_EspecialidadId] ON [dbo].[Empleado] 
(
	[EspecialidadId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CalendarioVacunacion]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalendarioVacunacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VacunaId] [int] NOT NULL,
	[DosisId] [int] NOT NULL,
	[Anio] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[Dia] [int] NOT NULL,
	[Obligatoria] [bit] NOT NULL,
 CONSTRAINT [PK_PlanVacunaciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpresaEmpleado]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpresaEmpleado](
	[EmpleadoId] [int] NOT NULL,
	[EmpresaId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EmpresaEmpleado] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC,
	[EmpresaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_EmpleadoId] ON [dbo].[EmpresaEmpleado] 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_EmpresaId] ON [dbo].[EmpresaEmpleado] 
(
	[EmpresaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PacientePatologia]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PacientePatologia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PacienteId] [int] NOT NULL,
	[PatologiaId] [int] NOT NULL,
	[Anio] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[Observacion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_PacientePatologia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[NombreUsuario] [varchar](250) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[EstaEliminado] [bit] NOT NULL,
	[EstaBloqueado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PlanVacunacion]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanVacunacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PacienteId] [int] NOT NULL,
	[CalendarioVacunacionId] [int] NOT NULL,
	[FechaPlan] [datetime] NOT NULL,
	[FechaReal] [datetime] NULL,
	[Estado] [bit] NOT NULL,
	[Observacion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Paciente_Vacunas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilUsuario]    Script Date: 05/12/2014 13:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilUsuario](
	[UsuarioId] [int] NOT NULL,
	[PerfilId] [int] NOT NULL,
 CONSTRAINT [PK_PerfilUsuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC,
	[PerfilId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwEmpleadoUsuario]    Script Date: 05/12/2014 13:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwEmpleadoUsuario]
AS
SELECT
     CONVERT(int, row_number() over(order by e.Id desc)) as Id,       
	 E.Id AS EmpleadoId, 
	 COALESCE (U.Id, - 1) AS UsuarioId, 
	 E.Apellido + ' ' + E.Nombre AS ApyNom,
	 E.Dni, 
	 COALESCE (U.NombreUsuario, 'NO ASIGNADO') AS NombreUsuario, 
     CASE WHEN COALESCE (U.EstaBloqueado, 0) = 1 THEN 'SI'
		  WHEN COALESCE (U.EstaBloqueado, 0) = 0 THEN 'NO' END AS EstaBloqueado,
	 CASE WHEN COALESCE (U.EstaEliminado, 0) = 1 THEN 'SI'
		  WHEN COALESCE (U.EstaEliminado, 0) = 0 THEN 'NO' END AS EstaEliminado
FROM Empleado AS E LEFT JOIN
     Usuario AS U ON U.EmpleadoId = E.Id
GO
/****** Object:  View [dbo].[vwAccesoSistema]    Script Date: 05/12/2014 13:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwAccesoSistema]
AS
SELECT     F.Id, F.DescripcionLarga, U.NombreUsuario
FROM Usuario U 
inner join PerfilUsuario PU on (U.Id = PU.UsuarioId)
inner join Perfil P on (PU.PerfilId = P.Id)
inner join PerfilFormulario PF on (P.Id = PF.PerfilId)
inner join Formulario F on (PF.FormularioId = F.Id)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Formulario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Perfil"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 111
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PerfilFormulario"
            Begin Extent = 
               Top = 6
               Left = 444
               Bottom = 96
               Right = 604
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PerfilUsuario"
            Begin Extent = 
               Top = 6
               Left = 642
               Bottom = 96
               Right = 802
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 840
               Bottom = 126
               Right = 1002
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 90' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwAccesoSistema'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwAccesoSistema'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwAccesoSistema'
GO
/****** Object:  ForeignKey [FK_PerfilFormulario_Formulario]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PerfilFormulario]  WITH CHECK ADD  CONSTRAINT [FK_PerfilFormulario_Formulario] FOREIGN KEY([FormularioId])
REFERENCES [dbo].[Formulario] ([Id])
GO
ALTER TABLE [dbo].[PerfilFormulario] CHECK CONSTRAINT [FK_PerfilFormulario_Formulario]
GO
/****** Object:  ForeignKey [FK_PerfilFormulario_Perfil]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PerfilFormulario]  WITH CHECK ADD  CONSTRAINT [FK_PerfilFormulario_Perfil] FOREIGN KEY([PerfilId])
REFERENCES [dbo].[Perfil] ([Id])
GO
ALTER TABLE [dbo].[PerfilFormulario] CHECK CONSTRAINT [FK_PerfilFormulario_Perfil]
GO
/****** Object:  ForeignKey [FK_Paciente_GrupoSanguineo]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_GrupoSanguineo] FOREIGN KEY([GrupoSanguineoId])
REFERENCES [dbo].[GrupoSanguineo] ([Id])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_GrupoSanguineo]
GO
/****** Object:  ForeignKey [FK_Paciente_ObraSocial]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_ObraSocial] FOREIGN KEY([ObraSocialId])
REFERENCES [dbo].[ObraSocial] ([Id])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_ObraSocial]
GO
/****** Object:  ForeignKey [FK_Paciente_Sexo]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Sexo] FOREIGN KEY([SexoId])
REFERENCES [dbo].[Sexo] ([Id])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Sexo]
GO
/****** Object:  ForeignKey [FK_dbo.Empleado_dbo.Especialidad_EspecialidadId]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Empleado_dbo.Especialidad_EspecialidadId] FOREIGN KEY([EspecialidadId])
REFERENCES [dbo].[Especialidad] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_dbo.Empleado_dbo.Especialidad_EspecialidadId]
GO
/****** Object:  ForeignKey [FK_CalendarioVacunacion_Dosis]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[CalendarioVacunacion]  WITH CHECK ADD  CONSTRAINT [FK_CalendarioVacunacion_Dosis] FOREIGN KEY([DosisId])
REFERENCES [dbo].[Dosis] ([Id])
GO
ALTER TABLE [dbo].[CalendarioVacunacion] CHECK CONSTRAINT [FK_CalendarioVacunacion_Dosis]
GO
/****** Object:  ForeignKey [FK_PlanVacunacion_Vacuna]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[CalendarioVacunacion]  WITH CHECK ADD  CONSTRAINT [FK_PlanVacunacion_Vacuna] FOREIGN KEY([VacunaId])
REFERENCES [dbo].[Vacuna] ([Id])
GO
ALTER TABLE [dbo].[CalendarioVacunacion] CHECK CONSTRAINT [FK_PlanVacunacion_Vacuna]
GO
/****** Object:  ForeignKey [FK_dbo.EmpresaEmpleado_dbo.Empleado_EmpleadoId]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[EmpresaEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmpresaEmpleado_dbo.Empleado_EmpleadoId] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleado] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpresaEmpleado] CHECK CONSTRAINT [FK_dbo.EmpresaEmpleado_dbo.Empleado_EmpleadoId]
GO
/****** Object:  ForeignKey [FK_dbo.EmpresaEmpleado_dbo.Empresa_EmpresaId]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[EmpresaEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmpresaEmpleado_dbo.Empresa_EmpresaId] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpresaEmpleado] CHECK CONSTRAINT [FK_dbo.EmpresaEmpleado_dbo.Empresa_EmpresaId]
GO
/****** Object:  ForeignKey [FK_PacientePatologia_Paciente]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PacientePatologia]  WITH CHECK ADD  CONSTRAINT [FK_PacientePatologia_Paciente] FOREIGN KEY([PacienteId])
REFERENCES [dbo].[Paciente] ([Id])
GO
ALTER TABLE [dbo].[PacientePatologia] CHECK CONSTRAINT [FK_PacientePatologia_Paciente]
GO
/****** Object:  ForeignKey [FK_PacientePatologia_Patologia]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PacientePatologia]  WITH CHECK ADD  CONSTRAINT [FK_PacientePatologia_Patologia] FOREIGN KEY([PatologiaId])
REFERENCES [dbo].[Patologia] ([Id])
GO
ALTER TABLE [dbo].[PacientePatologia] CHECK CONSTRAINT [FK_PacientePatologia_Patologia]
GO
/****** Object:  ForeignKey [FK_Usuario_Empleado]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
/****** Object:  ForeignKey [FK_PacienteVacuna_Paciente]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PlanVacunacion]  WITH CHECK ADD  CONSTRAINT [FK_PacienteVacuna_Paciente] FOREIGN KEY([PacienteId])
REFERENCES [dbo].[Paciente] ([Id])
GO
ALTER TABLE [dbo].[PlanVacunacion] CHECK CONSTRAINT [FK_PacienteVacuna_Paciente]
GO
/****** Object:  ForeignKey [FK_PacienteVacuna_PlanVacunacion]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PlanVacunacion]  WITH CHECK ADD  CONSTRAINT [FK_PacienteVacuna_PlanVacunacion] FOREIGN KEY([CalendarioVacunacionId])
REFERENCES [dbo].[CalendarioVacunacion] ([Id])
GO
ALTER TABLE [dbo].[PlanVacunacion] CHECK CONSTRAINT [FK_PacienteVacuna_PlanVacunacion]
GO
/****** Object:  ForeignKey [FK_PerfilUsuario_Perfil]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PerfilUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PerfilUsuario_Perfil] FOREIGN KEY([PerfilId])
REFERENCES [dbo].[Perfil] ([Id])
GO
ALTER TABLE [dbo].[PerfilUsuario] CHECK CONSTRAINT [FK_PerfilUsuario_Perfil]
GO
/****** Object:  ForeignKey [FK_PerfilUsuario_Usuario]    Script Date: 05/12/2014 13:57:35 ******/
ALTER TABLE [dbo].[PerfilUsuario]  WITH CHECK ADD  CONSTRAINT [FK_PerfilUsuario_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[PerfilUsuario] CHECK CONSTRAINT [FK_PerfilUsuario_Usuario]
GO

