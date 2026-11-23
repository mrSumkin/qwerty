using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B6D RID: 7021
public abstract class c4r : cwp
{
	// Token: 0x06009817 RID: 38935 RVA: 0x003B3BD8 File Offset: 0x003B1DD8
	public static b1j a(efk A_0, WeaponSubtype A_1, double A_2, double A_3 = 1.0, b1j? A_4 = null, b1j? A_5 = null)
	{
		double num = (as3.ac[A_1] + A_2 * as3.ad[A_1]) * A_3;
		b1j b1j = (A_4 != null) ? A_4.Value : as3.ae[A_1];
		if (A_5 != null)
		{
			b1j.b *= A_5.Value.b;
			b1j.c *= A_5.Value.c;
		}
		double num2 = 1.0;
		if (A_0 != null && A_0.Feats.Contains<cmr>() && euf.g(A_1))
		{
			num2 += cmr.a + (double)A_0.GetSpecializationValue<boi>(true) * boi.a;
		}
		return new b1j(num * b1j.b, num * b1j.c * num2);
	}

	// Token: 0x06009818 RID: 38936 RVA: 0x003B3CB8 File Offset: 0x003B1EB8
	protected static void a(bke A_0, a1k A_1)
	{
		double value = A_1.a7().GetPrimitivePropertyValue<double>("PrecisionModifier", new double?(0.0)).Value;
		double value2 = A_1.a7().GetPrimitivePropertyValue<double>("FocusPenaltyModifier", new double?(0.0)).Value;
		double value3 = A_1.a7().GetPrimitivePropertyValue<double>("MeleePenaltyModifier", new double?(0.0)).Value;
		double value4 = A_1.a7().GetPrimitivePropertyValue<double>("CriticalChanceModifier", new double?(0.0)).Value;
		double value5 = A_1.a7().GetPrimitivePropertyValue<double>("BurstPrecisionModifier", new double?(0.0)).Value;
		int value6 = A_1.a7().GetPrimitivePropertyValue<int>("RangeModifier", new int?(0)).Value;
		int value7 = A_1.a7().GetPrimitivePropertyValue<int>("OptimalRangeModifier", new int?(0)).Value;
		double? primitivePropertyValue = A_1.a7().GetPrimitivePropertyValue<double>("CriticalDamageBonus", null);
		double value8 = A_1.a7().GetPrimitivePropertyValue<double>("CriticalDamageBonusModifier", new double?(0.0)).Value;
		int value9 = A_1.a7().GetPrimitivePropertyValue<int>("ApCostModifier", new int?(0)).Value;
		int value10 = A_1.a7().GetPrimitivePropertyValue<int>("MagazineModifier", new int?(0)).Value;
		int value11 = A_1.a7().GetPrimitivePropertyValue<int>("AttackSpreadAngleModifier", new int?(0)).Value;
		int value12 = A_1.a7().GetPrimitivePropertyValue<int>("ExtraBurstShots", new int?(0)).Value;
		A_0.g(Math.Round(A_0.ab() + value, 2));
		c4r.a(ref A_0.v, value2);
		A_0.f(Math.Round(A_0.ai() + value4, 2));
		A_0.c(Math.Round(A_0.y() + value8, 2));
		A_0.e(Math.Round(A_0.s() + value5, 2));
		A_0.c(A_0.ad() + (float)value6);
		A_0.d(A_0.h() + (float)value7);
		A_0.a(A_0.v() + value9);
		c4r.a(ref A_0.u, Convert.ToSingle(value3));
		A_0.c(A_0.f() + value10);
		A_0.a(A_0.x() + value11);
		A_0.d(A_0.d() + value12);
		if (primitivePropertyValue != null)
		{
			A_0.c(primitivePropertyValue.Value);
		}
		if (A_0.h() > A_0.ad())
		{
			A_0.d(A_0.ad());
		}
	}

	// Token: 0x06009819 RID: 38937 RVA: 0x003B3FC4 File Offset: 0x003B21C4
	protected static void a(ref double A_0, double A_1)
	{
		A_0 = Math.Round(Math.Max(0.0, A_0 + A_1), 2);
	}

	// Token: 0x0600981A RID: 38938 RVA: 0x003B3FE0 File Offset: 0x003B21E0
	protected static void a(ref float A_0, float A_1)
	{
		A_0 = Convert.ToSingle(Math.Round((double)Math.Max(0f, A_0 + A_1), 2));
	}

	// Token: 0x0600981B RID: 38939 RVA: 0x003B4000 File Offset: 0x003B2200
	protected static void a(bke A_0, btz A_1, WeaponSubtype A_2, a1k A_3)
	{
		A_0.a(as3.af[A_2]);
		A_0.f(as3.w[A_2]);
		A_0.c(as3.x[A_2]);
		A_0.c(as3.y[A_1][0]);
		A_0.d(as3.y[A_1][1]);
		A_0.b((float)A_0.v() * d0u.c);
		A_0.a(A_1);
		A_0.c(as3.ag[A_2]);
		A_0.a(new WeaponSubtype?(A_2));
		if (A_3 != null)
		{
			int? primitivePropertyValue = A_3.a7().GetPrimitivePropertyValue<int>("StrengthRequirement", null);
			if (primitivePropertyValue != null)
			{
				A_0.b(Math.Max(A_0.i(), primitivePropertyValue.Value));
			}
			c4r.a(A_0, A_3);
		}
		switch (A_1)
		{
		case btz.a:
			if (A_2 == WeaponSubtype.Pistol_Electro)
			{
				A_0.a(esu.m);
				A_0.a(ImpactSpeed.VeryHigh);
			}
			else if (A_2 == WeaponSubtype.Pistol_Laser)
			{
				A_0.a(esu.g);
				A_0.a(ImpactSpeed.VeryHigh);
			}
			else if (A_2 == WeaponSubtype.Pistol_Plasma)
			{
				A_0.a(esu.l);
				A_0.a(ImpactSpeed.VeryHigh);
			}
			else
			{
				A_0.a(esu.e);
				A_0.a(ImpactSpeed.Medium);
			}
			A_0.b("p");
			return;
		case btz.b:
			A_0.a(esu.e);
			A_0.a(ImpactSpeed.Medium);
			A_0.b("sm");
			return;
		case btz.c:
			A_0.a(esu.e);
			A_0.a(ImpactSpeed.High);
			A_0.b("ra");
			return;
		case btz.d:
			A_0.a(esu.e);
			A_0.a(ImpactSpeed.High);
			A_0.b("rs");
			return;
		case btz.e:
			A_0.a(esu.r);
			A_0.a(ImpactSpeed.Medium);
			return;
		case btz.f:
			A_0.a(esu.c);
			A_0.a(ImpactSpeed.Low);
			A_0.b("x");
			return;
		case btz.g:
			A_0.a(ImpactSpeed.VeryLow);
			return;
		case btz.h:
			A_0.a(esu.a);
			A_0.a(ImpactSpeed.VeryHigh);
			A_0.b("xphwg");
			return;
		case btz.i:
			A_0.a(esu.a);
			A_0.a(ImpactSpeed.VeryHigh);
			A_0.b("xphwf");
			return;
		case btz.j:
			A_0.a(esu.e);
			A_0.a(ImpactSpeed.High);
			A_0.b("xphwmg");
			return;
		case btz.k:
			A_0.a(esu.e);
			A_0.a(ImpactSpeed.High);
			A_0.b("xphwgg");
			return;
		case btz.l:
			A_0.a(esu.a);
			A_0.a(ImpactSpeed.VeryHigh);
			A_0.b("xphwr");
			return;
		default:
			return;
		}
	}

	// Token: 0x0600981C RID: 38940 RVA: 0x003B428C File Offset: 0x003B248C
	protected static AmmoType a(BarrelType A_0)
	{
		switch (A_0)
		{
		default:
			return AmmoType.Caliber_5;
		case BarrelType.Caliber_762:
			return AmmoType.Caliber_762;
		case BarrelType.Caliber_9:
			return AmmoType.Caliber_9;
		case BarrelType.Caliber_44:
			return AmmoType.Caliber_44;
		case BarrelType.Caliber_86:
			return AmmoType.Caliber_86;
		case BarrelType.Caliber_127:
			return AmmoType.Caliber_127;
		}
	}

