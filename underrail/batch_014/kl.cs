using System;
using System.Linq;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C14 RID: 7188
public static class kl
{
	// Token: 0x06009DC4 RID: 40388 RVA: 0x003DFF38 File Offset: 0x003DE138
	public static void a()
	{
		kl.a = 0;
		kl.b = 0;
	}

	// Token: 0x06009DC5 RID: 40389 RVA: 0x003DFF4C File Offset: 0x003DE14C
	public static void a(ref bool A_0, efk A_1, efk A_2)
	{
		if (A_2 != null && A_2.Passive)
		{
			return;
		}
		if (A_1 != null && A_1.be != null && A_1.be.a && A_1.be.a())
		{
			if (kl.a > 0)
			{
				A_0 = false;
				kl.b++;
				kl.a--;
				return;
			}
			if (A_0)
			{
				float num = 0.1f * A_1.be.b;
				if (cuo.a.NextDouble() < (double)num)
				{
					A_0 = false;
					kl.a = 1 + cuo.a.Next(Convert.ToInt32(1f + 3f * A_1.be.b));
					kl.b = 0;
					return;
				}
			}
			else if (kl.b > 0)
			{
				float num2 = 0.33f;
				if (cuo.a.NextDouble() < (double)num2)
				{
					A_0 = true;
					kl.b--;
				}
			}
		}
	}

	// Token: 0x06009DC6 RID: 40390 RVA: 0x003E0058 File Offset: 0x003DE258
	public static void d(ref double A_0, efk A_1, efk A_2)
	{
		if (A_2 != null && A_2.be != null)
		{
			if (A_2.be.a() && A_2.be.j > 0f)
			{
				double num = 0.08 * (double)A_2.be.c * (double)A_2.be.d * (1.0 - A_2.Defense.aj()) * (double)A_2.be.j;
				A_0 += num;
			}
			if (A_2.be.a() && A_2.be.k > 0f)
			{
				double num2 = 0.05 * (double)A_2.be.c * (double)A_2.be.e * (double)A_2.be.k;
				A_0 = Math.Max(0.02, A_0 - num2);
			}
		}
	}

	// Token: 0x06009DC7 RID: 40391 RVA: 0x003E0154 File Offset: 0x003DE354
	public static void c(ref double A_0, efk A_1, efk A_2)
	{
		if (A_1 != null && A_1.be != null && A_1.be.a() && A_1.be.h > 0f)
		{
			double num = 0.05 * (double)A_1.be.c * (double)A_1.be.e * (double)A_1.be.h;
			A_0 += num;
		}
	}

	// Token: 0x06009DC8 RID: 40392 RVA: 0x003E01D0 File Offset: 0x003DE3D0
	public static void b(ref double A_0, efk A_1, efk A_2)
	{
		if (A_2 != null && A_2.be != null && A_2.be.a() && A_2.be.j > 0f)
		{
			double val = Math.Min(0.01, A_0);
			double num = 0.07 * (double)A_2.be.c * (double)A_2.be.e * A_2.Defense.aj() * (double)A_2.be.j;
			A_0 = Math.Max(val, A_0 - num);
		}
		if (A_1 != null && A_1.GetMicrofeat<c0h>() != null)
		{
			A_0 = 0.0;
		}
	}

	// Token: 0x06009DC9 RID: 40393 RVA: 0x003E028C File Offset: 0x003DE48C
	public static void a(ref double A_0, efk A_1, efk A_2)
	{
		if (A_2 != null && A_2.be != null && A_2.be.a && A_2.be.a())
		{
			double num = 0.12 * (double)A_2.be.b;
			A_0 += num;
		}
		if (A_1 != null && A_1.be != null && A_1.be.a() && A_1.be.g > 0f)
		{
			double num2 = 0.03 * (double)A_1.be.c * (double)A_1.be.e * (double)A_1.be.g;
			A_0 += num2;
		}
	}

