using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000615 RID: 1557
[e7l(SpellTargetType.Trap)]
public sealed class azi : emk
{
	// Token: 0x0600284E RID: 10318 RVA: 0x000E826C File Offset: 0x000E646C
	public azi(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x000E8278 File Offset: 0x000E6478
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.r.b is ed2;
	}
}
