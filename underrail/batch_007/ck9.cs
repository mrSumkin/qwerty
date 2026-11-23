using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005FC RID: 1532
[e7l(SpellTargetType.DiscoveredPenetrableSpotWithWater)]
public class ck9 : bww
{
	// Token: 0x06002816 RID: 10262 RVA: 0x000E7A34 File Offset: 0x000E5C34
	public ck9(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x000E7A40 File Offset: 0x000E5C40
	public override bool ajz(ak1 A_0)
	{
		return A_0 != null && base.ajz(A_0) && !A_0.Formation.b(4L) && aw1.a(A_0);
	}
}
