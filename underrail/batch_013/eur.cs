using System;
using System.Collections.Generic;

// Token: 0x02001EBE RID: 7870
[ayj("ShootCrawlerPoisonBolt")]
public sealed class eur : eyv
{
	// Token: 0x0600B1A0 RID: 45472 RVA: 0x00402B24 File Offset: 0x00400D24
	public override string y8()
	{
		return "Запустить отравленный болт";
	}

	// Token: 0x0600B1A1 RID: 45473 RVA: 0x00402B2C File Offset: 0x00400D2C
	public override string os()
	{
		return "ShootCrawlerPoisonBolt";
	}

	// Token: 0x0600B1A2 RID: 45474 RVA: 0x00402B34 File Offset: 0x00400D34
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1A3 RID: 45475 RVA: 0x00402B38 File Offset: 0x00400D38
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1A4 RID: 45476 RVA: 0x00402B3C File Offset: 0x00400D3C
	public eur()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B1A5 RID: 45477 RVA: 0x00402B60 File Offset: 0x00400D60
	public override string bo(cnm A_0)
	{
		int num = ezx.e;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/ShootCrawlerPoisonBolt", new object[]
		{
			num,
			l4.a(ezx.d, false),
			l4.a(ezx.f, false)
		});
	}

	// Token: 0x0600B1A6 RID: 45478 RVA: 0x00402BE4 File Offset: 0x00400DE4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B1A7 RID: 45479 RVA: 0x00402BF0 File Offset: 0x00400DF0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1A8 RID: 45480 RVA: 0x00402C24 File Offset: 0x00400E24
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0400412A RID: 16682
	private new List<string> a;
}
