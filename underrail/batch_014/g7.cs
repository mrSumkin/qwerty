using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F28 RID: 7976
[ayj("Enrage")]
public sealed class g7 : ce5
{
	// Token: 0x0600B887 RID: 47239 RVA: 0x0040FE6C File Offset: 0x0040E06C
	public override string y8()
	{
		return "Взбесить";
	}

	// Token: 0x0600B888 RID: 47240 RVA: 0x0040FE74 File Offset: 0x0040E074
	public override string os()
	{
		return "Enrage";
	}

	// Token: 0x0600B889 RID: 47241 RVA: 0x0040FE7C File Offset: 0x0040E07C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B88A RID: 47242 RVA: 0x0040FE80 File Offset: 0x0040E080
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B88B RID: 47243 RVA: 0x0040FE84 File Offset: 0x0040E084
	public override int ci()
	{
		return 5;
	}

	// Token: 0x0600B88C RID: 47244 RVA: 0x0040FE88 File Offset: 0x0040E088
	public g7()
	{
		this.e = new List<string>
		{
			d7f.b,
			g7.a
		};
	}

	// Token: 0x0600B88D RID: 47245 RVA: 0x0040FEBC File Offset: 0x0040E0BC
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B88E RID: 47246 RVA: 0x0040FEF0 File Offset: 0x0040E0F0
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B88F RID: 47247 RVA: 0x0040FEFC File Offset: 0x0040E0FC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(g7.a, 8 * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B890 RID: 47248 RVA: 0x0040FF48 File Offset: 0x0040E148
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/Enrage", new object[]
		{
			l4.a(g7.c, false)
		});
	}

	// Token: 0x0600B891 RID: 47249 RVA: 0x0040FF6C File Offset: 0x0040E16C
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
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B892 RID: 47250 RVA: 0x0040FFC0 File Offset: 0x0040E1C0
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x0600B893 RID: 47251 RVA: 0x0040FFC4 File Offset: 0x0040E1C4
	protected override int br(cnm A_0)
	{
		return 2000;
	}

	// Token: 0x0600B894 RID: 47252 RVA: 0x0040FFCC File Offset: 0x0040E1CC
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B895 RID: 47253 RVA: 0x0040FFD4 File Offset: 0x0040E1D4
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B896 RID: 47254 RVA: 0x0040FFDC File Offset: 0x0040E1DC
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B897 RID: 47255 RVA: 0x00410010 File Offset: 0x0040E210
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004330 RID: 17200
	public new static readonly string a = "Psi.Enrage";

	// Token: 0x04004331 RID: 17201
	private const int b = 8;

	// Token: 0x04004332 RID: 17202
	public static readonly int c = 2;

	// Token: 0x04004333 RID: 17203
	public static readonly int d = 1;

	// Token: 0x04004334 RID: 17204
	private new List<string> e;
}
