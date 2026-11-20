using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F6E RID: 8046
[ayj("NailBombThrow")]
public sealed class c9 : ami
{
	// Token: 0x0600BC2F RID: 48175 RVA: 0x00415C78 File Offset: 0x00413E78
	public override string y8()
	{
		return "Бросок бомбы с гвоздями";
	}

	// Token: 0x0600BC30 RID: 48176 RVA: 0x00415C80 File Offset: 0x00413E80
	public override string os()
	{
		return "NailBombThrow";
	}

	// Token: 0x0600BC31 RID: 48177 RVA: 0x00415C88 File Offset: 0x00413E88
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC32 RID: 48178 RVA: 0x00415C94 File Offset: 0x00413E94
	public override string bp(cnm A_0)
	{
		return qv.a("Grenades/NailBomb", new object[]
		{
			c9.a,
			c9.b,
			c9.a().a(true),
			Convert.ToInt32(c9.e * 100.0),
			Convert.ToInt32(c9.f * 100.0),
			l4.a(c9.g, false),
			Convert.ToInt32(c9.h * 100.0),
			Convert.ToInt32(c6t.a * 100.0),
			Convert.ToInt32(c6t.b * 100.0),
			c6t.c
		});
	}

	// Token: 0x0600BC33 RID: 48179 RVA: 0x00415D88 File Offset: 0x00413F88
	public static a1q a()
	{
		return new a1q(DamageType.Mechanical, c9.c, c9.d);
	}

	// Token: 0x0600BC34 RID: 48180 RVA: 0x00415D9C File Offset: 0x00413F9C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.l, ami.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC35 RID: 48181 RVA: 0x00415DBC File Offset: 0x00413FBC
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.l
		};
	}

	// Token: 0x0600BC36 RID: 48182 RVA: 0x00415DD0 File Offset: 0x00413FD0
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x040043FB RID: 17403
	public new static readonly int a = 4;

	// Token: 0x040043FC RID: 17404
	public static readonly int b = 8;

	// Token: 0x040043FD RID: 17405
	public static readonly int c = 15;

	// Token: 0x040043FE RID: 17406
	public static readonly int d = 55;

	// Token: 0x040043FF RID: 17407
	public new static readonly double e = 0.5;

	// Token: 0x04004400 RID: 17408
	public static readonly double f = 1.0;

	// Token: 0x04004401 RID: 17409
	public new static readonly int g = 3;

	// Token: 0x04004402 RID: 17410
	public new static readonly double h = 0.35;
}
