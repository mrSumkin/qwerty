using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BA1 RID: 7073
[dgg("machete")]
public sealed class akk : c4r, bd3
{
	// Token: 0x06009997 RID: 39319 RVA: 0x003BD520 File Offset: 0x003BB720
	public override string bt()
	{
		return "荑Мачете";
	}

	// Token: 0x06009998 RID: 39320 RVA: 0x003BD528 File Offset: 0x003BB728
	public override string bu()
	{
		return "machete";
	}

	// Token: 0x06009999 RID: 39321 RVA: 0x003BD530 File Offset: 0x003BB730
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600999A RID: 39322 RVA: 0x003BD534 File Offset: 0x003BB734
	public override bool bw()
	{
		return true;
	}

	// Token: 0x0600999B RID: 39323 RVA: 0x003BD538 File Offset: 0x003BB738
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x0600999C RID: 39324 RVA: 0x003BD53C File Offset: 0x003BB73C
	public akk()
	{
		base.Slots.Add(akk.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, true, false, null));
		base.Slots.Add(akk.c, new cgo(new eh0(new string[]
		{
			"straightMacheteBladeMold",
			"curvedMacheteBladeMold"
		}, 99), "Форма", false, 1, 0.1f, true, false, null));
		base.Slots.Add(akk.b, new cgo(new eh0("macheteHandle", 100), "Ручка", false, 1, 0.1f, false, false, null));
		base.Slots.Add(akk.d, new cgo(new eh0(new string[]
		{
			"electroshockGenerator",
			"energyEdgeEmitter"
		}, 43), "Силовой модуль", true, 1, 0.1f, false, false, null));
		base.Slots.Add(akk.e, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x0600999D RID: 39325 RVA: 0x003BD65C File Offset: 0x003BB85C
	public List<bj8> bz()
	{
		int num = 8;
		int num2 = 0;
		string a_ = "xpbl_Weapons";
		int num3 = 4;
		int num4 = 2;
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num4; j++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("machete.{0}.{1}", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num + j, num2 + i), 1f));
				list.Add(bj);
				for (int k = 0; k < 2; k++)
				{
					bj = new bj8();
					bj.a(string.Format("machete.{0}.{1}.m{2}", i + 1, j + 1, k));
					if (k == 0)
					{
						bj.a().Add(new d8h(a_, new Point(num + j, num2 + i + num3), 1f));
					}
					else if (k == 1)
					{
						bj.a().Add(new d8h("xpbl_Weapons", new Point(num + j + num4, num2 + i), 1f));
						bj.a().Add(new d8h("xpbl_Weapons", new Point(num + j + num4 * 2, num2 + i), 0.7f));
						bj.a().Add(new d8h("xpbl_Weapons", new Point(num + j + num4 * 3, num2 + i), 0.45f));
					}
					list.Add(bj);
				}
			}
		}
		return list;
	}

	// Token: 0x0600999E RID: 39326 RVA: 0x003BD814 File Offset: 0x003BBA14
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(akk.a, null);
		fv fv2 = A_1.SafeGet(akk.b, null);
		fv fv3 = A_1.SafeGet(akk.c, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			ett ett = fv.TypedDefinition as ett;
			if (ett != null)
			{
				WeaponSubtype weaponSubtype;
				if (fv3.TypedDefinition.a5() == "curvedMacheteBladeMold")
				{
					weaponSubtype = WeaponSubtype.Machete_Curved;
				}
				else
				{
					weaponSubtype = WeaponSubtype.Machete_Straight;
				}
				double num = cwp.a(fv);
				bke bke = new bke();
				bke.b(new double?((double)(fv.SingleItemValue / 3 + fv2.SingleItemValue)));
				bke.h(Math.Round(fv.SingleItemWeight / 5.0 + fv2.SingleItemWeight, 2));
				bke.g((int)Math.Ceiling(num));
				bke.a(ett.bc());
				bke.a(bhx.l);
				bke.a(esu.b);
				bke.b("xpblm");
				bke.b(5);
				bke.a(AmmoType.Sword);
				bke.a(new WeaponSubtype?(weaponSubtype));
				bke.a(ItemStealingCategory.Weapon);
				bke.a(a0.g);
				bke.aa().Add(new edm("carveUp", 1.0, 1, true));
				c4r.a(bke, btz.g, weaponSubtype, null);
				if (A_0 != null && A_0.Feats.Contains<e8m>())
				{
					bke bke2 = bke;
					bke2.f(bke2.ai() + (e8m.a + (double)A_0.GetSpecializationValue<bu9>(true) * bu9.a));
				}
				b1j? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
				WeaponSubtype a_ = weaponSubtype;
				double a_2 = num;
				double a_3 = 1.0;
				b1j? a_4 = primitivePropertyValue;
				b1j b1j = c4r.a(A_0, a_, a_2, a_3, null, a_4);
				bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
				bke.g("мачете");
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("Material");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					bke.g(classPropertyValue + " " + bke.az());
				}
				bke.i(qv.b("Items\\Weapons/Machete"));
				bke.f(string.Format("machete.{0}", fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("MaterialIndex", new int?(1)).Value));
				if (fv3.TypedDefinition.a5() == "curvedMacheteBladeMold")
				{
					bke bke3 = bke;
					bke3.f(bke3.a3() + ".1");
				}
				else
				{
					bke bke4 = bke;
					bke4.f(bke4.a3() + ".2");
				}
				cd1 result = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
				string text = ett.a5();
				if (!(text == "tungstenSteel"))
				{
					if (!(text == "triChrome"))
					{
						if (!(text == "supersteel"))
						{
							bke bke5 = bke;
							bke5.f(bke5.ai() + 0.02);
						}
						else
						{
							bke.aa()[0].Chance += 0.15;
							bke bke6 = bke;
							bke6.f(bke6.ai() + 0.01);
							bke bke7 = bke;
							bke7.g(bke7.ab() + 0.03);
							bke bke8 = bke;
							bke8.a(bke8.v() - 1);
						}
					}
					else
					{
						bke bke9 = bke;
						bke9.a(bke9.v() - 2);
					}
				}
				else
				{
					bke bke10 = bke;
					bke10.c(bke10.y() + 0.2);
					bke bke11 = bke;
					bke11.b(bke11.i() + 1);
				}
				fv fv4 = A_1.SafeGet(akk.d, null);
				a1k a1k = (fv4 != null) ? fv4.TypedDefinition : null;
				fv fv5 = A_1.SafeGet(akk.e, null);
				a1k a1k2 = (fv5 != null) ? fv5.TypedDefinition : null;
				if (a1k != null && a1k2 == null)
				{
					A_2 = "Для питания модуля необходимо энергетическое ядро.";
				}
				else if (a1k == null && a1k2 != null)
				{
					A_2 = "Энергетическое ядро ничего не питает.";
				}
				else if (a1k != null && a1k2 != null)
				{
					if (a1k.bc() > bke.bc())
					{
						bke.a(a1k.bc());
					}
					if (a1k.a5() == "electroshockGenerator")
					{
						bke.aa().Add(new edm("electroshockAoe", 1.0, (int)((double)fv4.QualityLevel * 0.55), true));
						bke.c(new int?(c6o.a(fv5, A_0)));
						bke bke12 = bke;
						bke12.f(bke12.a3() + ".m0");
						bke.g("Шоков. " + bke.az());
						bke bke13 = bke;
						bke13.i(bke13.a0() + " " + qv.b("Items\\Mods/electroshockMachete"));
					}
					else if (a1k.a5() == "energyEdgeEmitter")
					{
						bke.aa().Add(new edm("energyCut", 1.0, (int)((double)fv4.QualityLevel * 0.8), true));
						bke.c(new int?(c6o.a(fv5, A_0)));
						bke bke14 = bke;
						bke14.f(bke14.a3() + ".m1");
						bke.g("Энергетическ. " + bke.az());
						bke bke15 = bke;
						bke15.i(bke15.a0() + " " + qv.b("Items\\Mods/energyEdgeMachete"));
						for (int i = 0; i < bke.l().Count; i++)
						{
							a1q a1q = bke.l()[i];
							if (a1q.DamageType == DamageType.Mechanical)
							{
								bke.l()[i] = new a1q(DamageType.Mechanical, (int)((double)a1q.LowerBoundary * 0.9), (int)((double)a1q.UpperBoundary * 0.9));
							}
						}
					}
					bke bke16 = bke;
					bke16.b(bke16.bf() + (double)(fv4.SingleItemValue + fv5.SingleItemValue));
					bke bke17 = bke;
					bke17.h(bke17.a4() + (fv4.SingleItemWeight + fv5.SingleItemWeight));
					bke.a(ItemRepairCategory.Electronic);
				}
				if (weaponSubtype == WeaponSubtype.Machete_Curved)
				{
					bke.g("Изогнутое " + bke.az());
				}
				bke bke18 = bke;
				bke18.b(bke18.bf() * (double)2);
				return result;
			}
		}
		return null;
	}

	// Token: 0x04003ABC RID: 15036
	public new static readonly string a = "metal";

	// Token: 0x04003ABD RID: 15037
	public new static readonly string b = "handle";

	// Token: 0x04003ABE RID: 15038
	public static readonly string c = "mold";

	// Token: 0x04003ABF RID: 15039
	public new static readonly string d = "module";

	// Token: 0x04003AC0 RID: 15040
	public static readonly string e = "core";
}
