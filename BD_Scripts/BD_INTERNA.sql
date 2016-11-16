/*
Navicat SQL Server Data Transfer

Source Server         : SQL Server (serv-55)
Source Server Version : 105000
Source Host           : serv-55:1433
Source Database       : BD_INTERNA
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2016-11-16 12:07:34
*/


-- ----------------------------
-- Table structure for LOG_RegistroError
-- ----------------------------
DROP TABLE [LOG_RegistroError]
GO
CREATE TABLE [LOG_RegistroError] (
[Validacion_key] varchar(50) NOT NULL ,
[Codigo] varchar(20) NOT NULL ,
[Descripcion] varchar(500) NOT NULL ,
[Regla] varchar(500) NULL 
)


GO

-- ----------------------------
-- Records of LOG_RegistroError
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [LOG_RegistroError] ([Validacion_key], [Codigo], [Descripcion], [Regla]) VALUES (N'SC_DATOSARIESGO', N'SC101000001', N'Cantidad trabajadores de empresa es null', N'Antiguedad_en_meses is null'), (N'SC_DATOSARIESGO', N'SC101000002', N'Capital adeudado con valor negativo', N'Capital_adeudado < 0'), (N'SC_DATOSARIESGO', N'SC101000003', N'Total de Afiliados nulo', N'total_de_afiliados is null')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for LOG_SeguimientoError
-- ----------------------------
DROP TABLE [LOG_SeguimientoError]
GO
CREATE TABLE [LOG_SeguimientoError] (
[Validacion_key] varchar(50) NOT NULL ,
[FechaHora] datetime NOT NULL ,
[Codigo] varchar(20) NOT NULL ,
[Descripcion] varchar(500) NOT NULL 
)


GO

-- ----------------------------
-- Records of LOG_SeguimientoError
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [LOG_SeguimientoError] ([Validacion_key], [FechaHora], [Codigo], [Descripcion]) VALUES (N'SC_DATOSARIESGO', N'2016-09-09 15:10:58.887', N'SC101000003', N'Total de Afiliados nulo')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for LOG_Validacion
-- ----------------------------
DROP TABLE [LOG_Validacion]
GO
CREATE TABLE [LOG_Validacion] (
[Validacion_key] varchar(50) NOT NULL ,
[Nombre] varchar(255) NOT NULL ,
[Consulta_validatoria] varchar(500) NOT NULL 
)


GO

-- ----------------------------
-- Records of LOG_Validacion
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [LOG_Validacion] ([Validacion_key], [Nombre], [Consulta_validatoria]) VALUES (N'SC_DATOSARIESGO', N'Validar datos antes de enviar a riesgo', N'select * from BD_CAMPANIAS..TabCmp_PreAprobadosAntesRiesgo')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_Grupo
-- ----------------------------
DROP TABLE [SCA_Grupo]
GO
CREATE TABLE [SCA_Grupo] (
[grp_id] int NOT NULL IDENTITY(1,1) ,
[grp_nombre] varchar(500) NULL ,
[grp_sistema] int NULL 
)


GO
DBCC CHECKIDENT(N'[SCA_Grupo]', RESEED, 4)
GO

-- ----------------------------
-- Records of SCA_Grupo
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [SCA_Grupo] ON
GO
INSERT INTO [SCA_Grupo] ([grp_id], [grp_nombre], [grp_sistema]) VALUES (N'1', N'SuperAdmins', N'0'), (N'2', N'Directorio', N'1'), (N'3', N'Gerencia General', N'1'), (N'4', N'Genericos (privilegios minimos)', N'1')
GO
GO
SET IDENTITY_INSERT [SCA_Grupo] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_GruposDeUsuario
-- ----------------------------
DROP TABLE [SCA_GruposDeUsuario]
GO
CREATE TABLE [SCA_GruposDeUsuario] (
[gus_id_usuario] varchar(50) NULL ,
[gus_id_grupo] int NULL 
)


GO

-- ----------------------------
-- Records of SCA_GruposDeUsuario
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [SCA_GruposDeUsuario] ([gus_id_usuario], [gus_id_grupo]) VALUES (N'Sadmin', N'1'), (N'17042783-1', N'1'), (N'17337576-6', N'2')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_Recurso
-- ----------------------------
DROP TABLE [SCA_Recurso]
GO
CREATE TABLE [SCA_Recurso] (
[rec_id] int NOT NULL IDENTITY(1,1) ,
[rec_id_padre] int NULL ,
[rec_tipo] varchar(10) NULL ,
[rec_nombre] varchar(500) NULL ,
[rec_url] varchar(500) NULL ,
[rec_icono] varchar(300) NULL ,
[rec_orden] int NULL 
)


