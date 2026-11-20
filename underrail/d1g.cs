using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200182F RID: 6191
[d1q("pistolBurst")]
public sealed class d1g : @if
{
	// Token: 0x060083F7 RID: 33783 RVA: 0x00370490 File Offset: 0x0036E690
	public override afq g3()
	{
		return new enc();
	}

	// Token: 0x060083F8 RID: 33784 RVA: 0x00370498 File Offset: 0x0036E698
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Burst
		};
	}
}
