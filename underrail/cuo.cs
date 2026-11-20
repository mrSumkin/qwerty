using System;
using System.Collections.Generic;

// Token: 0x02000495 RID: 1173
public static class cuo
{
	// Token: 0x06001DFD RID: 7677 RVA: 0x000A66D0 File Offset: 0x000A48D0
	public static List<T> ShuffleList<T>(List<T> list, int? seed = null)
	{
		Random random;
		if (seed != null)
		{
			random = new Random(seed.Value);
		}
		else
		{
			random = cuo.a;
		}
		for (int i = list.Count; i > 1; i--)
		{
			int index = random.Next(i);
			T value = list[i - 1];
			list[i - 1] = list[index];
			list[index] = value;
		}
		return list;
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x000A6740 File Offset: 0x000A4940
	public static double a(double A_0, double A_1)
	{
		return cuo.a.NextDouble() * (A_1 - A_0) + A_0;
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x000A6754 File Offset: 0x000A4954
	public static double a(double A_0)
	{
		return 1.0 - A_0 + cuo.a.NextDouble() * A_0;
	}

	// Token: 0x04001296 RID: 4758
	public static readonly Random a = new Random();
}
