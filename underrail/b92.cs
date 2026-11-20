using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001647 RID: 5703
[d1q("CryokineticOrb")]
public sealed class b92 : bmv
{
	// Token: 0x06007D0A RID: 32010 RVA: 0x0034B9CC File Offset: 0x00349BCC
	public override afq ba()
	{
		return new bvt();
	}

	// Token: 0x06007D0B RID: 32011 RVA: 0x0034B9D4 File Offset: 0x00349BD4
	public override CombatSpeakEvent[] b6(amc A_0)
	{
		return new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Battlecry_Frost
		};
	}

	// Token: 0x06007D0C RID: 32012 RVA: 0x0034B9E4 File Offset: 0x00349BE4
	public override List<byte> sb()
	{
		return new List<byte>
		{
			5
		};
	}
}
