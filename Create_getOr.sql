USE [badge]
GO

/****** Object:  StoredProcedure [dbo].[getOr]    Script Date: 7/28/2018 4:57:17 PM ******/
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

DECLARE @tmp binary(960) = 0;

DECLARE 	@rtn0	binary(8) = 0;
DECLARE 	@rtn1	binary(8) = 0;
DECLARE 	@rtn2	binary(8) = 0;
DECLARE 	@rtn3	binary(8) = 0;
DECLARE 	@rtn4	binary(8) = 0;
DECLARE 	@rtn5	binary(8) = 0;
DECLARE 	@rtn6	binary(8) = 0;
DECLARE 	@rtn7	binary(8) = 0;
DECLARE 	@rtn8	binary(8) = 0;
DECLARE 	@rtn9	binary(8) = 0;
DECLARE 	@rtn10	binary(8) = 0;
DECLARE 	@rtn11	binary(8) = 0;
DECLARE 	@rtn12	binary(8) = 0;
DECLARE 	@rtn13	binary(8) = 0;
DECLARE 	@rtn14	binary(8) = 0;
DECLARE 	@rtn15	binary(8) = 0;
DECLARE 	@rtn16	binary(8) = 0;
DECLARE 	@rtn17	binary(8) = 0;
DECLARE 	@rtn18	binary(8) = 0;
DECLARE 	@rtn19	binary(8) = 0;
DECLARE 	@rtn20	binary(8) = 0;
DECLARE 	@rtn21	binary(8) = 0;
DECLARE 	@rtn22	binary(8) = 0;
DECLARE 	@rtn23	binary(8) = 0;
DECLARE 	@rtn24	binary(8) = 0;
DECLARE 	@rtn25	binary(8) = 0;
DECLARE 	@rtn26	binary(8) = 0;
DECLARE 	@rtn27	binary(8) = 0;
DECLARE 	@rtn28	binary(8) = 0;
DECLARE 	@rtn29	binary(8) = 0;
DECLARE 	@rtn30	binary(8) = 0;
DECLARE 	@rtn31	binary(8) = 0;
DECLARE 	@rtn32	binary(8) = 0;
DECLARE 	@rtn33	binary(8) = 0;
DECLARE 	@rtn34	binary(8) = 0;
DECLARE 	@rtn35	binary(8) = 0;
DECLARE 	@rtn36	binary(8) = 0;
DECLARE 	@rtn37	binary(8) = 0;
DECLARE 	@rtn38	binary(8) = 0;
DECLARE 	@rtn39	binary(8) = 0;
DECLARE 	@rtn40	binary(8) = 0;
DECLARE 	@rtn41	binary(8) = 0;
DECLARE 	@rtn42	binary(8) = 0;
DECLARE 	@rtn43	binary(8) = 0;
DECLARE 	@rtn44	binary(8) = 0;
DECLARE 	@rtn45	binary(8) = 0;
DECLARE 	@rtn46	binary(8) = 0;
DECLARE 	@rtn47	binary(8) = 0;
DECLARE 	@rtn48	binary(8) = 0;
DECLARE 	@rtn49	binary(8) = 0;
DECLARE 	@rtn50	binary(8) = 0;
DECLARE 	@rtn51	binary(8) = 0;
DECLARE 	@rtn52	binary(8) = 0;
DECLARE 	@rtn53	binary(8) = 0;
DECLARE 	@rtn54	binary(8) = 0;
DECLARE 	@rtn55	binary(8) = 0;
DECLARE 	@rtn56	binary(8) = 0;
DECLARE 	@rtn57	binary(8) = 0;
DECLARE 	@rtn58	binary(8) = 0;
DECLARE 	@rtn59	binary(8) = 0;
DECLARE 	@rtn60	binary(8) = 0;
DECLARE 	@rtn61	binary(8) = 0;
DECLARE 	@rtn62	binary(8) = 0;
DECLARE 	@rtn63	binary(8) = 0;
DECLARE 	@rtn64	binary(8) = 0;
DECLARE 	@rtn65	binary(8) = 0;
DECLARE 	@rtn66	binary(8) = 0;
DECLARE 	@rtn67	binary(8) = 0;
DECLARE 	@rtn68	binary(8) = 0;
DECLARE 	@rtn69	binary(8) = 0;
DECLARE 	@rtn70	binary(8) = 0;
DECLARE 	@rtn71	binary(8) = 0;
DECLARE 	@rtn72	binary(8) = 0;
DECLARE 	@rtn73	binary(8) = 0;
DECLARE 	@rtn74	binary(8) = 0;
DECLARE 	@rtn75	binary(8) = 0;
DECLARE 	@rtn76	binary(8) = 0;
DECLARE 	@rtn77	binary(8) = 0;
DECLARE 	@rtn78	binary(8) = 0;
DECLARE 	@rtn79	binary(8) = 0;
DECLARE 	@rtn80	binary(8) = 0;
DECLARE 	@rtn81	binary(8) = 0;
DECLARE 	@rtn82	binary(8) = 0;
DECLARE 	@rtn83	binary(8) = 0;
DECLARE 	@rtn84	binary(8) = 0;
DECLARE 	@rtn85	binary(8) = 0;
DECLARE 	@rtn86	binary(8) = 0;
DECLARE 	@rtn87	binary(8) = 0;
DECLARE 	@rtn88	binary(8) = 0;
DECLARE 	@rtn89	binary(8) = 0;
DECLARE 	@rtn90	binary(8) = 0;
DECLARE 	@rtn91	binary(8) = 0;
DECLARE 	@rtn92	binary(8) = 0;
DECLARE 	@rtn93	binary(8) = 0;
DECLARE 	@rtn94	binary(8) = 0;
DECLARE 	@rtn95	binary(8) = 0;
DECLARE 	@rtn96	binary(8) = 0;
DECLARE 	@rtn97	binary(8) = 0;
DECLARE 	@rtn98	binary(8) = 0;
DECLARE 	@rtn99	binary(8) = 0;
DECLARE 	@rtn100	binary(8) = 0;
DECLARE 	@rtn101	binary(8) = 0;
DECLARE 	@rtn102	binary(8) = 0;
DECLARE 	@rtn103	binary(8) = 0;
DECLARE 	@rtn104	binary(8) = 0;
DECLARE 	@rtn105	binary(8) = 0;
DECLARE 	@rtn106	binary(8) = 0;
DECLARE 	@rtn107	binary(8) = 0;
DECLARE 	@rtn108	binary(8) = 0;
DECLARE 	@rtn109	binary(8) = 0;
DECLARE 	@rtn110	binary(8) = 0;
DECLARE 	@rtn111	binary(8) = 0;
DECLARE 	@rtn112	binary(8) = 0;
DECLARE 	@rtn113	binary(8) = 0;
DECLARE 	@rtn114	binary(8) = 0;
DECLARE 	@rtn115	binary(8) = 0;
DECLARE 	@rtn116	binary(8) = 0;
DECLARE 	@rtn117	binary(8) = 0;
DECLARE 	@rtn118	binary(8) = 0;
DECLARE 	@rtn119	binary(8) = 0;



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

