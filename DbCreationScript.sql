USE [master]
GO

CREATE DATABASE [StudentDb]
 ON  PRIMARY 
( 
    NAME = N'StudentDb', 
    FILENAME = N'[local path]\StudentDb.mdf' , 
    SIZE = 8192KB , 
    MAXSIZE = UNLIMITED, 
    FILEGROWTH = 65536KB )
 LOG ON 
( 
    NAME = N'StudentDb_log', 
    FILENAME = N'[local path]\StudentDb.ldf' , 
    SIZE = 8192KB , 
    MAXSIZE = 2048GB , 
    FILEGROWTH = 65536KB 
)
GO

USE [StudentDb]
GO

CREATE TABLE [dbo].[Students]
(
	[ID] [int] NOT NULL,
	[Name_FirstName] [varchar](50) NOT NULL,
	[Name_LastName] [varchar](50) NOT NULL,
    PRIMARY KEY CLUSTERED 
    (
	    [ID] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO