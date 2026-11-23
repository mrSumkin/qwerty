using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F0B RID: 7947
[ayj("CryogenicBarrier")]
public sealed class e7j : ce5
{
	// Token: 0x0600B688 RID: 46728 RVA: 0x0040B610 File Offset: 0x00409810
	public override string y8()
	{
		return "Криогенный барьер";
	}

	// Token: 0x0600B689 RID: 46729 RVA: 0x0040B618 File Offset: 0x00409818
	public override string os()
	{
		return "CryogenicBarrier";
	}

	// Token: 0x0600B68A RID: 46730 RVA: 0x0040B620 File Offset: 0x00409820
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B68B RID: 46731 RVA: 0x0040B624 File Offset: 0x00409824
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B68C RID: 46732 RVA: 0x0040B628 File Offset: 0x00409828
	public override int ci()
	{
		return 5;
	}

	// Token: 0x0600B68D RID: 46733 RVA: 0x0040B62C File Offset: 0x0040982C
	public e7j()
	{
		this.p = new List<string>
		{
			d7f.b,
			e7j.a
		};
	}

	// Token: 0x0600B68E RID: 46734 RVA: 0x0040B660 File Offset: 0x00409860
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpotWithWater;
	}

	// Token: 0x0600B68F RID: 46735 RVA: 0x0040B664 File Offset: 0x00409864
	public override IList<string> bi()
	{
		return this.p;
	}

	// Token: 0x0600B690 RID: 46736 RVA: 0x0040B66C File Offset: 0x0040986C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(e7j.a, e7j.b, false, false));
		return list;
	}

	// Token: 0x0600B691 RID: 46737 RVA: 0x0040B6B8 File Offset: 0x004098B8
	public override string bo(cnm A_0)
	{
		List<a1q> list = e7j.b(A_0);
		if (list == null || list.Count < 2)
		{
			return string.Empty;
		}
		return qv.a("Psi/CryogenicBarrier", new object[]
		{
			list[0].a(true),
			list[1].a(true),
			e7j.c(A_0),
			l4.a((double)e7j.d(A_0), false),
			b34.a,
			l4.a((double)h7.b(A_0), false),
			h7.i,
			e7j.a(A_0).ToString()
		});
	}

	// Token: 0x0600B692 RID: 46738 RVA: 0x0040B77C File Offset: 0x0040997C
	public static int d(cnm A_0)
	{
		return e7j.e * d0u.b + euf.a(A_0);
	}

	// Token: 0x0600B693 RID: 46739 RVA: 0x0040B794 File Offset: 0x00409994
	public static int c(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<rs>(A_0);
		double num = e7j.c + (double)effectivePsiSkillLevel * e7j.d;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<a9z>())
		{
			num *= 1.0 + co4.c + (double)A_0.b8().GetSpecializationValue<ecc>(true) * ecc.a;
		}
		return Convert.ToInt32(num);
	}

	// Token: 0x0600B694 RID: 46740 RVA: 0x0040B80C File Offset: 0x00409A0C
	public static List<a1q> b(cnm A_0)
	{
		double num = c3n.a("CryogenicBarrier", A_0);
		a1q item = default(a1q);
		item.DamageType = DamageType.Cold;
		a1q item2 = default(a1q);
		item2.DamageType = DamageType.Mechanical;
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<rs>(A_0);
		item.LowerBoundary = Convert.ToInt32((10.0 + 0.25 * (double)effectivePsiSkillLevel) * num);
		item.UpperBoundary = Convert.ToInt32((11.0 + 0.5 * (double)effectivePsiSkillLevel) * num);
		item2.LowerBoundary = Convert.ToInt32((8.0 + 0.2 * (double)effectivePsiSkillLevel) * num);
		item2.UpperBoundary = Convert.ToInt32((9.0 + 0.33 * (double)effectivePsiSkillLevel) * num);
		return new List<a1q>
		{
			item,
			item2
		};
	}

	// Token: 0x0600B695 RID: 46741 RVA: 0x0040B8F0 File Offset: 0x00409AF0
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600B696 RID: 46742 RVA: 0x0040B8F4 File Offset: 0x00409AF4
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B697 RID: 46743 RVA: 0x0040B8FC File Offset: 0x00409AFC
	protected override float f0(cnm A_0)
	{
		return 9f;
	}

	// Token: 0x0600B698 RID: 46744 RVA: 0x0040B904 File Offset: 0x00409B04
	protected override float cj(cnm A_0)
	{
		return 30f;
	}

	// Token: 0x0600B699 RID: 46745 RVA: 0x0040B90C File Offset: 0x00409B0C
	protected override int d2(cnm A_0)
	{
		return 2;
	}

	// Token: 0x0600B69A RID: 46746 RVA: 0x0040B910 File Offset: 0x00409B10
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.c) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B69B RID: 46747 RVA: 0x0040B954 File Offset: 0x00409B54
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(45, new Type[]
			{
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B69C RID: 46748 RVA: 0x0040B9A8 File Offset: 0x00409BA8
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0600B69D RID: 46749 RVA: 0x0040B9B0 File Offset: 0x00409BB0
	public new static du2 a(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		double a_ = Math.Min(0.9, Math.Round(e7j.l + e7j.m * (double)effectivePsiSkillLevel, 2));
		int a_2 = Convert.ToInt32(e7j.n + e7j.o * (double)effectivePsiSkillLevel);
		return new du2(DamageType.Mechanical, a_2, a_);
	}

	// Token: 0x04004250 RID: 16976
	public new static readonly string a = "Psi.CryogenicBarrier";

	// Token: 0x04004251 RID: 16977
	private static readonly int b = 8 * d0u.b;

	// Token: 0x04004252 RID: 16978
	public static readonly double c = 20.0;

	// Token: 0x04004253 RID: 16979
	public static readonly double d = 1.0;

	// Token: 0x04004254 RID: 16980
	public new static readonly int e = 3;

	// Token: 0x04004255 RID: 16981
	private new const double f = 10.0;

	// Token: 0x04004256 RID: 16982
	private new const double g = 0.25;

	// Token: 0x04004257 RID: 16983
	private new const double h = 0.5;

	// Token: 0x04004258 RID: 16984
	private new const double i = 8.0;

	// Token: 0x04004259 RID: 16985
	private new const double j = 0.2;

	// Token: 0x0400425A RID: 16986
	private new const double k = 0.33;

	// Token: 0x0400425B RID: 16987
	public new static readonly double l = 0.15;

	// Token: 0x0400425C RID: 16988
	public new static readonly double m = 0.002;

	// Token: 0x0400425D RID: 16989
	public new static readonly double n = 5.0;

	// Token: 0x0400425E RID: 16990
	public new static readonly double o = 0.1;

	// Token: 0x0400425F RID: 16991
	private new List<string> p;
}
