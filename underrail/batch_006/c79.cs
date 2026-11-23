using System;

// Token: 0x02001F59 RID: 8025
[ayj("PlaceCrawlerPoisonBearTrap")]
public sealed class c79 : blb
{
	// Token: 0x0600BB62 RID: 47970 RVA: 0x00414A54 File Offset: 0x00412C54
	public override string y8()
	{
		return "Place Poisoned Bear Trap";
	}

	// Token: 0x0600BB63 RID: 47971 RVA: 0x00414A5C File Offset: 0x00412C5C
	public override string os()
	{
		return "PlaceCrawlerPoisonBearTrap";
	}

	// Token: 0x0600BB64 RID: 47972 RVA: 0x00414A64 File Offset: 0x00412C64
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.e;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Traps/CrawlerPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			num,
			l4.a(ezx.d, false),
			l4.a(ezx.f, false)
		});
	}
}
