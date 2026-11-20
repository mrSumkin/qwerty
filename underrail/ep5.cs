using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200060F RID: 1551
[e7l(SpellTargetType.DiscoveredTraversableSpot)]
public class ep5 : bww
{
	// Token: 0x06002840 RID: 10304 RVA: 0x000E7FBC File Offset: 0x000E61BC
	public ep5(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002841 RID: 10305 RVA: 0x000E7FC8 File Offset: 0x000E61C8
	public override bool ajz(ak1 A_0)
	{
		return base.ajz(A_0) && (!A_0.Formation.b(2L) || A_0.Formation.b(128L));
	}
}
