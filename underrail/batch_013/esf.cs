using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002181 RID: 8577
[dp2("1.0.3.1_ChemicalPistolDamageBuff", "1.0.3.1")]
public sealed class esf : dnv
{
	// Token: 0x0600C950 RID: 51536 RVA: 0x004720E4 File Offset: 0x004702E4
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null)
		{
			if (euf.h(bke))
			{
				bke.b("ap");
				return true;
			}
			WeaponSubtype? weaponSubtype = euf.d(bke);
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Laser || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Plasma || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Electro)
			{
				bke.b("ep");
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600C951 RID: 51537 RVA: 0x00472154 File Offset: 0x00470354
	public bool er(coh A_0)
	{
		return true;
	}
}
