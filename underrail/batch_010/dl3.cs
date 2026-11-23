using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F2C RID: 7980
[ayj("Electrokinesis")]
public sealed class dl3 : ce5
{
	// Token: 0x0600B8D4 RID: 47316 RVA: 0x00410798 File Offset: 0x0040E998
	public override string y8()
	{
		return "Электрокинез";
	}

	// Token: 0x0600B8D5 RID: 47317 RVA: 0x004107A0 File Offset: 0x0040E9A0
	public override string os()
	{
		return "Electrokinesis";
	}

	// Token: 0x0600B8D6 RID: 47318 RVA: 0x004107A8 File Offset: 0x0040E9A8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B8D7 RID: 47319 RVA: 0x004107AC File Offset: 0x0040E9AC
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B8D8 RID: 47320 RVA: 0x004107B0 File Offset: 0x0040E9B0
	public override int ci()
	{
		return 3;
	}

	// Token: 0x0600B8D9 RID: 47321 RVA: 0x004107B4 File Offset: 0x0040E9B4
	public dl3()
	{
		this.g = new List<string>
		{
			d7f.b
		};
	}

	// Token: 0x0600B8DA RID: 47322 RVA: 0x004107D4 File Offset: 0x0040E9D4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B8DB RID: 47323 RVA: 0x004107D8 File Offset: 0x0040E9D8
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B8DC RID: 47324 RVA: 0x004107E0 File Offset: 0x0040E9E0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B8DD RID: 47325 RVA: 0x00410814 File Offset: 0x0040EA14
	public override string bo(cnm A_0)
	{
		a1q a1q = dl3.a(A_0, 0, 0);
		return qv.a("Psi/Electrokinesis", new object[]
		{
			a1q.LowerBoundary,
			a1q.UpperBoundary,
			l4.a(dl3.f, false),
			dl3.d,
			(int)(dl3.e * 100.0)
		});
	}

	// Token: 0x0600B8DE RID: 47326 RVA: 0x0041088C File Offset: 0x0040EA8C
	public static a1q a(cnm A_0, int A_1, int A_2)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return new a1q(DamageType.Electricity, 0, 0);
		}
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		double num = c3n.a("Electrokinesis", A_0);
		return new a1q
		{
			DamageType = DamageType.Electricity,
			LowerBoundary = Convert.ToInt32((8.0 + (double)A_1 + 0.15 * (double)effectivePsiSkillLevel) * (1.0 - (double)A_2 * dl3.e) * num),
			UpperBoundary = Convert.ToInt32((8.0 + (double)A_1 + 1.0 + 0.45 * (double)effectivePsiSkillLevel) * (1.0 - (double)A_2 * dl3.e) * num)
		};
	}

	// Token: 0x0600B8DF RID: 47327 RVA: 0x00410958 File Offset: 0x0040EB58
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(30, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B8E0 RID: 47328 RVA: 0x004109AC File Offset: 0x0040EBAC
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B8E1 RID: 47329 RVA: 0x004109B4 File Offset: 0x0040EBB4
	protected override float f0(cnm A_0)
	{
		return 8f;
	}

	// Token: 0x0600B8E2 RID: 47330 RVA: 0x004109BC File Offset: 0x0040EBBC
	protected override float cj(cnm A_0)
	{
		return 35f;
	}

	// Token: 0x0600B8E3 RID: 47331 RVA: 0x004109C4 File Offset: 0x0040EBC4
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x0600B8E4 RID: 47332 RVA: 0x004109C8 File Offset: 0x0040EBC8
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0400434A RID: 17226
	private new const double a = 8.0;

	// Token: 0x0400434B RID: 17227
	private const double b = 0.15;

	// Token: 0x0400434C RID: 17228
	private const double c = 0.45;

	// Token: 0x0400434D RID: 17229
	public static readonly int d = 4;

	// Token: 0x0400434E RID: 17230
	public new static readonly double e = 0.2;

	// Token: 0x0400434F RID: 17231
	public new static readonly int f = 1;

	// Token: 0x04004350 RID: 17232
	private new List<string> g;
}
