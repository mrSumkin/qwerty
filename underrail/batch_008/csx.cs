using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000610 RID: 1552
[e7l(SpellTargetType.LivingCreatureNotSelf)]
public sealed class csx : emk
{
	// Token: 0x06002842 RID: 10306 RVA: 0x000E8000 File Offset: 0x000E6200
	public csx(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x000E800C File Offset: 0x000E620C
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && (c5x.h.b != null && !c5x.h.b.aa().Dead && !c5x.h.b.aa().Passive && !c5x.h.b.aa().b(d8o.e)) && !c5x.h.b.@as();
	}
}
