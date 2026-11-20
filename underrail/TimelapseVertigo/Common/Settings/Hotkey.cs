using System;

namespace TimelapseVertigo.Common.Settings
{
	// Token: 0x02000048 RID: 72
	[eiz("eHK")]
	[Serializable]
	public enum Hotkey
	{
		// Token: 0x04000211 RID: 529
		[cia]
		None,
		// Token: 0x04000212 RID: 530
		[cgf("Help Screen")]
		HelpScreen,
		// Token: 0x04000213 RID: 531
		[cgf("Quick Save")]
		QuickSave,
		// Token: 0x04000214 RID: 532
		[cgf("Quick Load")]
		QuickLoad,
		// Token: 0x04000215 RID: 533
		[cgf("Toggle HUD")]
		ToggleHUD,
		// Token: 0x04000216 RID: 534
		[cia]
		Escape,
		// Token: 0x04000217 RID: 535
		[cgf("Action Button 1")]
		ActionButton1 = 11,
		// Token: 0x04000218 RID: 536
		[cgf("Action Button 2")]
		ActionButton2,
		// Token: 0x04000219 RID: 537
		[cgf("Action Button 3")]
		ActionButton3,
		// Token: 0x0400021A RID: 538
		[cgf("Action Button 4")]
		ActionButton4,
		// Token: 0x0400021B RID: 539
		[cgf("Action Button 5")]
		ActionButton5,
		// Token: 0x0400021C RID: 540
		[cgf("Action Button 6")]
		ActionButton6,
		// Token: 0x0400021D RID: 541
		[cgf("Action Button 7")]
		ActionButton7,
		// Token: 0x0400021E RID: 542
		[cgf("Action Button 8")]
		ActionButton8,
		// Token: 0x0400021F RID: 543
		[cgf("Action Button 9")]
		ActionButton9,
		// Token: 0x04000220 RID: 544
		[cgf("Quick Button 1")]
		QuickButton1 = 21,
		// Token: 0x04000221 RID: 545
		[cgf("Quick Button 2")]
		QuickButton2,
		// Token: 0x04000222 RID: 546
		[cgf("Quick Button 3")]
		QuickButton3,
		// Token: 0x04000223 RID: 547
		[cgf("Quick Button 4")]
		QuickButton4,
		// Token: 0x04000224 RID: 548
		[cgf("Quick Button 5")]
		QuickButton5,
		// Token: 0x04000225 RID: 549
		[cgf("Quick Button 6")]
		QuickButton6,
		// Token: 0x04000226 RID: 550
		[cgf("Swap Weapon")]
		SwapWeapon,
		// Token: 0x04000227 RID: 551
		[cia]
		[cgf("Reload Current Weapon")]
		ReloadCurrentWeapon,
		// Token: 0x04000228 RID: 552
		[cgf("Toggle Energy Shield")]
		ToggleShield,
		// Token: 0x04000229 RID: 553
		[cgf("Recharge Shield")]
		RechargeShield,
		// Token: 0x0400022A RID: 554
		[cgf("End Turn")]
		EndTurn,
		// Token: 0x0400022B RID: 555
		[cgf("Start/End Combat")]
		EndCombat,
		// Token: 0x0400022C RID: 556
		[cgf("Speed Up")]
		SpeedUp,
		// Token: 0x0400022D RID: 557
		[cgf("Slow Down")]
		SlowDown,
		// Token: 0x0400022E RID: 558
		[cgf("Highlight")]
		Highlight,
		// Token: 0x0400022F RID: 559
		[cgf("Reverse Highlight")]
		ReverseHighlight,
		// Token: 0x04000230 RID: 560
		[cgf("Toggle Follow Player")]
		ToggleFollowPlayer,
		// Token: 0x04000231 RID: 561
		[cgf("Quick Invoker")]
		QuickInvoker = 40,
		// Token: 0x04000232 RID: 562
		[cgf("Combat Stats")]
		CombatStatsOverview,
		// Token: 0x04000233 RID: 563
		[cgf("Character Sheet")]
		CharacterSheet,
		// Token: 0x04000234 RID: 564
		[cgf("Crafting Window")]
		CraftingWindow,
		// Token: 0x04000235 RID: 565
		[cgf("Inventory")]
		Inventory,
		// Token: 0x04000236 RID: 566
		[cgf("Notes")]
		Notes,
		// Token: 0x04000237 RID: 567
		[cgf("Oddities Window")]
		OdditiesWindow,
		// Token: 0x04000238 RID: 568
		[cgf("Vehicle Window")]
		[af(new string[]
		{
			"xpbl"
		})]
		VehicleWindow,
		// Token: 0x04000239 RID: 569
		[cgf("Global Map Window")]
		GlobalMapWindow,
		// Token: 0x0400023A RID: 570
		[cgf("Psi")]
		Psi,
		// Token: 0x0400023B RID: 571
		[cgf("Take All")]
		TakeAll,
		// Token: 0x0400023C RID: 572
		[cgf("Scroll Up")]
		ScrollUp = 60,
		// Token: 0x0400023D RID: 573
		[cgf("Scroll Down")]
		ScrollDown,
		// Token: 0x0400023E RID: 574
		[cgf("Scroll Left")]
		ScrollLeft,
		// Token: 0x0400023F RID: 575
		[cgf("Scroll Right")]
		ScrollRight
	}
}
