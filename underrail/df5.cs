using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000628 RID: 1576
[e7l(SpellTargetType.DiscoveredPenetrableSpot)]
public class df5 : bww
{
	// Token: 0x06002886 RID: 10374 RVA: 0x000E9008 File Offset: 0x000E7208
	public df5(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002887 RID: 10375 RVA: 0x000E9014 File Offset: 0x000E7214
	public override bool ajz(ak1 A_0)
	{
		return base.ajz(A_0) && !A_0.Formation.b(4L);
	}
}
