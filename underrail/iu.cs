using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020015B9 RID: 5561
[d1q("RapidFire")]
public sealed class iu : @if
{
	// Token: 0x06007B05 RID: 31493 RVA: 0x00336338 File Offset: 0x00334538
	public override afq g3()
	{
		return new s();
	}

	// Token: 0x06007B06 RID: 31494 RVA: 0x00336340 File Offset: 0x00334540
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Burst
		};
	}

	// Token: 0x06007B07 RID: 31495 RVA: 0x00336350 File Offset: 0x00334550
	public override int? g4()
	{
		return new int?(70);
	}
}
