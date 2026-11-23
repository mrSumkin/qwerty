using System;

// Token: 0x02001BF7 RID: 7159
public static class cl5
{
	// Token: 0x06009BE1 RID: 39905 RVA: 0x003D2270 File Offset: 0x003D0470
	public static int a(coh A_0, efk A_1)
	{
		if (A_0 != null)
		{
			int num = A_0.Definition.a7().GetPrimitivePropertyValue<int>("DamagePerTurn", new int?(1)).Value;
			if (A_1 != null && A_1.Feats.Contains<dt>())
			{
				num = (int)((double)num * (1.0 + dt.a(A_1)));
			}
			return num;
		}
		return 1;
	}

	// Token: 0x06009BE2 RID: 39906 RVA: 0x003D22D8 File Offset: 0x003D04D8
	public static int d(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("PoisonDuration", new int?(1)).Value;
		}
		return 1;
	}

	// Token: 0x06009BE3 RID: 39907 RVA: 0x003D2310 File Offset: 0x003D0510
	public static string c(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetClassPropertyValue<string>("PoisonCode");
		}
		return null;
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x003D2330 File Offset: 0x003D0530
	public static string b(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetClassPropertyValue<string>("PoisonName");
		}
		return null;
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x003D2354 File Offset: 0x003D0554
	public static int a(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("MaxPoisonStacks", new int?(1)).Value;
		}
		return 1;
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x003D238C File Offset: 0x003D058C
	public static int a(int A_0, int A_1)
	{
		int num = 1;
		for (int i = 2; i <= A_1; i++)
		{
			num += i;
		}
		return (int)((double)(num * A_0) * ezx.w);
	}
}
