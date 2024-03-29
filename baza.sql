USE [master]
GO
/****** Object:  Database [ZavrsniRad]    Script Date: 27.9.2023. 14:23:44 ******/
CREATE DATABASE [ZavrsniRad]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZavrsniRad', FILENAME = N'C:\Users\HP\ZavrsniRad.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZavrsniRad_log', FILENAME = N'C:\Users\HP\ZavrsniRad_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ZavrsniRad] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZavrsniRad].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZavrsniRad] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZavrsniRad] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZavrsniRad] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZavrsniRad] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZavrsniRad] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZavrsniRad] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZavrsniRad] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZavrsniRad] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZavrsniRad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZavrsniRad] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZavrsniRad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZavrsniRad] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZavrsniRad] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZavrsniRad] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZavrsniRad] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZavrsniRad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZavrsniRad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZavrsniRad] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZavrsniRad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZavrsniRad] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZavrsniRad] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZavrsniRad] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZavrsniRad] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZavrsniRad] SET  MULTI_USER 
GO
ALTER DATABASE [ZavrsniRad] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZavrsniRad] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZavrsniRad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZavrsniRad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZavrsniRad] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZavrsniRad] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ZavrsniRad] SET QUERY_STORE = OFF
GO
USE [ZavrsniRad]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 27.9.2023. 14:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aranzman]    Script Date: 27.9.2023. 14:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aranzman](
	[Id] [int] NOT NULL,
	[Administrator] [varchar](50) NOT NULL,
	[Destinacija] [int] NOT NULL,
	[Opis] [varchar](200) NOT NULL,
	[Cena] [float] NOT NULL,
	[Kapacitet] [int] NOT NULL,
	[TipPrevoza] [int] NOT NULL,
	[DatumOd] [date] NOT NULL,
	[DatumDo] [date] NOT NULL,
 CONSTRAINT [PK_Aranzman] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinacija]    Script Date: 27.9.2023. 14:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinacija](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Destinacija] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Putnik]    Script Date: 27.9.2023. 14:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Putnik](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[PassportNumber] [char](9) NOT NULL,
	[JMBG] [char](13) NOT NULL,
 CONSTRAINT [PK_Putnik] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 27.9.2023. 14:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[Aranzman] [int] NOT NULL,
	[Putnik] [varchar](50) NOT NULL,
	[BrojRezervacije] [int] NOT NULL,
 CONSTRAINT [PK_Rezervacija_1] PRIMARY KEY CLUSTERED 
(
	[BrojRezervacije] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administrator] ([Username], [Password], [FirstName], [LastName], [Email]) VALUES (N'admin', N'admin', N'Adminar', N'Adminov', N'admi4@gmail.com')
INSERT [dbo].[Administrator] ([Username], [Password], [FirstName], [LastName], [Email]) VALUES (N'administrator', N'administrator', N'administrator', N'administrator', N'administrator@gmail.com')
INSERT [dbo].[Administrator] ([Username], [Password], [FirstName], [LastName], [Email]) VALUES (N'nikola', N'nikola', N'Nikola', N'Jovanovic', N'jovanoviic225@gmail.com')
INSERT [dbo].[Administrator] ([Username], [Password], [FirstName], [LastName], [Email]) VALUES (N'njegos', N'123456', N'Petar', N'Petrovic', N'nikola@gmail.com')
INSERT [dbo].[Administrator] ([Username], [Password], [FirstName], [LastName], [Email]) VALUES (N'onomad', N'scYLI1P', N'Onomad', N'Rs', N'onomad.rs@gmail.com')
INSERT [dbo].[Administrator] ([Username], [Password], [FirstName], [LastName], [Email]) VALUES (N'pera', N'pera', N'Petar', N'Petrovic', N'pera@gmail.com')
GO
INSERT [dbo].[Aranzman] ([Id], [Administrator], [Destinacija], [Opis], [Cena], [Kapacitet], [TipPrevoza], [DatumOd], [DatumDo]) VALUES (104, N'nikola', 2004, N'Ovo je glavni grad Finske.', 300, 20, 2, CAST(N'2023-11-09' AS Date), CAST(N'2023-11-24' AS Date))
INSERT [dbo].[Aranzman] ([Id], [Administrator], [Destinacija], [Opis], [Cena], [Kapacitet], [TipPrevoza], [DatumOd], [DatumDo]) VALUES (20144, N'nikola', 8008, N'Biciklom na Rusiju', 310, 50, 2, CAST(N'2023-11-15' AS Date), CAST(N'2023-12-01' AS Date))
INSERT [dbo].[Aranzman] ([Id], [Administrator], [Destinacija], [Opis], [Cena], [Kapacitet], [TipPrevoza], [DatumOd], [DatumDo]) VALUES (84224, N'admin', 7007, N'Telefonske govornice za slikanje.', 300, 40, 2, CAST(N'2023-10-08' AS Date), CAST(N'2023-10-21' AS Date))
INSERT [dbo].[Aranzman] ([Id], [Administrator], [Destinacija], [Opis], [Cena], [Kapacitet], [TipPrevoza], [DatumOd], [DatumDo]) VALUES (99631, N'nikola', 1002, N'Grad na dva kontinenta!', 80, 40, 1, CAST(N'2023-09-27' AS Date), CAST(N'2023-10-04' AS Date))
INSERT [dbo].[Aranzman] ([Id], [Administrator], [Destinacija], [Opis], [Cena], [Kapacitet], [TipPrevoza], [DatumOd], [DatumDo]) VALUES (611832, N'nikola', 5007, N'Svi putevi vode u Rim!', 150, 15, 2, CAST(N'2023-11-15' AS Date), CAST(N'2023-11-25' AS Date))
INSERT [dbo].[Aranzman] ([Id], [Administrator], [Destinacija], [Opis], [Cena], [Kapacitet], [TipPrevoza], [DatumOd], [DatumDo]) VALUES (778912, N'nikola', 2006, N'Grad Grckih Bogova', 150, 40, 1, CAST(N'2023-09-28' AS Date), CAST(N'2023-09-30' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Destinacija] ON 

INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (1002, N'Madrid')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (2002, N'Rim')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (2004, N'Helsinki')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (2006, N'Atina')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (2007, N'Krakov')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (3007, N'Zagreb')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (4007, N'Budimpesta')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (5007, N'Skoplje')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (5008, N'Istanbul')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (7007, N'London')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (7008, N'Solun')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (8008, N'Moskva')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (9007, N'Beograd')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (9008, N'Budva')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (9009, N'Budimpešta')
INSERT [dbo].[Destinacija] ([Id], [Naziv]) VALUES (10007, N'Kopenhagen')
SET IDENTITY_INSERT [dbo].[Destinacija] OFF
GO
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'mika', N'mika', N'Mika', N'Mikic', N'mikam@gmail.com', N'0611714848', N'986512375', N'7986143259911')
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'nevena', N'nevena', N'Nevena', N'Jovanovic', N'nevena@gmail.com', N'061158791', N'030579941', N'1746932580017')
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'nikolaj', N'nikolaj', N'Nikola', N'Jovanovic', N'jovanoviic225@gmail.com', N'0600321639', N'010254981', N'2205997761050')
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'noviUser', N'lozinka', N'Nikola', N'Nikolic', N'onomad.rs@gmail.com', N'98520104', N'111222333', N'2205997761020')
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'testnovi', N'novi', N'Ime', N'Prezime', N'noviTest@gmail.com', N'066321859', N'993245780', N'7761325549801')
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'veka', N'veka', N'Veroljub', N'Jovanovic', N'veka@gmail.com', N'0658851763', N'852369741', N'2278501356999')
INSERT [dbo].[Putnik] ([Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [PassportNumber], [JMBG]) VALUES (N'violeta', N'violeta', N'Violeta', N'Jovanovic', N'violeta@gmail.com', N'064474417', N'374986512', N'0408997984710')
GO
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (611832, N'noviUser', 48062)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (778912, N'nevena', 55593)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (104, N'violeta', 55617)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (778912, N'noviUser', 88539)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (104, N'noviUser', 96314)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (611832, N'nevena', 98715)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (778912, N'nikolaj', 110065)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (778912, N'mika', 110112)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (611832, N'veka', 1140981)
INSERT [dbo].[Rezervacija] ([Aranzman], [Putnik], [BrojRezervacije]) VALUES (104, N'nikolaj', 2205997)
GO
ALTER TABLE [dbo].[Aranzman]  WITH CHECK ADD  CONSTRAINT [FK_Aranzman_Administrator] FOREIGN KEY([Administrator])
REFERENCES [dbo].[Administrator] ([Username])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Aranzman] CHECK CONSTRAINT [FK_Aranzman_Administrator]
GO
ALTER TABLE [dbo].[Aranzman]  WITH CHECK ADD  CONSTRAINT [FK_Aranzman_Destinacija] FOREIGN KEY([Destinacija])
REFERENCES [dbo].[Destinacija] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Aranzman] CHECK CONSTRAINT [FK_Aranzman_Destinacija]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Aranzman] FOREIGN KEY([Aranzman])
REFERENCES [dbo].[Aranzman] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Aranzman]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Putnik] FOREIGN KEY([Putnik])
REFERENCES [dbo].[Putnik] ([Username])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Putnik]
GO
USE [master]
GO
ALTER DATABASE [ZavrsniRad] SET  READ_WRITE 
GO
