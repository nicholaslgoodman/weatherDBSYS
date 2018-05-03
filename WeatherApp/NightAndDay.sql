﻿CREATE TABLE [dbo].[NightAndDay]
(
	[Date] DATE NOT NULL , 
    [ZIP] INT NOT NULL , 
    [Moonrise] TIME NULL, 
    [Moonset] TIME NULL, 
    [Sunrise] TIME NULL, 
    [Sunset] TIME NULL,
	 [LocationCity] NCHAR(10) NULL, 
    [LocationState] NCHAR(10) NULL, 
    CONSTRAINT [PK_Rise] PRIMARY KEY CLUSTERED ([ZIP] ASC, [Date] ASC)
)
