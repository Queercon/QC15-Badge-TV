USE [badge]
GO

/****** Object:  StoredProcedure [dbo].[getOr]    Script Date: 7/17/2018 11:35:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getOr] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
DECLARE @tmp INT = 0;
DECLARE @rtn INT = 0;

IF CURSOR_STATUS('global','badge_cursor')>=-1
BEGIN
 DEALLOCATE badge_cursor
END

DECLARE badge_cursor CURSOR FAST_FORWARD 
FOR

SELECT [file] FROM [badge].[dbo].[badges]

OPEN badge_cursor

FETCH NEXT FROM badge_cursor 
INTO @tmp

SET @rtn = @rtn | @tmp

WHILE @@FETCH_STATUS = 0
	BEGIN
		
		FETCH NEXT FROM badge_cursor
		INTO @tmp
		SET @rtn = @rtn | @tmp
		
	END
RETURN @rtn
CLOSE badge_cursor
DEALLOCATE badge_cursor




END
GO


