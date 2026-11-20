using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200163F RID: 5695
[d1q("TemporaryRewind")]
public sealed class bw6 : bmv
{
	// Token: 0x06007CF5 RID: 31989 RVA: 0x0034B8FC File Offset: 0x00349AFC
	public override afq ba()
	{
		return new df3();
	}

	// Token: 0x06007CF6 RID: 31990 RVA: 0x0034B904 File Offset: 0x00349B04
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Temporal
		};
	}
}
