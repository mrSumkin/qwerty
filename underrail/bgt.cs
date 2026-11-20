using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001815 RID: 6165
[d1q("Chainsaw")]
public sealed class bgt : @if
{
	// Token: 0x06008329 RID: 33577 RVA: 0x0036DD50 File Offset: 0x0036BF50
	public override afq g3()
	{
		return new nt();
	}

	// Token: 0x0600832A RID: 33578 RVA: 0x0036DD58 File Offset: 0x0036BF58
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Melee
		};
	}

	// Token: 0x0600832B RID: 33579 RVA: 0x0036DD68 File Offset: 0x0036BF68
	public override int? xv()
	{
		return new int?(5);
	}

	// Token: 0x0600832C RID: 33580 RVA: 0x0036DD70 File Offset: 0x0036BF70
	public override int? g4()
	{
		return new int?(int.MaxValue);
	}

	// Token: 0x0600832D RID: 33581 RVA: 0x0036DD7C File Offset: 0x0036BF7C
	public override string aak()
	{
		return "Chainsaw";
	}
}
