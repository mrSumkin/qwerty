using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F2F RID: 7983
[ayj("ForceEmission")]
public sealed class e5o : aoc
{
	// Token: 0x0600B8FF RID: 47359 RVA: 0x00410DAC File Offset: 0x0040EFAC
	public override string y8()
	{
		return "Эмиссия силы";
	}

	// Token: 0x0600B900 RID: 47360 RVA: 0x00410DB4 File Offset: 0x0040EFB4
	public override string os()
	{
		return "ForceEmission";
	}

	// Token: 0x0600B901 RID: 47361 RVA: 0x00410DBC File Offset: 0x0040EFBC
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B902 RID: 47362 RVA: 0x00410DC0 File Offset: 0x0040EFC0
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600B903 RID: 47363 RVA: 0x00410DC8 File Offset: 0x0040EFC8
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B904 RID: 47364 RVA: 0x00410DCC File Offset: 0x0040EFCC
	public override int ci()
	{
		return 4;
	}

	// Token: 0x0600B905 RID: 47365 RVA: 0x00410DD0 File Offset: 0x0040EFD0
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600B906 RID: 47366 RVA: 0x00410DD4 File Offset: 0x0040EFD4
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/ForceEmission", new object[]
		{
			e5o.a(A_0.b8()).a(true),
			this.a(A_0)
		});
	}

	// Token: 0x0600B907 RID: 47367 RVA: 0x00410E18 File Offset: 0x0040F018
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B908 RID: 47368 RVA: 0x00410E20 File Offset: 0x0040F020
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new c54()
		};
	}

	// Token: 0x0600B909 RID: 47369 RVA: 0x00410E34 File Offset: 0x0040F034
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null;
	}

	// Token: 0x0600B90A RID: 47370 RVA: 0x00410E58 File Offset: 0x0040F058
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && A_0 != null && A_0.b8() != null;
	}

	// Token: 0x0600B90B RID: 47371 RVA: 0x00410E7C File Offset: 0x0040F07C
	public int a(cnm A_0)
	{
		int num = 5;
		num = Convert.ToInt32((float)num * this.c(A_0));
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<a9z>())
		{
			num = Math.Max(1, num - a9z.d);
		}
		return num;
	}

	// Token: 0x0600B90C RID: 47372 RVA: 0x00410ED0 File Offset: 0x0040F0D0
	public static a1q a(efk A_0)
	{
		double num = 1.0;
		if (A_0.Feats.Contains<d6t>() && A_0.BaseAbilities.Strength > d6t.b)
		{
			num *= 1.0 + (d6t.a + (double)A_0.GetSpecializationValue<e31>(true) * e31.a) * (double)(A_0.BaseAbilities.Strength - d6t.b);
		}
		return e5o.a(A_0.Offense.ag()[PsiSchool.Psychokinesis].b(), num);
	}

	// Token: 0x0600B90D RID: 47373 RVA: 0x00410F5C File Offset: 0x0040F15C
	public static a1q a(int A_0, double A_1 = 1.0)
	{
		return new a1q(DamageType.Mechanical, (int)((5.0 + 0.1 * (double)A_0) * A_1), (int)((10.0 + 0.2 * (double)A_0) * A_1));
	}

	// Token: 0x0600B90E RID: 47374 RVA: 0x00410F98 File Offset: 0x0040F198
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(35, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B90F RID: 47375 RVA: 0x00410FEC File Offset: 0x0040F1EC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004359 RID: 17241
	private new const double a = 5.0;

	// Token: 0x0400435A RID: 17242
	private new const double b = 0.1;

	// Token: 0x0400435B RID: 17243
	private new const double c = 10.0;

	// Token: 0x0400435C RID: 17244
	private const double d = 0.2;
}
