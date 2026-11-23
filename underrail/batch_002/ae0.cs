using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001654 RID: 5716
[d1q("PyrokineticStream")]
public sealed class ae0 : bmv
{
	// Token: 0x06007D2D RID: 32045 RVA: 0x0034BB2C File Offset: 0x00349D2C
	public override afq g3()
	{
		return new c28();
	}

	// Token: 0x06007D2E RID: 32046 RVA: 0x0034BB34 File Offset: 0x00349D34
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Fire
		};
	}

	// Token: 0x06007D2F RID: 32047 RVA: 0x0034BB44 File Offset: 0x00349D44
	public override afq ml()
	{
		return new bn0(wm.a);
	}

	// Token: 0x06007D30 RID: 32048 RVA: 0x0034BB4C File Offset: 0x00349D4C
	public override afq ol()
	{
		return new bn0(wm.a);
	}
}
