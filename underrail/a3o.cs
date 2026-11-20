using System;

// Token: 0x02001FC6 RID: 8134
public static class a3o
{
	// Token: 0x0600BF1C RID: 48924 RVA: 0x00421DE8 File Offset: 0x0041FFE8
	public static void c()
	{
		a3o.a = new DateTime?(DateTime.Now + TimeSpan.FromSeconds((double)czo.a()));
	}

	// Token: 0x0600BF1D RID: 48925 RVA: 0x00421E0C File Offset: 0x0042000C
	public static void b()
	{
		a3o.a = null;
	}

	// Token: 0x0600BF1E RID: 48926 RVA: 0x00421E1C File Offset: 0x0042001C
	public static void a()
	{
		if (a3o.a != null && a3o.a.Value <= DateTime.Now)
		{
			bpo.GetServiceOrThrow<am7>().ai3(c2g.a, new bn3(czo.b(), 1f, null, null));
			a3o.a = null;
		}
	}

	// Token: 0x040044B5 RID: 17589
	private static DateTime? a;
}
