using System;

// Token: 0x020001A6 RID: 422
public static class bjn
{
	// Token: 0x06000C25 RID: 3109 RVA: 0x00030ADC File Offset: 0x0002ECDC
	public static chr d()
	{
		if (bjn.c == null)
		{
			bjn.c = bpo.GetService<chr>();
		}
		return bjn.c;
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00030AF8 File Offset: 0x0002ECF8
	public static d1a c()
	{
		if (bjn.b == null)
		{
			bjn.b = bpo.GetService<d1a>();
		}
		return bjn.b;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00030B14 File Offset: 0x0002ED14
	public static bcm b()
	{
		if (bjn.a == null)
		{
			bjn.a = bpo.GetService<bcm>();
		}
		return bjn.a;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00030B30 File Offset: 0x0002ED30
	public static d9d a()
	{
		if (bjn.d == null)
		{
			bjn.d = bpo.GetService<d9d>();
		}
		return bjn.d;
	}

	// Token: 0x04000737 RID: 1847
	private static bcm a;

	// Token: 0x04000738 RID: 1848
	private static d1a b;

	// Token: 0x04000739 RID: 1849
	private static chr c;

	// Token: 0x0400073A RID: 1850
	private static d9d d;
}