	// Token: 0x0600981D RID: 38941 RVA: 0x003B42D0 File Offset: 0x003B24D0
	protected static bhx a(BarrelType? A_0)
	{
		if (A_0 != null)
		{
			switch (A_0.GetValueOrDefault())
			{
			case BarrelType.Caliber_762:
				return bhx.s;
			case BarrelType.Caliber_9:
				return bhx.t;
			case BarrelType.Caliber_44:
				return bhx.u;
			case BarrelType.Caliber_86:
				return bhx.v;
			case BarrelType.Caliber_127:
				return bhx.w;
			}
		}
		return bhx.r;
	}

	// Token: 0x0600981E RID: 38942 RVA: 0x003B4320 File Offset: 0x003B2520
	protected static string a(AmmoType A_0)
	{
		if (A_0 <= AmmoType.Caliber_44)
		{
			if (A_0 <= AmmoType.Caliber_762)
			{
				if (A_0 == AmmoType.Caliber_5)
				{
					return "5мм ";
				}
				if (A_0 == AmmoType.Caliber_762)
				{
					return "7,62мм ";
				}
			}
			else
			{
				if (A_0 == AmmoType.Caliber_9)
				{
					return "9мм ";
				}
				if (A_0 == AmmoType.Caliber_44)
				{
					return ".44 ";
				}
			}
		}
		else if (A_0 <= AmmoType.Caliber_127)
		{
			if (A_0 == AmmoType.Caliber_86)
			{
				return "8,6мм ";
			}
			if (A_0 == AmmoType.Caliber_127)
			{
				return "12,7мм ";
			}
		}
		else
		{
			if (A_0 == AmmoType.Grenade_25)
			{
				return "25мм ";
			}
			if (A_0 == AmmoType.Grenade_40)
			{
				return "40мм ";
			}
			if (A_0 == AmmoType.Rocket_84)
			{
				return "84мм ПЗРК ";
			}
		}
		return "";
	}

	// Token: 0x0600981F RID: 38943 RVA: 0x003B4400 File Offset: 0x003B2600
	protected static bool a(bke A_0, fv A_1, List<string> A_2)
	{
		if (A_0 != null && A_1 != null && A_1.TypedDefinition != null)
		{
			if (A_1.TypedDefinition.a5() == "smartModule")
			{
				A_0.ar().Add(new efx(0.15 + 0.003 * (double)A_1.QualityLevel, cs5.a));
				A_0.g("Умный " + A_0.az());
				A_0.i(A_0.a0() + " Имеет модуль с программой, облегчающей прицеливание, что повышает эффективность точных выстрелов.");
				A_2.Add("s");
				return true;
			}
			if (A_1.TypedDefinition.a5() == "rapidReloader")
			{
				int num = (int)Math.Max(1.0, (double)A_0.v() * 0.2);
				A_0.a(A_0.v() - num);
				A_0.g("Быстр. " + A_0.az());
				A_0.i(A_0.a0() + " Вместо обычного механизма подачи патрона используется быстрая система подачи патрона.");
				A_2.Add("r");
				int a_ = Math.Min(20, A_0.v());
				A_0.aa().Add(new edm("rapidReload", 0.25, a_, true));
				return true;
			}
			if (A_1.TypedDefinition.a5() == "barrelCompensator")
			{
				double? primitivePropertyValue = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BurstPrecisionBonus", null);
				if (primitivePropertyValue != null)
				{
					A_0.e(A_0.s() + primitivePropertyValue.Value);
				}
				A_0.g("Сбалансированн. " + A_0.az());
				A_0.i(A_0.a0() + " На срезе ствола установлен компенсатор отдачи, смягчающий подброс оружия при стрельбе очередью.");
				A_2.Add("a");
				return true;
			}
			if (A_1.TypedDefinition.a5() == "muzzleBrake")
			{
				A_0.g("Оснащенн. дульным тормозом " + A_0.az());
				A_0.i(A_0.a0() + " На срезе ствола установлен дульный тормоз, смягчающий отдачу, что позволяет стрелять более длинными очередями.");
				A_0.d(A_0.d() + 2);
				A_2.Add("b");
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009820 RID: 38944 RVA: 0x003B4648 File Offset: 0x003B2848
	protected static string a(string A_0, string A_1, ref bool A_2)
	{
		string text = A_0;
		if (!A_2)
		{
			text += ".";
		}
		text += A_1;
		A_2 = true;
		return text;
	}
}
