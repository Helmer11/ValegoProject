USE [ValegoDB]
GO
/****** Object:  Table [dbo].[NetWork]    Script Date: 4/14/2023 3:18:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NetWork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Network_Name] [varchar](50) NOT NULL,
	[_Name] [varchar](50) NOT NULL,
	[Currency] [varchar](50) NULL,
	[NetworkSymbol] [varchar](50) NOT NULL,
	[TransactionExplorer] [varchar](500) NULL,
	[TokenExplorer] [varchar](500) NULL,
	[DepositConfirmations] [int] NOT NULL,
	[_Enabled] [bit] NOT NULL,
 CONSTRAINT [PK__NetWork__3214EC075397EA8A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Redes]    Script Date: 4/14/2023 3:18:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Redes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Asset] [varchar](30) NOT NULL,
	[TokenAddress] [varchar](100) NULL,
	[DepositEnabled] [bit] NOT NULL,
	[WithdrawalEnabled] [bit] NOT NULL,
	[withdrawalFee] [int] NOT NULL,
	[MinFee] [int] NOT NULL,
	[maxFee] [int] NOT NULL,
 CONSTRAINT [PK__Networks__3214EC0737A4BE46] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wallet]    Script Date: 4/14/2023 3:18:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wallet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Asset] [varchar](30) NOT NULL,
	[Currency] [varchar](50) NOT NULL,
	[MajorCurrency] [varchar](50) NOT NULL,
	[_Name] [varchar](20) NOT NULL,
	[CuurencyType] [varchar](30) NOT NULL,
	[Scala] [tinyint] NOT NULL,
	[_Enable] [bit] NOT NULL,
	[IsMarginCurrency] [bit] NULL,
	[MinDepositAmount] [int] NOT NULL,
	[MinWithdrawalAmount] [int] NOT NULL,
	[MaxWithdrawalAmount] [int] NOT NULL,
	[NetworksId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NetWork] ON 

INSERT [dbo].[NetWork] ([Id], [Network_Name], [_Name], [Currency], [NetworkSymbol], [TransactionExplorer], [TokenExplorer], [DepositConfirmations], [_Enabled]) VALUES (4, N'btc', N'Bitcoin', N'', N'XBt       ', N'https://blockstream.info/tx/{}', N'https://etherscan.io/token/{}', 12, 1)
INSERT [dbo].[NetWork] ([Id], [Network_Name], [_Name], [Currency], [NetworkSymbol], [TransactionExplorer], [TokenExplorer], [DepositConfirmations], [_Enabled]) VALUES (5, N'btc', N'Bitcoin', N'Gwei', N'XBt       ', N'https://blockstream.info/tx/{}', N'https://etherscan.io/token/{}', 12, 1)
INSERT [dbo].[NetWork] ([Id], [Network_Name], [_Name], [Currency], [NetworkSymbol], [TransactionExplorer], [TokenExplorer], [DepositConfirmations], [_Enabled]) VALUES (6, N'btc', N'Bitcoin', N'XBt', N'https://blockstream.info/tx/{}', NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[NetWork] OFF
ALTER TABLE [dbo].[NetWork] ADD  CONSTRAINT [DF_NetWork__Enabled]  DEFAULT ((1)) FOR [_Enabled]
GO
ALTER TABLE [dbo].[Wallet]  WITH CHECK ADD  CONSTRAINT [FK__Wallet__Networks__4BAC3F29] FOREIGN KEY([NetworksId])
REFERENCES [dbo].[Redes] ([Id])
GO
ALTER TABLE [dbo].[Wallet] CHECK CONSTRAINT [FK__Wallet__Networks__4BAC3F29]
GO