SET @rtn0 =  CAST((SUBSTRING(@tmp, 1, 8) | cast(@rtn0 as BIGINT)) AS BINARY(8))
SET @rtn1 =  CAST((SUBSTRING(@tmp, 9, 16) | cast(@rtn1 as BIGINT)) AS BINARY(8))
SET @rtn2 =  CAST((SUBSTRING(@tmp, 17, 24) | cast(@rtn2 as BIGINT)) AS BINARY(8))
SET @rtn3 =  CAST((SUBSTRING(@tmp, 25, 32) | cast(@rtn3 as BIGINT)) AS BINARY(8))
SET @rtn4 =  CAST((SUBSTRING(@tmp, 33, 40) | cast(@rtn4 as BIGINT)) AS BINARY(8))
SET @rtn5 =  CAST((SUBSTRING(@tmp, 41, 48) | cast(@rtn5 as BIGINT)) AS BINARY(8))
SET @rtn6 =  CAST((SUBSTRING(@tmp, 49, 56) | cast(@rtn6 as BIGINT)) AS BINARY(8))
SET @rtn7 =  CAST((SUBSTRING(@tmp, 57, 64) | cast(@rtn7 as BIGINT)) AS BINARY(8))
SET @rtn8 =  CAST((SUBSTRING(@tmp, 65, 72) | cast(@rtn8 as BIGINT)) AS BINARY(8))
SET @rtn9 =  CAST((SUBSTRING(@tmp, 73, 80) | cast(@rtn9 as BIGINT)) AS BINARY(8))
SET @rtn10 =  CAST((SUBSTRING(@tmp, 81, 88) | cast(@rtn10 as BIGINT)) AS BINARY(8))
SET @rtn11 =  CAST((SUBSTRING(@tmp, 89, 96) | cast(@rtn11 as BIGINT)) AS BINARY(8))
SET @rtn12 =  CAST((SUBSTRING(@tmp, 97, 104) | cast(@rtn12 as BIGINT)) AS BINARY(8))
SET @rtn13 =  CAST((SUBSTRING(@tmp, 105, 112) | cast(@rtn13 as BIGINT)) AS BINARY(8))
SET @rtn14 =  CAST((SUBSTRING(@tmp, 113, 120) | cast(@rtn14 as BIGINT)) AS BINARY(8))
SET @rtn15 =  CAST((SUBSTRING(@tmp, 121, 128) | cast(@rtn15 as BIGINT)) AS BINARY(8))
SET @rtn16 =  CAST((SUBSTRING(@tmp, 129, 136) | cast(@rtn16 as BIGINT)) AS BINARY(8))
SET @rtn17 =  CAST((SUBSTRING(@tmp, 137, 144) | cast(@rtn17 as BIGINT)) AS BINARY(8))
SET @rtn18 =  CAST((SUBSTRING(@tmp, 145, 152) | cast(@rtn18 as BIGINT)) AS BINARY(8))
SET @rtn19 =  CAST((SUBSTRING(@tmp, 153, 160) | cast(@rtn19 as BIGINT)) AS BINARY(8))
SET @rtn20 =  CAST((SUBSTRING(@tmp, 161, 168) | cast(@rtn20 as BIGINT)) AS BINARY(8))
SET @rtn21 =  CAST((SUBSTRING(@tmp, 169, 176) | cast(@rtn21 as BIGINT)) AS BINARY(8))
SET @rtn22 =  CAST((SUBSTRING(@tmp, 177, 184) | cast(@rtn22 as BIGINT)) AS BINARY(8))
SET @rtn23 =  CAST((SUBSTRING(@tmp, 185, 192) | cast(@rtn23 as BIGINT)) AS BINARY(8))
SET @rtn24 =  CAST((SUBSTRING(@tmp, 193, 200) | cast(@rtn24 as BIGINT)) AS BINARY(8))
SET @rtn25 =  CAST((SUBSTRING(@tmp, 201, 208) | cast(@rtn25 as BIGINT)) AS BINARY(8))
SET @rtn26 =  CAST((SUBSTRING(@tmp, 209, 216) | cast(@rtn26 as BIGINT)) AS BINARY(8))
SET @rtn27 =  CAST((SUBSTRING(@tmp, 217, 224) | cast(@rtn27 as BIGINT)) AS BINARY(8))
SET @rtn28 =  CAST((SUBSTRING(@tmp, 225, 232) | cast(@rtn28 as BIGINT)) AS BINARY(8))
SET @rtn29 =  CAST((SUBSTRING(@tmp, 233, 240) | cast(@rtn29 as BIGINT)) AS BINARY(8))
SET @rtn30 =  CAST((SUBSTRING(@tmp, 241, 248) | cast(@rtn30 as BIGINT)) AS BINARY(8))
SET @rtn31 =  CAST((SUBSTRING(@tmp, 249, 256) | cast(@rtn31 as BIGINT)) AS BINARY(8))
SET @rtn32 =  CAST((SUBSTRING(@tmp, 257, 264) | cast(@rtn32 as BIGINT)) AS BINARY(8))
SET @rtn33 =  CAST((SUBSTRING(@tmp, 265, 272) | cast(@rtn33 as BIGINT)) AS BINARY(8))
SET @rtn34 =  CAST((SUBSTRING(@tmp, 273, 280) | cast(@rtn34 as BIGINT)) AS BINARY(8))
SET @rtn35 =  CAST((SUBSTRING(@tmp, 281, 288) | cast(@rtn35 as BIGINT)) AS BINARY(8))
SET @rtn36 =  CAST((SUBSTRING(@tmp, 289, 296) | cast(@rtn36 as BIGINT)) AS BINARY(8))
SET @rtn37 =  CAST((SUBSTRING(@tmp, 297, 304) | cast(@rtn37 as BIGINT)) AS BINARY(8))
SET @rtn38 =  CAST((SUBSTRING(@tmp, 305, 312) | cast(@rtn38 as BIGINT)) AS BINARY(8))
SET @rtn39 =  CAST((SUBSTRING(@tmp, 313, 320) | cast(@rtn39 as BIGINT)) AS BINARY(8))
SET @rtn40 =  CAST((SUBSTRING(@tmp, 321, 328) | cast(@rtn40 as BIGINT)) AS BINARY(8))
SET @rtn41 =  CAST((SUBSTRING(@tmp, 329, 336) | cast(@rtn41 as BIGINT)) AS BINARY(8))
SET @rtn42 =  CAST((SUBSTRING(@tmp, 337, 344) | cast(@rtn42 as BIGINT)) AS BINARY(8))
SET @rtn43 =  CAST((SUBSTRING(@tmp, 345, 352) | cast(@rtn43 as BIGINT)) AS BINARY(8))
SET @rtn44 =  CAST((SUBSTRING(@tmp, 353, 360) | cast(@rtn44 as BIGINT)) AS BINARY(8))
SET @rtn45 =  CAST((SUBSTRING(@tmp, 361, 368) | cast(@rtn45 as BIGINT)) AS BINARY(8))
SET @rtn46 =  CAST((SUBSTRING(@tmp, 369, 376) | cast(@rtn46 as BIGINT)) AS BINARY(8))
SET @rtn47 =  CAST((SUBSTRING(@tmp, 377, 384) | cast(@rtn47 as BIGINT)) AS BINARY(8))
SET @rtn48 =  CAST((SUBSTRING(@tmp, 385, 392) | cast(@rtn48 as BIGINT)) AS BINARY(8))
SET @rtn49 =  CAST((SUBSTRING(@tmp, 393, 400) | cast(@rtn49 as BIGINT)) AS BINARY(8))
SET @rtn50 =  CAST((SUBSTRING(@tmp, 401, 408) | cast(@rtn50 as BIGINT)) AS BINARY(8))
SET @rtn51 =  CAST((SUBSTRING(@tmp, 409, 416) | cast(@rtn51 as BIGINT)) AS BINARY(8))
SET @rtn52 =  CAST((SUBSTRING(@tmp, 417, 424) | cast(@rtn52 as BIGINT)) AS BINARY(8))
SET @rtn53 =  CAST((SUBSTRING(@tmp, 425, 432) | cast(@rtn53 as BIGINT)) AS BINARY(8))
SET @rtn54 =  CAST((SUBSTRING(@tmp, 433, 440) | cast(@rtn54 as BIGINT)) AS BINARY(8))
SET @rtn55 =  CAST((SUBSTRING(@tmp, 441, 448) | cast(@rtn55 as BIGINT)) AS BINARY(8))
SET @rtn56 =  CAST((SUBSTRING(@tmp, 449, 456) | cast(@rtn56 as BIGINT)) AS BINARY(8))
SET @rtn57 =  CAST((SUBSTRING(@tmp, 457, 464) | cast(@rtn57 as BIGINT)) AS BINARY(8))
SET @rtn58 =  CAST((SUBSTRING(@tmp, 465, 472) | cast(@rtn58 as BIGINT)) AS BINARY(8))
SET @rtn59 =  CAST((SUBSTRING(@tmp, 473, 480) | cast(@rtn59 as BIGINT)) AS BINARY(8))
SET @rtn60 =  CAST((SUBSTRING(@tmp, 481, 488) | cast(@rtn60 as BIGINT)) AS BINARY(8))
SET @rtn61 =  CAST((SUBSTRING(@tmp, 489, 496) | cast(@rtn61 as BIGINT)) AS BINARY(8))
SET @rtn62 =  CAST((SUBSTRING(@tmp, 497, 504) | cast(@rtn62 as BIGINT)) AS BINARY(8))
SET @rtn63 =  CAST((SUBSTRING(@tmp, 505, 512) | cast(@rtn63 as BIGINT)) AS BINARY(8))
SET @rtn64 =  CAST((SUBSTRING(@tmp, 513, 520) | cast(@rtn64 as BIGINT)) AS BINARY(8))
SET @rtn65 =  CAST((SUBSTRING(@tmp, 521, 528) | cast(@rtn65 as BIGINT)) AS BINARY(8))
SET @rtn66 =  CAST((SUBSTRING(@tmp, 529, 536) | cast(@rtn66 as BIGINT)) AS BINARY(8))
SET @rtn67 =  CAST((SUBSTRING(@tmp, 537, 544) | cast(@rtn67 as BIGINT)) AS BINARY(8))
SET @rtn68 =  CAST((SUBSTRING(@tmp, 545, 552) | cast(@rtn68 as BIGINT)) AS BINARY(8))
SET @rtn69 =  CAST((SUBSTRING(@tmp, 553, 560) | cast(@rtn69 as BIGINT)) AS BINARY(8))
SET @rtn70 =  CAST((SUBSTRING(@tmp, 561, 568) | cast(@rtn70 as BIGINT)) AS BINARY(8))
SET @rtn71 =  CAST((SUBSTRING(@tmp, 569, 576) | cast(@rtn71 as BIGINT)) AS BINARY(8))
SET @rtn72 =  CAST((SUBSTRING(@tmp, 577, 584) | cast(@rtn72 as BIGINT)) AS BINARY(8))
SET @rtn73 =  CAST((SUBSTRING(@tmp, 585, 592) | cast(@rtn73 as BIGINT)) AS BINARY(8))
SET @rtn74 =  CAST((SUBSTRING(@tmp, 593, 600) | cast(@rtn74 as BIGINT)) AS BINARY(8))
SET @rtn75 =  CAST((SUBSTRING(@tmp, 601, 608) | cast(@rtn75 as BIGINT)) AS BINARY(8))
SET @rtn76 =  CAST((SUBSTRING(@tmp, 609, 616) | cast(@rtn76 as BIGINT)) AS BINARY(8))
SET @rtn77 =  CAST((SUBSTRING(@tmp, 617, 624) | cast(@rtn77 as BIGINT)) AS BINARY(8))
SET @rtn78 =  CAST((SUBSTRING(@tmp, 625, 632) | cast(@rtn78 as BIGINT)) AS BINARY(8))
SET @rtn79 =  CAST((SUBSTRING(@tmp, 633, 640) | cast(@rtn79 as BIGINT)) AS BINARY(8))
SET @rtn80 =  CAST((SUBSTRING(@tmp, 641, 648) | cast(@rtn80 as BIGINT)) AS BINARY(8))
SET @rtn81 =  CAST((SUBSTRING(@tmp, 649, 656) | cast(@rtn81 as BIGINT)) AS BINARY(8))
SET @rtn82 =  CAST((SUBSTRING(@tmp, 657, 664) | cast(@rtn82 as BIGINT)) AS BINARY(8))
SET @rtn83 =  CAST((SUBSTRING(@tmp, 665, 672) | cast(@rtn83 as BIGINT)) AS BINARY(8))
SET @rtn84 =  CAST((SUBSTRING(@tmp, 673, 680) | cast(@rtn84 as BIGINT)) AS BINARY(8))
SET @rtn85 =  CAST((SUBSTRING(@tmp, 681, 688) | cast(@rtn85 as BIGINT)) AS BINARY(8))
SET @rtn86 =  CAST((SUBSTRING(@tmp, 689, 696) | cast(@rtn86 as BIGINT)) AS BINARY(8))
SET @rtn87 =  CAST((SUBSTRING(@tmp, 697, 704) | cast(@rtn87 as BIGINT)) AS BINARY(8))
SET @rtn88 =  CAST((SUBSTRING(@tmp, 705, 712) | cast(@rtn88 as BIGINT)) AS BINARY(8))
SET @rtn89 =  CAST((SUBSTRING(@tmp, 713, 720) | cast(@rtn89 as BIGINT)) AS BINARY(8))
SET @rtn90 =  CAST((SUBSTRING(@tmp, 721, 728) | cast(@rtn90 as BIGINT)) AS BINARY(8))
SET @rtn91 =  CAST((SUBSTRING(@tmp, 729, 736) | cast(@rtn91 as BIGINT)) AS BINARY(8))
SET @rtn92 =  CAST((SUBSTRING(@tmp, 737, 744) | cast(@rtn92 as BIGINT)) AS BINARY(8))
SET @rtn93 =  CAST((SUBSTRING(@tmp, 745, 752) | cast(@rtn93 as BIGINT)) AS BINARY(8))
SET @rtn94 =  CAST((SUBSTRING(@tmp, 753, 760) | cast(@rtn94 as BIGINT)) AS BINARY(8))
SET @rtn95 =  CAST((SUBSTRING(@tmp, 761, 768) | cast(@rtn95 as BIGINT)) AS BINARY(8))
SET @rtn96 =  CAST((SUBSTRING(@tmp, 769, 776) | cast(@rtn96 as BIGINT)) AS BINARY(8))
SET @rtn97 =  CAST((SUBSTRING(@tmp, 777, 784) | cast(@rtn97 as BIGINT)) AS BINARY(8))
SET @rtn98 =  CAST((SUBSTRING(@tmp, 785, 792) | cast(@rtn98 as BIGINT)) AS BINARY(8))
SET @rtn99 =  CAST((SUBSTRING(@tmp, 793, 800) | cast(@rtn99 as BIGINT)) AS BINARY(8))
SET @rtn100 =  CAST((SUBSTRING(@tmp, 801, 808) | cast(@rtn100 as BIGINT)) AS BINARY(8))
SET @rtn101 =  CAST((SUBSTRING(@tmp, 809, 816) | cast(@rtn101 as BIGINT)) AS BINARY(8))
SET @rtn102 =  CAST((SUBSTRING(@tmp, 817, 824) | cast(@rtn102 as BIGINT)) AS BINARY(8))
SET @rtn103 =  CAST((SUBSTRING(@tmp, 825, 832) | cast(@rtn103 as BIGINT)) AS BINARY(8))
SET @rtn104 =  CAST((SUBSTRING(@tmp, 833, 840) | cast(@rtn104 as BIGINT)) AS BINARY(8))
SET @rtn105 =  CAST((SUBSTRING(@tmp, 841, 848) | cast(@rtn105 as BIGINT)) AS BINARY(8))
SET @rtn106 =  CAST((SUBSTRING(@tmp, 849, 856) | cast(@rtn106 as BIGINT)) AS BINARY(8))
SET @rtn107 =  CAST((SUBSTRING(@tmp, 857, 864) | cast(@rtn107 as BIGINT)) AS BINARY(8))
SET @rtn108 =  CAST((SUBSTRING(@tmp, 865, 872) | cast(@rtn108 as BIGINT)) AS BINARY(8))
SET @rtn109 =  CAST((SUBSTRING(@tmp, 873, 880) | cast(@rtn109 as BIGINT)) AS BINARY(8))
SET @rtn110 =  CAST((SUBSTRING(@tmp, 881, 888) | cast(@rtn110 as BIGINT)) AS BINARY(8))
SET @rtn111 =  CAST((SUBSTRING(@tmp, 889, 896) | cast(@rtn111 as BIGINT)) AS BINARY(8))
SET @rtn112 =  CAST((SUBSTRING(@tmp, 897, 904) | cast(@rtn112 as BIGINT)) AS BINARY(8))
SET @rtn113 =  CAST((SUBSTRING(@tmp, 905, 912) | cast(@rtn113 as BIGINT)) AS BINARY(8))
SET @rtn114 =  CAST((SUBSTRING(@tmp, 913, 920) | cast(@rtn114 as BIGINT)) AS BINARY(8))
SET @rtn115 =  CAST((SUBSTRING(@tmp, 921, 928) | cast(@rtn115 as BIGINT)) AS BINARY(8))
SET @rtn116 =  CAST((SUBSTRING(@tmp, 929, 936) | cast(@rtn116 as BIGINT)) AS BINARY(8))
SET @rtn117 =  CAST((SUBSTRING(@tmp, 937, 944) | cast(@rtn117 as BIGINT)) AS BINARY(8))
SET @rtn118 =  CAST((SUBSTRING(@tmp, 945, 952) | cast(@rtn118 as BIGINT)) AS BINARY(8))
SET @rtn119 =  CAST((SUBSTRING(@tmp, 953, 960) | cast(@rtn119 as BIGINT)) AS BINARY(8))

