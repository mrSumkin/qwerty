using System;

// Token: 0x02002169 RID: 8553
[dp2("1.0.4.6_RepairAllSuits", "1.0.4.6")]
public sealed class dqu : dnv
{
	// Token: 0x0600C920 RID: 51488 RVA: 0x00471050 File Offset: 0x0046F250
	public bool eq(bk3 A_0)
	{
		return true;
	}

	// Token: 0x0600C921 RID: 51489 RVA: 0x00471054 File Offset: 0x0046F254
	public bool er(coh A_0)
	{
		c43 c = A_0.Definition as c43;
		if (c != null)
		{
			cgk cgk = A_0 as cgk;
			if (cgk != null && c.a8() <= 1 && cgk.Durability == 0.0)
			{
				cgk.Durability = (double)cgk.MaxDurability;
			}
		}
		return true;
	}
}
