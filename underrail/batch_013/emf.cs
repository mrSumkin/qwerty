using System;
using System.Collections.Generic;

// Token: 0x02001EC0 RID: 7872
[ayj("ShootSerratedBolt")]
public sealed class emf : eyv
{
	// Token: 0x0600B1B2 RID: 45490 RVA: 0x00402D20 File Offset: 0x00400F20
	public override string y8()
	{
		return "Выстрел зазубренным болтом";
	}

	// Token: 0x0600B1B3 RID: 45491 RVA: 0x00402D28 File Offset: 0x00400F28
	public override string os()
	{
		return "ShootSerratedBolt";
	}

	// Token: 0x0600B1B4 RID: 45492 RVA: 0x00402D30 File Offset: 0x00400F30
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1B5 RID: 45493 RVA: 0x00402D34 File Offset: 0x00400F34
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1B6 RID: 45494 RVA: 0x00402D38 File Offset: 0x00400F38
	public emf()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
	}

	// Token: 0x0600B1B7 RID: 45495 RVA: 0x00402D5C File Offset: 0x00400F5C
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B1B8 RID: 45496 RVA: 0x00402D60 File Offset: 0x00400F60
	public override string bp(cnm A_0)
	{
		return qv.a("SpecialAttacks/ShootSerratedBolt", new object[]
		{
			(int)(emf.a * 100.0),
			l4.a(emf.b, false),
			(int)(emf.c * 100.0)
		});
	}

	// Token: 0x0600B1B9 RID: 45497 RVA: 0x00402DBC File Offset: 0x00400FBC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1BA RID: 45498 RVA: 0x00402DF0 File Offset: 0x00400FF0
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0400412C RID: 16684
	public new static readonly double a = 1.0;

	// Token: 0x0400412D RID: 16685
	public static readonly int b = 3;

	// Token: 0x0400412E RID: 16686
	public static readonly double c = 0.15;

	// Token: 0x0400412F RID: 16687
	private List<string> d;
}
