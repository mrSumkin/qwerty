using System;

// Token: 0x02000107 RID: 263
public static class dr3
{
	// Token: 0x0600063F RID: 1599 RVA: 0x0001B0EC File Offset: 0x000192EC
	public static cvq e()
	{
		if (dr3.a == null)
		{
			dr3.a = bpo.GetService<cvq>();
		}
		return dr3.a;
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x0001B108 File Offset: 0x00019308
	public static d67 d()
	{
		if (dr3.b == null)
		{
			dr3.b = bpo.GetService<d67>();
		}
		return dr3.b;
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0001B124 File Offset: 0x00019324
	public static a1y c()
	{
		return bpo.GetService<a1y>();
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x0001B12C File Offset: 0x0001932C
	public static s6 b()
	{
		return bpo.GetService<s6>();
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x0001B134 File Offset: 0x00019334
	public static cne a()
	{
		if (dr3.c == null)
		{
			dr3.c = bpo.GetService<cne>();
		}
		return dr3.c;
	}

	// Token: 0x0400050C RID: 1292
	private static cvq a;

	// Token: 0x0400050D RID: 1293
	private static d67 b;

	// Token: 0x0400050E RID: 1294
	private static cne c;
}
