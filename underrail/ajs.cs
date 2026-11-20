using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002116 RID: 8470
[dp2("1.1.5.0_SteelWeaponsChange", "1.1.5.0")]
public sealed class ajs : dnv
{
	// Token: 0x0600C877 RID: 51319 RVA: 0x0046ACCC File Offset: 0x00468ECC
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && !string.IsNullOrEmpty(bke.az()) && bke.e() == btz.g && bke.ae() != null && (bke.ae().GetValueOrDefault() == WeaponSubtype.Sledgehammer || bke.ae().GetValueOrDefault() == WeaponSubtype.Glove_Leather || bke.ae().GetValueOrDefault() == WeaponSubtype.Glove_Metal) && (bke.az().Contains("Покрыт. лезвиями ") || bke.az().Contains("Шипованн. ")))
		{
			bke.a7()[dii.a] = true;
		}
		return true;
	}

	// Token: 0x0600C878 RID: 51320 RVA: 0x0046AD9C File Offset: 0x00468F9C
	public bool er(coh A_0)
	{
		return true;
	}
}
