USE badge;
GO

Declare @sect1 binary(10) = convert(binary(10), '0x000F', 1)
Declare @sect2 binary(10) = convert(binary(10), '0x01FFFFFFFF', 1)

select @sect1 + @sect2

GO

DECLARE @tmp binary(960) = 0;
DECLARE @rtn binary(960) = 0;

IF CURSOR_STATUS('global','badge_cursor')>=-1
BEGIN
 DEALLOCATE badge_cursor
END

DECLARE badge_cursor CURSOR FAST_FORWARD 
FOR

SELECT [0] + [1] + [2] + [3] + [4] + [5] + [6] + [7] + [8] + [9] + [10] + [11] + [12] + [13] + [14] + [15] + [16] + [17] + [18] + [19] + [20] + [21] + [22] + [23] + [24] + [25] + [26] + [27] + [28] + [29] + [30] + [31] + [32] + [33] + [34] + [35] + [36] + [37] + [38] + [39] + [40] + [41] + [42] + [43] + [44] + [45] + [46] + [47] + [48] + [49] + [50] + [51] + [52] + [53] + [54] + [55] + [56] + [57] + [58] + [59] + [60] + [61] + [62] + [63] + [64] + [65] + [66] + [67] + [68] + [69] + [70] + [71] + [72] + [73] + [74] + [75] + [76] + [77] + [78] + [79] + [80] + [81] + [82] + [83] + [84] + [85] + [86] + [87] + [88] + [89] + [90] + [91] + [92] + [93] + [94] + [95]
 FROM [badge].[dbo].[badges]

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
PRINT @rtn
CLOSE badge_cursor
DEALLOCATE badge_cursor


