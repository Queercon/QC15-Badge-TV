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
	[id0] [int] NOT NULL,
	[lastseen] [datetime2](7) NULL,
	[0] BINARY(10) DEFAULT 0 NOT NULL,
	[1] BINARY(10) DEFAULT 0 NOT NULL,
	[2] BINARY(10) DEFAULT 0 NOT NULL,
	[3] BINARY(10) DEFAULT 0 NOT NULL,
	[4] BINARY(10) DEFAULT 0 NOT NULL,
	[5] BINARY(10) DEFAULT 0 NOT NULL,
	[6] BINARY(10) DEFAULT 0 NOT NULL,
	[7] BINARY(10) DEFAULT 0 NOT NULL,
	[8] BINARY(10) DEFAULT 0 NOT NULL,
	[9] BINARY(10) DEFAULT 0 NOT NULL,
	[10] BINARY(10) DEFAULT 0 NOT NULL,
	[11] BINARY(10) DEFAULT 0 NOT NULL,
	[12] BINARY(10) DEFAULT 0 NOT NULL,
	[13] BINARY(10) DEFAULT 0 NOT NULL,
	[14] BINARY(10) DEFAULT 0 NOT NULL,
	[15] BINARY(10) DEFAULT 0 NOT NULL,
	[16] BINARY(10) DEFAULT 0 NOT NULL,
	[17] BINARY(10) DEFAULT 0 NOT NULL,
	[18] BINARY(10) DEFAULT 0 NOT NULL,
	[19] BINARY(10) DEFAULT 0 NOT NULL,
	[20] BINARY(10) DEFAULT 0 NOT NULL,
	[21] BINARY(10) DEFAULT 0 NOT NULL,
	[22] BINARY(10) DEFAULT 0 NOT NULL,
	[23] BINARY(10) DEFAULT 0 NOT NULL,
	[24] BINARY(10) DEFAULT 0 NOT NULL,
	[25] BINARY(10) DEFAULT 0 NOT NULL,
	[26] BINARY(10) DEFAULT 0 NOT NULL,
	[27] BINARY(10) DEFAULT 0 NOT NULL,
	[28] BINARY(10) DEFAULT 0 NOT NULL,
	[29] BINARY(10) DEFAULT 0 NOT NULL,
	[30] BINARY(10) DEFAULT 0 NOT NULL,
	[31] BINARY(10) DEFAULT 0 NOT NULL,
	[32] BINARY(10) DEFAULT 0 NOT NULL,
	[33] BINARY(10) DEFAULT 0 NOT NULL,
	[34] BINARY(10) DEFAULT 0 NOT NULL,
	[35] BINARY(10) DEFAULT 0 NOT NULL,
	[36] BINARY(10) DEFAULT 0 NOT NULL,
	[37] BINARY(10) DEFAULT 0 NOT NULL,
	[38] BINARY(10) DEFAULT 0 NOT NULL,
	[39] BINARY(10) DEFAULT 0 NOT NULL,
	[40] BINARY(10) DEFAULT 0 NOT NULL,
	[41] BINARY(10) DEFAULT 0 NOT NULL,
	[42] BINARY(10) DEFAULT 0 NOT NULL,
	[43] BINARY(10) DEFAULT 0 NOT NULL,
	[44] BINARY(10) DEFAULT 0 NOT NULL,
	[45] BINARY(10) DEFAULT 0 NOT NULL,
	[46] BINARY(10) DEFAULT 0 NOT NULL,
	[47] BINARY(10) DEFAULT 0 NOT NULL,
	[48] BINARY(10) DEFAULT 0 NOT NULL,
	[49] BINARY(10) DEFAULT 0 NOT NULL,
	[50] BINARY(10) DEFAULT 0 NOT NULL,
	[51] BINARY(10) DEFAULT 0 NOT NULL,
	[52] BINARY(10) DEFAULT 0 NOT NULL,
	[53] BINARY(10) DEFAULT 0 NOT NULL,
	[54] BINARY(10) DEFAULT 0 NOT NULL,
	[55] BINARY(10) DEFAULT 0 NOT NULL,
	[56] BINARY(10) DEFAULT 0 NOT NULL,
	[57] BINARY(10) DEFAULT 0 NOT NULL,
	[58] BINARY(10) DEFAULT 0 NOT NULL,
	[59] BINARY(10) DEFAULT 0 NOT NULL,
	[60] BINARY(10) DEFAULT 0 NOT NULL,
	[61] BINARY(10) DEFAULT 0 NOT NULL,
	[62] BINARY(10) DEFAULT 0 NOT NULL,
	[63] BINARY(10) DEFAULT 0 NOT NULL,
	[64] BINARY(10) DEFAULT 0 NOT NULL,
	[65] BINARY(10) DEFAULT 0 NOT NULL,
	[66] BINARY(10) DEFAULT 0 NOT NULL,
	[67] BINARY(10) DEFAULT 0 NOT NULL,
	[68] BINARY(10) DEFAULT 0 NOT NULL,
	[69] BINARY(10) DEFAULT 0 NOT NULL,
	[70] BINARY(10) DEFAULT 0 NOT NULL,
	[71] BINARY(10) DEFAULT 0 NOT NULL,
	[72] BINARY(10) DEFAULT 0 NOT NULL,
	[73] BINARY(10) DEFAULT 0 NOT NULL,
	[74] BINARY(10) DEFAULT 0 NOT NULL,
	[75] BINARY(10) DEFAULT 0 NOT NULL,
	[76] BINARY(10) DEFAULT 0 NOT NULL,
	[77] BINARY(10) DEFAULT 0 NOT NULL,
	[78] BINARY(10) DEFAULT 0 NOT NULL,
	[79] BINARY(10) DEFAULT 0 NOT NULL,
	[80] BINARY(10) DEFAULT 0 NOT NULL,
	[81] BINARY(10) DEFAULT 0 NOT NULL,
	[82] BINARY(10) DEFAULT 0 NOT NULL,
	[83] BINARY(10) DEFAULT 0 NOT NULL,
	[84] BINARY(10) DEFAULT 0 NOT NULL,
	[85] BINARY(10) DEFAULT 0 NOT NULL,
	[86] BINARY(10) DEFAULT 0 NOT NULL,
	[87] BINARY(10) DEFAULT 0 NOT NULL,
	[88] BINARY(10) DEFAULT 0 NOT NULL,
	[89] BINARY(10) DEFAULT 0 NOT NULL,
	[90] BINARY(10) DEFAULT 0 NOT NULL,
	[91] BINARY(10) DEFAULT 0 NOT NULL,
	[92] BINARY(10) DEFAULT 0 NOT NULL,
	[93] BINARY(10) DEFAULT 0 NOT NULL,
	[94] BINARY(10) DEFAULT 0 NOT NULL,
	[95] BINARY(10) DEFAULT 0 NOT NULL

) ON [PRIMARY]
GO

