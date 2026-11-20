using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002141 RID: 8513
[dp2("1.1.2.0_SpearheadSniperChange", "1.1.2.0")]
public sealed class as1 : dnv
{
	// Token: 0x0600C8C6 RID: 51398 RVA: 0x0046D91C File Offset: 0x0046BB1C
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && !string.IsNullOrEmpty(bke.az()) && bke.e() == btz.d && bke.ae().GetValueOrDefault() == WeaponSubtype.Sniper_762 && bke.az().Contains("Spearhead"))
		{
			int num = bke.v();
			bool flag = bke.az().Contains("Rapid");
			if (flag)
			{
				num = (int)((double)num * 1.25);
			}
			num += 2;
			if (flag)
			{
				num -= (int)((double)num * 0.2);
			}
			bke.a(num);
		}
		return true;
	}

	// Token: 0x0600C8C7 RID: 51399 RVA: 0x0046D9C8 File Offset: 0x0046BBC8
	public bool er(coh A_0)
	{
		return true;
	}
}
