using System;

namespace TimelapseVertigo.Common.Settings
{
	// Token: 0x0200004B RID: 75
	[eiz("eSCTXOP")]
	[Flags]
	[Serializable]
	public enum ScrollingCombatTextOptions
	{
		// Token: 0x0400025E RID: 606
		Mandatory = 0,
		// Token: 0x0400025F RID: 607
		Damage = 1,
		// Token: 0x04000260 RID: 608
		PeriodicDamage = 2,
		// Token: 0x04000261 RID: 609
		Healing = 4,
		// Token: 0x04000262 RID: 610
		ShieldGain = 8,
		// Token: 0x04000263 RID: 611
		ShieldLoss = 16,
		// Token: 0x04000264 RID: 612
		PsiGain = 32,
		// Token: 0x04000265 RID: 613
		PsiLoss = 64,
		// Token: 0x04000266 RID: 614
		Buffs = 128,
		// Token: 0x04000267 RID: 615
		Debuffs = 256,
		// Token: 0x04000268 RID: 616
		ResistsSImmunities = 512,
		// Token: 0x04000269 RID: 617
		ApCarryover = 1024,
		// Token: 0x0400026A RID: 618
		SpecialActions = 2048,
		// Token: 0x0400026B RID: 619
		Initiative = 4096,
		// Token: 0x0400026C RID: 620
		All = 8191
	}
}
