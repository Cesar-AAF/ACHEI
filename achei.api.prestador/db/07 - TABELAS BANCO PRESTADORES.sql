USE [ACHEI_PRESTADOR]
GO
/****** Object:  Table [dbo].[Extrato]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[PrestadorServico]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PrestadorServico](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CNPJ] [varchar](15) NULL,
	[Nome] [varchar](200) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[DDD] [varchar](5) NOT NULL,
	[Telefone] [varchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[EnderecoID] [int] NULL,
	[DataCriacao] [datetime] NOT NULL,
	[Descricao] [varchar](500) NULL,
	[PrestadorServicoAvaliacaoID] [int] NOT NULL,
	[SaldoID] [int] NOT NULL,
 CONSTRAINT [PK_PrestadorServico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PrestadorServicoAvaliacao]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PrestadorServicoAvaliacao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Codigo] [int] NOT NULL,
 CONSTRAINT [PK_Avaliacao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PrestadorServicoXProfissao]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrestadorServicoXProfissao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrestadorServicoID] [int] NOT NULL,
	[ProfissaoID] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioXProfissao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PrestadorServicoXServico]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrestadorServicoXServico](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrestadorServicoID] [int] NOT NULL,
	[ServicoID] [int] NOT NULL,
 CONSTRAINT [PK_PrestadorServicoXServico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profissao]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profissao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Profissao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servico]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Servico](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[ServicoSubCategoriaID] [int] NOT NULL,
 CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServicoCategoria]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServicoCategoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
 CONSTRAINT [PK_ServicoCategoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServicoSubCategoria]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServicoSubCategoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[ServicoCategoriaID] [int] NULL,
 CONSTRAINT [PK_SubCategoriaServico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[PrestadorServico]  WITH CHECK ADD  CONSTRAINT [FK_PrestadorServico_PrestadorServicoAvaliacao] FOREIGN KEY([PrestadorServicoAvaliacaoID])
REFERENCES [dbo].[PrestadorServicoAvaliacao] ([ID])
GO
ALTER TABLE [dbo].[PrestadorServico] CHECK CONSTRAINT [FK_PrestadorServico_PrestadorServicoAvaliacao]
GO
ALTER TABLE [dbo].[PrestadorServicoXProfissao]  WITH CHECK ADD  CONSTRAINT [FK_PrestadorServicoXProfissao_PrestadorServico] FOREIGN KEY([PrestadorServicoID])
REFERENCES [dbo].[PrestadorServico] ([ID])
GO
ALTER TABLE [dbo].[PrestadorServicoXProfissao] CHECK CONSTRAINT [FK_PrestadorServicoXProfissao_PrestadorServico]
GO
ALTER TABLE [dbo].[PrestadorServicoXProfissao]  WITH CHECK ADD  CONSTRAINT [FK_PrestadorServicoXProfissao_Profissao] FOREIGN KEY([ProfissaoID])
REFERENCES [dbo].[Profissao] ([ID])
GO
ALTER TABLE [dbo].[PrestadorServicoXProfissao] CHECK CONSTRAINT [FK_PrestadorServicoXProfissao_Profissao]
GO
ALTER TABLE [dbo].[PrestadorServicoXServico]  WITH CHECK ADD  CONSTRAINT [FK_PrestadorServicoXServico_PrestadorServico] FOREIGN KEY([PrestadorServicoID])
REFERENCES [dbo].[PrestadorServico] ([ID])
GO
ALTER TABLE [dbo].[PrestadorServicoXServico] CHECK CONSTRAINT [FK_PrestadorServicoXServico_PrestadorServico]
GO
ALTER TABLE [dbo].[PrestadorServicoXServico]  WITH CHECK ADD  CONSTRAINT [FK_PrestadorServicoXServico_Servico] FOREIGN KEY([ServicoID])
REFERENCES [dbo].[Servico] ([ID])
GO
ALTER TABLE [dbo].[PrestadorServicoXServico] CHECK CONSTRAINT [FK_PrestadorServicoXServico_Servico]
GO
ALTER TABLE [dbo].[Servico]  WITH CHECK ADD  CONSTRAINT [FK_Servico_ServicoSubCategoria] FOREIGN KEY([ServicoSubCategoriaID])
REFERENCES [dbo].[ServicoSubCategoria] ([ID])
GO
ALTER TABLE [dbo].[Servico] CHECK CONSTRAINT [FK_Servico_ServicoSubCategoria]
GO
ALTER TABLE [dbo].[ServicoSubCategoria]  WITH CHECK ADD  CONSTRAINT [FK_ServicoSubCategoria_ServicoCategoria] FOREIGN KEY([ServicoCategoriaID])
REFERENCES [dbo].[ServicoCategoria] ([ID])
GO
ALTER TABLE [dbo].[ServicoSubCategoria] CHECK CONSTRAINT [FK_ServicoSubCategoria_ServicoCategoria]
GO
