using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001644 RID: 5700
[d1q("TemporalDistorsion")]
public sealed class c2s : bmv
{
	// Token: 0x06007D03 RID: 32003 RVA: 0x0034B98C File Offset: 0x00349B8C
	public override afq ba()
	{
		return new c7h();
	}

	// Token: 0x06007D04 RID: 32004 RVA: 0x0034B994 File Offset: 0x00349B94
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Temporal
		};
	}
}
