using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200217E RID: 8574
[dp2("1.0.3.17_WeightySniperFix", "1.0.3.17")]
public sealed class c7x : dnv
{
	// Token: 0x0600C948 RID: 51528 RVA: 0x00471D80 File Offset: 0x0046FF80
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && bke.a4() >= 50.0)
		{
			WeaponSubtype? weaponSubtype = euf.d(bke);
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Sniper_127 || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Sniper_762 || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Sniper_86)
			{
				List<coh> classPropertyValue = bke.a7().GetClassPropertyValue<List<coh>>("Components");
				if (classPropertyValue != null && classPropertyValue.Count > 0)
				{
					bke.h(0.0);
					using (List<coh>.Enumerator enumerator = classPropertyValue.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							coh coh = enumerator.Current;
							bke bke2 = bke;
							bke2.h(bke2.a4() + coh.Weight);
						}
						return true;
					}
				}
				bke.h(5.0);
			}
		}
		return true;
	}

	// Token: 0x0600C949 RID: 51529 RVA: 0x00471E78 File Offset: 0x00470078
	public bool er(coh A_0)
	{
		return true;
	}
}
