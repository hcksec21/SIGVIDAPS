-- NIVELES
INSERT INTO [dbo].[NIVEL]([COD_NIVEL],[NIVEL])VALUES ('NIV1', 1);
INSERT INTO [dbo].[NIVEL]([COD_NIVEL],[NIVEL])VALUES ('NIV2', 2);

--CARGOS
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[CODCARGO] ,[NOMCARGO]) VALUES (1 ,'JFA' ,'JEFE TÉCNICO DE ÁREA');
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[CODCARGO] ,[NOMCARGO]) VALUES (2 ,'CT' ,'CÓDIGO DE TRABAJO');
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[CODCARGO] ,[NOMCARGO]) VALUES (2 ,'SP1' ,'SERVIDOR PÚBLICO 1');
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[CODCARGO] ,[NOMCARGO]) VALUES (2 ,'SP4' ,'SERVIDOR PÚBLICO 4');
INSERT INTO [dbo].[CARGO]([IDNIVEL] ,[CODCARGO] ,[NOMCARGO]) VALUES (2 ,'SP7' ,'SERVIDOR PÚBLICO 7');