	// Token: 0x06009DCA RID: 40394 RVA: 0x003E0354 File Offset: 0x003DE554
	public static void c(ref double A_0, efk A_1)
	{
		if (A_1 != null && A_1.be != null)
		{
			if (A_1.be.a() && A_1.be.g > 0f)
			{
				double num = 0.08 * (double)A_1.be.c * (double)A_1.be.d * (double)A_1.be.g;
				A_0 = Math.Max(0.03, A_0 - num);
			}
			if (A_1.be.a() && A_1.be.i > 0f)
			{
				float num2 = 0f;
				c9i c9i = Enumerable.FirstOrDefault<c9i>(A_1.StatusEffects.Get<c9i>());
				if (c9i != null)
				{
					if (c9i.Duration > 0)
					{
						num2 = Convert.ToSingle(c9i.TimeLeft / (double)c9i.Duration);
					}
					else
					{
						num2 = 1f;
					}
				}
				double num3;
				if (num2 > 0.25f)
				{
					num3 = (double)((num2 - 0.25f) / 0.75f) * 0.2 * (double)A_1.be.c * (double)A_1.be.e * (double)A_1.be.i;
				}
				else
				{
					num3 = -((double)(1f - num2 / 0.25f) * 0.25 * (double)A_1.be.c * (double)A_1.be.d * (double)A_1.be.i);
				}
				A_0 = d05.b(aiy.ae, A_0 + num3, aiy.ad);
			}
		}
	}

	// Token: 0x06009DCB RID: 40395 RVA: 0x003E04F0 File Offset: 0x003DE6F0
	public static void b(ref double A_0, efk A_1)
	{
		if (A_1 != null && A_1.be != null && A_1.be.a() && A_1.be.h > 0f)
		{
			double num = 0.08 * (double)A_1.be.c * (double)A_1.be.d * (double)A_1.be.h;
			A_0 = Math.Max(0.03, A_0 - num);
		}
	}

	// Token: 0x06009DCC RID: 40396 RVA: 0x003E0578 File Offset: 0x003DE778
	public static void a(ref double A_0, edm A_1, efk A_2, efk A_3)
	{
		if (A_1 != null && A_3 != null && A_3.be != null && A_3.be.a() && A_3.be.k > 0f && A_1.Name == "bleedingWound")
		{
			double val = Math.Max(A_0, 0.9);
			double num = 0.25 * (double)A_3.be.d * (double)A_3.be.c * (double)A_3.be.k;
			A_0 *= 1.0 + num;
			A_0 = Math.Min(A_0, val);
		}
	}

	// Token: 0x06009DCD RID: 40397 RVA: 0x003E0634 File Offset: 0x003DE834
	public static void a(efk A_0, ref double A_1)
	{
		if (A_0 != null && A_0.be != null && A_0.be.l > 0f)
		{
			if (A_1 > 1.0)
			{
				A_1 = Math.Pow(A_1, 1.0 + 0.7 * (double)A_0.be.c * (double)A_0.be.e * (double)A_0.be.l);
				return;
			}
			A_1 *= Math.Pow(0.9, 0.25 + (double)(A_0.be.d * A_0.be.c) * 0.75 * (double)A_0.be.l);
		}
	}

	// Token: 0x06009DCE RID: 40398 RVA: 0x003E0708 File Offset: 0x003DE908
	public static void a(ref double A_0, csk A_1, efk A_2)
	{
		if (A_2 != null && A_2.be != null && A_2.be.a() && A_2.be.m > 0f && A_1.DamageType == DamageType.Electricity)
		{
			double num = 1.0 + 0.15 * (double)A_2.be.c * (double)((A_2.be.d - 1f) / 2f + 1f) * (double)A_2.be.m;
			A_0 *= num;
		}
	}

	// Token: 0x06009DCF RID: 40399 RVA: 0x003E07AC File Offset: 0x003DE9AC
	public static void a(ref csk A_0, cd1 A_1, efk A_2, efk A_3)
	{
		if (A_2 != null && A_2.be != null && A_2.be.a() && A_2.be.m > 0f && A_0.DamageType == DamageType.Electricity)
		{
			double num = 0.15 * (double)A_2.be.c * (double)A_2.be.e * (double)A_2.be.m;
			double num2 = 1.0 + num;
			A_0.Amount = Convert.ToInt32((double)A_0.Amount * num2);
		}
	}

	// Token: 0x06009DD0 RID: 40400 RVA: 0x003E084C File Offset: 0x003DEA4C
	public static void a(ref double A_0, efk A_1)
	{
		if (A_1 != null && A_1.be != null && A_1.be.m > 0f)
		{
			double num = 1.25 * (double)A_1.be.c * (double)A_1.be.e * (double)A_1.be.m;
			A_0 += num;
		}
	}

	// Token: 0x06009DD1 RID: 40401 RVA: 0x003E08B8 File Offset: 0x003DEAB8
	public static void a(string A_0, params object[] A_1)
	{
	}

	// Token: 0x04003D2F RID: 15663
	private static int a;

	// Token: 0x04003D30 RID: 15664
	private static int b;
}