WHILE @@FETCH_STATUS = 0
	BEGIN
		
		FETCH NEXT FROM badge_cursor
		INTO @tmp
		SET @rtn0 =  CAST((SUBSTRING(@tmp, 1, 8) | cast(@rtn0 as BIGINT)) AS BINARY(8))
		SET @rtn1 =  CAST((SUBSTRING(@tmp, 9, 16) | cast(@rtn1 as BIGINT)) AS BINARY(8))
		SET @rtn2 =  CAST((SUBSTRING(@tmp, 17, 24) | cast(@rtn2 as BIGINT)) AS BINARY(8))
		SET @rtn3 =  CAST((SUBSTRING(@tmp, 25, 32) | cast(@rtn3 as BIGINT)) AS BINARY(8))
		SET @rtn4 =  CAST((SUBSTRING(@tmp, 33, 40) | cast(@rtn4 as BIGINT)) AS BINARY(8))
		SET @rtn5 =  CAST((SUBSTRING(@tmp, 41, 48) | cast(@rtn5 as BIGINT)) AS BINARY(8))
		SET @rtn6 =  CAST((SUBSTRING(@tmp, 49, 56) | cast(@rtn6 as BIGINT)) AS BINARY(8))
		SET @rtn7 =  CAST((SUBSTRING(@tmp, 57, 64) | cast(@rtn7 as BIGINT)) AS BINARY(8))
		SET @rtn8 =  CAST((SUBSTRING(@tmp, 65, 72) | cast(@rtn8 as BIGINT)) AS BINARY(8))
		SET @rtn9 =  CAST((SUBSTRING(@tmp, 73, 80) | cast(@rtn9 as BIGINT)) AS BINARY(8))
		SET @rtn10 =  CAST((SUBSTRING(@tmp, 81, 88) | cast(@rtn10 as BIGINT)) AS BINARY(8))
		SET @rtn11 =  CAST((SUBSTRING(@tmp, 89, 96) | cast(@rtn11 as BIGINT)) AS BINARY(8))
		SET @rtn12 =  CAST((SUBSTRING(@tmp, 97, 104) | cast(@rtn12 as BIGINT)) AS BINARY(8))
		SET @rtn13 =  CAST((SUBSTRING(@tmp, 105, 112) | cast(@rtn13 as BIGINT)) AS BINARY(8))
		SET @rtn14 =  CAST((SUBSTRING(@tmp, 113, 120) | cast(@rtn14 as BIGINT)) AS BINARY(8))
		SET @rtn15 =  CAST((SUBSTRING(@tmp, 121, 128) | cast(@rtn15 as BIGINT)) AS BINARY(8))
		SET @rtn16 =  CAST((SUBSTRING(@tmp, 129, 136) | cast(@rtn16 as BIGINT)) AS BINARY(8))
		SET @rtn17 =  CAST((SUBSTRING(@tmp, 137, 144) | cast(@rtn17 as BIGINT)) AS BINARY(8))
		SET @rtn18 =  CAST((SUBSTRING(@tmp, 145, 152) | cast(@rtn18 as BIGINT)) AS BINARY(8))
		SET @rtn19 =  CAST((SUBSTRING(@tmp, 153, 160) | cast(@rtn19 as BIGINT)) AS BINARY(8))
		SET @rtn20 =  CAST((SUBSTRING(@tmp, 161, 168) | cast(@rtn20 as BIGINT)) AS BINARY(8))
		SET @rtn21 =  CAST((SUBSTRING(@tmp, 169, 176) | cast(@rtn21 as BIGINT)) AS BINARY(8))
		SET @rtn22 =  CAST((SUBSTRING(@tmp, 177, 184) | cast(@rtn22 as BIGINT)) AS BINARY(8))
		SET @rtn23 =  CAST((SUBSTRING(@tmp, 185, 192) | cast(@rtn23 as BIGINT)) AS BINARY(8))
		SET @rtn24 =  CAST((SUBSTRING(@tmp, 193, 200) | cast(@rtn24 as BIGINT)) AS BINARY(8))
		SET @rtn25 =  CAST((SUBSTRING(@tmp, 201, 208) | cast(@rtn25 as BIGINT)) AS BINARY(8))
		SET @rtn26 =  CAST((SUBSTRING(@tmp, 209, 216) | cast(@rtn26 as BIGINT)) AS BINARY(8))
		SET @rtn27 =  CAST((SUBSTRING(@tmp, 217, 224) | cast(@rtn27 as BIGINT)) AS BINARY(8))
		SET @rtn28 =  CAST((SUBSTRING(@tmp, 225, 232) | cast(@rtn28 as BIGINT)) AS BINARY(8))
		SET @rtn29 =  CAST((SUBSTRING(@tmp, 233, 240) | cast(@rtn29 as BIGINT)) AS BINARY(8))
		SET @rtn30 =  CAST((SUBSTRING(@tmp, 241, 248) | cast(@rtn30 as BIGINT)) AS BINARY(8))
		SET @rtn31 =  CAST((SUBSTRING(@tmp, 249, 256) | cast(@rtn31 as BIGINT)) AS BINARY(8))
		SET @rtn32 =  CAST((SUBSTRING(@tmp, 257, 264) | cast(@rtn32 as BIGINT)) AS BINARY(8))
		SET @rtn33 =  CAST((SUBSTRING(@tmp, 265, 272) | cast(@rtn33 as BIGINT)) AS BINARY(8))
		SET @rtn34 =  CAST((SUBSTRING(@tmp, 273, 280) | cast(@rtn34 as BIGINT)) AS BINARY(8))
		SET @rtn35 =  CAST((SUBSTRING(@tmp, 281, 288) | cast(@rtn35 as BIGINT)) AS BINARY(8))
		SET @rtn36 =  CAST((SUBSTRING(@tmp, 289, 296) | cast(@rtn36 as BIGINT)) AS BINARY(8))
		SET @rtn37 =  CAST((SUBSTRING(@tmp, 297, 304) | cast(@rtn37 as BIGINT)) AS BINARY(8))
		SET @rtn38 =  CAST((SUBSTRING(@tmp, 305, 312) | cast(@rtn38 as BIGINT)) AS BINARY(8))
		SET @rtn39 =  CAST((SUBSTRING(@tmp, 313, 320) | cast(@rtn39 as BIGINT)) AS BINARY(8))
		SET @rtn40 =  CAST((SUBSTRING(@tmp, 321, 328) | cast(@rtn40 as BIGINT)) AS BINARY(8))
		SET @rtn41 =  CAST((SUBSTRING(@tmp, 329, 336) | cast(@rtn41 as BIGINT)) AS BINARY(8))
		SET @rtn42 =  CAST((SUBSTRING(@tmp, 337, 344) | cast(@rtn42 as BIGINT)) AS BINARY(8))
		SET @rtn43 =  CAST((SUBSTRING(@tmp, 345, 352) | cast(@rtn43 as BIGINT)) AS BINARY(8))
		SET @rtn44 =  CAST((SUBSTRING(@tmp, 353, 360) | cast(@rtn44 as BIGINT)) AS BINARY(8))
		SET @rtn45 =  CAST((SUBSTRING(@tmp, 361, 368) | cast(@rtn45 as BIGINT)) AS BINARY(8))
		SET @rtn46 =  CAST((SUBSTRING(@tmp, 369, 376) | cast(@rtn46 as BIGINT)) AS BINARY(8))
		SET @rtn47 =  CAST((SUBSTRING(@tmp, 377, 384) | cast(@rtn47 as BIGINT)) AS BINARY(8))
		SET @rtn48 =  CAST((SUBSTRING(@tmp, 385, 392) | cast(@rtn48 as BIGINT)) AS BINARY(8))
		SET @rtn49 =  CAST((SUBSTRING(@tmp, 393, 400) | cast(@rtn49 as BIGINT)) AS BINARY(8))
		SET @rtn50 =  CAST((SUBSTRING(@tmp, 401, 408) | cast(@rtn50 as BIGINT)) AS BINARY(8))
		SET @rtn51 =  CAST((SUBSTRING(@tmp, 409, 416) | cast(@rtn51 as BIGINT)) AS BINARY(8))
		SET @rtn52 =  CAST((SUBSTRING(@tmp, 417, 424) | cast(@rtn52 as BIGINT)) AS BINARY(8))
		SET @rtn53 =  CAST((SUBSTRING(@tmp, 425, 432) | cast(@rtn53 as BIGINT)) AS BINARY(8))
		SET @rtn54 =  CAST((SUBSTRING(@tmp, 433, 440) | cast(@rtn54 as BIGINT)) AS BINARY(8))
		SET @rtn55 =  CAST((SUBSTRING(@tmp, 441, 448) | cast(@rtn55 as BIGINT)) AS BINARY(8))
		SET @rtn56 =  CAST((SUBSTRING(@tmp, 449, 456) | cast(@rtn56 as BIGINT)) AS BINARY(8))
		SET @rtn57 =  CAST((SUBSTRING(@tmp, 457, 464) | cast(@rtn57 as BIGINT)) AS BINARY(8))
		SET @rtn58 =  CAST((SUBSTRING(@tmp, 465, 472) | cast(@rtn58 as BIGINT)) AS BINARY(8))
		SET @rtn59 =  CAST((SUBSTRING(@tmp, 473, 480) | cast(@rtn59 as BIGINT)) AS BINARY(8))
		SET @rtn60 =  CAST((SUBSTRING(@tmp, 481, 488) | cast(@rtn60 as BIGINT)) AS BINARY(8))
		SET @rtn61 =  CAST((SUBSTRING(@tmp, 489, 496) | cast(@rtn61 as BIGINT)) AS BINARY(8))
		SET @rtn62 =  CAST((SUBSTRING(@tmp, 497, 504) | cast(@rtn62 as BIGINT)) AS BINARY(8))
		SET @rtn63 =  CAST((SUBSTRING(@tmp, 505, 512) | cast(@rtn63 as BIGINT)) AS BINARY(8))
		SET @rtn64 =  CAST((SUBSTRING(@tmp, 513, 520) | cast(@rtn64 as BIGINT)) AS BINARY(8))
		SET @rtn65 =  CAST((SUBSTRING(@tmp, 521, 528) | cast(@rtn65 as BIGINT)) AS BINARY(8))
		SET @rtn66 =  CAST((SUBSTRING(@tmp, 529, 536) | cast(@rtn66 as BIGINT)) AS BINARY(8))
		SET @rtn67 =  CAST((SUBSTRING(@tmp, 537, 544) | cast(@rtn67 as BIGINT)) AS BINARY(8))
		SET @rtn68 =  CAST((SUBSTRING(@tmp, 545, 552) | cast(@rtn68 as BIGINT)) AS BINARY(8))
		SET @rtn69 =  CAST((SUBSTRING(@tmp, 553, 560) | cast(@rtn69 as BIGINT)) AS BINARY(8))
		SET @rtn70 =  CAST((SUBSTRING(@tmp, 561, 568) | cast(@rtn70 as BIGINT)) AS BINARY(8))
		SET @rtn71 =  CAST((SUBSTRING(@tmp, 569, 576) | cast(@rtn71 as BIGINT)) AS BINARY(8))
		SET @rtn72 =  CAST((SUBSTRING(@tmp, 577, 584) | cast(@rtn72 as BIGINT)) AS BINARY(8))
		SET @rtn73 =  CAST((SUBSTRING(@tmp, 585, 592) | cast(@rtn73 as BIGINT)) AS BINARY(8))
		SET @rtn74 =  CAST((SUBSTRING(@tmp, 593, 600) | cast(@rtn74 as BIGINT)) AS BINARY(8))
		SET @rtn75 =  CAST((SUBSTRING(@tmp, 601, 608) | cast(@rtn75 as BIGINT)) AS BINARY(8))
		SET @rtn76 =  CAST((SUBSTRING(@tmp, 609, 616) | cast(@rtn76 as BIGINT)) AS BINARY(8))
		SET @rtn77 =  CAST((SUBSTRING(@tmp, 617, 624) | cast(@rtn77 as BIGINT)) AS BINARY(8))
		SET @rtn78 =  CAST((SUBSTRING(@tmp, 625, 632) | cast(@rtn78 as BIGINT)) AS BINARY(8))
		SET @rtn79 =  CAST((SUBSTRING(@tmp, 633, 640) | cast(@rtn79 as BIGINT)) AS BINARY(8))
		SET @rtn80 =  CAST((SUBSTRING(@tmp, 641, 648) | cast(@rtn80 as BIGINT)) AS BINARY(8))
		SET @rtn81 =  CAST((SUBSTRING(@tmp, 649, 656) | cast(@rtn81 as BIGINT)) AS BINARY(8))
		SET @rtn82 =  CAST((SUBSTRING(@tmp, 657, 664) | cast(@rtn82 as BIGINT)) AS BINARY(8))
		SET @rtn83 =  CAST((SUBSTRING(@tmp, 665, 672) | cast(@rtn83 as BIGINT)) AS BINARY(8))
		SET @rtn84 =  CAST((SUBSTRING(@tmp, 673, 680) | cast(@rtn84 as BIGINT)) AS BINARY(8))
		SET @rtn85 =  CAST((SUBSTRING(@tmp, 681, 688) | cast(@rtn85 as BIGINT)) AS BINARY(8))
		SET @rtn86 =  CAST((SUBSTRING(@tmp, 689, 696) | cast(@rtn86 as BIGINT)) AS BINARY(8))
		SET @rtn87 =  CAST((SUBSTRING(@tmp, 697, 704) | cast(@rtn87 as BIGINT)) AS BINARY(8))
		SET @rtn88 =  CAST((SUBSTRING(@tmp, 705, 712) | cast(@rtn88 as BIGINT)) AS BINARY(8))
		SET @rtn89 =  CAST((SUBSTRING(@tmp, 713, 720) | cast(@rtn89 as BIGINT)) AS BINARY(8))
		SET @rtn90 =  CAST((SUBSTRING(@tmp, 721, 728) | cast(@rtn90 as BIGINT)) AS BINARY(8))
		SET @rtn91 =  CAST((SUBSTRING(@tmp, 729, 736) | cast(@rtn91 as BIGINT)) AS BINARY(8))
		SET @rtn92 =  CAST((SUBSTRING(@tmp, 737, 744) | cast(@rtn92 as BIGINT)) AS BINARY(8))
		SET @rtn93 =  CAST((SUBSTRING(@tmp, 745, 752) | cast(@rtn93 as BIGINT)) AS BINARY(8))
		SET @rtn94 =  CAST((SUBSTRING(@tmp, 753, 760) | cast(@rtn94 as BIGINT)) AS BINARY(8))
		SET @rtn95 =  CAST((SUBSTRING(@tmp, 761, 768) | cast(@rtn95 as BIGINT)) AS BINARY(8))
		SET @rtn96 =  CAST((SUBSTRING(@tmp, 769, 776) | cast(@rtn96 as BIGINT)) AS BINARY(8))
		SET @rtn97 =  CAST((SUBSTRING(@tmp, 777, 784) | cast(@rtn97 as BIGINT)) AS BINARY(8))
		SET @rtn98 =  CAST((SUBSTRING(@tmp, 785, 792) | cast(@rtn98 as BIGINT)) AS BINARY(8))
		SET @rtn99 =  CAST((SUBSTRING(@tmp, 793, 800) | cast(@rtn99 as BIGINT)) AS BINARY(8))
		SET @rtn100 =  CAST((SUBSTRING(@tmp, 801, 808) | cast(@rtn100 as BIGINT)) AS BINARY(8))
		SET @rtn101 =  CAST((SUBSTRING(@tmp, 809, 816) | cast(@rtn101 as BIGINT)) AS BINARY(8))
		SET @rtn102 =  CAST((SUBSTRING(@tmp, 817, 824) | cast(@rtn102 as BIGINT)) AS BINARY(8))
		SET @rtn103 =  CAST((SUBSTRING(@tmp, 825, 832) | cast(@rtn103 as BIGINT)) AS BINARY(8))
		SET @rtn104 =  CAST((SUBSTRING(@tmp, 833, 840) | cast(@rtn104 as BIGINT)) AS BINARY(8))
		SET @rtn105 =  CAST((SUBSTRING(@tmp, 841, 848) | cast(@rtn105 as BIGINT)) AS BINARY(8))
		SET @rtn106 =  CAST((SUBSTRING(@tmp, 849, 856) | cast(@rtn106 as BIGINT)) AS BINARY(8))
		SET @rtn107 =  CAST((SUBSTRING(@tmp, 857, 864) | cast(@rtn107 as BIGINT)) AS BINARY(8))
		SET @rtn108 =  CAST((SUBSTRING(@tmp, 865, 872) | cast(@rtn108 as BIGINT)) AS BINARY(8))
		SET @rtn109 =  CAST((SUBSTRING(@tmp, 873, 880) | cast(@rtn109 as BIGINT)) AS BINARY(8))
		SET @rtn110 =  CAST((SUBSTRING(@tmp, 881, 888) | cast(@rtn110 as BIGINT)) AS BINARY(8))
		SET @rtn111 =  CAST((SUBSTRING(@tmp, 889, 896) | cast(@rtn111 as BIGINT)) AS BINARY(8))
		SET @rtn112 =  CAST((SUBSTRING(@tmp, 897, 904) | cast(@rtn112 as BIGINT)) AS BINARY(8))
		SET @rtn113 =  CAST((SUBSTRING(@tmp, 905, 912) | cast(@rtn113 as BIGINT)) AS BINARY(8))
		SET @rtn114 =  CAST((SUBSTRING(@tmp, 913, 920) | cast(@rtn114 as BIGINT)) AS BINARY(8))
		SET @rtn115 =  CAST((SUBSTRING(@tmp, 921, 928) | cast(@rtn115 as BIGINT)) AS BINARY(8))
		SET @rtn116 =  CAST((SUBSTRING(@tmp, 929, 936) | cast(@rtn116 as BIGINT)) AS BINARY(8))
		SET @rtn117 =  CAST((SUBSTRING(@tmp, 937, 944) | cast(@rtn117 as BIGINT)) AS BINARY(8))
		SET @rtn118 =  CAST((SUBSTRING(@tmp, 945, 952) | cast(@rtn118 as BIGINT)) AS BINARY(8))
		SET @rtn119 =  CAST((SUBSTRING(@tmp, 953, 960) | cast(@rtn119 as BIGINT)) AS BINARY(8))
		
	END
