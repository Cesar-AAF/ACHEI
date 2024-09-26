USE [ACHEI_ORCAMENTO]
GO
SET IDENTITY_INSERT [dbo].[OrcamentoStatus] ON 

INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (1, N'Aceito')
INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (2, N'Rejeitado')
INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (3, N'Aprovado')
INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (4, N'Em Andamento')
INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (5, N'Enviado')
INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (6, N'Em Analise')
INSERT [dbo].[OrcamentoStatus] ([ID], [Status]) VALUES (7, N'Não Aprovado')
SET IDENTITY_INSERT [dbo].[OrcamentoStatus] OFF
SET IDENTITY_INSERT [dbo].[Orcamento] ON 

INSERT [dbo].[Orcamento] ([ID], [OrcamentosServicoID], [Descricao], [OrcamentoStatusID], [Valor]) VALUES (1, 1, N'a mão de obra fica 50 reais a hora, mais o material', 5, CAST(500.00 AS Numeric(10, 2)))
INSERT [dbo].[Orcamento] ([ID], [OrcamentosServicoID], [Descricao], [OrcamentoStatusID], [Valor]) VALUES (2, 2, N'mão de obra mais material', 5, CAST(2500.00 AS Numeric(10, 2)))
SET IDENTITY_INSERT [dbo].[Orcamento] OFF
