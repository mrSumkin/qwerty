using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F1A RID: 7962
[ayj("PsychotemporalContraction")]
public sealed class c0o : ce5
{
	// Token: 0x0600B77C RID: 46972 RVA: 0x0040DC24 File Offset: 0x0040BE24
	public override string y8()
	{
		return "Психо-временное сжатие";
	}

	// Token: 0x0600B77D RID: 46973 RVA: 0x0040DC2C File Offset: 0x0040BE2C
	public override string os()
	{
		return "PsychotemporalContraction";
	}

	// Token: 0x0600B77E RID: 46974 RVA: 0x0040DC34 File Offset: 0x0040BE34
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B77F RID: 46975 RVA: 0x0040DC38 File Offset: 0x0040BE38
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B780 RID: 46976 RVA: 0x0040DC3C File Offset: 0x0040BE3C
	public override int ci()
	{
		return 5;
	}

	// Token: 0x0600B781 RID: 46977 RVA: 0x0040DC40 File Offset: 0x0040BE40
	public c0o()
	{
		this.m = new List<string>
		{
			d7f.b,
			"PsychotemporalContraction"
		};
	}

	// Token: 0x0600B782 RID: 46978 RVA: 0x0040DC74 File Offset: 0x0040BE74
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(55, new Type[]
			{
				typeof(p5)
			})
		};
	}

	// Token: 0x0600B783 RID: 46979 RVA: 0x0040DCC8 File Offset: 0x0040BEC8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Creature;
	}

	// Token: 0x0600B784 RID: 46980 RVA: 0x0040DCCC File Offset: 0x0040BECC
	public override IList<string> bi()
	{
		return this.m;
	}

	// Token: 0x0600B785 RID: 46981 RVA: 0x0040DCD8 File Offset: 0x0040BED8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		int num = c0o.h;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b);
		}
		if (num > 0)
		{
			list.Add(new cfd("PsychotemporalContraction", num * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B786 RID: 46982 RVA: 0x0040DD64 File Offset: 0x0040BF64
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/PsychotemporalContraction", new object[]
		{
			c0o.c(A_0),
			c0o.e,
			l4.a(c0o.b(A_0), false),
			Convert.ToInt32(c0o.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B787 RID: 46983 RVA: 0x0040DDC8 File Offset: 0x0040BFC8
	public static int c(cnm A_0)
	{
		int num = c0o.d;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<bu8>())
		{
			num += bu8.a + (int)((double)A_0.b8().GetSpecializationValue<e1x>(true) * e1x.a);
		}
		return num;
	}

	// Token: 0x0600B788 RID: 46984 RVA: 0x0040DE20 File Offset: 0x0040C020
	public static int b(cnm A_0)
	{
		int num = c0o.g;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<bu8>())
		{
			num += bu8.b;
		}
		return num;
	}

	// Token: 0x0600B789 RID: 46985 RVA: 0x0040DE64 File Offset: 0x0040C064
	public new static double a(cnm A_0)
	{
		int a_ = 0;
		if (A_0 != null && A_0.b8() != null)
		{
			a_ = A_0.b8().Offense.ag()[PsiSchool.TemporalManipulation].b();
		}
		return c0o.a(a_);
	}

	// Token: 0x0600B78A RID: 46986 RVA: 0x0040DEA8 File Offset: 0x0040C0A8
	public static double a(int A_0)
	{
		double num = c0o.i;
		if (A_0 > c0o.k)
		{
			double num2 = (double)Math.Min(A_0 - c0o.k, c0o.l) / (double)c0o.l;
			num -= num2 * c0o.j;
		}
		return num;
	}

	// Token: 0x0600B78B RID: 46987 RVA: 0x0040DEEC File Offset: 0x0040C0EC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B78C RID: 46988 RVA: 0x0040DEF0 File Offset: 0x0040C0F0
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B78D RID: 46989 RVA: 0x0040DEF8 File Offset: 0x0040C0F8
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B78E RID: 46990 RVA: 0x0040DF00 File Offset: 0x0040C100
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B78F RID: 46991 RVA: 0x0040DF08 File Offset: 0x0040C108
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x040042AB RID: 17067
	private new const string a = "Psycho-temporal Contraction";

	// Token: 0x040042AC RID: 17068
	private const string b = "PsychotemporalContraction";

	// Token: 0x040042AD RID: 17069
	private const string c = "PsychotemporalContraction";

	// Token: 0x040042AE RID: 17070
	private static readonly int d = 15;

	// Token: 0x040042AF RID: 17071
	public new static readonly int e = 30;

	// Token: 0x040042B0 RID: 17072
	public new static readonly float f = 0.2f;

	// Token: 0x040042B1 RID: 17073
	private new static readonly int g = 2;

	// Token: 0x040042B2 RID: 17074
	public new static readonly int h = 6;

	// Token: 0x040042B3 RID: 17075
	public new static readonly double i = 0.6;

	// Token: 0x040042B4 RID: 17076
	public new static readonly double j = 0.3;

	// Token: 0x040042B5 RID: 17077
	public new static readonly int k = 50;

	// Token: 0x040042B6 RID: 17078
	public new static readonly int l = 100;

	// Token: 0x040042B7 RID: 17079
	private new List<string> m;
}
