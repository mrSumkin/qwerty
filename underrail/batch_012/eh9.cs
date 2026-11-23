using System;

// Token: 0x0200008D RID: 141
public static class eh9
{
	// Token: 0x06000364 RID: 868 RVA: 0x0000FE0C File Offset: 0x0000E00C
	public static int b()
	{
		return eh9.b;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0000FE14 File Offset: 0x0000E014
	public static void a(int A_0)
	{
		if (eh9.b != A_0)
		{
			eh9.b = A_0;
			eh9.a();
		}
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0000FE2C File Offset: 0x0000E02C
	private static void a()
	{
		eh9.c = (long)eh9.a * eh9.d + (long)eh9.b;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x0000FE48 File Offset: 0x0000E048
	static eh9()
	{
		eh9.a();
	}

	// Token: 0x04000403 RID: 1027
	public static readonly int a = 44;

	// Token: 0x04000404 RID: 1028
	private static int b = 0;

	// Token: 0x04000405 RID: 1029
	public static long c;

	// Token: 0x04000406 RID: 1030
	internal static long d = 10000000000L;
}
