using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F29 RID: 7977
[ayj("ThermodynamicDestabilization")]
public sealed class aph : ce5
{
	// Token: 0x0600B899 RID: 47257 RVA: 0x0041002C File Offset: 0x0040E22C
	public override string y8()
	{
		return "Термодинамическая дестабилизация";
	}

	// Token: 0x0600B89A RID: 47258 RVA: 0x00410034 File Offset: 0x0040E234
	public override string os()
	{
		return "ThermodynamicDestabilization";
	}

	// Token: 0x0600B89B RID: 47259 RVA: 0x0041003C File Offset: 0x0040E23C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B89C RID: 47260 RVA: 0x00410040 File Offset: 0x0040E240
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B89D RID: 47261 RVA: 0x00410044 File Offset: 0x0040E244
	public override int ci()
	{
		return 7;
	}

	// Token: 0x0600B89E RID: 47262 RVA: 0x00410048 File Offset: 0x0040E248
	public aph()
	{
		this.h = new List<string>
		{
			"Psi.ThermodynamicDestabilization"
		};
	}

	// Token: 0x0600B89F RID: 47263 RVA: 0x00410068 File Offset: 0x0040E268
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B8A0 RID: 47264 RVA: 0x0041006C File Offset: 0x0040E26C
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B8A1 RID: 47265 RVA: 0x00410074 File Offset: 0x0040E274
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.ThermodynamicDestabilization", 5 * d0u.b, false, false)
		};
	}

	// Token: 0x0600B8A2 RID: 47266 RVA: 0x00410094 File Offset: 0x0040E294
	public override string bo(cnm A_0)
	{
		string text = qv.a("Psi/ThermodynamicDestabilization", new object[]
		{
			l4.a(aph.b, false),
			(int)(aph.a(A_0) * 100.0)
		});
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<xk>())
		{
			text = text + " " + qv.a("Psi/ThermodynamicDestabilizationPyromaniac", new object[]
			{
				(int)(aph.g * 100.0),
				(int)(xk.a(A_0) * 100.0),
				l4.a(3, false)
			});
		}
		return text;
	}

	// Token: 0x0600B8A3 RID: 47267 RVA: 0x00410158 File Offset: 0x0040E358
	public new static double a(cnm A_0)
	{
		if (A_0 != null)
		{
			return Math.Min(aph.f, 0.3 + (double)ce5.GetEffectivePsiSkillLevel<rs>(A_0) * 0.005);
		}
		return 0.3;
	}

	// Token: 0x0600B8A4 RID: 47268 RVA: 0x00410190 File Offset: 0x0040E390
	public static csk[] b(int A_0)
	{
		return new csk[]
		{
			new csk(DamageType.Heat, Math.Max(1, A_0 / 2)),
			new csk(DamageType.Mechanical, Math.Max(1, A_0 / 2))
		};
	}

	// Token: 0x0600B8A5 RID: 47269 RVA: 0x004101C8 File Offset: 0x0040E3C8
	public static a1q[] a(int A_0)
	{
		return new a1q[]
		{
			new a1q(DamageType.Heat, Math.Max(1, A_0 / 2), Math.Max(1, A_0 / 2)),
			new a1q(DamageType.Mechanical, Math.Max(1, A_0 / 2), Math.Max(1, A_0 / 2))
		};
	}

	// Token: 0x0600B8A6 RID: 47270 RVA: 0x0041021C File Offset: 0x0040E41C
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B8A7 RID: 47271 RVA: 0x00410224 File Offset: 0x0040E424
	protected override float cj(cnm A_0)
	{
		return 30f;
	}

	// Token: 0x0600B8A8 RID: 47272 RVA: 0x0041022C File Offset: 0x0040E42C
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
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B8A9 RID: 47273 RVA: 0x00410280 File Offset: 0x0040E480
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.b) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B8AA RID: 47274 RVA: 0x004102C4 File Offset: 0x0040E4C4
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B8AB RID: 47275 RVA: 0x004102C8 File Offset: 0x0040E4C8
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x04004335 RID: 17205
	public new const string a = "Psi.ThermodynamicDestabilization";

	// Token: 0x04004336 RID: 17206
	public static readonly int b = 2;

	// Token: 0x04004337 RID: 17207
	private const int c = 5;

	// Token: 0x04004338 RID: 17208
	private const double d = 0.3;

	// Token: 0x04004339 RID: 17209
	private new const double e = 0.005;

	// Token: 0x0400433A RID: 17210
	private new static readonly double f = 1.0;

	// Token: 0x0400433B RID: 17211
	public new static double g = 0.5;

	// Token: 0x0400433C RID: 17212
	private new List<string> h;
}
