USE [master]
GO
/****** Object:  Database [GB_Sator]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE DATABASE [GB_Sator]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GB_Sator', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DESARROLLO\MSSQL\DATA\GB_Sator.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GB_Sator_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DESARROLLO\MSSQL\DATA\GB_Sator_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GB_Sator] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GB_Sator].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GB_Sator] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GB_Sator] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GB_Sator] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GB_Sator] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GB_Sator] SET ARITHABORT OFF 
GO
ALTER DATABASE [GB_Sator] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GB_Sator] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GB_Sator] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GB_Sator] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GB_Sator] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GB_Sator] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GB_Sator] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GB_Sator] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GB_Sator] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GB_Sator] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GB_Sator] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GB_Sator] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GB_Sator] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GB_Sator] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GB_Sator] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GB_Sator] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GB_Sator] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GB_Sator] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GB_Sator] SET  MULTI_USER 
GO
ALTER DATABASE [GB_Sator] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GB_Sator] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GB_Sator] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GB_Sator] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GB_Sator] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GB_Sator] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GB_Sator] SET QUERY_STORE = OFF
GO
USE [GB_Sator]
GO
/****** Object:  Schema [GB_Sator]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE SCHEMA [GB_Sator]
GO
/****** Object:  Table [GB_Sator].[carta]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[carta](
	[id_carta] [int] IDENTITY(1,1) NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[estado] [smallint] NOT NULL,
 CONSTRAINT [PK_carta_id_carta] PRIMARY KEY CLUSTERED 
(
	[id_carta] ASC,
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[cartaproductos]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[cartaproductos](
	[id_carta] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_tamano] [int] NOT NULL,
	[estado] [smallint] NOT NULL,
 CONSTRAINT [PK_cartaproductos_id_carta] PRIMARY KEY CLUSTERED 
(
	[id_carta] ASC,
	[id_sucursal] ASC,
	[id_producto] ASC,
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[formapago]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[formapago](
	[id_formapago] [nvarchar](4) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_formapago_id_formapago] PRIMARY KEY CLUSTERED 
(
	[id_formapago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[ingrediente]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[ingrediente](
	[id_ingrediente] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](45) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_ingrediente_id_ingrediente] PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[orden]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[orden](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[orden_producto] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_tamano] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_orden_id_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC,
	[orden_producto] ASC,
	[id_producto] ASC,
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[ordennoingrediente]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[ordennoingrediente](
	[id_pedido] [int] NOT NULL,
	[orden_producto] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_tamano] [int] NOT NULL,
 CONSTRAINT [PK_ordennoingrediente_id_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC,
	[orden_producto] ASC,
	[id_producto] ASC,
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[pagopedido]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[pagopedido](
	[id_pedido] [int] NOT NULL,
	[id_formapago] [nvarchar](4) NOT NULL,
	[valor] [decimal](10, 0) NULL,
 CONSTRAINT [PK_pagopedido_id_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC,
	[id_formapago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[pedido]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[pedido](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[codigo_cliente] [int] NOT NULL,
	[fec_pedido] [date] NOT NULL,
	[horapedido] [time](7) NOT NULL,
	[horaentrega] [time](7) NOT NULL,
	[id_tipopedido] [int] NOT NULL,
	[codigo_empleado] [int] NOT NULL,
 CONSTRAINT [PK_pedido_id_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[persona]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[persona](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [nvarchar](13) NOT NULL,
	[id_tipoid] [nvarchar](2) NOT NULL,
	[nombre] [nvarchar](15) NOT NULL,
	[apellido] [nvarchar](15) NOT NULL,
	[fec_nace] [date] NOT NULL,
	[genero] [nvarchar](1) NOT NULL,
	[email] [nvarchar](45) NOT NULL,
	[num_celular] [decimal](10, 0) NULL,
 CONSTRAINT [PK_persona_codigo] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[producto]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo] [int] NOT NULL,
	[descripcion] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_producto_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[productoingrediente]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[productoingrediente](
	[id_producto] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
 CONSTRAINT [PK_productoingrediente_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[productotamano]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[productotamano](
	[id_producto] [int] NOT NULL,
	[id_tamano] [int] NOT NULL,
	[precio] [decimal](5, 0) NOT NULL,
 CONSTRAINT [PK_productotamano_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[sucursal]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[sucursal](
	[id_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](45) NOT NULL,
	[direccion] [nvarchar](45) NOT NULL,
	[num_fijo] [bigint] NOT NULL,
	[num_celular] [decimal](10, 0) NOT NULL,
	[estado] [smallint] NOT NULL,
 CONSTRAINT [PK_sucursal_id_sucursal] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[tamano]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[tamano](
	[id_tamano] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tamano_id_tamano] PRIMARY KEY CLUSTERED 
(
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[tipoid]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[tipoid](
	[id_tipoid] [nvarchar](2) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tipoid_id_tipoid] PRIMARY KEY CLUSTERED 
(
	[id_tipoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[tipopedido]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[tipopedido](
	[id_tipopedido] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tipopedido_id_tipopedido] PRIMARY KEY CLUSTERED 
(
	[id_tipopedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GB_Sator].[tipoproducto]    Script Date: 6/10/2021 10:10:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GB_Sator].[tipoproducto](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tipoproducto_id_tipo] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [FK_SUCURSAL_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_SUCURSAL_idx] ON [GB_Sator].[carta]
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_PRODUCTOTAMANO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_PRODUCTOTAMANO_idx] ON [GB_Sator].[cartaproductos]
(
	[id_producto] ASC,
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_PRODTAMANO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_PRODTAMANO_idx] ON [GB_Sator].[orden]
(
	[id_producto] ASC,
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [FK_FORMAPAGO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_FORMAPAGO_idx] ON [GB_Sator].[pagopedido]
(
	[id_formapago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_CLIENTE_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_CLIENTE_idx] ON [GB_Sator].[pedido]
(
	[codigo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_EMPLEADO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_EMPLEADO_idx] ON [GB_Sator].[pedido]
(
	[codigo_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_TIPOPEDIDO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_TIPOPEDIDO_idx] ON [GB_Sator].[pedido]
(
	[id_tipopedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [FK_TIPOID_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_TIPOID_idx] ON [GB_Sator].[persona]
(
	[id_tipoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_TIPO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_TIPO_idx] ON [GB_Sator].[producto]
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_INGREDIENTE_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_INGREDIENTE_idx] ON [GB_Sator].[productoingrediente]
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_PRODUCTOINGREDIENTE_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_PRODUCTOINGREDIENTE_idx] ON [GB_Sator].[productoingrediente]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_PRODUCTO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_PRODUCTO_idx] ON [GB_Sator].[productotamano]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [FK_TAMANO_idx]    Script Date: 6/10/2021 10:10:29 p. m. ******/
CREATE NONCLUSTERED INDEX [FK_TAMANO_idx] ON [GB_Sator].[productotamano]
(
	[id_tamano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [GB_Sator].[cartaproductos] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [GB_Sator].[pagopedido] ADD  DEFAULT (NULL) FOR [valor]
GO
ALTER TABLE [GB_Sator].[pedido] ADD  DEFAULT (CONVERT([date],getdate())) FOR [fec_pedido]
GO
ALTER TABLE [GB_Sator].[pedido] ADD  DEFAULT (getdate()) FOR [horapedido]
GO
ALTER TABLE [GB_Sator].[pedido] ADD  DEFAULT (getdate()) FOR [horaentrega]
GO
ALTER TABLE [GB_Sator].[persona] ADD  DEFAULT (NULL) FOR [num_celular]
GO
ALTER TABLE [GB_Sator].[productotamano] ADD  DEFAULT ((0)) FOR [precio]
GO
ALTER TABLE [GB_Sator].[carta]  WITH CHECK ADD  CONSTRAINT [carta$FK_SUCURSAL] FOREIGN KEY([id_sucursal])
REFERENCES [GB_Sator].[sucursal] ([id_sucursal])
GO
ALTER TABLE [GB_Sator].[carta] CHECK CONSTRAINT [carta$FK_SUCURSAL]
GO
ALTER TABLE [GB_Sator].[cartaproductos]  WITH CHECK ADD  CONSTRAINT [cartaproductos$FK_CARTA] FOREIGN KEY([id_carta], [id_sucursal])
REFERENCES [GB_Sator].[carta] ([id_carta], [id_sucursal])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[cartaproductos] CHECK CONSTRAINT [cartaproductos$FK_CARTA]
GO
ALTER TABLE [GB_Sator].[cartaproductos]  WITH CHECK ADD  CONSTRAINT [cartaproductos$FK_PRODUCTOTAMANO] FOREIGN KEY([id_producto], [id_tamano])
REFERENCES [GB_Sator].[productotamano] ([id_producto], [id_tamano])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[cartaproductos] CHECK CONSTRAINT [cartaproductos$FK_PRODUCTOTAMANO]
GO
ALTER TABLE [GB_Sator].[orden]  WITH CHECK ADD  CONSTRAINT [orden$FK_PEDIDOORDEN] FOREIGN KEY([id_pedido])
REFERENCES [GB_Sator].[pedido] ([id_pedido])
GO
ALTER TABLE [GB_Sator].[orden] CHECK CONSTRAINT [orden$FK_PEDIDOORDEN]
GO
ALTER TABLE [GB_Sator].[orden]  WITH CHECK ADD  CONSTRAINT [orden$FK_PRODTAMANO] FOREIGN KEY([id_producto], [id_tamano])
REFERENCES [GB_Sator].[productotamano] ([id_producto], [id_tamano])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[orden] CHECK CONSTRAINT [orden$FK_PRODTAMANO]
GO
ALTER TABLE [GB_Sator].[ordennoingrediente]  WITH CHECK ADD  CONSTRAINT [ordennoingrediente$FK_ORDENNOINGRED] FOREIGN KEY([id_pedido], [orden_producto], [id_producto], [id_tamano])
REFERENCES [GB_Sator].[orden] ([id_pedido], [orden_producto], [id_producto], [id_tamano])
GO
ALTER TABLE [GB_Sator].[ordennoingrediente] CHECK CONSTRAINT [ordennoingrediente$FK_ORDENNOINGRED]
GO
ALTER TABLE [GB_Sator].[pagopedido]  WITH CHECK ADD  CONSTRAINT [pagopedido$FK_FORMAPAGO] FOREIGN KEY([id_formapago])
REFERENCES [GB_Sator].[formapago] ([id_formapago])
GO
ALTER TABLE [GB_Sator].[pagopedido] CHECK CONSTRAINT [pagopedido$FK_FORMAPAGO]
GO
ALTER TABLE [GB_Sator].[pagopedido]  WITH CHECK ADD  CONSTRAINT [pagopedido$FK_PEDIDO] FOREIGN KEY([id_pedido])
REFERENCES [GB_Sator].[pedido] ([id_pedido])
GO
ALTER TABLE [GB_Sator].[pagopedido] CHECK CONSTRAINT [pagopedido$FK_PEDIDO]
GO
ALTER TABLE [GB_Sator].[pedido]  WITH CHECK ADD  CONSTRAINT [pedido$FK_CLIENTE] FOREIGN KEY([codigo_cliente])
REFERENCES [GB_Sator].[persona] ([codigo])
GO
ALTER TABLE [GB_Sator].[pedido] CHECK CONSTRAINT [pedido$FK_CLIENTE]
GO
ALTER TABLE [GB_Sator].[pedido]  WITH CHECK ADD  CONSTRAINT [pedido$FK_EMPLEADO] FOREIGN KEY([codigo_empleado])
REFERENCES [GB_Sator].[persona] ([codigo])
GO
ALTER TABLE [GB_Sator].[pedido] CHECK CONSTRAINT [pedido$FK_EMPLEADO]
GO
ALTER TABLE [GB_Sator].[pedido]  WITH CHECK ADD  CONSTRAINT [pedido$FK_TIPOPEDIDO] FOREIGN KEY([id_tipopedido])
REFERENCES [GB_Sator].[tipopedido] ([id_tipopedido])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[pedido] CHECK CONSTRAINT [pedido$FK_TIPOPEDIDO]
GO
ALTER TABLE [GB_Sator].[persona]  WITH CHECK ADD  CONSTRAINT [persona$FK_TIPOID] FOREIGN KEY([id_tipoid])
REFERENCES [GB_Sator].[tipoid] ([id_tipoid])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[persona] CHECK CONSTRAINT [persona$FK_TIPOID]
GO
ALTER TABLE [GB_Sator].[producto]  WITH CHECK ADD  CONSTRAINT [producto$FK_TIPO] FOREIGN KEY([id_tipo])
REFERENCES [GB_Sator].[tipoproducto] ([id_tipo])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[producto] CHECK CONSTRAINT [producto$FK_TIPO]
GO
ALTER TABLE [GB_Sator].[productoingrediente]  WITH CHECK ADD  CONSTRAINT [productoingrediente$FK_INGREDIENTE] FOREIGN KEY([id_ingrediente])
REFERENCES [GB_Sator].[ingrediente] ([id_ingrediente])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[productoingrediente] CHECK CONSTRAINT [productoingrediente$FK_INGREDIENTE]
GO
ALTER TABLE [GB_Sator].[productotamano]  WITH CHECK ADD  CONSTRAINT [productotamano$FK_TAMANO] FOREIGN KEY([id_tamano])
REFERENCES [GB_Sator].[tamano] ([id_tamano])
ON UPDATE CASCADE
GO
ALTER TABLE [GB_Sator].[productotamano] CHECK CONSTRAINT [productotamano$FK_TAMANO]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.carta' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'carta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.cartaproductos' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'cartaproductos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.formapago' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'formapago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.ingrediente' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'ingrediente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.orden' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'orden'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.ordennoingrediente' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'ordennoingrediente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.pagopedido' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'pagopedido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.pedido' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'pedido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.persona' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'persona'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.producto' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.productoingrediente' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'productoingrediente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.productotamano' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'productotamano'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.sucursal' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'sucursal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.tamano' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'tamano'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.tipoid' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'tipoid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.tipopedido' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'tipopedido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GB_Sator.tipoproducto' , @level0type=N'SCHEMA',@level0name=N'GB_Sator', @level1type=N'TABLE',@level1name=N'tipoproducto'
GO
USE [master]
GO
ALTER DATABASE [GB_Sator] SET  READ_WRITE 
GO
