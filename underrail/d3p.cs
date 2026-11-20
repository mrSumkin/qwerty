using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000617 RID: 1559
[e7l(SpellTargetType.CreatureNotSelf)]
public sealed class d3p : emk
{
	// Token: 0x06002852 RID: 10322 RVA: 0x000E82EC File Offset: 0x000E64EC
	public d3p(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x000E82F8 File Offset: 0x000E64F8
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.h.b != null && !c5x.h.b.@as();
	}
}