GO
DBCC CHECKIDENT(N'[SCA_Recurso]', RESEED, 7)
GO

-- ----------------------------
-- Records of SCA_Recurso
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [SCA_Recurso] ON
GO
INSERT INTO [SCA_Recurso] ([rec_id], [rec_id_padre], [rec_tipo], [rec_nombre], [rec_url], [rec_icono], [rec_orden]) VALUES (N'1', null, N'ENC', N'Inicio', N'DirectorioReportal/Home', N'demo-psi-home', N'1'), (N'2', null, N'ENC', N'Crédito', N'#', N'fa fa-credit-card', N'2'), (N'3', N'2', N'LNK', N'Presupuesto', N'DirectorioReportal/Credito/Presupuesto', null, N'3'), (N'4', N'2', N'LNK', N'Colocación', N'DirectorioReportal/Colocacion/Colocaciones', null, N'4'), (N'5', N'2', N'LNK', N'Financiamento', N'DirectorioReportal/Financiamento', null, N'5'), (N'6', null, N'ENC', N'Campañas', N'#', N'fa fa-bullhorn', N'6'), (N'7', N'6', N'LNK', N'Seg. Pre Aprobados', N'DirectorioReportal/SeguimientoPreaprobados', null, N'7')
GO
GO
SET IDENTITY_INSERT [SCA_Recurso] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_Sistema
-- ----------------------------
DROP TABLE [SCA_Sistema]
GO
CREATE TABLE [SCA_Sistema] (
[sis_id] int NOT NULL IDENTITY(1,1) ,
[sis_nombre] varchar(500) NULL 
)


GO

-- ----------------------------
-- Records of SCA_Sistema
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [SCA_Sistema] ON
GO
INSERT INTO [SCA_Sistema] ([sis_id], [sis_nombre]) VALUES (N'1', N'Reportes Unificados')
GO
GO
SET IDENTITY_INSERT [SCA_Sistema] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_Tokens
-- ----------------------------
DROP TABLE [SCA_Tokens]
GO
CREATE TABLE [SCA_Tokens] (
[TokenId] int NOT NULL IDENTITY(1,1) ,
[UserId] varchar(20) NULL ,
[AuthToken] nvarchar(250) NOT NULL ,
[IssuedOn] datetime NOT NULL ,
[ExpiresOn] datetime NOT NULL 
)


GO
DBCC CHECKIDENT(N'[SCA_Tokens]', RESEED, 28)
GO

