using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000630 RID: 1584
[e7l(SpellTargetType.VisibleSpot)]
public sealed class c0u : a0h
{
	// Token: 0x0600289E RID: 10398 RVA: 0x000E93C4 File Offset: 0x000E75C4
	public c0u(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x000E93D0 File Offset: 0x000E75D0
	public override bool ajz(ak1 A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return A_0.b(serviceOrThrow.aqu().v().a().d);
	}
}
