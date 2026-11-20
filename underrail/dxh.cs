using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F34 RID: 7988
[ayj("TelekineticPunch")]
public sealed class dxh : ce5
{
	// Token: 0x0600B95F RID: 47455 RVA: 0x00411A5C File Offset: 0x0040FC5C
	public override string y8()
	{
		return "Телекинетический удар";
	}

	// Token: 0x0600B960 RID: 47456 RVA: 0x00411A64 File Offset: 0x0040FC64
	public override string os()
	{
		return "TelekineticPunch";
	}

	// Token: 0x0600B961 RID: 47457 RVA: 0x00411A6C File Offset: 0x0040FC6C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B962 RID: 47458 RVA: 0x00411A70 File Offset: 0x0040FC70
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B963 RID: 47459 RVA: 0x00411A74 File Offset: 0x0040FC74
	public override int ci()
	{
		return 1;
	}

	// Token: 0x0600B964 RID: 47460 RVA: 0x00411A7C File Offset: 0x0040FC7C
	public dxh()
	{
		this.g = new List<string>
		{
			d7f.b,
			dxh.a
		};
	}

	// Token: 0x0600B965 RID: 47461 RVA: 0x00411AB0 File Offset: 0x0040FCB0
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

	// Token: 0x0600B966 RID: 47462 RVA: 0x00411AE4 File Offset: 0x0040FCE4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B967 RID: 47463 RVA: 0x00411AE8 File Offset: 0x0040FCE8
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B968 RID: 47464 RVA: 0x00411AF4 File Offset: 0x0040FCF4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(dxh.a, 15000, false, false));
		return list;
	}

	// Token: 0x0600B969 RID: 47465 RVA: 0x00411B40 File Offset: 0x0040FD40
	public override string bo(cnm A_0)
	{
		a1q a1q = dxh.b(A_0);
		string text = qv.b("Psi/TelekineticPunch");
		string result = string.Empty;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				result = string.Format(text, a1q.LowerBoundary, a1q.UpperBoundary, l4.a(l4.a((double)dxh.f), false));
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x0600B96A RID: 47466 RVA: 0x00411BBC File Offset: 0x0040FDBC
	public static a1q b(cnm A_0)
	{
		a1q result = default(a1q);
		result.DamageType = DamageType.Mechanical;
		if (A_0 != null && A_0.b8() != null)
		{
			double num = 1.0;
			if (A_0.b8().Feats.Contains<a9z>())
			{
				num *= 1.0 + a9z.a + (double)A_0.b8().GetSpecializationValue<dk3>(true) * dk3.a;
			}
			if (A_0.b8().Feats.Contains<d6t>() && A_0.b8().BaseAbilities.Strength > d6t.b)
			{
				num *= 1.0 + (d6t.a + (double)A_0.b8().GetSpecializationValue<e31>(true) * e31.a) * (double)(A_0.b8().BaseAbilities.Strength - d6t.b);
			}
			int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
			double num2 = c3n.a("TelekineticPunch", A_0);
			result.LowerBoundary = (int)((9.0 + 0.4 * (double)effectivePsiSkillLevel) * num * num2);
			result.UpperBoundary = (int)((10.0 + 0.65 * (double)effectivePsiSkillLevel) * num * num2);
		}
		return result;
	}

	// Token: 0x0600B96B RID: 47467 RVA: 0x00411CF4 File Offset: 0x0040FEF4
	public new static int a(cnm A_0)
	{
		return ce5.GetEffectivePsiSkillLevel<fd>(A_0);
	}

	// Token: 0x0600B96C RID: 47468 RVA: 0x00411CFC File Offset: 0x0040FEFC
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600B96D RID: 47469 RVA: 0x00411D00 File Offset: 0x0040FF00
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B96E RID: 47470 RVA: 0x00411D08 File Offset: 0x0040FF08
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B96F RID: 47471 RVA: 0x00411D10 File Offset: 0x0040FF10
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B970 RID: 47472 RVA: 0x00411D18 File Offset: 0x0040FF18
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x04004379 RID: 17273
	public new static readonly string a = "Psi.TelekineticPunch";

	// Token: 0x0400437A RID: 17274
	private const double b = 9.0;

	// Token: 0x0400437B RID: 17275
	private const double c = 0.4;

	// Token: 0x0400437C RID: 17276
	private const double d = 0.65;

	// Token: 0x0400437D RID: 17277
	private new const int e = 15000;

	// Token: 0x0400437E RID: 17278
	public new static readonly int f = d0u.b;

	// Token: 0x0400437F RID: 17279
	private new List<string> g;
}
