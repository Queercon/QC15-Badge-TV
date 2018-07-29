USE badge;
GO


Declare @sect1 binary(10) = convert(binary(10), '0xFFFFFFFFFFFFFFFFFFFF', 1)

UPDATE badges
set [0] = @sect1, [lastseen] = SYSDATETIME()
WHERE [id0] = '79'
