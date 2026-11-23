using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F1B RID: 7963
[ayj("PsychotemporalDilation")]
public sealed class c4n : ce5
{
	// Token: 0x0600B791 RID: 46993 RVA: 0x0040DF6C File Offset: 0x0040C16C
	public override string y8()
	{
		return "Психо-временное растягивание";
	}

	// Token: 0x0600B792 RID: 46994 RVA: 0x0040DF74 File Offset: 0x0040C174
	public override string os()
	{
		return "PsychotemporalDilation";
	}

	// Token: 0x0600B793 RID: 46995 RVA: 0x0040DF7C File Offset: 0x0040C17C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B794 RID: 46996 RVA: 0x0040DF80 File Offset: 0x0040C180
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B795 RID: 46997 RVA: 0x0040DF84 File Offset: 0x0040C184
	public override int ci()
	{
		return 2;
	}

	// Token: 0x0600B796 RID: 46998 RVA: 0x0040DF8C File Offset: 0x0040C18C
	public c4n()
	{
		this.n = new List<string>
		{
			d7f.b,
			"PsychotemporalDilation"
		};
	}

	// Token: 0x0600B797 RID: 46999 RVA: 0x0040DFC0 File Offset: 0x0040C1C0
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(25, new Type[]
			{
				typeof(p5)
			})
		};
	}

	// Token: 0x0600B798 RID: 47000 RVA: 0x0040E014 File Offset: 0x0040C214
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B799 RID: 47001 RVA: 0x0040E018 File Offset: 0x0040C218
	public override IList<string> bi()
	{
		return this.n;
	}

	// Token: 0x0600B79A RID: 47002 RVA: 0x0040E024 File Offset: 0x0040C224
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		int num = c4n.l;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b);
		}
		if (num > 0)
		{
			list.Add(new cfd("PsychotemporalDilation", num * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B79B RID: 47003 RVA: 0x0040E0B0 File Offset: 0x0040C2B0
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/PsychotemporalDilation", new object[]
		{
			c4n.d(A_0),
			c4n.c(A_0),
			l4.a(c4n.a(A_0), false)
		});
	}

	// Token: 0x0600B79C RID: 47004 RVA: 0x0040E0F0 File Offset: 0x0040C2F0
	public static int d(cnm A_0)
	{
		int num = c4n.d;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<bu8>())
		{
			num += bu8.a + (int)((double)A_0.b8().GetSpecializationValue<e1x>(true) * e1x.a);
		}
		return num;
	}

	// Token: 0x0600B79D RID: 47005 RVA: 0x0040E148 File Offset: 0x0040C348
	public static int c(cnm A_0)
	{
		int num = c4n.e;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (int)((double)A_0.b8().Offense.ag()[PsiSchool.TemporalManipulation].b() * c4n.f);
		}
		return Math.Min(c4n.g, num);
	}

	// Token: 0x0600B79E RID: 47006 RVA: 0x0040E1A0 File Offset: 0x0040C3A0
	public static float b(cnm A_0)
	{
		float num = c4n.h;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (float)((int)((float)A_0.b8().Offense.ag()[PsiSchool.TemporalManipulation].b() * c4n.i));
		}
		return Math.Min(c4n.j, num);
	}

	// Token: 0x0600B79F RID: 47007 RVA: 0x0040E1F8 File Offset: 0x0040C3F8
	public new static int a(cnm A_0)
	{
		int num = c4n.k;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<bu8>())
		{
			num += bu8.b;
		}
		return num;
	}

	// Token: 0x0600B7A0 RID: 47008 RVA: 0x0040E23C File Offset: 0x0040C43C
	protected override int hi(cnm A_0)
	{
		int num = 10;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num += ank.a(A_0);
		}
		return num;
	}

	// Token: 0x0600B7A1 RID: 47009 RVA: 0x0040E27C File Offset: 0x0040C47C
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B7A2 RID: 47010 RVA: 0x0040E284 File Offset: 0x0040C484
	protected override float cj(cnm A_0)
	{
		return 25f;
	}

	// Token: 0x0600B7A3 RID: 47011 RVA: 0x0040E28C File Offset: 0x0040C48C
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B7A4 RID: 47012 RVA: 0x0040E294 File Offset: 0x0040C494
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x040042B8 RID: 17080
	private new const string a = "Psycho-temporal Dilation";

	// Token: 0x040042B9 RID: 17081
	private const string b = "PsychotemporalDilation";

	// Token: 0x040042BA RID: 17082
	private const string c = "PsychotemporalDilation";

	// Token: 0x040042BB RID: 17083
	private static readonly int d = 10;

	// Token: 0x040042BC RID: 17084
	public new static readonly int e = 20;

	// Token: 0x040042BD RID: 17085
	public new static readonly double f = 0.3;

	// Token: 0x040042BE RID: 17086
	public new static readonly int g = 50;

	// Token: 0x040042BF RID: 17087
	public new static readonly float h = 0.1f;

	// Token: 0x040042C0 RID: 17088
	public new static readonly float i = 0.01f;

	// Token: 0x040042C1 RID: 17089
	public new static readonly float j = 0.1f;

	// Token: 0x040042C2 RID: 17090
	private new static readonly int k = 2;

	// Token: 0x040042C3 RID: 17091
	public new static readonly int l = 4;

	// Token: 0x040042C4 RID: 17092
	public new static readonly double m = 0.5;

	// Token: 0x040042C5 RID: 17093
	private new List<string> n;
}
