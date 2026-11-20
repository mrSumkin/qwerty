using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F2B RID: 7979
[ayj("MentalBreakdown")]
public sealed class be7 : ce5
{
	// Token: 0x0600B8C1 RID: 47297 RVA: 0x004105A0 File Offset: 0x0040E7A0
	public override string y8()
	{
		return "Ментальное разложение";
	}

	// Token: 0x0600B8C2 RID: 47298 RVA: 0x004105A8 File Offset: 0x0040E7A8
	public override string os()
	{
		return "MentalBreakdown";
	}

	// Token: 0x0600B8C3 RID: 47299 RVA: 0x004105B0 File Offset: 0x0040E7B0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B8C4 RID: 47300 RVA: 0x004105B4 File Offset: 0x0040E7B4
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B8C5 RID: 47301 RVA: 0x004105B8 File Offset: 0x0040E7B8
	public override int ci()
	{
		return 4;
	}

	// Token: 0x0600B8C6 RID: 47302 RVA: 0x004105C0 File Offset: 0x0040E7C0
	public be7()
	{
		this.e = new List<string>
		{
			d7f.b,
			be7.a
		};
	}

	// Token: 0x0600B8C7 RID: 47303 RVA: 0x004105F4 File Offset: 0x0040E7F4
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B8C8 RID: 47304 RVA: 0x00410628 File Offset: 0x0040E828
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B8C9 RID: 47305 RVA: 0x00410634 File Offset: 0x0040E834
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		list.Add(new cfd(be7.a, be7.b, false, false));
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B8CA RID: 47306 RVA: 0x00410680 File Offset: 0x0040E880
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/MentalBreakdown", new object[]
		{
			l4.a(be7.c, false),
			(int)(be7.d * 100.0)
		});
	}

	// Token: 0x0600B8CB RID: 47307 RVA: 0x004106BC File Offset: 0x0040E8BC
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
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B8CC RID: 47308 RVA: 0x00410710 File Offset: 0x0040E910
	public new static int a(cnm A_0)
	{
		return ce5.GetEffectivePsiSkillLevel<dql>(A_0);
	}

	// Token: 0x0600B8CD RID: 47309 RVA: 0x00410718 File Offset: 0x0040E918
	protected override int br(cnm A_0)
	{
		return 2000;
	}

	// Token: 0x0600B8CE RID: 47310 RVA: 0x00410720 File Offset: 0x0040E920
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B8CF RID: 47311 RVA: 0x00410728 File Offset: 0x0040E928
	protected override float cj(cnm A_0)
	{
		return 60f;
	}

	// Token: 0x0600B8D0 RID: 47312 RVA: 0x00410730 File Offset: 0x0040E930
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B8D1 RID: 47313 RVA: 0x00410764 File Offset: 0x0040E964
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B8D2 RID: 47314 RVA: 0x00410768 File Offset: 0x0040E968
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004345 RID: 17221
	private new static readonly string a = "Psi.MentalBreakdown";

	// Token: 0x04004346 RID: 17222
	private static readonly int b = 8 * d0u.b;

	// Token: 0x04004347 RID: 17223
	public static readonly int c = 3;

	// Token: 0x04004348 RID: 17224
	public static readonly double d = 0.5;

	// Token: 0x04004349 RID: 17225
	private new List<string> e;
}
