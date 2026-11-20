using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005FD RID: 1533
[e7l(SpellTargetType.DiscoveredSpot)]
public class bww : a0h
{
	// Token: 0x06002818 RID: 10264 RVA: 0x000E7A70 File Offset: 0x000E5C70
	public bww(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x000E7A7C File Offset: 0x000E5C7C
	public override bool ajz(ak1 A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return A_0.a(serviceOrThrow.aqu().v().a().d);
	}
}
