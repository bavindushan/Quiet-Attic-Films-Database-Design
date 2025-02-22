USE [master]
GO
/****** Object:  Database [Quiet Attic Films]    Script Date: 2/19/2024 9:57:06 PM ******/
CREATE DATABASE [Quiet Attic Films]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quiet Attic Films', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Quiet Attic Films.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quiet Attic Films_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Quiet Attic Films_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Quiet Attic Films] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quiet Attic Films].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quiet Attic Films] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quiet Attic Films] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quiet Attic Films] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quiet Attic Films] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quiet Attic Films] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET RECOVERY FULL 
GO
ALTER DATABASE [Quiet Attic Films] SET  MULTI_USER 
GO
ALTER DATABASE [Quiet Attic Films] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quiet Attic Films] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quiet Attic Films] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quiet Attic Films] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quiet Attic Films] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quiet Attic Films] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quiet Attic Films', N'ON'
GO
ALTER DATABASE [Quiet Attic Films] SET QUERY_STORE = ON
GO
ALTER DATABASE [Quiet Attic Films] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Quiet Attic Films]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Client_ID] [int] NOT NULL,
	[Client_Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Location_ID] [int] NOT NULL,
	[Location_Name] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Location_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[userID] [int] NOT NULL,
	[username] [varchar](100) NULL,
	[psw] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Production]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production](
	[Production_ID] [int] NOT NULL,
	[Production_Name] [varchar](50) NULL,
	[Client_ID] [int] NULL,
	[Start_Date] [date] NULL,
	[End_Date] [date] NULL,
	[Production_Type] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Production_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Production_Property_Location]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production_Property_Location](
	[Production_ID] [int] NULL,
	[Property_ID] [int] NULL,
	[Location_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Production_Staff]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production_Staff](
	[Production_ID] [int] NULL,
	[Staff_ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Property]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property](
	[Property_ID] [int] NOT NULL,
	[Property_Name] [varchar](50) NULL,
	[Property_Type] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Property_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Staff_ID] [int] NOT NULL,
	[Staff_Name] [varchar](100) NULL,
	[Staff_Type] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Staff_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Types]    Script Date: 2/19/2024 9:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Types](
	[Staff_Type] [varchar](50) NOT NULL,
	[Staff_Fee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Staff_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Production]  WITH CHECK ADD  CONSTRAINT [FK_Production_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
GO
ALTER TABLE [dbo].[Production] CHECK CONSTRAINT [FK_Production_Client]
GO
ALTER TABLE [dbo].[Production_Property_Location]  WITH CHECK ADD FOREIGN KEY([Location_ID])
REFERENCES [dbo].[Location] ([Location_ID])
GO
ALTER TABLE [dbo].[Production_Property_Location]  WITH CHECK ADD FOREIGN KEY([Production_ID])
REFERENCES [dbo].[Production] ([Production_ID])
GO
ALTER TABLE [dbo].[Production_Property_Location]  WITH CHECK ADD FOREIGN KEY([Property_ID])
REFERENCES [dbo].[Property] ([Property_ID])
GO
ALTER TABLE [dbo].[Production_Staff]  WITH CHECK ADD FOREIGN KEY([Production_ID])
REFERENCES [dbo].[Production] ([Production_ID])
GO
ALTER TABLE [dbo].[Production_Staff]  WITH CHECK ADD FOREIGN KEY([Staff_ID])
REFERENCES [dbo].[Staff] ([Staff_ID])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([Staff_Type])
REFERENCES [dbo].[Staff_Types] ([Staff_Type])
GO
USE [master]
GO
ALTER DATABASE [Quiet Attic Films] SET  READ_WRITE 
GO
