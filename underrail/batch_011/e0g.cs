using System;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200063D RID: 1597
[e7l(SpellTargetType.CapacitativeSheetCompatibleWeapon)]
public sealed class e0g : atd
{
	// Token: 0x060028D4 RID: 10452 RVA: 0x000E9AC0 File Offset: 0x000E7CC0
	public e0g(av A_0)
	{
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x000E9ACC File Offset: 0x000E7CCC
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return cd != null && !cd.TypedDefinition.a7().GetPrimitivePropertyValue<bool>(dii.b, new bool?(false)).Value && !cd.TypedDefinition.a7().GetPrimitivePropertyValue<bool>(dii.a, new bool?(false)).Value && (cd.TypedDefinition != null && cd.TypedDefinition.ae() != null) && (euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.BluntMelee) || euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.Gloves));
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x000E9B9C File Offset: 0x000E7D9C
	public override bcw c5()
	{
		return bcw.c;
	}
}
