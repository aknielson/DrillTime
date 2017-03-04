IF (NOT EXISTS(SELECT * FROM [dbo].[Drills]))
BEGIN
   
	SET IDENTITY_INSERT [dbo].[Drills] ON 

	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure], [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (1, N'Sight Picture Confirmation', N'Standing in box A, hands naturally at sides', N'Draw and establish an acceptable sight picture on a blank wall (no target).  Finger should end on Trigger.  Do not pull the trigger', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure], [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (2, N'10-Yard Index', N'Standing in box A, hands naturally at sides', N'Draw and establish an acceptable sight picture on the lower A zone of T1.  Do not pull the trigger.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure], [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (3, N'10-Yard Surrender Index', N'Standing in box A, hands above shoulders', N'Draw and establish an acceptable sight picgture on the lower A-zone of T1.  Do not pull the trigger.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure], [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (4, N'Turn and Draw', N'Standing in box A, facing up rage away from the target the hands above shoulders', N'Trun, then draw and establish an acceptablde sight picgture on the lower A-zone of T1.  Do not pull the trigger.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure], [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (5, N'Strong Hand Index', N'Standing in box A, hands naturally at sides', N'Draw and establish an acceptable sight picture on the lower A-Zone of T1 with the strong hand only.  Do not pull the trigger.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],   [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (6, N'Weak Hand Index', N'Standing in box A, hands naturally at sides', N'Draw, transfer gun to weak hand and establish an acceptable sight picture on the lower A-zone of T1 with the weak hand only.  Do not pull the trigger.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],   [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (7, N'Burkett Reloads', N'Gun on targe in a freestyle position', N'Hit the mag button while bringing a new mag just to the edge of the magwell', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],   [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (8, N'6 Reload 6', N'Standing in box A, hands naturally at sides', N'Engage T1-T3 with two shots only, perform a reload, and then engate T1-T3 with two shots only', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],   [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (9, N'Surrender 6, Reload 6', N'Standing in box A, hands naturally at sides', N'Engage T1-T3 with two shots only, perform a reload, and then engate T1-T3 with two shots only', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],  [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (10, N'El Prez', N'Facing uprange away from the targets, hands above shoulders.', N'Turn, then draw and engage T1 - T3 with two shots only, perform a reload and engage T1 - T3 with two shots only.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],  [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (11, N'6 Reload Strong', N'Standing in box A, hands relaxed at sides.', N'Engage T1 - T3 with two shots only freestyle, perform a relad the engage T1 - T3 with two shots only with just the strong hand.', 0,0,0)
	
	INSERT [dbo].[Drills] ([Id], [Name], [StartPosition], [Procedure],  [SuggestedTimeSpan], [SuggestedReps], [TargetPar]) 
	VALUES (12, N'6 Reload Weak', N'Standing in box A, hands relaxed at sides.', N'Engage T1 - T3 with two shots only, perform a reload then engage T1 - T3 with just two shots with the weak hand only.',0,0,0)
	
	SET IDENTITY_INSERT [dbo].[Drills] OFF
	

END
