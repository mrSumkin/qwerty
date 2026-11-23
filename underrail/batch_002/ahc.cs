using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000640 RID: 1600
[e7l(SpellTargetType.FirearmWeapon)]
public sealed class ahc : atd
{
	// Token: 0x060028DD RID: 10461 RVA: 0x000E9D38 File Offset: 0x000E7F38
	public ahc(av A_0)
	{
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x000E9D44 File Offset: 0x000E7F44
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return cd != null && cd.TypedDefinition != null && eub.f(cd.TypedDefinition.ak());
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x000E9D7C File Offset: 0x000E7F7C
	public override bcw c5()
	{
		return bcw.c;
	}
}
