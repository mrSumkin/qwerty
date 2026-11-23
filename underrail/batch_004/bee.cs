using System;

// Token: 0x02001F55 RID: 8021
[ayj("PlaceBlackDragonPoisonBearTrap")]
public sealed class bee : blb
{
	// Token: 0x0600BB4E RID: 47950 RVA: 0x00414854 File Offset: 0x00412A54
	public override string y8()
	{
		return "Place Poisoned Bear Trap";
	}

	// Token: 0x0600BB4F RID: 47951 RVA: 0x0041485C File Offset: 0x00412A5C
	public override string os()
	{
		return "PlaceBlackDragonPoisonBearTrap";
	}

	// Token: 0x0600BB50 RID: 47952 RVA: 0x00414868 File Offset: 0x00412A68
	public override string bp(cnm A_0)
	{
		return qv.a("Traps/BlackDragonPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			l4.a(ezx.g, false)
		});
	}
}
