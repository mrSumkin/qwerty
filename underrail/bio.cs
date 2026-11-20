using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000604 RID: 1540
[e7l(SpellTargetType.HumanoidNoVehicleNotSelf)]
public sealed class bio : emk
{
	// Token: 0x06002828 RID: 10280 RVA: 0x000E7C10 File Offset: 0x000E5E10
	public bio(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x000E7C1C File Offset: 0x000E5E1C
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.h.b != null && !c5x.h.b.@as() && c5x.h.b.aa().Vehicle == null && c5x.h.b.aa().c(d8o.c);
	}
}
