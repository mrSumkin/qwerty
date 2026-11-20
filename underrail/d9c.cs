using System;

// Token: 0x02000496 RID: 1174
internal static class d9c
{
	// Token: 0x06001E01 RID: 7681 RVA: 0x000A677C File Offset: 0x000A497C
	static d9c()
	{
		Random random = new Random(12041985);
		d9c.c = new double[d9c.b];
		d9c.e = new int[d9c.b];
		d9c.d = new float[d9c.b];
		for (int i = 0; i < d9c.b; i++)
		{
			d9c.c[i] = random.NextDouble();
			d9c.d[i] = (float)d9c.c[i];
			d9c.e[i] = random.Next();
		}
	}

	// Token: 0x04001297 RID: 4759
	private const int a = 12041985;

	// Token: 0x04001298 RID: 4760
	public static readonly int b = 10000;

	// Token: 0x04001299 RID: 4761
	public static double[] c;

	// Token: 0x0400129A RID: 4762
	public static float[] d;

	// Token: 0x0400129B RID: 4763
	public static int[] e;
}
