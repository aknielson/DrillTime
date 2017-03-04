CREATE TABLE [dbo].[LogEntry] (
    [Id]                    INT        IDENTITY (1, 1) NOT NULL,
    [DrillRunDate]          DATETIME   NULL,
    [DrillId]               INT        NULL,
    [DrillStartParTime]     FLOAT (53) NULL,
    [DrillSEndParTime]      FLOAT (53) NULL,
    [DrillTimeSpanSeconds]  INT        NULL,
    [DrillReps]             INT        NULL,
    [PreviousLogIdForDrill] INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LogEntry_Drills] FOREIGN KEY ([DrillId]) REFERENCES [dbo].[Drills] ([Id]),
    CONSTRAINT [FK_LogEntry_LogEntry] FOREIGN KEY ([PreviousLogIdForDrill]) REFERENCES [dbo].[LogEntry] ([Id])
);





