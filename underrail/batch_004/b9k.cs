using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002114 RID: 8468
[dp2("1.1.3.0_FirearmPistolChanges", "1.1.3.0")]
public sealed class b9k : dnv
{
	// Token: 0x0600C871 RID: 51313 RVA: 0x0046AA1C File Offset: 0x00468C1C
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && !string.IsNullOrEmpty(bke.az()) && bke.e() == btz.a && bke.ae() != null && euf.g(bke.ae().Value) && bke.l().Count > 0 && bke.l()[0].DamageType == DamageType.Mechanical)
		{
			bke bke2 = bke;
			bke2.f(bke2.ai() + 0.03);
			bke.l()[0] = a1q.a(bke.l()[0], 1.25);
		}
		return true;
	}

	// Token: 0x0600C872 RID: 51314 RVA: 0x0046AAE4 File Offset: 0x00468CE4
	public bool er(coh A_0)
	{
		return true;
	}
}
