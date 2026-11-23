using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E1B RID: 7707
public static class c2h
{
	// Token: 0x0600AAAA RID: 43690 RVA: 0x003F4338 File Offset: 0x003F2538
	public static int e(efk A_0)
	{
		if (A_0 != null)
		{
			return aiy.a8 + A_0.Level * aiy.a9;
		}
		return 0;
	}

	// Token: 0x0600AAAB RID: 43691 RVA: 0x003F4358 File Offset: 0x003F2558
	public static int b(e3q A_0)
	{
		int num = A_0.Level - 1;
		for (int i = A_0.i(); i >= 0; i -= c2h.a(num + 1, A_0.e(), A_0.BaseAbilities.Get<av8>().f()))
		{
			num++;
		}
		return num;
	}

	// Token: 0x0600AAAC RID: 43692 RVA: 0x003F43A4 File Offset: 0x003F25A4
	public static int a(int A_0, double A_1, double A_2)
	{
		double num = 1.0;
		if (A_1 < A_2)
		{
			num = Math.Max((double)aiy.be, Math.Pow((double)aiy.bd, A_2 - A_1));
		}
		int num2 = Convert.ToInt32((double)A_0 * num);
		if (num2 < aiy.bg)
		{
			return 0;
		}
		return num2;
	}

	// Token: 0x0600AAAD RID: 43693 RVA: 0x003F43F4 File Offset: 0x003F25F4
	public static int a(int A_0, ExperienceSystem A_1, int A_2)
	{
		if (A_1 == ExperienceSystem.Classic)
		{
			int num = (A_0 - 1) * aiy.bh;
			if (A_0 > aiy.bk)
			{
				num += aiy.bi + (A_0 - aiy.bk) * aiy.bj;
			}
			return num;
		}
		int num2 = Math.Min(aiy.bt, aiy.bp + aiy.bq * (A_0 - 2));
		if (A_0 > aiy.bk)
		{
			num2 += aiy.br + (A_0 - aiy.bk) * aiy.bs;
			num2 = num2 / 2 * 2;
		}
		A_2 -= 4;
		while (A_2 > 0 && num2 > 3)
		{
			if (A_0 % aiy.bw < A_2)
			{
				num2--;
			}
			A_2 -= aiy.bw;
		}
		if (A_0 > aiy.bk)
		{
			num2 = num2 / 2 * 2;
		}
		return Math.Min(aiy.bu, num2);
	}

	// Token: 0x0600AAAE RID: 43694 RVA: 0x003F44C4 File Offset: 0x003F26C4
	public static bool a(e3q A_0)
	{
		return A_0.Level < c2h.a() && A_0.i() >= c2h.a(A_0.Level + 1, A_0.e(), A_0.BaseAbilities.Get<av8>().f());
	}

	// Token: 0x0600AAAF RID: 43695 RVA: 0x003F4514 File Offset: 0x003F2714
	public static int a()
	{
		if (!dk2.f())
		{
			return aiy.bk;
		}
		int? maxLevel = euf.b().MaxLevel;
		if (maxLevel == null)
		{
			return aiy.bk + aiy.bl;
		}
		return maxLevel.GetValueOrDefault();
	}

	// Token: 0x0600AAB0 RID: 43696 RVA: 0x003F455C File Offset: 0x003F275C
	public static int d(int A_0, int A_1)
	{
		return aiy.bn + A_1 * aiy.bo;
	}

	// Token: 0x0600AAB1 RID: 43697 RVA: 0x003F456C File Offset: 0x003F276C
	public static int c(int A_0, int A_1)
	{
		return aiy.ba + aiy.bb * A_1;
	}

	// Token: 0x0600AAB2 RID: 43698 RVA: 0x003F457C File Offset: 0x003F277C
	public static int b(int A_0, int A_1)
	{
		return c2h.a(A_0, A_1, (double)aiy.a);
	}

	// Token: 0x0600AAB3 RID: 43699 RVA: 0x003F458C File Offset: 0x003F278C
	public static int a(int A_0, int A_1)
	{
		return c2h.a(A_0, A_1, (double)aiy.b);
	}

	// Token: 0x0600AAB4 RID: 43700 RVA: 0x003F459C File Offset: 0x003F279C
	public static int a(int A_0, int A_1, double A_2)
	{
		return (int)((double)((1f + c2h.d(A_0)) * (float)(A_1 + 2)) * A_2);
	}

	// Token: 0x0600AAB5 RID: 43701 RVA: 0x003F45B8 File Offset: 0x003F27B8
	public static float d(int A_0)
	{
		float result;
		if (A_0 > aiy.z)
		{
			result = (float)(A_0 - aiy.z) * aiy.ab;
		}
		else if (A_0 < aiy.z)
		{
			result = (float)(A_0 - aiy.z) * aiy.aa;
		}
		else
		{
			result = 0f;
		}
		return result;
	}

	// Token: 0x0600AAB6 RID: 43702 RVA: 0x003F460C File Offset: 0x003F280C
	public static float a(float A_0, int A_1)
	{
		return (float)(Convert.ToInt32(A_0 / (float)A_1) * A_1);
	}

