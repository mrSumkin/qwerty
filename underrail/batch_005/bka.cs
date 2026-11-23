using System;
using System.Collections.Generic;

// Token: 0x02001EAE RID: 7854
[ayj("ShootBroadheadBolt")]
public sealed class bka : eyv
{
	// Token: 0x0600B0B7 RID: 45239 RVA: 0x004005EC File Offset: 0x003FE7EC
	public override string y8()
	{
		return "Выстрел болтом с широким наконечником";
	}

	// Token: 0x0600B0B8 RID: 45240 RVA: 0x004005F4 File Offset: 0x003FE7F4
	public override string os()
	{
		return "ShootBroadheadBolt";
	}

	// Token: 0x0600B0B9 RID: 45241 RVA: 0x004005FC File Offset: 0x003FE7FC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0BA RID: 45242 RVA: 0x00400600 File Offset: 0x003FE800
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B0BB RID: 45243 RVA: 0x00400604 File Offset: 0x003FE804
	public bka()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
	}

	// Token: 0x0600B0BC RID: 45244 RVA: 0x00400628 File Offset: 0x003FE828
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B0BD RID: 45245 RVA: 0x0040062C File Offset: 0x003FE82C
	public override string bp(cnm A_0)
	{
		return qv.a("SpecialAttacks/ShootBroadheadBolt", new object[]
		{
			(int)(bka.a * 100.0),
			l4.a(bka.b, false),
			(int)(bka.c * 100.0)
		});
	}

	// Token: 0x0600B0BE RID: 45246 RVA: 0x00400688 File Offset: 0x003FE888
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B0BF RID: 45247 RVA: 0x004006BC File Offset: 0x003FE8BC
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x040040E8 RID: 16616
	public new static readonly double a = 1.5;

	// Token: 0x040040E9 RID: 16617
	public static readonly int b = 3;

	// Token: 0x040040EA RID: 16618
	public static readonly double c = 0.15;

	// Token: 0x040040EB RID: 16619
	private List<string> d;
}
