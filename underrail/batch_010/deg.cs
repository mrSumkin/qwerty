using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000603 RID: 1539
[e7l(SpellTargetType.TowableNavalObject)]
public sealed class deg : emk
{
	// Token: 0x06002826 RID: 10278 RVA: 0x000E7BDC File Offset: 0x000E5DDC
	public deg(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x000E7BE8 File Offset: 0x000E5DE8
	public override bool f8(b0b A_0)
	{
		return A_0.GetAspect<bim>() is wv || A_0.GetAspect<bdf>() is atg;
	}
}
