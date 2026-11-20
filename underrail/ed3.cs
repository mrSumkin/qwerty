using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F1D RID: 7965
[ayj("TemporalDistorsion")]
public sealed class ed3 : ce5
{
	// Token: 0x0600B7B8 RID: 47032 RVA: 0x0040E63C File Offset: 0x0040C83C
	public override string y8()
	{
		return "Временное искажение";
	}

	// Token: 0x0600B7B9 RID: 47033 RVA: 0x0040E644 File Offset: 0x0040C844
	public override string os()
	{
		return "TemporalDistorsion";
	}

	// Token: 0x0600B7BA RID: 47034 RVA: 0x0040E64C File Offset: 0x0040C84C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B7BB RID: 47035 RVA: 0x0040E650 File Offset: 0x0040C850
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B7BC RID: 47036 RVA: 0x0040E654 File Offset: 0x0040C854
	public override int ci()
	{
		return 1;
	}

	// Token: 0x0600B7BD RID: 47037 RVA: 0x0040E658 File Offset: 0x0040C858
	public ed3()
	{
		this.l = new List<string>
		{
			d7f.b
		};
	}

	// Token: 0x0600B7BE RID: 47038 RVA: 0x0040E678 File Offset: 0x0040C878
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

	// Token: 0x0600B7BF RID: 47039 RVA: 0x0040E6AC File Offset: 0x0040C8AC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B7C0 RID: 47040 RVA: 0x0040E6B0 File Offset: 0x0040C8B0
	public override IList<string> bi()
	{
		return this.l;
	}

	// Token: 0x0600B7C1 RID: 47041 RVA: 0x0040E6B8 File Offset: 0x0040C8B8
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

	// Token: 0x0600B7C2 RID: 47042 RVA: 0x0040E6E8 File Offset: 0x0040C8E8
	public override string bo(cnm A_0)
	{
		List<a1q> list = ed3.a(A_0);
		return qv.a("Psi/TemporalDistorsion", new object[]
		{
			l4.a(ed3.k, false),
			list[0].a(true),
			list[1].a(true),
			(int)(ed3.j * 100.0),
			(int)(ed3.i * 100.0)
		});
	}

	// Token: 0x0600B7C3 RID: 47043 RVA: 0x0040E770 File Offset: 0x0040C970
	public new static List<a1q> a(cnm A_0)
	{
		List<a1q> list = new List<a1q>();
		if (A_0 != null && A_0.b8() != null)
		{
			int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<p5>(A_0);
			double num = 1.0;
			double num2 = c3n.a("TemporalDistorsion", A_0);
			list.Add(new a1q
			{
				DamageType = DamageType.Mechanical,
				LowerBoundary = (int)((5.0 + 0.075 * (double)effectivePsiSkillLevel) * num * num2),
				UpperBoundary = (int)((6.0 + 0.15 * (double)effectivePsiSkillLevel) * num * num2)
			});
			list.Add(new a1q
			{
				DamageType = DamageType.Energy,
				LowerBoundary = (int)((5.0 + 0.075 * (double)effectivePsiSkillLevel) * num * num2),
				UpperBoundary = (int)((6.0 + 0.15 * (double)effectivePsiSkillLevel) * num * num2)
			});
		}
		return list;
	}

	// Token: 0x0600B7C4 RID: 47044 RVA: 0x0040E86C File Offset: 0x0040CA6C
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600B7C5 RID: 47045 RVA: 0x0040E870 File Offset: 0x0040CA70
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B7C6 RID: 47046 RVA: 0x0040E878 File Offset: 0x0040CA78
	protected override float cj(cnm A_0)
	{
		return 15f;
	}

	// Token: 0x0600B7C7 RID: 47047 RVA: 0x0040E880 File Offset: 0x0040CA80
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B7C8 RID: 47048 RVA: 0x0040E888 File Offset: 0x0040CA88
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x040042D4 RID: 17108
	private new const string a = "Temporal Distortion";

	// Token: 0x040042D5 RID: 17109
	private const string b = "TemporalDistorsion";

	// Token: 0x040042D6 RID: 17110
	private const double c = 5.0;

	// Token: 0x040042D7 RID: 17111
	private const double d = 0.075;

	// Token: 0x040042D8 RID: 17112
	private new const double e = 0.15;

	// Token: 0x040042D9 RID: 17113
	private new const double f = 5.0;

	// Token: 0x040042DA RID: 17114
	private new const double g = 0.075;

	// Token: 0x040042DB RID: 17115
	private new const double h = 0.15;

	// Token: 0x040042DC RID: 17116
	public new static readonly double i = 0.5;

	// Token: 0x040042DD RID: 17117
	public new static readonly double j = 0.2;

	// Token: 0x040042DE RID: 17118
	public new static readonly int k = 2;

	// Token: 0x040042DF RID: 17119
	private new List<string> l;
}
