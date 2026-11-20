using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000605 RID: 1541
[e7l(SpellTargetType.HotwireableVehicle)]
public sealed class aul : emk
{
	// Token: 0x0600282A RID: 10282 RVA: 0x000E7C90 File Offset: 0x000E5E90
	public aul(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x000E7C9C File Offset: 0x000E5E9C
	public override bool f8(b0b A_0)
	{
		wv wv = A_0.GetAspect<bim>() as wv;
		return wv != null && wv.g() != null && !wv.g().af() && wv.g().t() > 0;
	}
}
