using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F10 RID: 7952
[ayj("PlasmaBeam")]
public sealed class evz : ce5
{
	// Token: 0x0600B6DE RID: 46814 RVA: 0x0040C800 File Offset: 0x0040AA00
	public override string y8()
	{
		return "Плазменный луч";
	}

	// Token: 0x0600B6DF RID: 46815 RVA: 0x0040C808 File Offset: 0x0040AA08
	public override string os()
	{
		return "PlasmaBeam";
	}

	// Token: 0x0600B6E0 RID: 46816 RVA: 0x0040C810 File Offset: 0x0040AA10
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B6E1 RID: 46817 RVA: 0x0040C814 File Offset: 0x0040AA14
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B6E2 RID: 46818 RVA: 0x0040C818 File Offset: 0x0040AA18
	public override int ci()
	{
		return 9;
	}

	// Token: 0x0600B6E3 RID: 46819 RVA: 0x0040C81C File Offset: 0x0040AA1C
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B6E4 RID: 46820 RVA: 0x0040C824 File Offset: 0x0040AA24
	public evz()
	{
		this.e = new List<string>
		{
			d7f.b
		};
	}

	// Token: 0x0600B6E5 RID: 46821 RVA: 0x0040C844 File Offset: 0x0040AA44
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(90, new Type[]
			{
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B6E6 RID: 46822 RVA: 0x0040C898 File Offset: 0x0040AA98
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B6E7 RID: 46823 RVA: 0x0040C89C File Offset: 0x0040AA9C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		if (A_1 == v5.b)
		{
			return new List<cfd>
			{
				new cfd(d7f.b, d7f.g, true, false)
			};
		}
		return d7f.o;
	}

	// Token: 0x0600B6E8 RID: 46824 RVA: 0x0040C8CC File Offset: 0x0040AACC
	public override string bo(cnm A_0)
	{
		List<a1q> list = this.b(A_0, 1000f);
		return qv.a("Psi/PlasmaBeam", new object[]
		{
			list[0].a(true),
			list[1].a(true)
		});
	}

	// Token: 0x0600B6E9 RID: 46825 RVA: 0x0040C91C File Offset: 0x0040AB1C
	public List<a1q> b(cnm A_0, float A_1)
	{
		double num = c3n.a("PlasmaBeam", A_0);
		a1q item = default(a1q);
		item.DamageType = DamageType.Energy;
		a1q item2 = default(a1q);
		item2.DamageType = DamageType.Heat;
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<rs>(A_0);
		float num2 = this.a(A_0, A_1);
		double num3 = (double)(0.2f + 0.8f * num2);
		int num4;
		int num5;
		this.a(effectivePsiSkillLevel, num * num3, out num4, out num5);
		item.LowerBoundary = Convert.ToInt32((double)num4 / 2.0);
		item.UpperBoundary = Convert.ToInt32((double)num5 / 2.0);
		item2.LowerBoundary = item.LowerBoundary;
		item2.UpperBoundary = item.UpperBoundary;
		return new List<a1q>
		{
			item,
			item2
		};
	}

	// Token: 0x0600B6EA RID: 46826 RVA: 0x0040C9E8 File Offset: 0x0040ABE8
	private void a(int A_0, double A_1, out int A_2, out int A_3)
	{
		double num = 250.0;
		double num2 = Math.Pow((double)A_0 / num, 0.75) * num;
		A_2 = Convert.ToInt32((30.0 + 1.0 * num2) * A_1);
		A_3 = Convert.ToInt32((30.0 + 2.0 * num2) * A_1);
	}

	// Token: 0x0600B6EB RID: 46827 RVA: 0x0040CA54 File Offset: 0x0040AC54
	public float a(cnm A_0, float A_1)
	{
		float num = this.afi(A_0);
		return Math.Min(A_1 / (evz.d * num), 1f);
	}

	// Token: 0x0600B6EC RID: 46828 RVA: 0x0040CA7C File Offset: 0x0040AC7C
	protected override int d2(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B6ED RID: 46829 RVA: 0x0040CA80 File Offset: 0x0040AC80
	protected override float f0(cnm A_0)
	{
		return 11f;
	}

	// Token: 0x0600B6EE RID: 46830 RVA: 0x0040CA88 File Offset: 0x0040AC88
	protected override float cj(cnm A_0)
	{
		return 70f;
	}

	// Token: 0x0600B6EF RID: 46831 RVA: 0x0040CA90 File Offset: 0x0040AC90
	protected override int br(cnm A_0)
	{
		return 1750;
	}

	// Token: 0x0600B6F0 RID: 46832 RVA: 0x0040CA98 File Offset: 0x0040AC98
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600B6F1 RID: 46833 RVA: 0x0040CA9C File Offset: 0x0040AC9C
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0400427A RID: 17018
	private new const double a = 30.0;

	// Token: 0x0400427B RID: 17019
	private const double b = 1.0;

	// Token: 0x0400427C RID: 17020
	private const double c = 2.0;

	// Token: 0x0400427D RID: 17021
	public static readonly float d = 0.66f;

	// Token: 0x0400427E RID: 17022
	private new List<string> e;
}
