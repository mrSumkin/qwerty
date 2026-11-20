using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200164F RID: 5711
[d1q("Enrage")]
public sealed class e41 : bmv
{
	// Token: 0x06007D20 RID: 32032 RVA: 0x0034BAAC File Offset: 0x00349CAC
	public override afq ba()
	{
		return new cb0();
	}

	// Token: 0x06007D21 RID: 32033 RVA: 0x0034BAB4 File Offset: 0x00349CB4
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Mind
		};
	}
}
