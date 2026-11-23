using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000644 RID: 1604
[e7l(SpellTargetType.BulletBasedWeapon)]
public sealed class eky : atd
{
	// Token: 0x060028E9 RID: 10473 RVA: 0x000E9F30 File Offset: 0x000E8130
	public eky(av A_0)
	{
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x000E9F3C File Offset: 0x000E813C
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return cd != null && cd.TypedDefinition != null && !cd.TypedDefinition.ao && cd.TypedDefinition.f() > 0 && (eub.f(cd.TypedDefinition.ak()) || eub.d(cd.TypedDefinition.ak()));
	}

	// Token: 0x060028EB RID: 10475 RVA: 0x000E9FAC File Offset: 0x000E81AC
	public override bcw c5()
	{
		return bcw.c;
	}
}
