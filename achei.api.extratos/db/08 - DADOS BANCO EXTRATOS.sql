USE [ACHEI_EXTRATO]
GO

SET IDENTITY_INSERT [dbo].[Saldo] ON
INSERT [dbo].[Saldo] ([ID], [Saldo], [DataAtualizacao], [DataCriacao]) VALUES (1, CAST(250 AS Numeric(10, 0)), CAST(N'2020-05-08 15:00:00.000' AS DateTime), CAST(N'2020-05-08 00:00:00.000' AS DateTime))
INSERT [dbo].[Saldo] ([ID], [Saldo], [DataAtualizacao], [DataCriacao]) VALUES (2, CAST(0 AS Numeric(10, 0)), CAST(N'2020-05-08 00:00:00.000' AS DateTime), CAST(N'2020-05-08 00:00:00.000' AS DateTime))
INSERT [dbo].[Saldo] ([ID], [Saldo], [DataAtualizacao], [DataCriacao]) VALUES (3, CAST(0 AS Numeric(10, 0)), CAST(N'2020-05-08 00:00:00.000' AS DateTime), CAST(N'2020-05-08 00:00:00.000' AS DateTime))
INSERT [dbo].[Saldo] ([ID], [Saldo], [DataAtualizacao], [DataCriacao]) VALUES (4, CAST(0 AS Numeric(10, 0)), CAST(N'2020-05-08 00:00:00.000' AS DateTime), CAST(N'2020-05-08 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Saldo] OFF

SET IDENTITY_INSERT [dbo].[TipoOperacao] ON
INSERT [dbo].[TipoOperacao] ([ID], [Nome]) VALUES (1, N'Adição')
INSERT [dbo].[TipoOperacao] ([ID], [Nome]) VALUES (2, N'Subtração')
SET IDENTITY_INSERT [dbo].[TipoOperacao] OFF

SET IDENTITY_INSERT [dbo].[Extrato] ON 
INSERT [dbo].[Extrato] ([ID], [SaldoID], [ValorAnterior], [ValorPosterior], [ValorOperacao], [TipoOperacaoID], [DataOperacao]) VALUES (1, 1, CAST(0 AS Numeric(10, 0)), CAST(100 AS Numeric(10, 0)), CAST(100 AS Numeric(10, 0)), 1, CAST(N'2020-05-08 10:00:00.000' AS DateTime))
INSERT [dbo].[Extrato] ([ID], [SaldoID], [ValorAnterior], [ValorPosterior], [ValorOperacao], [TipoOperacaoID], [DataOperacao]) VALUES (2, 1, CAST(100 AS Numeric(10, 0)), CAST(300 AS Numeric(10, 0)), CAST(200 AS Numeric(10, 0)), 1, CAST(N'2020-05-08 13:00:00.000' AS DateTime))
INSERT [dbo].[Extrato] ([ID], [SaldoID], [ValorAnterior], [ValorPosterior], [ValorOperacao], [TipoOperacaoID], [DataOperacao]) VALUES (3, 1, CAST(300 AS Numeric(10, 0)), CAST(250 AS Numeric(10, 0)), CAST(50 AS Numeric(10, 0)), 2, CAST(N'2020-05-08 15:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Extrato] OFF
