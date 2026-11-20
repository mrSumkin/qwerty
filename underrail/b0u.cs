using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000618 RID: 1560
[e7l(SpellTargetType.LivingCreature)]
public sealed class b0u : emk
{
	// Token: 0x06002854 RID: 10324 RVA: 0x000E8338 File Offset: 0x000E6538
	public b0u(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x000E8344 File Offset: 0x000E6544
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && (c5x.h.b != null && !c5x.h.b.aa().Dead && !c5x.h.b.aa().Passive) && !c5x.h.b.aa().b(d8o.e);
	}
}
