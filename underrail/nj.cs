using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B81 RID: 7041
[dgg("CombatGloves")]
public sealed class nj : c4r, bd3
{
	// Token: 0x060098B4 RID: 39092 RVA: 0x003B9884 File Offset: 0x003B7A84
	public override string bt()
	{
		return "茙Боевые перчатки";
	}

	// Token: 0x060098B5 RID: 39093 RVA: 0x003B988C File Offset: 0x003B7A8C
	public override string bu()
	{
		return "CombatGloves";
	}

	// Token: 0x060098B6 RID: 39094 RVA: 0x003B9894 File Offset: 0x003B7A94
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060098B7 RID: 39095 RVA: 0x003B9898 File Offset: 0x003B7A98
	public override bool bw()
	{
		return true;
	}

	// Token: 0x060098B8 RID: 39096 RVA: 0x003B989C File Offset: 0x003B7A9C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x060098B9 RID: 39097 RVA: 0x003B98A4 File Offset: 0x003B7AA4
	public nj()
	{
		base.Slots.Add(nj.a, new cgo(new c6s(new ms[]
		{
			ms.d,
			ms.ac
		}, 44), "Материал перчаток", false, 1, 0.1f, true, false, null));
		base.Slots.Add(nj.b, new cgo(new c6s(new ms[]
		{
			ms.ac,
			ms.ad
		}, 24), "Улучшения", true, 1, 0.1f, false, false, null));
		base.Slots.Add(nj.c, new cgo(new eh0(new string[]
		{
			"electroshockGenerator",
			"pneumaticHammer"
		}, 43), "Силовой модуль", true, 1, 0.1f, false, false, null));
		base.Slots.Add(nj.d, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098BA RID: 39098 RVA: 0x003B9998 File Offset: 0x003B7B98
	public List<bj8> bz()
	{
		int num = 34;
		int num2 = 0;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 15; i++)
		{
			for (int j = -1; j < 3; j++)
			{
				for (int k = -1; k < 2; k++)
				{
					bj8 bj = new bj8();
					bj.a(string.Format("glove.{0}", i));
					bj.a().Add(new d8h(a_, new Point(num + i % 10, num2 + i / 10), 1f));
					if (j != -1)
					{
						bj8 bj2 = bj;
						bj2.a(bj2.c() + string.Format(".e{0}", j));
						bj.a().Add(new d8h(a_, new Point(num + j, num2 + 2), 1f));
					}
					if (k != -1)
					{
						bj8 bj3 = bj;
						bj3.a(bj3.c() + string.Format(".m{0}", k));
						bj.a().Add(new d8h(a_, new Point(num + k, num2 + 3), 1f));
					}
					list.Add(bj);
				}
			}
		}
		return list;
	}

	// Token: 0x060098BB RID: 39099 RVA: 0x003B9AE8 File Offset: 0x003B7CE8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(nj.a, null);
		if (fv != null)
		{
			a1k a1k = fv.TypedDefinition;
			if (a1k != null)
			{
				int num = fv.QualityLevel;
				if (A_0 != null && a1k.i() == ms.d && A_0.Feats.Contains<uh>())
				{
					num = (int)((double)num * (1.0 + uh.a(A_0)));
				}
				double a_ = cwp.a(num);
				bke bke = new bke();
				bke.a(a1k.bc());
				bke.b(new double?((double)fv.SingleItemValue));
				bke.h(Math.Round(fv.SingleItemWeight / 5.0, 2));
				bke.g((int)Math.Ceiling(a_));
				bke.e(true);
				bke.a(bhx.e);
				bke.a(ItemStealingCategory.Weapon);
				bke.g("перчатки");
				bke.f("glove." + a1k.a7().GetPrimitivePropertyValue<int>("GloveMatIndex", new int?(0)).Value.ToString());
				bke.a(AmmoType.FistWeapon);
				bke.a(a0.g);
				WeaponSubtype weaponSubtype;
				if (a1k.i() == ms.d)
				{
					weaponSubtype = WeaponSubtype.Glove_Leather;
					bke.a(esu.h);
					bke.a(new WeaponSubtype?(WeaponSubtype.Glove_Leather));
					string classPropertyValue = a1k.a7().GetClassPropertyValue<string>("CustomInfusionLeatherType");
					string classPropertyValue2 = a1k.a7().GetClassPropertyValue<string>("SourceCreature");
					if (!string.IsNullOrEmpty(classPropertyValue2))
					{
						bke.g(string.Format("{0} {1} {2}", classPropertyValue2, classPropertyValue ?? "кожан.", bke.az()));
					}
					bke.i(string.Format("Это пара лёгких {0} {1} боевых перчаток.", classPropertyValue2.ToLowerInvariant(), (classPropertyValue ?? "кожаных").ToLowerInvariant()));
					bke.a(ItemRepairCategory.Fabric);
				}
				else
				{
					weaponSubtype = WeaponSubtype.Glove_Metal;
					bke.a(esu.d);
					bke.a(new WeaponSubtype?(WeaponSubtype.Glove_Metal));
					string text = a1k.a7().GetClassPropertyValue<string>("Material") ?? "";
					bke.g(text + " " + bke.az());
					bke.i(string.Format("Это пара тяжёлых {0} боевых перчаток.", text.ToLowerInvariant()));
					bke.a(ItemRepairCategory.Mechanical);
				}
				c4r.a(bke, btz.g, weaponSubtype, null);
				b1j b1j = c4r.a(A_0, weaponSubtype, a_, 1.0, null, null);
				bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
				fv fv2 = A_1.SafeGet(nj.b, null);
				coh result = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
				if (fv2 != null)
				{
					a1k a1k2 = fv2.TypedDefinition;
					if (a1k2 != null)
					{
						string text2 = a1k2.a7().GetClassPropertyValue<string>("Material") ?? "";
						bke bke2 = bke;
						bke2.b(bke2.bf() + (double)fv2.SingleItemValue);
						bke bke3 = bke;
						bke3.f(bke3.a3() + ".e" + a1k2.a7().GetPrimitivePropertyValue<int>("GloveEnhIndex", new int?(0)).Value.ToString());
						if (a1k2.i() == ms.ac)
						{
							bke.g("Укреплённ. " + bke.az());
							bke bke4 = bke;
							bke4.i(bke4.a0() + string.Format(" Они усилены {0} пластинами для увеличения наносимого урона.", text2.ToLowerInvariant()));
							b1j b1j2 = c4r.a(A_0, weaponSubtype, cwp.a(fv2), 0.2, null, null);
							bke.l()[0] = new a1q(DamageType.Mechanical, bke.l()[0].LowerBoundary + (int)b1j2.b, bke.l()[0].UpperBoundary + (int)b1j2.c);
							bke bke5 = bke;
							bke5.h(bke5.a4() + Math.Round(fv2.SingleItemWeight / 20.0, 2));
						}
						else if (a1k2.a7().GetPrimitivePropertyValue<bool>("IsSpike", new bool?(false)).Value)
						{
							bke.g("Шипованн. " + bke.az());
							bke bke6 = bke;
							bke6.i(bke6.a0() + string.Format(" Они снабжены {0} шипами, которые могут наносить дополнительный урон цели.", text2.ToLowerInvariant()));
							b1j b1j3 = c4r.a(A_0, weaponSubtype, cwp.a(fv2), 0.35, null, null);
							bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j3.b, (int)b1j3.c));
							bke.a7()[dii.a] = true;
							bke bke7 = bke;
							bke7.h(bke7.a4() + Math.Round(fv2.SingleItemWeight / 2.0, 2));
						}
						else if (a1k2.a7().GetPrimitivePropertyValue<bool>("IsBlade", new bool?(false)).Value)
						{
							bke.g("Покрыт. лезвиями " + bke.az());
							bke bke8 = bke;
							bke8.i(bke8.a0() + string.Format(" Они снабжены {0} зазубренными лезвиями, которые могут наносить кровоточащие раны.", text2.ToLowerInvariant()));
							double num2 = 0.25 + (double)fv2.QualityLevel * 0.01;
							bke.aa().Add(new edm("bleedingWound", 0.35, (int)(num2 * 100.0), true));
							bke.a7()[dii.a] = true;
							bke bke9 = bke;
							bke9.h(bke9.a4() + Math.Round(fv2.SingleItemWeight / 2.0, 2));
						}
					}
				}
				fv fv3 = A_1.SafeGet(nj.c, null);
				a1k a1k3 = (fv3 != null) ? fv3.TypedDefinition : null;
				fv fv4 = A_1.SafeGet(nj.d, null);
				a1k a1k4 = (fv4 != null) ? fv4.TypedDefinition : null;
				if (a1k3 != null && a1k4 == null)
				{
					A_2 = "Для питания модуля необходимо энергетическое ядро.";
				}
				else if (a1k3 == null && a1k4 != null)
				{
					A_2 = "Энергетическое ядро ничего не питает.";
				}
				else if (a1k3 != null && a1k4 != null)
				{
					if (a1k3.bc() > bke.bc())
					{
						bke.a(a1k3.bc());
					}
					if (a1k3.a5() == "electroshockGenerator")
					{
						bke.aa().Add(new edm("electroshockAoe", 1.0, (int)((double)fv3.QualityLevel * 0.25), true));
						bke.g("Шоков. " + bke.az());
						bke bke10 = bke;
						bke10.i(bke10.a0() + " " + qv.b("Items\\Mods/electroshockGloves"));
						bke bke11 = bke;
						bke11.f(bke11.a3() + ".m0");
					}
					else if (a1k3.a5() == "pneumaticHammer")
					{
						bke.aa().Add(new edm("pneumaticImpact", 1.0, fv3.QualityLevel, true));
						bke.g("Пневматическ. " + bke.az());
						bke bke12 = bke;
						bke12.i(bke12.a0() + " " + qv.b("Items\\Mods/pneumaticGloves"));
						bke bke13 = bke;
						bke13.f(bke13.a3() + ".m1");
					}
					bke bke14 = bke;
					bke14.b(bke14.bf() + (double)(fv3.SingleItemValue + fv4.SingleItemValue));
					bke bke15 = bke;
					bke15.h(bke15.a4() + (fv3.SingleItemWeight + fv4.SingleItemWeight));
					bke.c(new int?(c6o.a(fv4, A_0)));
					bke.a(ItemRepairCategory.Electronic);
				}
				bke bke16 = bke;
				bke16.b(bke16.bf() * (double)2);
				return result;
			}
		}
		return null;
	}

	// Token: 0x04003A89 RID: 14985
	public new static readonly string a = "material";

	// Token: 0x04003A8A RID: 14986
	public new static readonly string b = "enhancement";

	// Token: 0x04003A8B RID: 14987
	public static readonly string c = "module";

	// Token: 0x04003A8C RID: 14988
	public new static readonly string d = "core";
}
