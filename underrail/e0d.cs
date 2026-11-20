using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F71 RID: 8049
[ayj("stingballGrenadeThrow")]
public sealed class e0d : ami
{
	// Token: 0x0600BC4C RID: 48204 RVA: 0x00415FEC File Offset: 0x004141EC
	public override string y8()
	{
		return "Бросок шарикошипованой гранаты";
	}

	// Token: 0x0600BC4D RID: 48205 RVA: 0x00415FF4 File Offset: 0x004141F4
	public override string os()
	{
		return "stingballGrenadeThrow";
	}

	// Token: 0x0600BC4E RID: 48206 RVA: 0x00415FFC File Offset: 0x004141FC
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC4F RID: 48207 RVA: 0x00416008 File Offset: 0x00414208
	public override string bp(cnm A_0)
	{
		return qv.a("Grenades/Stingball", new object[]
		{
			e0d.b().a(true),
			l4.a((double)e0d.c(), false)
		});
	}

	// Token: 0x0600BC50 RID: 48208 RVA: 0x00416048 File Offset: 0x00414248
	public static int c()
	{
		return d0u.b;
	}

	// Token: 0x0600BC51 RID: 48209 RVA: 0x00416050 File Offset: 0x00414250
	public static a1q b()
	{
		return new a1q(DamageType.Mechanical, 10, 15);
	}

	// Token: 0x0600BC52 RID: 48210 RVA: 0x0041605C File Offset: 0x0041425C
	public static int a()
	{
		return c2h.a(14, 10, 5.0);
	}

	// Token: 0x0600BC53 RID: 48211 RVA: 0x00416070 File Offset: 0x00414270
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.n, e0d.a(A_0), false, false),
			new cfd("grenade.stingball", e0d.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC54 RID: 48212 RVA: 0x004160B4 File Offset: 0x004142B4
	public override IList<string> bi()
	{
		return new List<string>
		{
			"grenade.stingball",
			d7f.n
		};
	}

	// Token: 0x0600BC55 RID: 48213 RVA: 0x004160D4 File Offset: 0x004142D4
	protected override int d2(cnm A_0)
	{
		return c18.g();
	}

	// Token: 0x0600BC56 RID: 48214 RVA: 0x004160E0 File Offset: 0x004142E0
	private new static int a(cnm A_0)
	{
		int num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = c18.a(A_0.b8(), e0d.b);
		}
		else
		{
			num = e0d.b * d0u.b;
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<m6>())
		{
			num -= (int)(((double)m6.b + (double)A_0.b8().GetSpecializationValue<ajw>(true) * ajw.a) * (double)d0u.b);
		}
		return num;
	}

	// Token: 0x04004403 RID: 17411
	private new const string a = "grenade.stingball";

	// Token: 0x04004404 RID: 17412
	private static readonly int b = 8;
}
