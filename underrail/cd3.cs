using System;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001711 RID: 5905
[d1q("ThreadBotFlamethrowerAttack")]
public sealed class cd3 : b8m
{
	// Token: 0x06007FD8 RID: 32728 RVA: 0x00360A88 File Offset: 0x0035EC88
	public override afq g3()
	{
		return new cov();
	}

	// Token: 0x06007FD9 RID: 32729 RVA: 0x00360A90 File Offset: 0x0035EC90
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Fire
		};
	}
}
