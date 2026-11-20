using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F12 RID: 7954
[ayj("PsychokineticChain")]
public sealed class ari : ce5
{
	// Token: 0x0600B705 RID: 46853 RVA: 0x0040CC1C File Offset: 0x0040AE1C
	public override string y8()
	{
		return "Психокинетическая цепь";
	}

	// Token: 0x0600B706 RID: 46854 RVA: 0x0040CC24 File Offset: 0x0040AE24
	public override string os()
	{
		return "PsychokineticChain";
	}

	// Token: 0x0600B707 RID: 46855 RVA: 0x0040CC2C File Offset: 0x0040AE2C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B708 RID: 46856 RVA: 0x0040CC30 File Offset: 0x0040AE30
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B709 RID: 46857 RVA: 0x0040CC34 File Offset: 0x0040AE34
	public override int ci()
	{
		return 8;
	}

	// Token: 0x0600B70A RID: 46858 RVA: 0x0040CC3C File Offset: 0x0040AE3C
	public ari()
	{
		this.j = new List<string>
		{
			d7f.b,
			ari.a
		};
	}

	// Token: 0x0600B70B RID: 46859 RVA: 0x0040CC70 File Offset: 0x0040AE70
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(60, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B70C RID: 46860 RVA: 0x0040CCC4 File Offset: 0x0040AEC4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B70D RID: 46861 RVA: 0x0040CCC8 File Offset: 0x0040AEC8
	public override IList<string> bi()
	{
		return this.j;
	}

	// Token: 0x0600B70E RID: 46862 RVA: 0x0040CCD4 File Offset: 0x0040AED4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(ari.a, ari.h, false, false));
		return list;
	}

	// Token: 0x0600B70F RID: 46863 RVA: 0x0040CD20 File Offset: 0x0040AF20
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/PsychokineticChain", new object[]
		{
			ari.a(A_0),
			Convert.ToInt32(ari.c(A_0) * 100.0),
			ari.b(A_0),
			l4.a((double)ari.i, false)
		});
	}

	// Token: 0x0600B710 RID: 46864 RVA: 0x0040CD88 File Offset: 0x0040AF88
	public static double c(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		double val = 0.2 + (double)effectivePsiSkillLevel * 0.002;
		return Math.Min(0.5, val);
	}

	// Token: 0x0600B711 RID: 46865 RVA: 0x0040CDC4 File Offset: 0x0040AFC4
	public static int b(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		return Convert.ToInt32(30.0 + 0.7 * (double)effectivePsiSkillLevel);
	}

	// Token: 0x0600B712 RID: 46866 RVA: 0x0040CDF4 File Offset: 0x0040AFF4
	public new static int a(cnm A_0)
	{
		int num = 3;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<cqf>())
		{
			num++;
		}
		return num;
	}

	// Token: 0x0600B713 RID: 46867 RVA: 0x0040CE30 File Offset: 0x0040B030
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B714 RID: 46868 RVA: 0x0040CE34 File Offset: 0x0040B034
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B715 RID: 46869 RVA: 0x0040CE3C File Offset: 0x0040B03C
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B716 RID: 46870 RVA: 0x0040CE44 File Offset: 0x0040B044
	protected override float cj(cnm A_0)
	{
		return 25f;
	}

	// Token: 0x0600B717 RID: 46871 RVA: 0x0040CE4C File Offset: 0x0040B04C
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x04004283 RID: 17027
	public new static readonly string a = "Psi.PsychokineticChain";

	// Token: 0x04004284 RID: 17028
	private const double b = 0.2;

	// Token: 0x04004285 RID: 17029
	private const double c = 0.002;

	// Token: 0x04004286 RID: 17030
	private const double d = 0.5;

	// Token: 0x04004287 RID: 17031
	private new const double e = 30.0;

	// Token: 0x04004288 RID: 17032
	private new const double f = 0.7;

	// Token: 0x04004289 RID: 17033
	private new const int g = 3;

	// Token: 0x0400428A RID: 17034
	public new static readonly int h = 12 * d0u.b;

	// Token: 0x0400428B RID: 17035
	public new static readonly int i = 3 * d0u.b;

	// Token: 0x0400428C RID: 17036
	private new List<string> j;
}
