using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000625 RID: 1573
[e7l(SpellTargetType.HumanoidNotSelf)]
public sealed class ea1 : emk
{
	// Token: 0x06002880 RID: 10368 RVA: 0x000E8F74 File Offset: 0x000E7174
	public ea1(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x000E8F80 File Offset: 0x000E7180
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.h.b != null && !c5x.h.b.@as() && c5x.h.b.aa().c(d8o.c);
	}
}
