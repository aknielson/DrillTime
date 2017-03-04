CREATE TABLE [dbo].[Drills] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Name]              NCHAR (50)    NULL,
    [StartPosition]     VARCHAR (250) NULL,
    [Procedure]         VARCHAR (MAX) NULL,
    [SuggestedTimeSpan] INT           NULL,
    [SuggestedReps]     INT    NULL,
    [TargetPar]         FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

