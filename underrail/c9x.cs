using System;

// Token: 0x02002193 RID: 8595
[dp2("1.0.3.0_ChemicalPistolDamageBuff", "1.0.3.0")]
public sealed class c9x : dnv
{
	// Token: 0x0600C979 RID: 51577 RVA: 0x00473A00 File Offset: 0x00471C00
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && euf.h(bke))
		{
			for (int i = 0; i < bke.l().Count; i++)
			{
				a1q a1q = bke.l()[i];
				bke.l()[i] = new a1q(a1q.DamageType, (int)((double)a1q.LowerBoundary * 1.5), (int)((double)a1q.UpperBoundary * 1.5));
			}
		}
		return true;
	}

	// Token: 0x0600C97A RID: 51578 RVA: 0x00473A8C File Offset: 0x00471C8C
	public bool er(coh A_0)
	{
		return true;
	}
}
