using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B77 RID: 7031
[dgg("lightMachineGun")]
public sealed class y : c4r, bd3
{
	// Token: 0x06009868 RID: 39016 RVA: 0x003B693C File Offset: 0x003B4B3C
	public override string bt()
	{
		return "茡Пулемёт";
	}

	// Token: 0x06009869 RID: 39017 RVA: 0x003B6944 File Offset: 0x003B4B44
	public override string bu()
	{
		return "lightMachineGun";
	}

	// Token: 0x0600986A RID: 39018 RVA: 0x003B694C File Offset: 0x003B4B4C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600986B RID: 39019 RVA: 0x003B6950 File Offset: 0x003B4B50
	public override bool bw()
	{
		return true;
	}

	// Token: 0x0600986C RID: 39020 RVA: 0x003B6954 File Offset: 0x003B4B54
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x0600986D RID: 39021 RVA: 0x003B6958 File Offset: 0x003B4B58
	public y()
	{
		base.Slots.Add(y.a, new cgo(new c6s(ms.bu, 130), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(y.b, new cgo(new c6s(ms.s, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(y.c, new cgo(new c6s(ms.bv, 131), "Магазин", false, 1, 0.1f, false, false, null));
		base.Slots.Add(y.d, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"barrelCompensator",
			"muzzleBrake",
			"ergonomicHandle"
		}, 15), "Улучшение", true, 1, 0f, false, false, null));
		base.Slots.Add(y.e, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"barrelCompensator",
			"muzzleBrake",
			"ergonomicHandle"
		}, 15), "Улучшение", true, 1, 0f, false, false, null));
	}

	// Token: 0x0600986E RID: 39022 RVA: 0x003B6A9C File Offset: 0x003B4C9C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(y.a, null);
		fv fv2 = A_1.SafeGet(y.b, null);
		fv fv3 = A_1.SafeGet(y.c, null);
		fv fv4 = A_1.SafeGet(y.d, null);
		fv fv5 = A_1.SafeGet(y.e, null);
		if (fv == null || fv2 == null || fv3 == null)
		{
			return null;
		}
		List<BarrelType> classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<List<BarrelType>>("SupportedBarrelTypes");
		if (classPropertyValue == null || classPropertyValue.Count == 0)
		{
			return null;
		}
		BarrelType? primitivePropertyValue = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<BarrelType>("BarrelType", null);
		if (primitivePropertyValue == null || !classPropertyValue.Contains(primitivePropertyValue.Value))
		{
			A_2 = "Несовместимый тип ствола.";
			return null;
		}
		bool value = fv.Definition.a7().GetPrimitivePropertyValue<bool>("UsesBeltTypeMagazine", new bool?(false)).Value;
		int value2 = fv.Definition.a7().GetPrimitivePropertyValue<int>("AttackSpreadAngleMod", new int?(0)).Value;
		int value3 = fv.Definition.a7().GetPrimitivePropertyValue<int>("ExtraBurstRounds", new int?(0)).Value;
		int value4 = fv.Definition.a7().GetPrimitivePropertyValue<int>("ApCostMod", new int?(0)).Value;
		double value5 = fv.Definition.a7().GetPrimitivePropertyValue<double>("CritChanceMod", new double?(0.0)).Value;
		bool value6 = fv3.Definition.a7().GetPrimitivePropertyValue<bool>("IsBeltType", new bool?(false)).Value;
		int value7 = fv3.Definition.a7().GetPrimitivePropertyValue<int>("StrengthRequirement", new int?(0)).Value;
		int value8 = fv3.Definition.a7().GetPrimitivePropertyValue<int>("Capacity", new int?(50)).Value;
		int value9 = fv3.Definition.a7().GetPrimitivePropertyValue<int>("MagIndex", new int?(0)).Value;
		if (fv4 != null && fv5 != null && fv4.TypedDefinition.i() == fv5.TypedDefinition.i())
		{
			A_2 = "Нельзя установить два улучшения одного типа.";
			return null;
		}
		if (value != value6)
		{
			A_2 = "Несовместимый тип магазина.";
			return null;
		}
		double a_ = cwp.a(fv);
		bke bke = new bke();
		bke.a(c4r.a(primitivePropertyValue.Value));
		bke.d(1.0);
		bke.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue + fv3.SingleItemValue)));
		bke.h(fv.SingleItemWeight + fv2.SingleItemWeight + fv3.SingleItemWeight);
		bke.g((int)Math.Ceiling(a_));
		bke.a(fv.TypedDefinition.bc());
		bke.a2().Add(new aia("uwep"));
		bke.b(0.15000000596046448);
		bke.e(-0.05);
		bke.a(ItemStealingCategory.WeaponHeavy);
		bke.a(a0.e);
		bke bke2 = bke;
		bke2.d(bke2.d() + 2);
		bke.a(new int?(45 + value2));
		double a_2 = 1.0;
		WeaponSubtype weaponSubtype = this.a(primitivePropertyValue.Value);
		c4r.a(bke, btz.j, weaponSubtype, fv.TypedDefinition);
		if (weaponSubtype == WeaponSubtype.LMG_9)
		{
			bke.a(bhx.ae);
		}
		else
		{
			bke.a(bhx.af);
		}
		b1j? primitivePropertyValue2 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
		b1j b1j = c4r.a(A_0, weaponSubtype, a_, a_2, null, primitivePropertyValue2);
		bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
		bke.c(value8);
		bke bke3 = bke;
		bke3.b(bke3.i() + value7);
		bke.c("machineGun");
		bke bke4 = bke;
		bke4.a(bke4.v() + value4);
		bke bke5 = bke;
		bke5.d(bke5.d() + value3);
		c4r.a(ref bke.k, value5);
		if (value6)
		{
			bke.a(3.0);
			bke bke6 = bke;
			bke6.a(bke6.v() - 5);
			bke bke7 = bke;
			bke7.d(bke7.d() + 1);
			bke bke8 = bke;
			bke8.e(bke8.s() - 0.02);
		}
		else
		{
			bke.a(2.0);
		}
		string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
		bke.g(c4r.a(bke.ak()));
		bke bke9 = bke;
		bke9.g(bke9.az() + string.Format("{0}-калибр ", bke.f()));
		bke bke10 = bke;
		bke10.g(bke10.az() + ((!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "Пулемёт"));
		bke.f(string.Format("lmg.{0}.{1}.{2}", classPropertyValue2.ToLowerInvariant(), value9, (primitivePropertyValue.GetValueOrDefault() == BarrelType.Caliber_44) ? "44" : "9"));
		string str = "";
		string str2 = "";
		bke.i(qv.a("Items\\Weapons/LMG", new object[]
		{
			c4r.a(bke.ak()),
			(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "unknown"
		}));
		if (value6)
		{
			bke bke11 = bke;
			bke11.i(bke11.a0() + string.Format(" Он оснащён ленточным магазином, вмещающим {0} патронов.", bke.f()));
		}
		else
		{
			bke bke12 = bke;
			bke12.i(bke12.a0() + string.Format(" Он оснащён коробчатым магазином, вмещающим {0} патронов.", bke.f()));
		}
		List<fv> list = new List<fv>();
		if (fv4 != null)
		{
			list.Add(fv4);
		}
		if (fv5 != null)
		{
			list.Add(fv5);
		}
		list.Sort(new Comparison<fv>(y.a.a.a));
		List<string> a_3 = new List<string>();
		string[] array = new string[]
		{
			"rifleBipod",
			"ergonomicHandle"
		};
		HashSet<string> hashSet = new HashSet<string>();
		foreach (fv fv6 in list)
		{
			if (fv6 != null)
			{
				hashSet.Add(fv6.Definition.a5());
				bke bke13 = bke;
				bke13.b(bke13.bf() + (double)fv6.SingleItemValue);
				bke bke14 = bke;
				bke14.h(bke14.a4() + fv6.SingleItemWeight);
				if (!c4r.a(bke, fv6, a_3))
				{
					string text = fv6.TypedDefinition.a5();
					if (fv6.TypedDefinition.i() == ms.x)
					{
						double num = 0.05;
						c4r.a(ref bke.v, num);
						c4r.a(ref bke.u, Convert.ToSingle(num));
						c4r.a(ref bke.s, (double)Convert.ToSingle(num));
						bke bke15 = bke;
						bke15.a(bke15.v() + 5);
						bke bke16 = bke;
						bke16.g(bke16.az() + " с сошками");
						bke bke17 = bke;
						bke17.i(bke17.a0() + " Сошки повышают точность стрельбы, но замедляют прицеливание.");
						bke bke18 = bke;
						bke18.a(bke18.x() - 3);
					}
					else if (text == "ergonomicHandle")
					{
						bke bke19 = bke;
						bke19.i(bke19.a0() + " Специальная эргономичная рукоятка улучшает контроль над оружием, особенно при стрельбе на ходу.");
						str += "Эргономичный ";
						bke bke20 = bke;
						bke20.g(bke20.ab() + 0.03);
						c4r.a(ref bke.v, -0.05);
						bke bke21 = bke;
						bke21.a(bke21.x() - 3);
					}
				}
			}
		}
		foreach (string text2 in array)
		{
			if (hashSet.Contains(text2))
			{
				bke bke22 = bke;
				bke22.f(bke22.a3() + "." + text2);
			}
		}
		bke.g(str + bke.az() + str2);
		bke bke23 = bke;
		bke23.b(bke23.bf() * (double)3);
		if (fv4 != null && fv5 != null)
		{
			bke bke24 = bke;
			bke24.b(bke24.bf() * 1.2);
		}
		cwp.a(bke, new coh[]
		{
			fv,
			fv3,
			fv2,
			fv4,
			fv5
		});
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600986F RID: 39023 RVA: 0x003B74AC File Offset: 0x003B56AC
	private WeaponSubtype a(BarrelType A_0)
	{
		if (A_0 == BarrelType.Caliber_9 || A_0 != BarrelType.Caliber_44)
		{
			return WeaponSubtype.LMG_9;
		}
		return WeaponSubtype.LMG_44;
	}

	// Token: 0x06009870 RID: 39024 RVA: 0x003B74C4 File Offset: 0x003B56C4
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 4;
		string a_ = "xphw_Weapons";
		List<bj8> list = new List<bj8>();
		string[] array = new string[]
		{
			"tango",
			"grudge",
			"ratchet",
			"guardian"
		};
		string[] array2 = new string[]
		{
			"9",
			"44"
		};
		string[] array3 = new string[]
		{
			"rifleBipod"
		};
		string[] array4 = new string[]
		{
			"ergonomicHandle"
		};
		for (int i = 0; i < array.Length; i++)
		{
			string arg = array[i];
			bj8 bj = new bj8();
			bj.a(string.Format("lmg.{0}.frame", arg));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					for (int l = -1; l < 1; l++)
					{
						for (int m = -1; m < 1; m++)
						{
							bj = new bj8();
							bj.a(string.Format("lmg.{0}.{1}.{2}", arg, j, array2[k]));
							if (l > -1)
							{
								bj8 bj2 = bj;
								bj2.a(bj2.c() + "." + array3[l]);
								bj.a().Add(new d8h(a_, new Point(num + 7 + l, num2 + i), 1f));
							}
							bj.a().Add(new d8h(a_, new Point(num + 1 + j, num2 + i), 1f));
							bj.a().Add(new d8h(a_, new Point(num + 5 + k, num2 + i), 1f));
							if (m > -1)
							{
								bj8 bj3 = bj;
								bj3.a(bj3.c() + "." + array4[m]);
								bj.a().Add(new d8h(a_, new Point(num + 8 + m, num2 + i), 1f));
							}
							list.Add(bj);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x04003A6F RID: 14959
	public new static readonly string a = "frame";

	// Token: 0x04003A70 RID: 14960
	public new static readonly string b = "barrel";

	// Token: 0x04003A71 RID: 14961
	public static readonly string c = "magazine";

	// Token: 0x04003A72 RID: 14962
	public new static readonly string d = "enhancement1";

	// Token: 0x04003A73 RID: 14963
	public static readonly string e = "enhancement2";

	// Token: 0x02001B78 RID: 7032
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009874 RID: 39028 RVA: 0x003B7768 File Offset: 0x003B5968
		internal int a(fv A_0, fv A_1)
		{
			return string.Compare(A_0.Definition.az(), A_1.Definition.az());
		}

		// Token: 0x04003A74 RID: 14964
		public static readonly y.a a = new y.a();

		// Token: 0x04003A75 RID: 14965
		public static Comparison<fv> b;
	}
}