DROP TABLE [dbo].[badgestats]

GO


CREATE TABLE [dbo].[badgestats](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [id0] [int] NOT NULL,
    [badgename] [varchar](50) NULL,
    [lastseen] [datetime2](7) NULL,
    [badges_seen] [int] DEFAULT 0,
    [badges_connected] [int] DEFAULT 0,
    [badges_uploaded] [int] DEFAULT 0,
    [ubers_seen] [int] DEFAULT 0,
    [ubers_connected] [int] DEFAULT 0,
    [ubers_uploaded] [int] DEFAULT 0,
    [handlers_seen] [int] DEFAULT 0,
    [handlers_connected] [int] DEFAULT 0,
    [handlers_uploaded] [int] DEFAULT 0
	) ON [PRIMARY]
GO

DECLARE @cnt INT = 0;

WHILE @cnt < 450
BEGIN


INSERT INTO [dbo].[badges]
           ([id0]
           ,[lastseen])
     VALUES
           (@cnt,
           SYSDATETIME());

SET @cnt = @cnt + 1;

END;
GO

INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 0 ,'Nagatha');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 1 ,'Kermit');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 2 ,'Niubi');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 3 ,'Marvin');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 4 ,'BLUE BOLT');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 5 ,'The Master');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 6 ,'XedGeek');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 7 ,'Skippy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 8 ,'Daddy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 9 ,'Sphincter');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 10 ,'Spork');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 11 ,'Lipsyncki');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 12 ,'Parzival');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 13 ,'Pupper');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 14 ,'Kresimir');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 15 ,'Awesome');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 16 ,'EagleEye');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 17 ,'ToppyPants');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 18 ,'MrSaturn');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 19 ,'Dmitri');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 20 ,'Tripwire');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 21 ,'MeshPotato');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 22 ,'Mr. Badge');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 23 ,'Rehpic');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 24 ,'Horace');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 25 ,'Robert');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 26 ,'Agatha');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 27 ,'Peter');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 28 ,'Ogg');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 29 ,'Lewis');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 30 ,'Willie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 31 ,'Bort');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 32 ,'Roger');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 33 ,'Pinkie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 34 ,'Brain');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 35 ,'Homer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 36 ,'Doobie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 37 ,'Greg');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 38 ,'Craig');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 39 ,'Leo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 40 ,'Goober');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 41 ,'Leslie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 42 ,'Bagel');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 43 ,'Frodo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 44 ,'Spanky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 45 ,'Billo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 46 ,'Teddy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 47 ,'Ducky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 48 ,'Catfish');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 49 ,'Doodle');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 50 ,'Bunny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 51 ,'Champ');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 52 ,'Cowboy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 53 ,'Woody');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 54 ,'Bitsy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 55 ,'Cubster');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 56 ,'Diddles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 57 ,'Doozer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 58 ,'Tilly');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 59 ,'Winters');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 60 ,'Ted');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 61 ,'Turbo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 62 ,'Tyke');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 63 ,'Toodles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 64 ,'Tabby');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 65 ,'Tink');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 66 ,'Tiger');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 67 ,'Turtle');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 68 ,'Abner');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 69 ,'Alfred');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 70 ,'Alvin');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 71 ,'Anton');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 72 ,'Apollo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 73 ,'Aquila');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 74 ,'Armand');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 75 ,'Arthur');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 76 ,'Ashton');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 77 ,'Atticus');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 78 ,'Dawson');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 79 ,'Captain');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 80 ,'Dominic');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 81 ,'Earl');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 82 ,'Duke');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 83 ,'Elmer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 84 ,'Ernest');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 85 ,'Finley');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 86 ,'Fletcher');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 87 ,'Gavin');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 88 ,'Gilbert');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 89 ,'Gus');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 90 ,'Nohomer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 91 ,'Irving');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 92 ,'Lolly');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 93 ,'Alfie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 94 ,'Archie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 95 ,'Barney');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 96 ,'Nico');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 97 ,'Ozzie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 98 ,'Ginger');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 99 ,'Lollypop');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 100 ,'Oreo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 101 ,'Mango');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 102 ,'Sunny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 103 ,'Robocall');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 104 ,'Maverick');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 105 ,'Morris');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 106 ,'Niles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 107 ,'Phineas');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 108 ,'Speedo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 109 ,'Sansa');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 110 ,'Blue');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 111 ,'Emmy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 112 ,'Avocado');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 113 ,'Jellybean');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 114 ,'Biscuit');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 115 ,'Loser');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 116 ,'Randy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 117 ,'Peanut');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 118 ,'Dotty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 119 ,'Nuggie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 120 ,'Princess');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 121 ,'Calvin');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 122 ,'Benji');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 123 ,'Monty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 124 ,'Remington');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 125 ,'Thaddeus');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 126 ,'Sprout');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 127 ,'Tadpole');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 128 ,'Rainbow');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 129 ,'Skyhook');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 130 ,'Dorkness');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 131 ,'Marley');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 132 ,'Allspark');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 133 ,'Plexi');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 134 ,'Dixie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 135 ,'Fifi');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 136 ,'Frankie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 137 ,'Johnnie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 138 ,'Kitty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 139 ,'Lulu');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 140 ,'Minnie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 141 ,'Nellie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 142 ,'Sam');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 143 ,'Vinnie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 144 ,'Toasty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 145 ,'Buttons');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 146 ,'Copper');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 147 ,'Astro');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 148 ,'Felix');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 149 ,'Newbie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 150 ,'Sparrow');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 151 ,'Bandit');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 152 ,'Hashtag');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 153 ,'Titan');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 154 ,'Daffy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 155 ,'Chipmunk');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 156 ,'Nipper');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 157 ,'Poodles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 158 ,'Junior');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 159 ,'Wiggles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 160 ,'Zippy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 161 ,'Twinkles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 162 ,'Boo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 163 ,'Tiddles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 164 ,'Buckaroo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 165 ,'Noodles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 166 ,'Pookie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 167 ,'Tricks');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 168 ,'Hamlet');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 169 ,'Tootsie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 170 ,'Angel');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 171 ,'Bestie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 172 ,'Clumsy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 173 ,'Cookie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 174 ,'Daisy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 175 ,'Dimples');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 176 ,'Giggles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 177 ,'Rhubarb');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 178 ,'Muggle');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 179 ,'Muppet');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 180 ,'Peach');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 181 ,'Sparkles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 182 ,'Bub');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 183 ,'Charcoal');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 184 ,'Hammer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 185 ,'Kiddo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 186 ,'McHottie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 187 ,'Numbnuts');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 188 ,'Papi');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 189 ,'Quackers');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 190 ,'Alaska');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 191 ,'Nebraska');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 192 ,'Montana');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 193 ,'Vegas');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 194 ,'Nuggets');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 195 ,'Arizona');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 196 ,'Waddles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 197 ,'Purrfect');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 198 ,'Knocknee');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 199 ,'Leopard');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 200 ,'Horsey');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 201 ,'Marsha');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 202 ,'Lorraine');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 203 ,'Wendell');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 204 ,'Herman');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 205 ,'Pauline');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 206 ,'Norma');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 207 ,'Darlena');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 208 ,'Ping Pong');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 209 ,'Buttercup');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 210 ,'Firefly');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 211 ,'Kit Kat');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 212 ,'Killer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 213 ,'Penguin');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 214 ,'Tater Tot');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 215 ,'Zorro');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 216 ,'Yankee');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 217 ,'Rocky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 218 ,'Smellie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 219 ,'Binky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 220 ,'Capslock');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 221 ,'Emperor');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 222 ,'Lockstep');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 223 ,'Hero');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 224 ,'Honeybuns');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 225 ,'Donut');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 226 ,'Lilly');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 227 ,'Penny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 228 ,'Sailor');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 229 ,'Callum');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 230 ,'Deckhand');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 231 ,'Augustus');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 232 ,'Fitz');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 233 ,'Spout');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 234 ,'Dipdip');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 235 ,'Looker');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 236 ,'Major');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 237 ,'Pudding');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 238 ,'Rucksack');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 239 ,'Attache');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 240 ,'Commando');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 241 ,'Jock');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 242 ,'Stud');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 243 ,'Tarzan');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 244 ,'Beast');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 245 ,'Bouncer');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 246 ,'Bruiser');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 247 ,'Hotshot');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 248 ,'Muddles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 249 ,'Eclair');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 250 ,'Professor');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 251 ,'Pinenut');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 252 ,'Laspass');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 253 ,'Twinkle');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 254 ,'Bambina');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 255 ,'Halfpint');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 256 ,'Zinc');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 257 ,'Comet');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 258 ,'Firsty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 259 ,'Bruno');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 260 ,'Jimmy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 261 ,'Mitch');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 262 ,'Newton');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 263 ,'Louie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 264 ,'Pebbles');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 265 ,'Sparky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 266 ,'Simba');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 267 ,'Chepito');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 268 ,'Louey');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 269 ,'Chuck');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 270 ,'Wonka');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 271 ,'Carrie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 272 ,'Becca');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 273 ,'Franny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 274 ,'Beeboop');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 275 ,'Weezy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 276 ,'Doober');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 277 ,'Longjohn');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 278 ,'Skrillex');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 279 ,'Lassie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 280 ,'Fisher');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 281 ,'Nikki');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 282 ,'Justy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 283 ,'Einstein');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 284 ,'Robot');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 285 ,'Badge');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 286 ,'Bloop');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 287 ,'Rugrat');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 288 ,'Dorp');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 289 ,'Dingdong');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 290 ,'Tupac');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 291 ,'Horcrux');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 292 ,'Eeyore');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 293 ,'Pinwheel');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 294 ,'Limbo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 295 ,'Fry');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 296 ,'Flywheel');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 297 ,'Clamps');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 298 ,'Porker');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 299 ,'Loopy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 300 ,'Stormy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 301 ,'Lightning');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 302 ,'Lampshade');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 303 ,'Alastair');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 304 ,'Abbatoir');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 305 ,'Speedbump');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 306 ,'Dorky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 307 ,'Rambo');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 308 ,'Blast');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 309 ,'Knock');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 310 ,'Buzz');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 311 ,'Darkness');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 312 ,'Tiny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 313 ,'Rebound');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 314 ,'Tipsy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 315 ,'Wigwam');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 316 ,'Reebok');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 317 ,'Shasta');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 318 ,'Zortec');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 319 ,'Nibbler');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 320 ,'Spins');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 321 ,'Abraham');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 322 ,'Hanky');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 323 ,'Augie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 324 ,'Flagpole');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 325 ,'Dick');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 326 ,'Dobby');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 327 ,'Cager');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 328 ,'Cuddy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 329 ,'Fanny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 330 ,'Gene');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 331 ,'Tech');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 332 ,'HAL');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 333 ,'Jude');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 334 ,'Kit');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 335 ,'Lazar');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 336 ,'Larry');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 337 ,'Lugnut');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 338 ,'Mal');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 339 ,'Gnat');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 340 ,'Ned');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 341 ,'Newt');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 342 ,'Ollie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 343 ,'Paddy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 344 ,'Lights');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 345 ,'Quill');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 346 ,'Apple');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 347 ,'Sandy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 348 ,'Si');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 349 ,'Tad');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 350 ,'Corrin');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 351 ,'Abbie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 352 ,'Babs');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 353 ,'Allie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 354 ,'Booty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 355 ,'Gordie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 356 ,'Clem');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 357 ,'Bella');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 358 ,'Betty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 359 ,'Biddie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 360 ,'Brit-brit');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 361 ,'Broken');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 362 ,'Cassie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 363 ,'Clara');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 364 ,'Lasso');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 365 ,'Pooh');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 366 ,'Quantum');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 367 ,'Vector');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 368 ,'Paradigm');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 369 ,'Cyber');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 370 ,'Cypher');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 371 ,'Darkweb');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 372 ,'Delia');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 373 ,'Delphia');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 374 ,'Darknet');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 375 ,'Dolly');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 376 ,'Donia');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 377 ,'Silicon');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 378 ,'Edie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 379 ,'Charger');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 380 ,'Dork');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 381 ,'Elsie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 382 ,'Nessie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 383 ,'Etta');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 384 ,'Chicken');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 385 ,'Sloop');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 386 ,'Flora');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 387 ,'Knickers');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 388 ,'Digdug');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 389 ,'Alleyoop');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 390 ,'Gerty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 391 ,'Ginny');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 392 ,'Gussie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 393 ,'Hatty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 394 ,'Nope');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 395 ,'Staypuft');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 396 ,'Hetty');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 397 ,'Lena');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 398 ,'Maybel');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 399 ,'Madge');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 400 ,'Midge');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 401 ,'Mimi');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 402 ,'Nora');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 403 ,'Patsy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 404 ,'Puss');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 405 ,'Turkey');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 406 ,'Electra');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 407 ,'Deadpan');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 408 ,'Deadpool');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 409 ,'Leela');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 410 ,'Avast');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 411 ,'Phish');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 412 ,'Camptown');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 413 ,'Nails');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 414 ,'Lorax');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 415 ,'Minion');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 416 ,'Doorbell');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 417 ,'Lightbulb');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 418 ,'Twiggy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 419 ,'Picasso');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 420 ,'Roebuck');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 421 ,'Tesla');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 422 ,'7of9');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 423 ,'Refill');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 424 ,'Greenie');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 425 ,'Shortcut');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 426 ,'Lastpass');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 427 ,'Zero');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 428 ,'One');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 429 ,'Two');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 430 ,'Three');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 431 ,'Four');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 432 ,'Five');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 433 ,'Six');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 434 ,'Seven');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 435 ,'Eight');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 436 ,'Eleven');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 437 ,'Fourteen');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 438 ,'Butter');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 439 ,'Livery');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 440 ,'Earbud');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 441 ,'Beer can');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 442 ,'Cylinder');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 443 ,'Roundy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 444 ,'Reboot');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 445 ,'Button');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 446 ,'Dopey');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 447 ,'Sleepy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 448 ,'Grumpy');
INSERT INTO [dbo].[badgestats] ([id0], [badgename]) VALUES ( 449 ,'Doc');


