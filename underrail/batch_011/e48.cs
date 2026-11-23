using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200165B RID: 5723
[d1q("Pyrokinesis")]
public sealed class e48 : bmv
{
	// Token: 0x06007D44 RID: 32068 RVA: 0x0034BC1C File Offset: 0x00349E1C
	public override afq ba()
	{
		return new dfs();
	}

	// Token: 0x06007D45 RID: 32069 RVA: 0x0034BC24 File Offset: 0x00349E24
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Fire
		};
	}

	// Token: 0x06007D46 RID: 32070 RVA: 0x0034BC34 File Offset: 0x00349E34
	public override List<byte> sb()
	{
		return new List<byte>
		{
			5
		};
	}
}
