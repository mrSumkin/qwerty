using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020015AA RID: 5546
[d1q("shotgunBurst")]
public sealed class bqy : @if
{
	// Token: 0x06007AE6 RID: 31462 RVA: 0x00336238 File Offset: 0x00334438
	public override afq g3()
	{
		return new ae7();
	}

	// Token: 0x06007AE7 RID: 31463 RVA: 0x00336240 File Offset: 0x00334440
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Burst
		};
	}
}
