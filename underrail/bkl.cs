using System;

// Token: 0x02002117 RID: 8471
[dp2("1.2.0.21_CraftedAssaultRiflesWithScopesIncreasedFocusPenalty", "1.2.0.21")]
public sealed class bkl : dnv
{
	// Token: 0x0600C87A RID: 51322 RVA: 0x0046ADAC File Offset: 0x00468FAC
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && bke.e() == btz.c && bke.az().StartsWith("Оснащённ. прицелом "))
		{
			bke.b(Math.Max(0.1, bke.aj()));
		}
		return true;
	}

	// Token: 0x0600C87B RID: 51323 RVA: 0x0046AE04 File Offset: 0x00469004
	public bool er(coh A_0)
	{
		return true;
	}
}
