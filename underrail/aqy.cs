using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200217D RID: 8573
[dp2("1.0.3.5_EnergyPistolRebalancing", "1.0.3.5")]
public sealed class aqy : dnv
{
	// Token: 0x0600C945 RID: 51525 RVA: 0x00471C90 File Offset: 0x0046FE90
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(bke);
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Plasma)
			{
				double num = 1.25;
				for (int i = 0; i < bke.l().Count; i++)
				{
					bke.l()[i] = new a1q(bke.l()[i].DamageType, (int)((double)bke.l()[i].LowerBoundary * num), (int)((double)bke.l()[i].UpperBoundary * num));
				}
			}
			else if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Laser)
			{
				bke bke2 = bke;
				bke2.a(bke2.v() - 7);
				bke bke3 = bke;
				bke3.d(bke3.k() * 0.8);
			}
		}
		return true;
	}

	// Token: 0x0600C946 RID: 51526 RVA: 0x00471D70 File Offset: 0x0046FF70
	public bool er(coh A_0)
	{
		return true;
	}
}
