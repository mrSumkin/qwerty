using System;

// Token: 0x02001E93 RID: 7827
[ayj("CrawlerPoisonKnifeThrow")]
public sealed class efr : a0y
{
	// Token: 0x0600AF28 RID: 44840 RVA: 0x003FD6A4 File Offset: 0x003FB8A4
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF29 RID: 44841 RVA: 0x003FD6AC File Offset: 0x003FB8AC
	public override string os()
	{
		return "CrawlerPoisonKnifeThrow";
	}

	// Token: 0x0600AF2A RID: 44842 RVA: 0x003FD6B4 File Offset: 0x003FB8B4
	public override string bp(cnm A_0)
	{
		int num = ezx.e;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/CrawlerPoison", new object[]
		{
			num,
			l4.a(ezx.d, false),
			l4.a(ezx.f, false)
		});
	}
}
