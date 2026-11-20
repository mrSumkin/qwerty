using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000623 RID: 1571
[e7l(SpellTargetType.OpenVentilationShaft)]
public sealed class hz : emk
{
	// Token: 0x0600287A RID: 10362 RVA: 0x000E8EB8 File Offset: 0x000E70B8
	public hz(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x000E8EC4 File Offset: 0x000E70C4
	public override bool f8(b0b A_0)
	{
		pa pa = A_0.GetAspect<bim>() as pa;
		return pa != null && pa.m();
	}
}