	// Token: 0x0600AAB7 RID: 43703 RVA: 0x003F461C File Offset: 0x003F281C
	public static int c(int A_0)
	{
		return A_0 * aiy.bv;
	}

	// Token: 0x0600AAB8 RID: 43704 RVA: 0x003F4628 File Offset: 0x003F2828
	public static int d(efk A_0)
	{
		if (A_0 != null)
		{
			return A_0.Level;
		}
		return 1;
	}

	// Token: 0x0600AAB9 RID: 43705 RVA: 0x003F463C File Offset: 0x003F283C
	public static int a(efk A_0, BaseAbilityEnum A_1)
	{
		int num = A_0.BaseAbilities.b(A_1.ToString()).g();
		if (A_1 == BaseAbilityEnum.Agility)
		{
			if (A_0.SpecialStates.b)
			{
				num = 0;
			}
			else if (A_0.EncumbranceLevel == db9.d)
			{
				num = 0;
			}
			else if (A_0.EncumbranceLevel == db9.c)
			{
				num -= 6;
			}
			else if (A_0.EncumbranceLevel == db9.b)
			{
				num -= 3;
			}
		}
		return num;
	}

	// Token: 0x0600AABA RID: 43706 RVA: 0x003F46C0 File Offset: 0x003F28C0
	public static int c(efk A_0)
	{
		if (A_0 != null)
		{
			int num = A_0.BaseAbilities.Perception;
			if (A_0.Feats.Contains<qq>())
			{
				num += qq.a + (int)((double)A_0.GetSpecializationValue<dv6>(true) * dv6.a);
			}
			if (A_0.StatusEffects.a(d62.a))
			{
				num += dfk.d;
			}
			return num;
		}
		return 0;
	}

	// Token: 0x0600AABB RID: 43707 RVA: 0x003F4728 File Offset: 0x003F2928
	public static int a(efk A_0, int A_1)
	{
		int num = A_1;
		if (A_0 is e3q)
		{
			num = (int)((float)num * euf.b().HealingModifier);
		}
		if (A_0 != null && A_0.Feats.Contains<yn>())
		{
			num = (int)((double)num * (1.0 + yn.a + (double)A_0.GetSpecializationValue<aog>(true) * aog.a));
		}
		return num;
	}

	// Token: 0x0600AABC RID: 43708 RVA: 0x003F478C File Offset: 0x003F298C
	public static double a(efk A_0, string[] A_1)
	{
		HashSet<PsiSchool> hashSet = new HashSet<PsiSchool>();
		foreach (string text in A_1)
		{
			if (text != null)
			{
				c7i c7i = dgk.a(text) as c7i;
				if (c7i != null)
				{
					hashSet.Add(c7i.School);
				}
			}
		}
		int num = hashSet.Count;
		if (num > 1 && A_0 != null && A_0.Feats.Contains<e0z>())
		{
			num--;
		}
		double num2 = 1.0 + (double)Math.Max(0, num - 1) * aiy.aw;
		if (hashSet.Count == 1 && A_0 != null && A_0.Feats.Contains<d5t>())
		{
			num2 -= d5t.a + (double)A_0.GetSpecializationValue<e0o>(true) * e0o.a;
		}
		return num2;
	}

	// Token: 0x0600AABD RID: 43709 RVA: 0x003F4864 File Offset: 0x003F2A64
	public static int b(efk A_0)
	{
		if (A_0 != null)
		{
			int num = c2h.b(A_0.BaseAbilities.a(aiy.a(A_0)).f()) + A_0.Offense.aj;
			if (num > 0)
			{
				int num2 = 999;
				List<coc> microfeats = A_0.GetMicrofeats<coc>();
				if (microfeats != null)
				{
					foreach (coc coc in microfeats)
					{
						num2 = Math.Min(coc.a(), num2);
					}
				}
				num2 = Math.Max(0, num2);
				num = Math.Min(num2, num);
			}
			return num;
		}
		return 0;
	}

	// Token: 0x0600AABE RID: 43710 RVA: 0x003F4918 File Offset: 0x003F2B18
	public static int b(int A_0)
	{
		return d05.a(1, 2 + A_0 / 2, aiy.av);
	}

	// Token: 0x0600AABF RID: 43711 RVA: 0x003F492C File Offset: 0x003F2B2C
	public static bool a(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().c(d8o.t) && A_0.b8().StatusEffects.a(dnq.a);
	}

	// Token: 0x0600AAC0 RID: 43712 RVA: 0x003F4978 File Offset: 0x003F2B78
	public static int a(efk A_0)
	{
		return c2h.b((int)(0.6f * (float)A_0.BaseAbilities.Constitution + 0.2f * (float)A_0.BaseAbilities.Will + 0.2f * (float)A_0.BaseAbilities.Strength), c2h.d(A_0));
	}

	// Token: 0x0600AAC1 RID: 43713 RVA: 0x003F49CC File Offset: 0x003F2BCC
	public static float a(int A_0)
	{
		return 1f + (float)Math.Max(0, A_0 - 4) * aiy.a7;
	}
}
