CREATE TABLE [dbo].[League] (
    [Team]   NCHAR (50) NOT NULL,
    [Wins]   INT        NULL,
    [Losses] INT        NULL,
    [Ties]   INT        NULL,
    PRIMARY KEY CLUSTERED ([Team] ASC)
);

