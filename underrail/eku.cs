using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002175 RID: 8565
[dp2("1.0.4.11_SpearRangeChange", "1.0.4.11")]
public sealed class eku : dnv
{
	// Token: 0x0600C934 RID: 51508 RVA: 0x004715F0 File Offset: 0x0046F7F0
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && bke.ae().GetValueOrDefault() == WeaponSubtype.Spear)
		{
			bke.e(2);
		}
		return true;
	}

	// Token: 0x0600C935 RID: 51509 RVA: 0x0047162C File Offset: 0x0046F82C
	public bool er(coh A_0)
	{
		return true;
	}
}
