using System;

// Token: 0x02001625 RID: 5669
public static class u6
{
	// Token: 0x06007C92 RID: 31890 RVA: 0x00347F70 File Offset: 0x00346170
	public static cr a(efk A_0, int A_1)
	{
		if (!A_0.c(d8o.e) && !A_0.Passive)
		{
			cr cr = new cr();
			if (A_0.StatusEffects.a(am0.a))
			{
				cr.Stacks = A_1 * 2;
			}
			else
			{
				cr.Stacks = A_1;
			}
			return cr;
		}
		return null;
	}

	// Token: 0x06007C93 RID: 31891 RVA: 0x00347FC8 File Offset: 0x003461C8
	public static void a(amc A_0, bool A_1)
	{
		if (A_0.aa().Feats.Contains<dyi>())
		{
			A_0.a8().Zone.ActionManager.g9(new amd(A_0, new els[]
			{
				new cvb(A_1)
			}), atp.a);
		}
	}

	// Token: 0x06007C94 RID: 31892 RVA: 0x00348018 File Offset: 0x00346218
	public static void a(amc A_0)
	{
		foreach (cvb a_ in A_0.aa().StatusEffects.Get<cvb>())
		{
			A_0.aa().StatusEffects.d(a_);
		}
	}
}
