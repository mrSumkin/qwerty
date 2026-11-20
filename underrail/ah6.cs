using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200063E RID: 1598
[e7l(SpellTargetType.SharpenableWeapon)]
public sealed class ah6 : atd
{
	// Token: 0x060028D7 RID: 10455 RVA: 0x000E9BA0 File Offset: 0x000E7DA0
	public ah6(av A_0)
	{
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x000E9BAC File Offset: 0x000E7DAC
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		if (cd != null && cd.TypedDefinition != null)
		{
			if (cd.TypedDefinition.a7().GetPrimitivePropertyValue<bool>(dii.b, new bool?(false)).Value)
			{
				return true;
			}
			if ((cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.BladedMelee)) || euf.c(cd.TypedDefinition.ak()))
			{
				using (List<edm>.Enumerator enumerator = cd.TypedDefinition.aa().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Name == "energyCut")
						{
							return false;
						}
					}
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x000E9CB4 File Offset: 0x000E7EB4
	public override bcw c5()
	{
		return bcw.c;
	}
}
