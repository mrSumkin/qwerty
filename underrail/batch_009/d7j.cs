using System;

// Token: 0x02002168 RID: 8552
[dp2("1.0.4.10_RepairAllSuits2", "1.0.4.10")]
public sealed class d7j : dnv
{
	// Token: 0x0600C91D RID: 51485 RVA: 0x00470FB4 File Offset: 0x0046F1B4
	public bool eq(bk3 A_0)
	{
		return true;
	}

	// Token: 0x0600C91E RID: 51486 RVA: 0x00470FB8 File Offset: 0x0046F1B8
	public bool er(coh A_0)
	{
		c43 c = A_0.Definition as c43;
		if (c != null)
		{
			cgk cgk = A_0 as cgk;
			if (cgk != null && cgk.Durability == 0.0 && (c.a5() == "gauntletRunnerJumpsuit" || c.a5() == "tchnob" || c.a5() == "robe"))
			{
				cgk.Durability = (double)cgk.MaxDurability;
			}
		}
		return true;
	}
}
