USE [ACHEI_ORCAMENTO]
GO
/****** Object:  Table [dbo].[Orcamento]    Script Date: 11/08/2020 10:12:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orcamento](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrcamentosServicoID] [int] NOT NULL,
	[Descricao] [varchar](250) NOT NULL,
	[OrcamentoStatusID] [int] NOT NULL,
	[Valor] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_Orcamento] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrcamentoStatus]    Script Date: 11/08/2020 10:12:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrcamentoStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_OrcamentoStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Orcamento]  WITH CHECK ADD  CONSTRAINT [FK_Orcamento_OrcamentoStatus] FOREIGN KEY([OrcamentoStatusID])
REFERENCES [dbo].[OrcamentoStatus] ([ID])
GO
ALTER TABLE [dbo].[Orcamento] CHECK CONSTRAINT [FK_Orcamento_OrcamentoStatus]
GO
