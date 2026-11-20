using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000639 RID: 1593
[e7l(SpellTargetType.ExplosiveCompatibleWeapon)]
public sealed class cb : atd
{
	// Token: 0x060028C7 RID: 10439 RVA: 0x000E9894 File Offset: 0x000E7A94
	public cb(av A_0)
	{
	}

	// Token: 0x060028C8 RID: 10440 RVA: 0x000E98A0 File Offset: 0x000E7AA0
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		if (cd != null && cd.TypedDefinition != null && cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.BluntMelee))
		{
			using (List<edm>.Enumerator enumerator = cd.TypedDefinition.aa().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Name == "electroshockAoe")
					{
						return false;
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x060028C9 RID: 10441 RVA: 0x000E9968 File Offset: 0x000E7B68
	public override bcw c5()
	{
		return bcw.c;
	}
}
