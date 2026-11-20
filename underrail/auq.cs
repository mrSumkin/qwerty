using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005FA RID: 1530
[e7l(SpellTargetType.Humanoid)]
public sealed class auq : emk
{
	// Token: 0x06002812 RID: 10258 RVA: 0x000E7928 File Offset: 0x000E5B28
	public auq(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002813 RID: 10259 RVA: 0x000E7934 File Offset: 0x000E5B34
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.h.b != null && c5x.h.b.aa().c(d8o.c);
	}
}
