using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000619 RID: 1561
[e7l(SpellTargetType.DiscoveredUnoccupiedTraversableSpot)]
public sealed class dx7 : ep5
{
	// Token: 0x06002856 RID: 10326 RVA: 0x000E83C0 File Offset: 0x000E65C0
	public dx7(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x000E83CC File Offset: 0x000E65CC
	public override bool ajz(ak1 A_0)
	{
		if (!base.ajz(A_0))
		{
			return false;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bm6 a_ = null;
		if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			a_ = serviceOrThrow.aqu().v().b().GetAspect<bm6>();
		}
		return aw1.a(A_0, a_) == 0L;
	}

	// Token: 0x06002858 RID: 10328 RVA: 0x000E8438 File Offset: 0x000E6638
	public override bool aqj(ak1 A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bm6 a_ = null;
		if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			a_ = serviceOrThrow.aqu().v().b().GetAspect<bm6>();
		}
		return (!A_0.Formation.b(2L) || A_0.Formation.b(128L)) && aw1.a(A_0, a_) == 0L;
	}
}
