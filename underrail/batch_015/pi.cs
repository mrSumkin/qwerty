using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005F8 RID: 1528
[e7l(SpellTargetType.BandagableLivingCreature)]
public sealed class pi : emk
{
	// Token: 0x0600280D RID: 10253 RVA: 0x000E77BC File Offset: 0x000E59BC
	public pi(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x000E77C8 File Offset: 0x000E59C8
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && !c5x.h.b.aa().Passive && !c5x.h.b.aa().b(d8o.e | d8o.s) && !c5x.h.b.aa().CustomProperties.GetPrimitivePropertyValue<bool>(ddm.l, new bool?(false)).Value && Math.Ceiling((double)(c5x.h.b.aa().Defense.q().zo() / Math.Max(1f, c5x.h.b.aa().Defense.q().zm()) * 100f)) / 100.0 > ec3.b(base.a());
	}
}
