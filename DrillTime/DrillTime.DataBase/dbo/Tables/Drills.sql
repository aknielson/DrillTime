CREATE TABLE [dbo].[Drills] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Name]              CHAR(50)    NULL,
    [StartPosition]     VARCHAR (250) NULL,
    [Procedure]         VARCHAR (MAX) NULL,
    [SuggestedTimeSpan] INT           NULL,
    [SuggestedReps]     INT    NULL,
    [TargetPar]         FLOAT (53)    NULL,
    [Tags] VARCHAR(250) NULL, 
    [DrillImage] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

