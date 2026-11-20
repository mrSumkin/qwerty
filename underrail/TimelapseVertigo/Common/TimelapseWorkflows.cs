using System;

namespace TimelapseVertigo.Common
{
	// Token: 0x02000035 RID: 53
	public enum TimelapseWorkflows
	{
		// Token: 0x040001A7 RID: 423
		InitProgram,
		// Token: 0x040001A8 RID: 424
		ExitProgram,
		// Token: 0x040001A9 RID: 425
		StartNewGame,
		// Token: 0x040001AA RID: 426
		ReturnToMainMenu,
		// Token: 0x040001AB RID: 427
		StartGameInLocale,
		// Token: 0x040001AC RID: 428
		QuitGameFromLocale,
		// Token: 0x040001AD RID: 429
		ChangeZone,
		// Token: 0x040001AE RID: 430
		SaveGame,
		// Token: 0x040001AF RID: 431
		LoadGameFromMainMenu,
		// Token: 0x040001B0 RID: 432
		LoadGameFromLocale,
		// Token: 0x040001B1 RID: 433
		MakeScreen,
		// Token: 0x040001B2 RID: 434
		OpenOptionsScreenWorkflow,
		// Token: 0x040001B3 RID: 435
		ExportCharacter,
		// Token: 0x040001B4 RID: 436
		StartCharacterGeneration,
		// Token: 0x040001B5 RID: 437
		GoToEndStory,
		// Token: 0x040001B6 RID: 438
		ReturnToMainMenuFromEndStory,
		// Token: 0x040001B7 RID: 439
		CompensateLoadGame = 101,
		// Token: 0x040001B8 RID: 440
		CompensateSaveGame,
		// Token: 0x040001B9 RID: 441
		CompensateChangeZone,
		// Token: 0x040001BA RID: 442
		CompensateExportCharacter,
		// Token: 0x040001BB RID: 443
		UndoLoadGame = 201,
		// Token: 0x040001BC RID: 444
		UndoSaveGame,
		// Token: 0x040001BD RID: 445
		UndoExportCharacter
	}
}
