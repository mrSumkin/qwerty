using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B5B RID: 7003
public static class c6o
{
	// Token: 0x060097A3 RID: 38819 RVA: 0x003B1760 File Offset: 0x003AF960
	public static void a(efk A_0, cgk A_1, ett A_2, int A_3, bool A_4 = false, double A_5 = 1.0, bool A_6 = true)
	{
		eya eya = A_1.fu();
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<dcs>() && A_2.i() == ms.ac)
		{
			num -= dcs.a + (double)A_0.GetSpecializationValue<b4e>(true) * b4e.a;
		}
		c6o.a(eya, A_2, A_3, A_4, A_5, A_6);
		eya.b(Math.Min(eya.h() + A_2.f() * A_5 * num, aiy.az));
		eya.b(Math.Max(eya.g(), A_2.c()));
		c6o.a(A_1.fu(), A_2, A_3);
		if (A_2.a() != null && A_2.a().Count > 0)
		{
			foreach (c3e c3e in A_2.a())
			{
				c3e c3e2 = c3e.xs(A_3);
				re re = c3e2 as re;
				if (re != null)
				{
					List<wq> list = re.as4(A_1);
					if (list == null)
					{
						continue;
					}
					using (List<wq>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							wq item = enumerator2.Current;
							eya.ao().Add(item);
						}
						continue;
					}
				}
				bool flag = false;
				if (c3e2 is y3)
				{
					foreach (c3e c3e3 in eya.f())
					{
						y3 y = c3e3 as y3;
						if (y != null && y.ao2(c3e2))
						{
							y.ao1(c3e2);
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					eya.f().Add(c3e2);
				}
			}
		}
	}

	// Token: 0x060097A4 RID: 38820 RVA: 0x003B1994 File Offset: 0x003AFB94
	public static string a(efk A_0)
	{
		if (A_0 != null && A_0.GetMicrofeat<cy9>() != null)
		{
			return "Enriched";
		}
		return "";
	}

	// Token: 0x060097A5 RID: 38821 RVA: 0x003B19B4 File Offset: 0x003AFBB4
	public static void a(diz A_0, ett A_1, int A_2)
	{
		foreach (d3e a_ in A_1.e())
		{
			c6o.a(A_0, a_);
		}
		foreach (wq wq in A_1.b())
		{
			A_0.ao().Add(wq.dn());
		}
	}

	// Token: 0x060097A6 RID: 38822 RVA: 0x003B1A60 File Offset: 0x003AFC60
	public static void a(diz A_0, d3e A_1)
	{
		if (A_1 is d7s)
		{
			foreach (d3e d3e in A_0.ar())
			{
				if (d3e.GetType() == A_1.GetType())
				{
					d7s d7s = (d7s)d3e;
					if (d7s.co(A_1))
					{
						d7s.cn(A_1);
						return;
					}
				}
			}
		}
		if (!A_1.Negative)
		{
			for (int i = 0; i < A_0.ar().Count; i++)
			{
				if (A_0.ar()[i].Negative)
				{
					A_0.ar().Insert(i, A_1.b3());
					return;
				}
			}
		}
		A_0.ar().Add(A_1.b3());
	}

	// Token: 0x060097A7 RID: 38823 RVA: 0x003B1B50 File Offset: 0x003AFD50
	public static void a(bk3 A_0, a1k A_1, int A_2)
	{
		diz diz = A_0 as diz;
		if (diz != null)
		{
			c6o.a(diz, A_1, A_2);
		}
	}

