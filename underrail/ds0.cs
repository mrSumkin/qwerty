using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005FE RID: 1534
[e7l(SpellTargetType.Robot)]
public sealed class ds0 : emk
{
	// Token: 0x0600281A RID: 10266 RVA: 0x000E7AAC File Offset: 0x000E5CAC
	public ds0(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x000E7AB8 File Offset: 0x000E5CB8
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && (c5x.h.b != null && !c5x.h.b.aa().Dead && !c5x.h.b.aa().Passive) && c5x.h.b.aa().b(d8o.e);
	}
}
