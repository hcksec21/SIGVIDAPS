-- NIVELES
INSERT INTO [dbo].[NIVEL]([COD_NIVEL],[NIVEL])VALUES ('PRIMER NIVEL', 1);
INSERT INTO [dbo].[NIVEL]([COD_NIVEL],[NIVEL])VALUES ('SEGUNDO NIVEL', 2);

--CARGOS
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[NOMCARGO], [ESTCARGO]) VALUES (1 ,'JEFE TÉCNICO DE ÁREA', 1);
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[NOMCARGO], [ESTCARGO]) VALUES (2 ,'CÓDIGO DE TRABAJO', 1);
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[NOMCARGO], [ESTCARGO]) VALUES (2 ,'SERVIDOR PÚBLICO 1', 1);
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[NOMCARGO], [ESTCARGO]) VALUES (2 ,'SERVIDOR PÚBLICO 4', 1);
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[NOMCARGO], [ESTCARGO]) VALUES (2 ,'SERVIDOR PÚBLICO 7', 1);

--PERFILES
INSERT INTO [dbo].[PERFIL]([NOMBREPERFIL])VALUES('Lider Administrativo');
INSERT INTO [dbo].[PERFIL]([NOMBREPERFIL])VALUES('Asistente Administrativo');
INSERT INTO [dbo].[PERFIL]([NOMBREPERFIL])VALUES('Director Administrativo');
INSERT INTO [dbo].[PERFIL]([NOMBREPERFIL])VALUES('Administrador');

--Menu PerFiles
USE [SIGVIDAPS]
GO

INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(1,'mnuAprobarFormularioAnticipo');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(1,'mnuAprobarFormularioLiquidacion');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(1,'mnuEmpleados');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(1,'mnuAdministracion');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(2,'mnuFormularios');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(3,'mnuEmpleados');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(3,'mnuAdministracion');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(3,'mnuRegistrarFormularioAnticipo');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(3,'mnuRegistrarFormularioLiquidación');
INSERT INTO [dbo].[MENU_PERFIL]([IDPERFIL],[MENUPERFIL])VALUES(3,'mnuEditarFormularioLiquidación');


--RUTAS
USE [SIGVIDAPS]
GO
INSERT INTO [dbo].[RUTA]([LUGARSALIDA],[LUGARLLEGADA],[CODRUTA], [ESTRUTA]) VALUES ('QUITO' ,'TABABELA','QUI-TAB', 1);
INSERT INTO [dbo].[RUTA]([LUGARSALIDA],[LUGARLLEGADA],[CODRUTA], [ESTRUTA]) VALUES ('TABABELA' ,'QUITO','TAB-QUI', 1);
INSERT INTO [dbo].[RUTA]([LUGARSALIDA],[LUGARLLEGADA],[CODRUTA], [ESTRUTA]) VALUES ('QUITO' ,'LOJA','QUI-LOJ', 1);
GO


--Combinaciones de Tipos de Viáticos
USE [SIGVIDAPS]
GO

INSERT INTO [dbo].[COMBINACION_VIATICOS]([NOMCOMBINACION]) VALUES('Subsistencia');
INSERT INTO [dbo].[COMBINACION_VIATICOS]([NOMCOMBINACION]) VALUES('Subsistencia+Movilización');
INSERT INTO [dbo].[COMBINACION_VIATICOS]([NOMCOMBINACION]) VALUES('Viático+Subsistencia');
INSERT INTO [dbo].[COMBINACION_VIATICOS]([NOMCOMBINACION]) VALUES('Viático+Subsistencia+Movilizción');
INSERT INTO [dbo].[COMBINACION_VIATICOS]([NOMCOMBINACION]) VALUES('Alimentación');
INSERT INTO [dbo].[COMBINACION_VIATICOS]([NOMCOMBINACION]) VALUES('Alimentación+Movilización');

--Empleado
INSERT INTO [dbo].[EMPLEADO]([IDCARGO],[CEDULAEMP],[NOMBREEMP],[APELLIDOEMP],[DIREMP],[TELEMP],[ESTEMP])VALUES(1,'0603938176'
           ,'Sebastian','Avalos','10 de Agosto','032941780',1);

--Usuario
INSERT INTO [dbo].[USUARIO]([IDEMP],[IDPERFIL],[NOMBREUSUARIO] ,[CONTRASENAUSUARIO],[ESTUSUARIO]) VALUES(1,1,'sebas1208',
  'DDzv3KLT5G+2xsf+FA3sEdykZTtz9w==',1)

--Tipos de Transporte
INSERT INTO [dbo].[TIPO_TRANSPORTE]([TIPOTRANSPORTE])VALUES('Taxi');
INSERT INTO [dbo].[TIPO_TRANSPORTE]([TIPOTRANSPORTE])VALUES('Transporte Interprovincial');
INSERT INTO [dbo].[TIPO_TRANSPORTE]([TIPOTRANSPORTE])VALUES('Transporte SIGTIERRAS');
INSERT INTO [dbo].[TIPO_TRANSPORTE]([TIPOTRANSPORTE])VALUES('Transporte Aereo');

--Tipo de Viaticos
INSERT INTO [dbo].[OPCIONES_VIATICOS]
           ([NOMBREOPCION])
     VALUES
           ('Viático');

INSERT INTO [dbo].[OPCIONES_VIATICOS]
           ([NOMBREOPCION])
     VALUES
           ('Subsistencia');


INSERT INTO [dbo].[OPCIONES_VIATICOS]
           ([NOMBREOPCION])
     VALUES
           ('Alimentación');


INSERT INTO [dbo].[OPCIONES_VIATICOS]
           ([NOMBREOPCION])
     VALUES
           ('Movilización');

--Opcion_Nivel Viatico
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (1
           ,1
           ,130.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (1
           ,2
           ,80.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (2
           ,1
           ,65.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (2
           ,2
           ,40.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (3
           ,1
           ,4.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (3
           ,2
           ,4.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (4
           ,1
           ,16.00)
INSERT INTO [dbo].[OPCION_NIVEL]
           ([IDOPCION]
           ,[IDNIVEL]
           ,[VALOROPCION])
     VALUES
           (4
           ,1
           ,16.00)