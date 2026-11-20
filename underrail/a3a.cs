using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001640 RID: 5696
[d1q("LimitedTemporalIncrement")]
public sealed class a3a : bmv
{
	// Token: 0x06007CF8 RID: 31992 RVA: 0x0034B91C File Offset: 0x00349B1C
	public override afq ba()
	{
		return new ege();
	}

	// Token: 0x06007CF9 RID: 31993 RVA: 0x0034B924 File Offset: 0x00349B24
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Temporal
		};
	}
}
