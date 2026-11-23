using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000609 RID: 1545
[e7l(SpellTargetType.SpyableDoor)]
public sealed class ej7 : emk
{
	// Token: 0x06002832 RID: 10290 RVA: 0x000E7DB4 File Offset: 0x000E5FB4
	public ej7(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x000E7DC0 File Offset: 0x000E5FC0
	public override bool f8(b0b A_0)
	{
		cnb cnb = A_0.GetAspect<bim>() as cnb;
		return (cnb != null && cnb.e()) || A_0.GetAspect<daf>() != null;
	}
}
