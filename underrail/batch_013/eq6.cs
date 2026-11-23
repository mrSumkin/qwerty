using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F27 RID: 7975
[ayj("Bilocation")]
public sealed class eq6 : ce5
{
	// Token: 0x0600B873 RID: 47219 RVA: 0x0040FBBC File Offset: 0x0040DDBC
	public override string y8()
	{
		return "Билокация";
	}

	// Token: 0x0600B874 RID: 47220 RVA: 0x0040FBC4 File Offset: 0x0040DDC4
	public override string os()
	{
		return "Bilocation";
	}

	// Token: 0x0600B875 RID: 47221 RVA: 0x0040FBCC File Offset: 0x0040DDCC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B876 RID: 47222 RVA: 0x0040FBD0 File Offset: 0x0040DDD0
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B877 RID: 47223 RVA: 0x0040FBD4 File Offset: 0x0040DDD4
	public override int ci()
	{
		return 3;
	}

	// Token: 0x0600B878 RID: 47224 RVA: 0x0040FBD8 File Offset: 0x0040DDD8
	public eq6()
	{
		this.g = new List<string>
		{
			d7f.b,
			eq6.a
		};
	}

	// Token: 0x0600B879 RID: 47225 RVA: 0x0040FC0C File Offset: 0x0040DE0C
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.HumanoidNoVehicleNotSelf;
	}

	// Token: 0x0600B87A RID: 47226 RVA: 0x0040FC40 File Offset: 0x0040DE40
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B87B RID: 47227 RVA: 0x0040FC4C File Offset: 0x0040DE4C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = uf.a(eq6.b, A_0, new CooldownCategory[]
		{
			CooldownCategory.Bilocation
		});
		List<cfd> list = new List<cfd>();
		if (num > 0)
		{
			list.Add(new cfd(eq6.a, num, false, false));
		}
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B87C RID: 47228 RVA: 0x0040FCB4 File Offset: 0x0040DEB4
	public override string bo(cnm A_0)
	{
		a1q a1q = eq6.a(A_0);
		return qv.a("Psi/Bilocation", new object[]
		{
			a1q.LowerBoundary,
			a1q.UpperBoundary,
			l4.a(eq6.f, false)
		});
	}

	// Token: 0x0600B87D RID: 47229 RVA: 0x0040FD04 File Offset: 0x0040DF04
	public new static a1q a(cnm A_0)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return new a1q(DamageType.Electricity, 0, 0);
		}
		return eq6.a(ce5.GetEffectivePsiSkillLevel<dql>(A_0));
	}

	// Token: 0x0600B87E RID: 47230 RVA: 0x0040FD2C File Offset: 0x0040DF2C
	public static a1q a(int A_0)
	{
		return new a1q
		{
			DamageType = DamageType.Electricity,
			LowerBoundary = Convert.ToInt32(6.0 + 0.08 * (double)A_0),
			UpperBoundary = Convert.ToInt32(7.0 + 0.2 * (double)A_0)
		};
	}

	// Token: 0x0600B87F RID: 47231 RVA: 0x0040FD90 File Offset: 0x0040DF90
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 7),
			new bap(35, new Type[]
			{
				typeof(dql)
			}),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x0600B880 RID: 47232 RVA: 0x0040FDF8 File Offset: 0x0040DFF8
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x0600B881 RID: 47233 RVA: 0x0040FE00 File Offset: 0x0040E000
	protected override float f0(cnm A_0)
	{
		return 7f;
	}

	// Token: 0x0600B882 RID: 47234 RVA: 0x0040FE08 File Offset: 0x0040E008
	protected override float cj(cnm A_0)
	{
		return 60f;
	}

	// Token: 0x0600B883 RID: 47235 RVA: 0x0040FE10 File Offset: 0x0040E010
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B884 RID: 47236 RVA: 0x0040FE44 File Offset: 0x0040E044
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x0600B885 RID: 47237 RVA: 0x0040FE48 File Offset: 0x0040E048
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x04004329 RID: 17193
	public new static readonly string a = "Psi.Bilocation";

	// Token: 0x0400432A RID: 17194
	private static readonly int b = 10 * d0u.b;

	// Token: 0x0400432B RID: 17195
	private const double c = 6.0;

	// Token: 0x0400432C RID: 17196
	private const double d = 0.08;

	// Token: 0x0400432D RID: 17197
	private new const double e = 0.2;

	// Token: 0x0400432E RID: 17198
	public new static readonly int f = 4;

	// Token: 0x0400432F RID: 17199
	private new List<string> g;
}