RETURN CAST(@rtn0 +  @rtn1 +  @rtn2 +  @rtn3 +  @rtn4 +  @rtn5 +  @rtn6 +  @rtn7 +  @rtn8 +  @rtn9 +  @rtn10 +  @rtn11 +  @rtn12 +  @rtn13 +  @rtn14 +  @rtn15 +  @rtn16 +  @rtn17 +  @rtn18 +  @rtn19 +  @rtn20 +  @rtn21 +  @rtn22 +  @rtn23 +  @rtn24 +  @rtn25 +  @rtn26 +  @rtn27 +  @rtn28 +  @rtn29 +  @rtn30 +  @rtn31 +  @rtn32 +  @rtn33 +  @rtn34 +  @rtn35 +  @rtn36 +  @rtn37 +  @rtn38 +  @rtn39 +  @rtn40 +  @rtn41 +  @rtn42 +  @rtn43 +  @rtn44 +  @rtn45 +  @rtn46 +  @rtn47 +  @rtn48 +  @rtn49 +  @rtn50 +  @rtn51 +  @rtn52 +  @rtn53 +  @rtn54 +  @rtn55 +  @rtn56 +  @rtn57 +  @rtn58 +  @rtn59 +  @rtn60 +  @rtn61 +  @rtn62 +  @rtn63 +  @rtn64 +  @rtn65 +  @rtn66 +  @rtn67 +  @rtn68 +  @rtn69 +  @rtn70 +  @rtn71 +  @rtn72 +  @rtn73 +  @rtn74 +  @rtn75 +  @rtn76 +  @rtn77 +  @rtn78 +  @rtn79 +  @rtn80 +  @rtn81 +  @rtn82 +  @rtn83 +  @rtn84 +  @rtn85 +  @rtn86 +  @rtn87 +  @rtn88 +  @rtn89 +  @rtn90 +  @rtn91 +  @rtn92 +  @rtn93 +  @rtn94 +  @rtn95 +  @rtn96 +  @rtn97 +  @rtn98 +  @rtn99 +  @rtn100 +  @rtn101 +  @rtn102 +  @rtn103 +  @rtn104 +  @rtn105 +  @rtn106 +  @rtn107 +  @rtn108 +  @rtn109 +  @rtn110 +  @rtn111 +  @rtn112 +  @rtn113 +  @rtn114 +  @rtn115 +  @rtn116 +  @rtn117 +  @rtn118 +  @rtn119 AS BINARY(960))
CLOSE badge_cursor
DEALLOCATE badge_cursor

END
GO


