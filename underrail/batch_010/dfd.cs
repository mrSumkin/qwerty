using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F0F RID: 7951
[ayj("PsychosomaticPredation")]
public sealed class dfd : ce5
{
	// Token: 0x0600B6CB RID: 46795 RVA: 0x0040C568 File Offset: 0x0040A768
	public override string y8()
	{
		return "Психосоматический хищник";
	}

	// Token: 0x0600B6CC RID: 46796 RVA: 0x0040C570 File Offset: 0x0040A770
	public override string os()
	{
		return "PsychosomaticPredation";
	}

	// Token: 0x0600B6CD RID: 46797 RVA: 0x0040C578 File Offset: 0x0040A778
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B6CE RID: 46798 RVA: 0x0040C57C File Offset: 0x0040A77C
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B6CF RID: 46799 RVA: 0x0040C580 File Offset: 0x0040A780
	public override int ci()
	{
		return 4;
	}

	// Token: 0x0600B6D0 RID: 46800 RVA: 0x0040C584 File Offset: 0x0040A784
	public dfd()
	{
		this.j = new List<string>
		{
			d7f.b,
			dfd.a
		};
	}

	// Token: 0x0600B6D1 RID: 46801 RVA: 0x0040C5B8 File Offset: 0x0040A7B8
	public new static double a(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_0);
		return Math.Min(dfd.g, Math.Round(dfd.e + (double)effectivePsiSkillLevel * dfd.f, 3));
	}

	// Token: 0x0600B6D2 RID: 46802 RVA: 0x0040C5EC File Offset: 0x0040A7EC
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B6D3 RID: 46803 RVA: 0x0040C620 File Offset: 0x0040A820
	public override IList<string> bi()
	{
		return this.j;
	}

	// Token: 0x0600B6D4 RID: 46804 RVA: 0x0040C628 File Offset: 0x0040A828
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(dfd.a, 6 * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B6D5 RID: 46805 RVA: 0x0040C674 File Offset: 0x0040A874
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/PsychosomaticPredation", new object[]
		{
			Math.Round(dfd.a(A_0) * 100.0, 1).ToString("0.0"),
			Convert.ToInt32(dfd.h * 100.0),
			l4.a(dfd.d, false),
			dfd.i
		});
	}

	// Token: 0x0600B6D6 RID: 46806 RVA: 0x0040C6F0 File Offset: 0x0040A8F0
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(50, new Type[]
			{
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B6D7 RID: 46807 RVA: 0x0040C744 File Offset: 0x0040A944
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600B6D8 RID: 46808 RVA: 0x0040C748 File Offset: 0x0040A948
	protected override int br(cnm A_0)
	{
		return 2000;
	}

	// Token: 0x0600B6D9 RID: 46809 RVA: 0x0040C750 File Offset: 0x0040A950
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B6DA RID: 46810 RVA: 0x0040C758 File Offset: 0x0040A958
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B6DB RID: 46811 RVA: 0x0040C760 File Offset: 0x0040A960
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B6DC RID: 46812 RVA: 0x0040C794 File Offset: 0x0040A994
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004270 RID: 17008
	public new static readonly string a = "Psi.PsychosomaticPredation";

	// Token: 0x04004271 RID: 17009
	private const int b = 6;

	// Token: 0x04004272 RID: 17010
	public static readonly int c = 2;

	// Token: 0x04004273 RID: 17011
	public static readonly int d = 3;

	// Token: 0x04004274 RID: 17012
	public new static readonly double e = 0.05;

	// Token: 0x04004275 RID: 17013
	public new static readonly double f = 0.0002;

	// Token: 0x04004276 RID: 17014
	public new static readonly double g = 0.15;

	// Token: 0x04004277 RID: 17015
	public new static readonly double h = 0.25;

	// Token: 0x04004278 RID: 17016
	public new static readonly int i = 25;

	// Token: 0x04004279 RID: 17017
	private new List<string> j;
}
