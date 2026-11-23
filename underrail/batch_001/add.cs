using System;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200063C RID: 1596
[e7l(SpellTargetType.PoisonableWeapon)]
public sealed class add : atd
{
	// Token: 0x060028D1 RID: 10449 RVA: 0x000E9A14 File Offset: 0x000E7C14
	public add(av A_0)
	{
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x000E9A20 File Offset: 0x000E7C20
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return cd != null && cd.TypedDefinition != null && ((cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.BladedMelee)) || euf.c(cd.TypedDefinition.ak()) || cd.TypedDefinition.a7().GetPrimitivePropertyValue<bool>(dii.a, new bool?(false)).Value);
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x000E9ABC File Offset: 0x000E7CBC
	public override bcw c5()
	{
		return bcw.c;
	}
}
