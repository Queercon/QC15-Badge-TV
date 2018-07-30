USE badge;
GO


Declare @sect1 binary(10) = convert(binary(10), '0xFFFFFFFFFFFFFFFFFFFF', 1)




DECLARE @cnt INT = 0;

WHILE @cnt < 449
BEGIN
WAITFOR DELAY '00:00:00:01'

UPDATE badges
set [0] = convert(binary(10), '0xFFFFFFFFFFFFFFFFFFFF', 1), [lastseen] = SYSDATETIME()
WHERE [id0] = @cnt

SET @cnt = @cnt + 1;
PRINT @cnt

END;
GO