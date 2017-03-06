IF (NOT EXISTS(SELECT * FROM [dbo].[LogEntries]))
BEGIN
	IF (EXISTS(SELECT * FROM [dbo].[Drills]))
	BEGIN

	SET IDENTITY_INSERT [dbo].[LogEntries] ON

	INSERT INTO [dbo].[LogEntries]
			   ([Id]
			   ,[DrillRunDate]
			   ,[DrillId]
			   ,[DrillStartParTime]
			   ,[DrillSEndParTime]
			   ,[DrillTimeSpanSeconds]
			   ,[DrillReps])
		 VALUES
			   (1,
			   GETDATE(),
			   1,
			   1.4,
			   1.4,
			   120,
			   15)

	SET IDENTITY_INSERT [dbo].[LogEntries] OFF
	END	
END