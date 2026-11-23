using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005FB RID: 1531
[e7l(SpellTargetType.ActiveCamera)]
public sealed class d36 : emk
{
	// Token: 0x06002814 RID: 10260 RVA: 0x000E7978 File Offset: 0x000E5B78
	public d36(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x000E7984 File Offset: 0x000E5B84
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().b(d8o.e) && c5x.t.b != null && string.Equals(c5x.t.b.ac(), "camera", StringComparison.OrdinalIgnoreCase))
		{
			dt5 aspect = c5x.GetAspect<dt5>();
			return aspect == null || aspect.e().GetValueOrDefault();
		}
		return false;
	}
}
