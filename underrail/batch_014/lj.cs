using System;

// Token: 0x02001F6A RID: 8042
[ayj("CrawlerPoisonCaltropsThrow")]
public sealed class lj : b4f
{
	// Token: 0x0600BC0F RID: 48143 RVA: 0x00415948 File Offset: 0x00413B48
	public override string y8()
	{
		return "Бросок колючек с ядом краулера";
	}

	// Token: 0x0600BC10 RID: 48144 RVA: 0x00415950 File Offset: 0x00413B50
	public override string os()
	{
		return "CrawlerPoisonCaltropsThrow";
	}

	// Token: 0x0600BC11 RID: 48145 RVA: 0x00415958 File Offset: 0x00413B58
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC12 RID: 48146 RVA: 0x00415964 File Offset: 0x00413B64
	public override string bp(cnm A_0)
	{
		c18.a(A_0);
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.e;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Caltrops/CrawlerPoison", new object[]
		{
			c18.f().a(true),
			c18.b1,
			num,
			l4.a(ezx.d, false),
			l4.a(ezx.f, false)
		});
	}
}
