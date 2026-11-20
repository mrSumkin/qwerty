using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200063B RID: 1595
[e7l(SpellTargetType.FirearmWeaponNotLauncher)]
public sealed class dk0 : atd
{
	// Token: 0x060028CE RID: 10446 RVA: 0x000E99A4 File Offset: 0x000E7BA4
	public dk0(av A_0)
	{
	}

	// Token: 0x060028CF RID: 10447 RVA: 0x000E99B0 File Offset: 0x000E7BB0
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return cd != null && cd.TypedDefinition != null && eub.f(cd.TypedDefinition.ak()) && cd.TypedDefinition.e() != btz.h && cd.TypedDefinition.e() != btz.l;
	}

	// Token: 0x060028D0 RID: 10448 RVA: 0x000E9A10 File Offset: 0x000E7C10
	public override bcw c5()
	{
		return bcw.c;
	}
}
