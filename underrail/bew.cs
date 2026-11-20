using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B75 RID: 7029
[dgg("minigun")]
public sealed class bew : c4r, bd3
{
	// Token: 0x0600985B RID: 39003 RVA: 0x003B5AF8 File Offset: 0x003B3CF8
	public override string bt()
	{
		return "茢Миниган";
	}

	// Token: 0x0600985C RID: 39004 RVA: 0x003B5B00 File Offset: 0x003B3D00
	public override string bu()
	{
		return "minigun";
	}

	// Token: 0x0600985D RID: 39005 RVA: 0x003B5B08 File Offset: 0x003B3D08
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600985E RID: 39006 RVA: 0x003B5B0C File Offset: 0x003B3D0C
	public override bool bw()
	{
		return true;
	}

	// Token: 0x0600985F RID: 39007 RVA: 0x003B5B10 File Offset: 0x003B3D10
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009860 RID: 39008 RVA: 0x003B5B18 File Offset: 0x003B3D18
	public bew()
	{
		base.Slots.Add(bew.a, new cgo(new c6s(ms.bw, 129), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bew.b, new cgo(new c6s(ms.bx, 127), "Мотор", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bew.c, new cgo(new c6s(ms.s, 17), "Ствол", false, 6, 0.1f, false, false, null));
		base.Slots.Add(bew.d, new cgo(new eh0(new string[]
		{
			"lmgBeltMag50",
			"lmgBeltMag65",
			"lmgBeltMag80",
			"lmgBeltMag100"
		}, 128), "Ленточный магазин 1", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bew.e, new cgo(new eh0(new string[]
		{
			"lmgBeltMag50",
			"lmgBeltMag65",
			"lmgBeltMag80",
			"lmgBeltMag100"
		}, 128), "Ленточный магазин 2", true, 1, 0.3f, false, false, null));
		base.Slots.Add(bew.f, new cgo(new eh0(new string[]
		{
			"rifleBipod",
			"ergonomicHandle"
		}, 15), "Улучшение", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009861 RID: 39009 RVA: 0x003B5CA0 File Offset: 0x003B3EA0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bew.a, null);
		fv fv2 = A_1.SafeGet(bew.b, null);
		fv fv3 = A_1.SafeGet(bew.c, null);
		fv fv4 = A_1.SafeGet(bew.d, null);
		fv fv5 = A_1.SafeGet(bew.e, null);
		fv fv6 = A_1.SafeGet(bew.f, null);
		if (fv == null || fv3 == null || fv4 == null || fv2 == null)
		{
			return null;
		}
		List<BarrelType> classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<List<BarrelType>>("SupportedBarrelTypes");
		if (classPropertyValue == null || classPropertyValue.Count == 0)
		{
			return null;
		}
		BarrelType? primitivePropertyValue = fv3.TypedDefinition.a7().GetPrimitivePropertyValue<BarrelType>("BarrelType", null);
		if (primitivePropertyValue == null || !classPropertyValue.Contains(primitivePropertyValue.Value))
		{
			A_2 = "Несовместимый тип ствола.";
			return null;
		}
		string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
		int value = fv.Definition.a7().GetPrimitivePropertyValue<int>("AttackSpreadAngleMod", new int?(0)).Value;
		int value2 = fv.Definition.a7().GetPrimitivePropertyValue<int>("ExtraBurstRounds", new int?(0)).Value;
		int value3 = fv.Definition.a7().GetPrimitivePropertyValue<int>("ApCostMod", new int?(0)).Value;
		double value4 = fv.Definition.a7().GetPrimitivePropertyValue<double>("CritChanceMod", new double?(0.0)).Value;
		string classPropertyValue3 = fv2.Definition.a7().GetClassPropertyValue<string>("Name");
		string classPropertyValue4 = fv2.Definition.a7().GetClassPropertyValue<string>("Code");
		int value5 = fv2.Definition.a7().GetPrimitivePropertyValue<int>("InitialBurstRoundsMod", new int?(0)).Value;
		double value6 = fv2.Definition.a7().GetPrimitivePropertyValue<double>("BonusBurstPerStack", new double?(0.0)).Value;
		int value7 = fv2.Definition.a7().GetPrimitivePropertyValue<int>("MaxBurstStacks", new int?(0)).Value;
		string classPropertyValue5 = fv2.Definition.a7().GetClassPropertyValue<string>("Adjective");
		int value8 = fv4.Definition.a7().GetPrimitivePropertyValue<int>("StrengthRequirement", new int?(0)).Value;
		int value9 = fv4.Definition.a7().GetPrimitivePropertyValue<int>("Capacity", new int?(50)).Value;
		int num = 0;
		int num2 = 0;
		if (fv5 != null)
		{
			num = fv5.Definition.a7().GetPrimitivePropertyValue<int>("StrengthRequirement", new int?(0)).Value;
			num2 = fv5.Definition.a7().GetPrimitivePropertyValue<int>("Capacity", new int?(50)).Value;
		}
		int num3 = value9 + num2;
		double a_ = cwp.a(fv);
		bke bke = new bke();
		bke.a(c4r.a(primitivePropertyValue.Value));
		bke.d(1.0);
		bke.b(new double?((double)(fv.SingleItemValue + fv3.SingleItemValue * 6 + fv2.SingleItemValue + fv4.SingleItemValue)));
		bke.h(fv.SingleItemWeight + fv3.SingleItemWeight * 6.0 + fv2.SingleItemWeight + fv4.SingleItemWeight);
		bke.g((int)Math.Ceiling(a_));
		bke.a(fv.TypedDefinition.bc());
		bke.a2().Add(new aia("uwep"));
		bke.b(0.15000000596046448);
		bke.e(-0.05);
		bke.a(ItemStealingCategory.WeaponHeavy);
		bke.a(a0.e);
		bke.a(new int?(45 + value));
		bke.a(3.0);
		if (fv5 != null)
		{
			bke bke2 = bke;
			bke2.b(bke2.bf() + (double)fv5.SingleItemValue);
			bke bke3 = bke;
			bke3.h(bke3.a4() + fv5.SingleItemWeight);
		}
		double a_2 = 1.0;
		WeaponSubtype weaponSubtype = this.a(primitivePropertyValue.Value);
		c4r.a(bke, btz.k, weaponSubtype, fv.TypedDefinition);
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
		int num4 = value8 + num;
		if (num4 == 0 && fv5 != null)
		{
			num4 = 1;
		}
		bke.c(num3);
		bke bke4 = bke;
		bke4.b(bke4.i() + num4);
		bke.c("minigun");
		bke bke5 = bke;
		bke5.a(bke5.v() + value3);
		bke bke6 = bke;
		bke6.d(bke6.d() + (value2 + value5));
		c4r.a(ref bke.k, value4);
		bke.n().Add(new y0
		{
			a = value6,
			b = value7
		});
		bke.g(string.Format("{0}{1} {2}-патронов {3}", new object[]
		{
			c4r.a(bke.ak()),
			classPropertyValue5,
			num3,
			(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "Миниган"
		}));
		int num5 = (num3 - 50) / 50;
		bke.f(string.Format("minigun.{0}.{1}.{2}", classPropertyValue2.ToLowerInvariant(), num5, classPropertyValue4));
		string str = "";
		string str2 = "";
		bke.i(qv.a("Items\\Weapons/Minigun", new object[]
		{
			c4r.a(bke.ak()),
			(!string.IsNullOrEmpty(classPropertyValue2)) ? classPropertyValue2 : "unknown",
			(!string.IsNullOrEmpty(classPropertyValue3)) ? classPropertyValue3 : "unknown"
		}));
		List<fv> list = new List<fv>();
		if (fv6 != null)
		{
			list.Add(fv6);
		}
		list.Sort(new Comparison<fv>(bew.a.a.a));
		List<string> list2 = new List<string>();
		foreach (fv fv7 in list)
		{
			if (fv7 != null)
			{
				bke bke7 = bke;
				bke7.f(bke7.a3() + "." + fv7.Definition.a5());
				bke bke8 = bke;
				bke8.b(bke8.bf() + (double)fv7.SingleItemValue);
				bke bke9 = bke;
				bke9.h(bke9.a4() + fv7.SingleItemWeight);
				if (!c4r.a(bke, fv7, list2))
				{
					string text = fv7.TypedDefinition.a5();
					if (fv7.TypedDefinition.i() == ms.x)
					{
						double num6 = 0.05;
						c4r.a(ref bke.v, num6);
						c4r.a(ref bke.u, Convert.ToSingle(num6));
						c4r.a(ref bke.s, (double)Convert.ToSingle(num6));
						bke bke10 = bke;
						bke10.a(bke10.v() + 5);
						bke bke11 = bke;
						bke11.g(bke11.az() + " с сошками");
						bke bke12 = bke;
						bke12.i(bke12.a0() + " Сошки повышают точность стрельбы, но замедляют прицеливание.");
						bke bke13 = bke;
						bke13.a(bke13.x() - 3);
					}
					else if (text == "ergonomicHandle")
					{
						bke bke14 = bke;
						bke14.i(bke14.a0() + " Специальная эргономичная рукоятка улучшает контроль над оружием, особенно при стрельбе на ходу.");
						str += "Эргономичный ";
						bke bke15 = bke;
						bke15.g(bke15.ab() + 0.03);
						c4r.a(ref bke.v, -0.05);
						bke bke16 = bke;
						bke16.a(bke16.x() - 3);
					}
				}
			}
		}
		c6o.a(bke, new b5x(-5));
		cwp.a(bke, list2);
		bke.g(str + bke.az() + str2);
		bke bke17 = bke;
		bke17.b(bke17.bf() * (double)3);
		cwp.a(bke, new coh[]
		{
			fv,
			fv4,
			fv3,
			fv6
		});
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x06009862 RID: 39010 RVA: 0x003B6670 File Offset: 0x003B4870
	private WeaponSubtype a(BarrelType A_0)
	{
		if (A_0 == BarrelType.Caliber_44 || A_0 != BarrelType.Caliber_127)
		{
			return WeaponSubtype.Minigun_44;
		}
		return WeaponSubtype.Minigun_127;
	}

	// Token: 0x06009863 RID: 39011 RVA: 0x003B6688 File Offset: 0x003B4888
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 8;
		string a_ = "xphw_Weapons";
		List<bj8> list = new List<bj8>();
		string[] array = new string[]
		{
			"barbarian",
			"destroyer",
			"predator",
			"terminator"
		};
		string[] array2 = new string[]
		{
			"slow1",
			"slow2",
			"jump1",
			"jump2",
			"long1",
			"long2"
		};
		string[] array3 = new string[]
		{
			"rifleBipod",
			"ergonomicHandle"
		};
		for (int i = 0; i < array.Length; i++)
		{
			string arg = array[i];
			bj8 bj = new bj8();
			bj.a(string.Format("minigun.{0}.frame", arg));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < array2.Length; j++)
			{
				for (int k = 0; k < 7; k++)
				{
					for (int l = -1; l < 2; l++)
					{
						bj = new bj8();
						bj.a(string.Format("minigun.{0}.{1}.{2}", arg, k, array2[j]));
						bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
						bj.a().Add(new d8h(a_, new Point(num + 11 + j, num2 + i), 1f));
						if (l > -1)
						{
							bj8 bj2 = bj;
							bj2.a(bj2.c() + "." + array3[l]);
							bj.a().Add(new d8h(a_, new Point(num + 9 + l, num2 + i), 1f));
						}
						bj.a().Add(new d8h(a_, new Point(num + 2 + k, num2 + i), 1f));
						list.Add(bj);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x04003A67 RID: 14951
	public new static readonly string a = "frame";

	// Token: 0x04003A68 RID: 14952
	public new static readonly string b = "motor";

	// Token: 0x04003A69 RID: 14953
	public static readonly string c = "barrel";

	// Token: 0x04003A6A RID: 14954
	public new static readonly string d = "magazine";

	// Token: 0x04003A6B RID: 14955
	public static readonly string e = "magazine2";

	// Token: 0x04003A6C RID: 14956
	public static readonly string f = "enhancement1";

	// Token: 0x02001B76 RID: 7030
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009867 RID: 39015 RVA: 0x003B6914 File Offset: 0x003B4B14
		internal int a(fv A_0, fv A_1)
		{
			return string.Compare(A_0.Definition.az(), A_1.Definition.az());
		}

		// Token: 0x04003A6D RID: 14957
		public static readonly bew.a a = new bew.a();

		// Token: 0x04003A6E RID: 14958
		public static Comparison<fv> b;
	}
}
