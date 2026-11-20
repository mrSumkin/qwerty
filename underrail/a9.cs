using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F1E RID: 7966
[ayj("CryoShield")]
public sealed class a9 : ce5
{
	// Token: 0x0600B7CA RID: 47050 RVA: 0x0040E8B0 File Offset: 0x0040CAB0
	public override string y8()
	{
		return "Криощит";
	}

	// Token: 0x0600B7CB RID: 47051 RVA: 0x0040E8B8 File Offset: 0x0040CAB8
	public override string os()
	{
		return "CryoShield";
	}

	// Token: 0x0600B7CC RID: 47052 RVA: 0x0040E8C0 File Offset: 0x0040CAC0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B7CD RID: 47053 RVA: 0x0040E8C4 File Offset: 0x0040CAC4
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B7CE RID: 47054 RVA: 0x0040E8C8 File Offset: 0x0040CAC8
	public override int ci()
	{
		return 4;
	}

	// Token: 0x0600B7CF RID: 47055 RVA: 0x0040E8CC File Offset: 0x0040CACC
	public a9()
	{
		this.h = new List<string>
		{
			"Psi.CryoShield"
		};
	}

	// Token: 0x0600B7D0 RID: 47056 RVA: 0x0040E8EC File Offset: 0x0040CAEC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B7D1 RID: 47057 RVA: 0x0040E8F0 File Offset: 0x0040CAF0
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B7D2 RID: 47058 RVA: 0x0040E8F8 File Offset: 0x0040CAF8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.CryoShield", 10 * d0u.b, false, false)
		};
	}

	// Token: 0x0600B7D3 RID: 47059 RVA: 0x0040E91C File Offset: 0x0040CB1C
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/CryoShield", new object[]
		{
			a9.c,
			(int)(a9.d * 100.0),
			a9.a(A_0),
			l4.a(a9.g, false)
		});
	}

	// Token: 0x0600B7D4 RID: 47060 RVA: 0x0040E97C File Offset: 0x0040CB7C
	public new static int a(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<rs>(A_0);
		return (int)(5.0 + (double)effectivePsiSkillLevel * 0.25);
	}

	// Token: 0x0600B7D5 RID: 47061 RVA: 0x0040E9A8 File Offset: 0x0040CBA8
	protected override float cj(cnm A_0)
	{
		return 20f;
	}

	// Token: 0x0600B7D6 RID: 47062 RVA: 0x0040E9B4 File Offset: 0x0040CBB4
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
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B7D7 RID: 47063 RVA: 0x0040EA08 File Offset: 0x0040CC08
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.c) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B7D8 RID: 47064 RVA: 0x0040EA4C File Offset: 0x0040CC4C
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600B7D9 RID: 47065 RVA: 0x0040EA50 File Offset: 0x0040CC50
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x040042E0 RID: 17120
	public new const string a = "Psi.CryoShield";

	// Token: 0x040042E1 RID: 17121
	private const int b = 10;

	// Token: 0x040042E2 RID: 17122
	public static readonly int c = 5;

	// Token: 0x040042E3 RID: 17123
	public static readonly double d = 0.5;

	// Token: 0x040042E4 RID: 17124
	private new const int e = 5;

	// Token: 0x040042E5 RID: 17125
	private new const double f = 0.25;

	// Token: 0x040042E6 RID: 17126
	public new static readonly int g = 8;

	// Token: 0x040042E7 RID: 17127
	private new List<string> h;
}
