using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F22 RID: 7970
[ayj("Implosion")]
public sealed class byu : ce5
{
	// Token: 0x0600B815 RID: 47125 RVA: 0x0040F1A0 File Offset: 0x0040D3A0
	public override string y8()
	{
		return "Имплозия";
	}

	// Token: 0x0600B816 RID: 47126 RVA: 0x0040F1A8 File Offset: 0x0040D3A8
	public override string os()
	{
		return "Implosion";
	}

	// Token: 0x0600B817 RID: 47127 RVA: 0x0040F1B0 File Offset: 0x0040D3B0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B818 RID: 47128 RVA: 0x0040F1B4 File Offset: 0x0040D3B4
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B819 RID: 47129 RVA: 0x0040F1B8 File Offset: 0x0040D3B8
	public override int ci()
	{
		return 9;
	}

	// Token: 0x0600B81A RID: 47130 RVA: 0x0040F1C0 File Offset: 0x0040D3C0
	public byu()
	{
		this.g = new List<string>
		{
			d7f.b,
			byu.a
		};
	}

	// Token: 0x0600B81B RID: 47131 RVA: 0x0040F1F4 File Offset: 0x0040D3F4
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(70, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B81C RID: 47132 RVA: 0x0040F248 File Offset: 0x0040D448
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B81D RID: 47133 RVA: 0x0040F24C File Offset: 0x0040D44C
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B81E RID: 47134 RVA: 0x0040F258 File Offset: 0x0040D458
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(byu.a, 5 * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B81F RID: 47135 RVA: 0x0040F2A4 File Offset: 0x0040D4A4
	public override string bo(cnm A_0)
	{
		double num = byu.a(A_0);
		return qv.a("Psi/Implosion", new object[]
		{
			(int)(num * 100.0)
		});
	}

	// Token: 0x0600B820 RID: 47136 RVA: 0x0040F2DC File Offset: 0x0040D4DC
	public new static double a(cnm A_0)
	{
		int num = 0;
		double num2 = 1.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
			if (A_0.b8().Feats.Contains<d6t>() && A_0.b8().BaseAbilities.Strength > d6t.b)
			{
				num2 += (d6t.a + (double)A_0.b8().GetSpecializationValue<e31>(true) * e31.a) * (double)(A_0.b8().BaseAbilities.Strength - d6t.b);
			}
		}
		return Math.Min(0.75, (0.2 + 0.002 * (double)num) * num2);
	}

	// Token: 0x0600B821 RID: 47137 RVA: 0x0040F398 File Offset: 0x0040D598
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x0600B822 RID: 47138 RVA: 0x0040F39C File Offset: 0x0040D59C
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B823 RID: 47139 RVA: 0x0040F3A4 File Offset: 0x0040D5A4
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B824 RID: 47140 RVA: 0x0040F3AC File Offset: 0x0040D5AC
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B825 RID: 47141 RVA: 0x0040F3B4 File Offset: 0x0040D5B4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x04004302 RID: 17154
	public new static readonly string a = "Psi.Implosion";

	// Token: 0x04004303 RID: 17155
	private const int b = 5;

	// Token: 0x04004304 RID: 17156
	public static readonly int c = d0u.b;

	// Token: 0x04004305 RID: 17157
	private const double d = 0.2;

	// Token: 0x04004306 RID: 17158
	private new const double e = 0.002;

	// Token: 0x04004307 RID: 17159
	private new const double f = 0.75;

	// Token: 0x04004308 RID: 17160
	private new List<string> g;
}
