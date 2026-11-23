using System;

// Token: 0x02002096 RID: 8342
[dp2("1.3.0.0_Xphw_GrenadeLauncher_Nerf", "1.3.0.0")]
public sealed class c0t : dnv
{
	// Token: 0x0600C7A1 RID: 51105 RVA: 0x00465510 File Offset: 0x00463710
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && bke.e() == btz.h)
		{
			double num = 0.8;
			for (int i = 0; i < bke.l().Count; i++)
			{
				bke.l()[i] = new a1q(bke.l()[i].DamageType, (int)((double)bke.l()[i].LowerBoundary * num), (int)((double)bke.l()[i].UpperBoundary * num));
			}
		}
		return true;
	}

	// Token: 0x0600C7A2 RID: 51106 RVA: 0x004655B0 File Offset: 0x004637B0
	public bool er(coh A_0)
	{
		return true;
	}
}
