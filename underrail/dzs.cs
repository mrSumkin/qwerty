using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F32 RID: 7986
[ayj("NeuralOverload")]
public sealed class dzs : ce5
{
	// Token: 0x0600B938 RID: 47416 RVA: 0x00411520 File Offset: 0x0040F720
	public override string y8()
	{
		return "Невральная перегрузка";
	}

	// Token: 0x0600B939 RID: 47417 RVA: 0x00411528 File Offset: 0x0040F728
	public override string os()
	{
		return "NeuralOverload";
	}

	// Token: 0x0600B93A RID: 47418 RVA: 0x00411530 File Offset: 0x0040F730
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B93B RID: 47419 RVA: 0x00411534 File Offset: 0x0040F734
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B93C RID: 47420 RVA: 0x00411538 File Offset: 0x0040F738
	public override int ci()
	{
		return 1;
	}

	// Token: 0x0600B93D RID: 47421 RVA: 0x0041153C File Offset: 0x0040F73C
	public dzs()
	{
		this.h = new List<string>
		{
			d7f.b
		};
	}

	// Token: 0x0600B93E RID: 47422 RVA: 0x0041155C File Offset: 0x0040F75C
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x0600B93F RID: 47423 RVA: 0x00411590 File Offset: 0x0040F790
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B940 RID: 47424 RVA: 0x004115C4 File Offset: 0x0040F7C4
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B941 RID: 47425 RVA: 0x004115CC File Offset: 0x0040F7CC
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

	// Token: 0x0600B942 RID: 47426 RVA: 0x004115F8 File Offset: 0x0040F7F8
	public override string bo(cnm A_0)
	{
		a1q a1q = dzs.a(A_0);
		string text = qv.a("Psi/NeuralOverload", new object[]
		{
			a1q.LowerBoundary,
			a1q.UpperBoundary,
			(int)(dzs.g * 100.0),
			dzs.f
		});
		if (A_0 != null && A_0.b8() != null)
		{
			c37 microfeat = A_0.b8().GetMicrofeat<c37>();
			if (microfeat != null)
			{
				text += "\r\n\r\n";
				text += qv.a("Psi/NeuralOverloadIntimidation", new object[]
				{
					microfeat.a(),
					l4.a(microfeat.b(), false)
				});
			}
			cl9 microfeat2 = A_0.b8().GetMicrofeat<cl9>();
			if (microfeat2 != null)
			{
				text += "\r\n\r\n";
				text += qv.a("Psi/NeuralOverloadCerebralAcidization", new object[]
				{
					Convert.ToInt32(microfeat2.a() * 100.0),
					l4.a(microfeat2.b(), false)
				});
			}
		}
		return text;
	}

	// Token: 0x0600B943 RID: 47427 RVA: 0x00411728 File Offset: 0x0040F928
	public new static a1q a(cnm A_0)
	{
		a1q result = default(a1q);
		result.DamageType = DamageType.Electricity;
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_0);
		double num = 1.0;
		if (A_0.b8().Feats.Contains<aio>())
		{
			num += aio.a + (double)A_0.b8().GetSpecializationValue<q2>(true) * global::q2.a;
		}
		double num2 = c3n.a("NeuralOverload", A_0);
		result.LowerBoundary = (int)((10.0 + 0.2 * (double)effectivePsiSkillLevel) * num * num2);
		result.UpperBoundary = (int)((11.0 + 0.4 * (double)effectivePsiSkillLevel) * num * num2);
		return result;
	}

	// Token: 0x0600B944 RID: 47428 RVA: 0x004117D8 File Offset: 0x0040F9D8
	public static double a(efk A_0)
	{
		return 1.0 + ((A_0.BaseAbilities.Intelligence > dzs.f) ? ((double)(A_0.BaseAbilities.Intelligence - dzs.f) * dzs.g) : 0.0);
	}

	// Token: 0x0600B945 RID: 47429 RVA: 0x0041182C File Offset: 0x0040FA2C
	public static double a(efk A_0, cnm A_1)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_1);
		return dzs.a(A_0, effectivePsiSkillLevel);
	}

	// Token: 0x0600B946 RID: 47430 RVA: 0x00411848 File Offset: 0x0040FA48
	public static double a(efk A_0, int A_1)
	{
		return qw.a((double)A_1, (double)A_0.Defense.ae());
	}

	// Token: 0x0600B947 RID: 47431 RVA: 0x00411860 File Offset: 0x0040FA60
	protected override int hi(cnm A_0)
	{
		return 18;
	}

	// Token: 0x0600B948 RID: 47432 RVA: 0x00411864 File Offset: 0x0040FA64
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B949 RID: 47433 RVA: 0x00411898 File Offset: 0x0040FA98
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B94A RID: 47434 RVA: 0x004118A0 File Offset: 0x0040FAA0
	protected override float cj(cnm A_0)
	{
		return 15f;
	}

	// Token: 0x0600B94B RID: 47435 RVA: 0x004118A8 File Offset: 0x0040FAA8
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B94C RID: 47436 RVA: 0x004118B0 File Offset: 0x0040FAB0
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0400436B RID: 17259
	private new const string a = "Neural Overload";

	// Token: 0x0400436C RID: 17260
	private const string b = "NeuralOverload";

	// Token: 0x0400436D RID: 17261
	private const double c = 10.0;

	// Token: 0x0400436E RID: 17262
	private const double d = 0.2;

	// Token: 0x0400436F RID: 17263
	private new const double e = 0.4;

	// Token: 0x04004370 RID: 17264
	public new static readonly int f = 5;

	// Token: 0x04004371 RID: 17265
	public new static readonly double g = 0.1;

	// Token: 0x04004372 RID: 17266
	private new List<string> h;
}
