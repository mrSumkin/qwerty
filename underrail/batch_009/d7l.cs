using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F20 RID: 7968
[ayj("CryokineticOrb")]
public sealed class d7l : ce5, a5q
{
	// Token: 0x0600B7EB RID: 47083 RVA: 0x0040EC3C File Offset: 0x0040CE3C
	public override string y8()
	{
		return "Криокинетическая сфера";
	}

	// Token: 0x0600B7EC RID: 47084 RVA: 0x0040EC44 File Offset: 0x0040CE44
	public override string os()
	{
		return "CryokineticOrb";
	}

	// Token: 0x0600B7ED RID: 47085 RVA: 0x0040EC4C File Offset: 0x0040CE4C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B7EE RID: 47086 RVA: 0x0040EC50 File Offset: 0x0040CE50
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B7EF RID: 47087 RVA: 0x0040EC54 File Offset: 0x0040CE54
	public override int ci()
	{
		return 4;
	}

	// Token: 0x0600B7F0 RID: 47088 RVA: 0x0040EC58 File Offset: 0x0040CE58
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600B7F1 RID: 47089 RVA: 0x0040EC64 File Offset: 0x0040CE64
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600B7F2 RID: 47090 RVA: 0x0040EC6C File Offset: 0x0040CE6C
	public d7l()
	{
		this.m = new List<string>
		{
			d7f.b,
			d7l.a
		};
	}

	// Token: 0x0600B7F3 RID: 47091 RVA: 0x0040ECA0 File Offset: 0x0040CEA0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B7F4 RID: 47092 RVA: 0x0040ECA4 File Offset: 0x0040CEA4
	public override IList<string> bi()
	{
		return this.m;
	}

	// Token: 0x0600B7F5 RID: 47093 RVA: 0x0040ECAC File Offset: 0x0040CEAC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		list.Add(new cfd(d7l.a, d7l.b, false, false));
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B7F6 RID: 47094 RVA: 0x0040ECF8 File Offset: 0x0040CEF8
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/CryokineticOrb", new object[]
		{
			d7l.a(A_0).a(true),
			d7l.b(A_0).a(true),
			b34.a,
			l4.a((double)h7.b(A_0), false),
			h7.i,
			(int)(d7l.j * 100.0),
			(int)(d7l.k * 100.0),
			l4.a(d7l.l, false)
		});
	}

	// Token: 0x0600B7F7 RID: 47095 RVA: 0x0040EDA4 File Offset: 0x0040CFA4
	public static a1q b(cnm A_0)
	{
		int num = 1;
		if (A_0 != null && A_0.b8() != null)
		{
			rs rs = A_0.b8().Skills.Get<rs>();
			if (rs != null)
			{
				num = rs.g();
			}
		}
		double num2 = c3n.a("CryokineticOrb", A_0);
		return new a1q
		{
			DamageType = DamageType.Mechanical,
			LowerBoundary = Convert.ToInt32((5.0 + 0.125 * (double)num) * num2),
			UpperBoundary = Convert.ToInt32((6.0 + 0.275 * (double)num) * num2)
		};
	}

	// Token: 0x0600B7F8 RID: 47096 RVA: 0x0040EE48 File Offset: 0x0040D048
	public new static a1q a(cnm A_0)
	{
		int num = 1;
		if (A_0 != null && A_0.b8() != null)
		{
			rs rs = A_0.b8().Skills.Get<rs>();
			if (rs != null)
			{
				num = rs.g();
			}
		}
		double num2 = c3n.a("CryokineticOrb", A_0);
		return new a1q
		{
			DamageType = DamageType.Cold,
			LowerBoundary = Convert.ToInt32((5.0 + 0.1 * (double)num) * num2),
			UpperBoundary = Convert.ToInt32((6.0 + 0.2 * (double)num) * num2)
		};
	}

	// Token: 0x0600B7F9 RID: 47097 RVA: 0x0040EEEC File Offset: 0x0040D0EC
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		return euf.a(A_0.b8(), A_0.b8().Skills.Get<rs>().g(), A_1, 0.0);
	}

	// Token: 0x0600B7FA RID: 47098 RVA: 0x0040EF24 File Offset: 0x0040D124
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x0600B7FB RID: 47099 RVA: 0x0040EF30 File Offset: 0x0040D130
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(40, new Type[]
			{
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B7FC RID: 47100 RVA: 0x0040EF84 File Offset: 0x0040D184
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B7FD RID: 47101 RVA: 0x0040EF8C File Offset: 0x0040D18C
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B7FE RID: 47102 RVA: 0x0040EF94 File Offset: 0x0040D194
	protected override int d2(cnm A_0)
	{
		return 5;
	}

	// Token: 0x0600B7FF RID: 47103 RVA: 0x0040EF98 File Offset: 0x0040D198
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.c) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B800 RID: 47104 RVA: 0x0040EFDC File Offset: 0x0040D1DC
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x0600B801 RID: 47105 RVA: 0x0040EFE0 File Offset: 0x0040D1E0
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x040042EC RID: 17132
	public new static readonly string a = "Psi.CryokineticOrb";

	// Token: 0x040042ED RID: 17133
	private static readonly int b = 3 * d0u.b;

	// Token: 0x040042EE RID: 17134
	private const double c = 5.0;

	// Token: 0x040042EF RID: 17135
	private const double d = 0.125;

	// Token: 0x040042F0 RID: 17136
	private new const double e = 0.275;

	// Token: 0x040042F1 RID: 17137
	private new const double f = 5.0;

	// Token: 0x040042F2 RID: 17138
	private new const double g = 0.1;

	// Token: 0x040042F3 RID: 17139
	private new const double h = 0.2;

	// Token: 0x040042F4 RID: 17140
	public new static readonly int i = 24;

	// Token: 0x040042F5 RID: 17141
	public new static readonly double j = 0.5;

	// Token: 0x040042F6 RID: 17142
	public new static readonly double k = 1.0;

	// Token: 0x040042F7 RID: 17143
	public new static readonly int l = 3;

	// Token: 0x040042F8 RID: 17144
	private new List<string> m;
}
