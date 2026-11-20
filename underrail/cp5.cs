using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F31 RID: 7985
[ayj("Forcefield")]
public sealed class cp5 : ce5
{
	// Token: 0x0600B923 RID: 47395 RVA: 0x004111CC File Offset: 0x0040F3CC
	public override string y8()
	{
		return "Силовое поле";
	}

	// Token: 0x0600B924 RID: 47396 RVA: 0x004111D4 File Offset: 0x0040F3D4
	public override string os()
	{
		return "Forcefield";
	}

	// Token: 0x0600B925 RID: 47397 RVA: 0x004111DC File Offset: 0x0040F3DC
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B926 RID: 47398 RVA: 0x004111E0 File Offset: 0x0040F3E0
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B927 RID: 47399 RVA: 0x004111E4 File Offset: 0x0040F3E4
	public override int ci()
	{
		return 2;
	}

	// Token: 0x0600B928 RID: 47400 RVA: 0x004111E8 File Offset: 0x0040F3E8
	public cp5()
	{
		this.i = new List<string>
		{
			d7f.b,
			cp5.a
		};
	}

	// Token: 0x0600B929 RID: 47401 RVA: 0x0041121C File Offset: 0x0040F41C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredUnoccupiedTraversableSpot;
	}

	// Token: 0x0600B92A RID: 47402 RVA: 0x00411220 File Offset: 0x0040F420
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B92B RID: 47403 RVA: 0x00411228 File Offset: 0x0040F428
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(cp5.a, cp5.b, false, false));
		return list;
	}

	// Token: 0x0600B92C RID: 47404 RVA: 0x00411274 File Offset: 0x0040F474
	public override string bo(cnm A_0)
	{
		double a_;
		int a_2;
		cp5.a(A_0, DamageType.Mechanical, out a_, out a_2);
		double a_3;
		int a_4;
		cp5.a(A_0, DamageType.Heat, out a_3, out a_4);
		return qv.a("Psi/Forcefield", new object[]
		{
			cp5.a(A_0),
			new du2(DamageType.Mechanical, a_2, a_).ToString(),
			new du2(DamageType.Heat, a_4, a_3).ToString(),
			l4.a((double)cp5.b(A_0))
		});
	}

	// Token: 0x0600B92D RID: 47405 RVA: 0x00411300 File Offset: 0x0040F500
	public static int b(cnm A_0)
	{
		int num = 2;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<a9z>())
		{
			num += a9z.b;
		}
		return num * d0u.b;
	}

	// Token: 0x0600B92E RID: 47406 RVA: 0x00411344 File Offset: 0x0040F544
	public new static int a(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		double num = cp5.c + (double)effectivePsiSkillLevel * cp5.d;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<a9z>())
		{
			num *= 1.0 + a9z.c + (double)A_0.b8().GetSpecializationValue<dgc>(true) * dgc.a;
		}
		return Convert.ToInt32(num);
	}

	// Token: 0x0600B92F RID: 47407 RVA: 0x004113BC File Offset: 0x0040F5BC
	public static void a(cnm A_0, DamageType A_1, out double A_2, out int A_3)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		double num;
		if (A_1 == DamageType.Mechanical)
		{
			num = 1.0;
		}
		else
		{
			num = 0.5;
		}
		A_2 = Math.Min(0.9, Math.Round((cp5.e + cp5.f * (double)effectivePsiSkillLevel) * num, 2));
		A_3 = Convert.ToInt32((cp5.g + cp5.h * (double)effectivePsiSkillLevel) * num);
	}

	// Token: 0x0600B930 RID: 47408 RVA: 0x0041142C File Offset: 0x0040F62C
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600B931 RID: 47409 RVA: 0x00411430 File Offset: 0x0040F630
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B932 RID: 47410 RVA: 0x00411438 File Offset: 0x0040F638
	protected override float f0(cnm A_0)
	{
		return 7f;
	}

	// Token: 0x0600B933 RID: 47411 RVA: 0x00411440 File Offset: 0x0040F640
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B934 RID: 47412 RVA: 0x00411448 File Offset: 0x0040F648
	protected override int d2(cnm A_0)
	{
		return 1;
	}

	// Token: 0x0600B935 RID: 47413 RVA: 0x0041144C File Offset: 0x0040F64C
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(25, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B936 RID: 47414 RVA: 0x004114A0 File Offset: 0x0040F6A0
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x04004362 RID: 17250
	public new static readonly string a = "Psi.Forcefield";

	// Token: 0x04004363 RID: 17251
	private static readonly int b = 8 * d0u.b;

	// Token: 0x04004364 RID: 17252
	public static readonly double c = 30.0;

	// Token: 0x04004365 RID: 17253
	public static readonly double d = 1.5;

	// Token: 0x04004366 RID: 17254
	public new static readonly double e = 0.15;

	// Token: 0x04004367 RID: 17255
	public new static readonly double f = 0.002;

	// Token: 0x04004368 RID: 17256
	public new static readonly double g = 5.0;

	// Token: 0x04004369 RID: 17257
	public new static readonly double h = 0.1;

	// Token: 0x0400436A RID: 17258
	private new List<string> i;
}
