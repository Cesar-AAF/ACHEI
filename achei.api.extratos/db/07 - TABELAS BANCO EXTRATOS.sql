USE [ACHEI_EXTRATO]
GO
/****** Object:  Table [dbo].[Extrato]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Extrato](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SaldoID] [int] NOT NULL,
	[ValorAnterior] [numeric](10, 0) NOT NULL,
	[ValorPosterior] [numeric](10, 0) NOT NULL,
	[ValorOperacao] [numeric](10, 0) NOT NULL,
	[TipoOperacaoID] [int] NOT NULL,
	[DataOperacao] [datetime] NOT NULL,
 CONSTRAINT [PK_Extrato] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Saldo]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saldo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Saldo] [numeric](10, 0) NOT NULL,
	[DataAtualizacao] [datetime] NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
 CONSTRAINT [PK_Saldo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoOperacao]    Script Date: 11/08/2020 10:16:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoOperacao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](25) NOT NULL,
 CONSTRAINT [PK_TipoOperacao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Extrato]  WITH CHECK ADD  CONSTRAINT [FK_Extrato_Saldo] FOREIGN KEY([SaldoID])
REFERENCES [dbo].[Saldo] ([ID])
GO
ALTER TABLE [dbo].[Extrato] CHECK CONSTRAINT [FK_Extrato_Saldo]
GO
ALTER TABLE [dbo].[Extrato]  WITH CHECK ADD  CONSTRAINT [FK_Extrato_TipoOperacao] FOREIGN KEY([TipoOperacaoID])
REFERENCES [dbo].[TipoOperacao] ([ID])
GO
ALTER TABLE [dbo].[Extrato] CHECK CONSTRAINT [FK_Extrato_TipoOperacao]
GO
