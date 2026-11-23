using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000622 RID: 1570
[e7l(SpellTargetType.ClosedVentilationShaft)]
public sealed class i8 : emk
{
	// Token: 0x06002878 RID: 10360 RVA: 0x000E8E80 File Offset: 0x000E7080
	public i8(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x000E8E8C File Offset: 0x000E708C
	public override bool f8(b0b A_0)
	{
		pa pa = A_0.GetAspect<bim>() as pa;
		return pa != null && !pa.m();
	}
}
