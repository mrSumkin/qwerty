using System;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200063F RID: 1599
[e7l(SpellTargetType.BladedMeleeWeapon)]
public sealed class bil : atd
{
	// Token: 0x060028DA RID: 10458 RVA: 0x000E9CB8 File Offset: 0x000E7EB8
	public bil(av A_0)
	{
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x000E9CC4 File Offset: 0x000E7EC4
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return cd != null && cd.TypedDefinition != null && ((cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.BladedMelee)) || euf.c(cd.TypedDefinition.ak()));
	}

	// Token: 0x060028DC RID: 10460 RVA: 0x000E9D34 File Offset: 0x000E7F34
	public override bcw c5()
	{
		return bcw.c;
	}
}
