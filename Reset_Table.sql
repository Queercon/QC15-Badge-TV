USE [badge]
GO

DROP TABLE [dbo].[badges]

GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[badges](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[lastseen] [datetime2](7) NULL,
	[handle] [varchar](50) NULL,
	[file] INT DEFAULT 0 NOT NULL
) ON [PRIMARY]
GO

DECLARE @cnt INT = 0;

WHILE @cnt < 300
BEGIN


INSERT INTO [dbo].[badges]
           ([name]
           ,[lastseen]
		   ,[file])
     VALUES
           (@cnt,
           SYSDATETIME(),
		   @cnt);

SET @cnt = @cnt + 1;

END;
GO