-- ----------------------------
-- Records of SCA_Tokens
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [SCA_Tokens] ON
GO
INSERT INTO [SCA_Tokens] ([TokenId], [UserId], [AuthToken], [IssuedOn], [ExpiresOn]) VALUES (N'1', N'17042783-1', N'7391a8a4-6821-4250-a574-d938b391d1b0', N'2016-11-15 12:53:19.747', N'2016-11-15 13:08:19.747'), (N'2', N'17042783-1', N'735e3d49-c2d2-4d77-bfb5-40605ad86444', N'2016-11-15 12:56:06.560', N'2016-11-15 13:26:06.560'), (N'3', N'17042783-1', N'15e941e4-7f58-414f-88d5-334f7d3d64d6', N'2016-11-15 13:03:23.683', N'2016-11-15 13:33:23.683'), (N'4', N'17042783-1', N'04d08b0f-2144-4b71-8719-e29665f9dae7', N'2016-11-15 13:44:54.477', N'2016-11-15 14:29:54.477'), (N'5', N'17042783-1', N'39d0a921-31ce-486d-a23c-01d72482d66d', N'2016-11-15 13:45:20.330', N'2016-11-15 14:30:20.330'), (N'6', N'17042783-1', N'9f9b7565-ae86-4036-9f0e-4c7ca63c1058', N'2016-11-15 13:48:47.497', N'2016-11-15 16:18:47.497'), (N'7', N'17042783-1', N'51068b11-ad43-4b82-a825-25d78c5f997f', N'2016-11-15 14:27:48.010', N'2016-11-15 14:42:48.010'), (N'8', N'17042783-1', N'f39e72ac-0f04-4845-8ba0-a351103795c9', N'2016-11-15 14:29:02.710', N'2016-11-15 21:44:02.710'), (N'9', N'17337576-6', N'847dbd61-aa54-427b-bf34-01081d58511f', N'2016-11-15 15:43:26.087', N'2016-11-15 15:58:26.087'), (N'10', N'17337576-6', N'1febb2f3-b2f1-4df3-846a-995a4906d568', N'2016-11-15 15:44:06.637', N'2016-11-15 15:59:06.637'), (N'11', N'17042783-1', N'fbf88808-4a34-4534-a74b-69f495e0004e', N'2016-11-15 15:47:49.537', N'2016-11-15 16:02:49.537'), (N'12', N'17042783-1', N'1ddbe1e8-fd4b-429b-b930-f5d3eabdd708', N'2016-11-15 15:49:13.753', N'2016-11-15 16:04:13.753'), (N'13', N'17042783-1', N'e0623256-6567-4e7f-ae5f-89bd713c9671', N'2016-11-15 15:49:35.213', N'2016-11-15 16:04:35.213'), (N'14', N'17042783-1', N'095039d5-7c4d-42c8-ab23-f54cbeb6833c', N'2016-11-15 15:51:10.083', N'2016-11-15 18:06:10.083'), (N'15', N'17042783-1', N'bbbd8498-d94a-4950-a9c9-540dd9892f6b', N'2016-11-15 16:04:13.150', N'2016-11-15 16:49:13.150'), (N'16', N'17042783-1', N'761e72ad-c745-4322-874c-b6c67201a7ba', N'2016-11-15 16:06:57.493', N'2016-11-15 16:51:57.493'), (N'17', N'17042783-1', N'37c586b7-52d1-4349-a57e-a32a8e232442', N'2016-11-15 16:08:52.013', N'2016-11-15 16:23:52.013'), (N'18', N'17042783-1', N'995ed398-4c68-4701-811b-6f264c42aa5d', N'2016-11-15 16:09:44.600', N'2016-11-15 16:54:44.600'), (N'19', N'17042783-1', N'dccce821-d994-44fe-9a12-55fa569995c3', N'2016-11-15 16:10:34.607', N'2016-11-15 16:55:34.607'), (N'20', N'17042783-1', N'13221bb2-52c5-4c6e-b952-0546a738098e', N'2016-11-15 16:14:38.360', N'2016-11-15 19:14:38.360'), (N'21', N'17042783-1', N'a434d828-cbe9-4381-aec3-22fcb7dedb94', N'2016-11-15 16:20:54.633', N'2016-11-15 17:20:54.633'), (N'22', N'17042783-1', N'f4b26f7f-a662-4d1b-9848-08f770022927', N'2016-11-15 16:24:25.590', N'2016-11-15 17:09:25.590'), (N'24', N'17337576-6', N'2ad2f5a6-cbeb-4d5b-be95-086cb8756787', N'2016-11-15 17:15:11.397', N'2016-11-15 18:45:11.397'), (N'25', N'17337578-6', N'55977ba5-26e5-4d48-8889-ff8b429334a7', N'2016-11-15 17:19:30.080', N'2016-11-15 17:49:30.080'), (N'28', N'17042783-1', N'8dc23d33-2704-45cc-9a38-2e4cbee460a8', N'2016-11-15 17:53:55.300', N'2016-11-16 08:38:55.300')
GO
GO
SET IDENTITY_INSERT [SCA_Tokens] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_UsoRecurso
-- ----------------------------
DROP TABLE [SCA_UsoRecurso]
GO
CREATE TABLE [SCA_UsoRecurso] (
[ure_id_recurso] int NOT NULL ,
[ure_id_grupo] int NOT NULL 
)


GO

-- ----------------------------
-- Records of SCA_UsoRecurso
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [SCA_UsoRecurso] ([ure_id_recurso], [ure_id_grupo]) VALUES (N'1', N'1'), (N'1', N'2'), (N'3', N'1'), (N'4', N'1'), (N'5', N'1'), (N'7', N'1')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for SCA_Usuario
-- ----------------------------
DROP TABLE [SCA_Usuario]
GO
CREATE TABLE [SCA_Usuario] (
[usr_id] varchar(50) NOT NULL ,
[usr_nombres] varchar(500) NULL ,
[usr_clave] varchar(500) NULL ,
[usr_estado] varchar(10) NULL 
)


GO

-- ----------------------------
-- Records of SCA_Usuario
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [SCA_Usuario] ([usr_id], [usr_nombres], [usr_clave], [usr_estado]) VALUES (N'Sadmin', N'Administrador', N'0A914CA359365C263653767E97D07CA2', N'ALTA'), (N'17042783-1', N'Carlos Pradenas', N'827CCB0EEA8A706C4C34A16891F84E7B', N'ALTA'), (N'17337578-6', N'Cristian Muñoz', N'827CCB0EEA8A706C4C34A16891F84E7B', N'ALTA')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Procedure structure for sp_GenerarExcel
-- ----------------------------
DROP PROCEDURE [sp_GenerarExcel]
GO
create procedure [sp_GenerarExcel]
(
    @db_name    varchar(100),
    @table_name varchar(100),   
    @file_name  varchar(100)
)
as

--Generate column names as a recordset
declare @columns varchar(8000), @sql varchar(8000), @data_file varchar(100)
select 
    @columns=coalesce(@columns+',','')+column_name+' as '+column_name 
from 
    information_schema.columns
where 
    table_name=@table_name
select @columns=''''''+replace(replace(@columns,' as ',''''' as '),',',',''''')

--Create a dummy file to have actual data
select @data_file=substring(@file_name,1,len(@file_name)-charindex('\',reverse(@file_name)))+'\data_file.xls'

--Generate column names in the passed EXCEL file
set @sql='exec master..xp_cmdshell ''bcp " select * from (select '+@columns+') as t" queryout "'+@file_name+'" -c'''
exec(@sql)

--Generate data in the dummy file
set @sql='exec master..xp_cmdshell ''bcp "select * from '+@db_name+'..'+@table_name+'" queryout "'+@data_file+'" -c'''
exec(@sql)

--Copy dummy file to passed EXCEL file
set @sql= 'exec master..xp_cmdshell ''type '+@data_file+' >> "'+@file_name+'"'''
exec(@sql)

--Delete dummy file 
set @sql= 'exec master..xp_cmdshell ''del '+@data_file+''''
exec(@sql)
GO

-- ----------------------------
-- Procedure structure for sp_SCA_ActualizaDatosToken
-- ----------------------------
DROP PROCEDURE [sp_SCA_ActualizaDatosToken]
GO
CREATE PROCEDURE [sp_SCA_ActualizaDatosToken]
	@TokenId INT,
	@UserId VARCHAR(20),
  @AuthToken VARCHAR(200),
	@IssuedOn DATETIME,
	@ExpiresOn DATETIME

AS
BEGIN
  -- routine body goes here, e.g.
  -- SELECT 'Navicat for SQL Server'
	UPDATE [BD_INTERNA].[dbo].[SCA_Tokens] 
	SET [UserId] = @UserId, 
			[AuthToken] = @AuthToken, 
			[IssuedOn] = @IssuedOn, 
			[ExpiresOn] = @ExpiresOn
	WHERE TokenId = @TokenId
		
END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_DatosToken
-- ----------------------------
DROP PROCEDURE [sp_SCA_DatosToken]
GO
CREATE PROCEDURE [sp_SCA_DatosToken]
	@AuthToken VARCHAR(300)
AS
BEGIN
  -- routine body goes here, e.g.
  -- SELECT 'Navicat for SQL Server'
	SELECT * 
	FROM SCA_Tokens
	WHERE AuthToken = @AuthToken;

END
GO

-- ----------------------------
-- Procedure structure for sp_SCA_EliminaToken
-- ----------------------------
DROP PROCEDURE [sp_SCA_EliminaToken]
GO
CREATE PROCEDURE [sp_SCA_EliminaToken]
	@AuthToken VARCHAR(200)

AS
BEGIN
  -- routine body goes here, e.g.
  -- SELECT 'Navicat for SQL Server'
	DELETE FROM [BD_INTERNA].[dbo].[SCA_Tokens] 
	WHERE AuthToken = @AuthToken
		
END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_EliminaTokenByUsuario
-- ----------------------------
DROP PROCEDURE [sp_SCA_EliminaTokenByUsuario]
GO
CREATE PROCEDURE [sp_SCA_EliminaTokenByUsuario]
	@UserID VARCHAR(20)

AS
BEGIN
  -- routine body goes here, e.g.
  -- SELECT 'Navicat for SQL Server'
	DELETE FROM [BD_INTERNA].[dbo].[SCA_Tokens] 
	WHERE UserId = @UserID
		
END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_InsertDatosToken
-- ----------------------------
DROP PROCEDURE [sp_SCA_InsertDatosToken]
GO
CREATE PROCEDURE [sp_SCA_InsertDatosToken]
	@UserId VARCHAR(20),
  @AuthToken VARCHAR(200),
	@IssuedOn DATETIME,
	@ExpiresOn DATETIME

	
AS
BEGIN
  -- routine body goes here, e.g.
  -- SELECT 'Navicat for SQL Server'
	INSERT INTO [BD_INTERNA].[dbo].[SCA_Tokens] ([UserId], [AuthToken], [IssuedOn], [ExpiresOn]) 
	VALUES (@UserId, @AuthToken, @IssuedOn, @ExpiresOn)
		
END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_ListarRecursos
-- ----------------------------
DROP PROCEDURE [sp_SCA_ListarRecursos]
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [sp_SCA_ListarRecursos]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * 
	from SCA_Recurso

END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_ListarRecursosDeUsuario
-- ----------------------------
DROP PROCEDURE [sp_SCA_ListarRecursosDeUsuario]
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [sp_SCA_ListarRecursosDeUsuario]
	@AuthToken varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    WITH CTE_Recurso  (rec_id, rec_id_padre, rec_tipo, rec_nombre, rec_icono, rec_url, rec_orden, rec_level)
	 AS 
	(

		select d.rec_id, d.rec_id_padre, d.rec_tipo, d.rec_nombre, d.rec_icono, d.rec_url, d.rec_orden, 0 rec_level 
		from SCA_Usuario a
		inner join SCA_GruposDeUsuario b ON a.usr_id = b.gus_id_usuario
		inner join SCA_UsoRecurso c ON b.gus_id_grupo = c.ure_id_grupo
		inner join SCA_Recurso d ON c.ure_id_recurso = d.rec_id
		INNER JOIN SCA_Tokens tk ON tk.UserId = a.usr_id
		where tk.AuthToken = @AuthToken

		union ALL

		select x.rec_id, x.rec_id_padre, x.rec_tipo, x.rec_nombre, x.rec_icono, x.rec_url, x.rec_orden, rec_level + 1
		from SCA_Recurso x
		inner join CTE_Recurso rc on rc.rec_id_padre = x.rec_id
	
	)


	SELECT distinct * 
	FROM CTE_Recurso
	order by rec_orden


END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_ListarUsuarios
-- ----------------------------
DROP PROCEDURE [sp_SCA_ListarUsuarios]
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [sp_SCA_ListarUsuarios]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * 
	FROM SCA_Usuario

END

GO

-- ----------------------------
-- Procedure structure for sp_SCA_ObtenerUsuario
-- ----------------------------
DROP PROCEDURE [sp_SCA_ObtenerUsuario]
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [sp_SCA_ObtenerUsuario]
	@IdUsuario VARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET LANGUAGE spanish;

	SELECT * 
	FROM SCA_Usuario
	WHERE usr_id = @IdUsuario

END

GO

-- ----------------------------
-- Procedure structure for spLOG_EjecutarValidacion
-- ----------------------------
DROP PROCEDURE [spLOG_EjecutarValidacion]
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [spLOG_EjecutarValidacion]
	
	@Validacion_key VARCHAR(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	DECLARE @Consulta_Valida NVARCHAR(500)
	DECLARE @Consulta_final NVARCHAR(500)
	
	DECLARE @ValiCodigo NVARCHAR(50)
	DECLARE @ValiDesc NVARCHAR(500)
	DECLARE @ValiRegla NVARCHAR(500)
	DECLARE @ResultCountConsul INT;

	DECLARE cValidaciones CURSOR LOCAL FOR
		SELECT  Codigo, Descripcion,Regla
		FROM  LOG_RegistroError
		WHERE Validacion_key = @Validacion_key;
	
	SELECT @Consulta_Valida = Consulta_validatoria
	FROM BD_INTERNA..LOG_Validacion
	WHERE Validacion_key = @Validacion_key
    
	IF @Consulta_Valida is null or @Consulta_Valida = '' 
	BEGIN
		PRINT N'Codigo de validacion no valido'
	END
	ELSE 
	BEGIN
		

		OPEN cValidaciones
		FETCH cValidaciones 
		INTO @ValiCodigo, @ValiDesc, @ValiRegla

		WHILE (@@FETCH_STATUS = 0 )
		BEGIN
			SET @Consulta_final =''
			/*Si la consulta validatoria no tiene where: se agrega uno por defecto con una logica verdadera*/
			IF ( CHARINDEX('where', LOWER(@Consulta_Valida)) <= 0)
			BEGIN
				 SET @Consulta_final = @Consulta_Valida + ' WHERE 1=1';
			END
			ELSE
			BEGIN
				SET @Consulta_final = @Consulta_Valida;
			END


			SET @Consulta_final = 'select @Salida=count(*) from (' + @Consulta_final + ' and ' + @ValiRegla + ') T'
			
			PRINT @Consulta_final
			EXECUTE sp_executesql  @Consulta_final, N'@Salida INT OUTPUT', @Salida = @ResultCountConsul OUTPUT

			IF (@ResultCountConsul > 0)
			BEGIN
				INSERT INTO LOG_SeguimientoError VALUES (@Validacion_key,GETDATE(), @ValiCodigo, @ValiDesc);
			END


			FETCH cValidaciones 
			INTO  @ValiCodigo, @ValiDesc, @ValiRegla
		END
		CLOSE cValidaciones
		DEALLOCATE cValidaciones

	END

END

GO

-- ----------------------------
-- Function structure for Format
-- ----------------------------
DROP FUNCTION [Format]
GO
CREATE FUNCTION [Format](@num int)
returns varChar(30)
As
Begin
Declare @out varChar(30) = ''

  while @num > 0 Begin
      Set @out = str(@num % 1000, 3, 0) + Coalesce(','+@out, '')
      Set @num = @num / 1000
  End
  Return @out
End
GO

-- ----------------------------
-- Function structure for ObtenerDigitoVerificador
-- ----------------------------
DROP FUNCTION [ObtenerDigitoVerificador]
GO
CREATE  FUNCTION [ObtenerDigitoVerificador]
(
	@rut INTEGER
 )
 RETURNS VARCHAR(1)

 AS
 BEGIN

 DECLARE @dv VARCHAR(1)
 DECLARE @rutAux INTEGER
 DECLARE @Digito INTEGER
 DECLARE @Contador INTEGER
 DECLARE @Multiplo INTEGER
 DECLARE @Acumulador INTEGER


 SET @Contador = 2;
 SET @Acumulador = 0;
 SET @Multiplo = 0;

	WHILE(@rut!=0)
		BEGIN

			SET @Multiplo = (@rut % 10) * @Contador;
			SET @Acumulador = @Acumulador + @Multiplo;
			SET @rut = @rut / 10;
			SET @Contador = @Contador + 1;
			if(@Contador = 8)
			BEGIN
				SET @Contador = 2;
			End;
		END;

	SET @Digito = 11 - (@Acumulador % 11);

	SET @dv = LTRIM(RTRIM(CONVERT(VARCHAR(2),@Digito)));

	IF(@Digito = 10)
	BEGIN
		SET @dv = 'K';
	END;

	IF(@Digito = 11)
	BEGIN
		SET @dv = '0';
	END;

RETURN @dv

END


GO

-- ----------------------------
-- Indexes structure for table LOG_RegistroError
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table LOG_RegistroError
-- ----------------------------
ALTER TABLE [LOG_RegistroError] ADD PRIMARY KEY ([Codigo])
GO

-- ----------------------------
-- Indexes structure for table SCA_Grupo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SCA_Grupo
-- ----------------------------
ALTER TABLE [SCA_Grupo] ADD PRIMARY KEY ([grp_id])
GO

-- ----------------------------
-- Indexes structure for table SCA_Recurso
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SCA_Recurso
-- ----------------------------
ALTER TABLE [SCA_Recurso] ADD PRIMARY KEY ([rec_id])
GO

-- ----------------------------
-- Indexes structure for table SCA_Sistema
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SCA_Sistema
-- ----------------------------
ALTER TABLE [SCA_Sistema] ADD PRIMARY KEY ([sis_id])
GO

-- ----------------------------
-- Indexes structure for table SCA_Tokens
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SCA_Tokens
-- ----------------------------
ALTER TABLE [SCA_Tokens] ADD PRIMARY KEY ([TokenId])
GO

-- ----------------------------
-- Indexes structure for table SCA_UsoRecurso
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SCA_UsoRecurso
-- ----------------------------
ALTER TABLE [SCA_UsoRecurso] ADD PRIMARY KEY ([ure_id_recurso], [ure_id_grupo])
GO