	// Token: 0x060097A8 RID: 38824 RVA: 0x003B1B74 File Offset: 0x003AFD74
	public static void a(diz A_0, a1k A_1, int A_2)
	{
		if (A_0 != null && A_1 != null && A_1.j() != null)
		{
			using (List<eu3>.Enumerator enumerator = A_1.j().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					c6o.a a = new c6o.a();
					a.a = enumerator.Current;
					if (!string.IsNullOrEmpty(a.a.c()) && (a.a.a() != 0 || a.a.b() != 0f))
					{
						int num = a.a.a() + (int)(a.a.b() * (float)A_2);
						dpw dpw = Enumerable.FirstOrDefault<dpw>(Enumerable.Where<dpw>(Enumerable.OfType<dpw>(A_0.ar()), new Func<dpw, bool>(a.a)));
						if (dpw == null)
						{
							dpw = new dpw(a.a.c(), num);
							A_0.ar().Add(dpw);
						}
						else
						{
							dpw dpw2 = dpw;
							dpw2.a(dpw2.c() + num);
						}
					}
				}
			}
		}
	}

	// Token: 0x060097A9 RID: 38825 RVA: 0x003B1C9C File Offset: 0x003AFE9C
	public static void a(eya A_0, du2 A_1)
	{
		for (int i = 0; i < A_0.i().Count; i++)
		{
			if (A_0.i()[i].b() == A_1.b())
			{
				du2 value = A_0.i()[i];
				value.a(A_1);
				A_0.i()[i] = value;
				return;
			}
		}
		A_0.i().Add(A_1);
	}

	// Token: 0x060097AA RID: 38826 RVA: 0x003B1D14 File Offset: 0x003AFF14
	public static void a(eya A_0, DamageType A_1, double A_2, int A_3)
	{
		for (int i = 0; i < A_0.i().Count; i++)
		{
			du2 du = A_0.i()[i];
			if (du.b() == DamageType.Mechanical)
			{
				du2 value = new du2(du.b(), Convert.ToInt32((double)du.a() * A_2), Math.Round(du.c() * (double)A_3, 2));
				A_0.i()[i] = value;
			}
		}
	}

	// Token: 0x060097AB RID: 38827 RVA: 0x003B1D90 File Offset: 0x003AFF90
	public static void a(eya A_0, ett A_1, int A_2, bool A_3 = false, double A_4 = 1.0, bool A_5 = true)
	{
		if (A_0 != null && A_1 != null && A_1.d() != null)
		{
			foreach (bt5 bt in A_1.d())
			{
				int num = 0;
				if (A_5)
				{
					num = (A_3 ? 0 : ((int)((double)bt.BaseDamageThreshold * A_4)));
					num += (int)((double)((float)A_2 * bt.DamageThresholdIncrement) * A_4);
				}
				double num2 = A_3 ? 0.0 : (bt.BaseDamageResistance * A_4);
				num2 += (double)A_2 * bt.DamageResistanceIncrement * A_4;
				for (int i = 0; i < A_0.i().Count; i++)
				{
					if (A_0.i()[i].b() == bt.DamageType)
					{
						num += A_0.i()[i].a();
						num2 += A_0.i()[i].c();
						A_0.i().RemoveAt(i);
						break;
					}
				}
				num2 = Math.Round(num2, 2);
				if (num > 0 || num2 > 0.0)
				{
					du2 item = new du2(bt.DamageType, num, num2);
					A_0.i().Add(item);
				}
			}
		}
	}

	// Token: 0x060097AC RID: 38828 RVA: 0x003B1F2C File Offset: 0x003B012C
	public static int a(fv A_0, efk A_1)
	{
		double value = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseEnergy", new double?((double)10)).Value;
		double value2 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("EnergyPerQuality", new double?(0.1)).Value;
		double num = value + value2 * (double)A_0.QualityLevel;
		if (A_1 != null && A_1.Feats.Contains<e7f>())
		{
			num *= 1.0 + e7f.a + (double)A_1.GetSpecializationValue<dso>(true) * dso.a;
		}
		return (int)num;
	}

	// Token: 0x060097AD RID: 38829 RVA: 0x003B1FD0 File Offset: 0x003B01D0
	public static int a(string A_0)
	{
		int result;
		if (A_0 == "tnt")
		{
			result = 1;
		}
		else if (A_0 == "tnttnt")
		{
			result = 2;
		}
		else if (A_0 == "hexogen")
		{
			result = 3;
		}
		else if (A_0 == "tnthexogen" || A_0 == "hexogentnt")
		{
			result = 4;
		}
		else if (A_0 == "hexogenhexogen")
		{
			result = 5;
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x04003A43 RID: 14915
	public static readonly float a = 0.15f;

	// Token: 0x02001B5C RID: 7004
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060097B0 RID: 38832 RVA: 0x003B2078 File Offset: 0x003B0278
		internal bool a(dpw A_0)
		{
			return string.Equals(A_0.SkillName, this.a.c(), StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04003A44 RID: 14916
		public eu3 a;
	}
}
