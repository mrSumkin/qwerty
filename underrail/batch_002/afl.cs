using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BA2 RID: 7074
[dgg("spear")]
public sealed class afl : c4r, bd3
{
	// Token: 0x060099A0 RID: 39328 RVA: 0x003BDFB0 File Offset: 0x003BC1B0
	public override string bt()
	{
		return "荒Копьё";
	}

	// Token: 0x060099A1 RID: 39329 RVA: 0x003BDFB8 File Offset: 0x003BC1B8
	public override string bu()
	{
		return "spear";
	}

	// Token: 0x060099A2 RID: 39330 RVA: 0x003BDFC0 File Offset: 0x003BC1C0
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060099A3 RID: 39331 RVA: 0x003BDFC4 File Offset: 0x003BC1C4
	public override bool bw()
	{
		return true;
	}

	// Token: 0x060099A4 RID: 39332 RVA: 0x003BDFC8 File Offset: 0x003BC1C8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x060099A5 RID: 39333 RVA: 0x003BDFD0 File Offset: 0x003BC1D0
	public afl()
	{
		base.Slots.Add(afl.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, true, false, null));
		base.Slots.Add(afl.b, new cgo(new eh0("spearShaft", 98), "Вал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(afl.c, new cgo(new eh0("stabilizationWings", 122), "Стабилизаторы", true, 1, 0.1f, false, false, null));
		base.Slots.Add(afl.d, new cgo(new eh0(new string[]
		{
			"electroshockGenerator",
			"energyEdgeEmitter"
		}, 43), "Силовой модуль", true, 1, 0.1f, false, false, null));
		base.Slots.Add(afl.e, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099A6 RID: 39334 RVA: 0x003BE0DC File Offset: 0x003BC2DC
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 0;
		string a_ = "xpbl_Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i <= 1; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("spear.{0}", j + 1));
				bj.a().Add(new d8h(a_, new Point(num, num2 + j), 1f));
				if (i == 1)
				{
					bj8 bj2 = bj;
					bj2.a(bj2.c() + ".w");
					bj.a().Add(new d8h(a_, new Point(num + 5, num2 + j), 1f));
				}
				list.Add(bj);
				for (int k = 0; k < 2; k++)
				{
					bj = new bj8();
					bj.a(string.Format("spear.{0}.{1}", j + 1, k + 1));
					if (k == 0)
					{
						bj.a().Add(new d8h(a_, new Point(num + k + 1, num2 + j), 1f));
					}
					else if (k == 1)
					{
						bj.a().Add(new d8h(a_, new Point(num + 2, num2 + j), 1f));
						bj.a().Add(new d8h(a_, new Point(num + 3, num2 + j), 0.7f));
						bj.a().Add(new d8h(a_, new Point(num + 4, num2 + j), 0.45f));
					}
					if (i == 1)
					{
						bj8 bj3 = bj;
						bj3.a(bj3.c() + ".w");
						bj.a().Add(new d8h(a_, new Point(num + 5, num2 + j), 1f));
					}
					list.Add(bj);
				}
			}
		}
		return list;
	}

	// Token: 0x060099A7 RID: 39335 RVA: 0x003BE2E0 File Offset: 0x003BC4E0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(afl.a, null);
		fv fv2 = A_1.SafeGet(afl.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			ett ett = fv.TypedDefinition as ett;
			if (ett != null)
			{
				double num = cwp.a(fv);
				bke bke = new bke();
				bke.b(new double?((double)(fv.SingleItemValue / 2 + fv2.SingleItemValue)));
				bke.h(Math.Round(fv.SingleItemWeight / 3.5 + fv2.SingleItemWeight, 2));
				bke.g((int)Math.Ceiling(num));
				bke.a(ett.bc());
				bke.a(bhx.k);
				bke.a(esu.b);
				bke.b("xpbls");
				bke.b(6);
				bke.a(AmmoType.Spear);
				bke.a(new WeaponSubtype?(WeaponSubtype.Spear));
				bke.a(ItemStealingCategory.WeaponHeavy);
				bke.a(a0.g);
				bke.e(2);
				int a_ = 10 + fv.QualityLevel / 5;
				bke.aa().Add(new edm("spearGuard", 1.0, a_, true));
				c4r.a(bke, btz.g, WeaponSubtype.Spear, null);
				if (A_0 != null && A_0.Feats.Contains<e8m>())
				{
					bke bke2 = bke;
					bke2.f(bke2.ai() + (e8m.a + (double)A_0.GetSpecializationValue<bu9>(true) * bu9.a));
				}
				b1j? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
				WeaponSubtype a_2 = WeaponSubtype.Spear;
				double a_3 = num;
				double a_4 = 1.0;
				b1j? a_5 = primitivePropertyValue;
				b1j b1j = c4r.a(A_0, a_2, a_3, a_4, null, a_5);
				bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
				bke.g("копьё");
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("Material");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					bke.g(classPropertyValue + " " + bke.az());
				}
				bke.i(qv.b("Items\\Weapons/Spear"));
				bke.f(string.Format("spear.{0}", fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("MaterialIndex", new int?(1)).Value));
				cd1 result = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
				string text = ett.a5();
				if (!(text == "tungstenSteel"))
				{
					if (!(text == "triChrome"))
					{
						if (!(text == "supersteel"))
						{
							bke bke3 = bke;
							bke3.f(bke3.ai() + 0.02);
						}
						else
						{
							bke.aa()[0].Power += 3;
							bke bke4 = bke;
							bke4.f(bke4.ai() + 0.01);
							bke bke5 = bke;
							bke5.g(bke5.ab() + 0.03);
						}
					}
					else
					{
						bke bke6 = bke;
						bke6.a(bke6.v() - 2);
					}
				}
				else
				{
					bke bke7 = bke;
					bke7.c(bke7.y() + 0.2);
					bke bke8 = bke;
					bke8.b(bke8.i() + 1);
				}
				fv fv3 = A_1.SafeGet(afl.c, null);
				a1k a1k = (fv3 != null) ? fv3.TypedDefinition : null;
				fv fv4 = A_1.SafeGet(afl.d, null);
				a1k a1k2 = (fv4 != null) ? fv4.TypedDefinition : null;
				fv fv5 = A_1.SafeGet(afl.e, null);
				a1k a1k3 = (fv5 != null) ? fv5.TypedDefinition : null;
				if (a1k2 != null && a1k3 == null)
				{
					A_2 = "Для питания модуля необходимо энергетическое ядро.";
				}
				else if (a1k2 == null && a1k3 != null)
				{
					A_2 = "Энергетическое ядро ничего не питает.";
				}
				else if (a1k2 != null && a1k3 != null)
				{
					if (a1k2.bc() > bke.bc())
					{
						bke.a(a1k2.bc());
					}
					bke.c(new int?(c6o.a(fv5, A_0)));
					if (a1k2.a5() == "electroshockGenerator")
					{
						bke.aa().Add(new edm("electroshockAoe", 1.0, (int)((double)fv4.QualityLevel * 0.75), true));
						bke bke9 = bke;
						bke9.f(bke9.a3() + ".1");
						bke.g("Шоков. " + bke.az());
						bke bke10 = bke;
						bke10.i(bke10.a0() + " " + qv.b("Items\\Mods/electroshockSpear"));
					}
					else if (a1k2.a5() == "energyEdgeEmitter")
					{
						bke.aa().Add(new edm("energyCut", 1.0, (int)((double)fv4.QualityLevel * 1.2), true));
						bke bke11 = bke;
						bke11.f(bke11.a3() + ".2");
						bke.g("Энергетическ. " + bke.az());
						bke bke12 = bke;
						bke12.i(bke12.a0() + " " + qv.b("Items\\Mods/energyEdgeSpear"));
						for (int i = 0; i < bke.l().Count; i++)
						{
							a1q a1q = bke.l()[i];
							if (a1q.DamageType == DamageType.Mechanical)
							{
								bke.l()[i] = new a1q(DamageType.Mechanical, (int)((double)a1q.LowerBoundary * 0.9), (int)((double)a1q.UpperBoundary * 0.9));
							}
						}
					}
					bke bke13 = bke;
					bke13.b(bke13.bf() + (double)(fv4.SingleItemValue + fv5.SingleItemValue));
					bke bke14 = bke;
					bke14.h(bke14.a4() + (fv4.SingleItemWeight + fv5.SingleItemWeight));
					bke.a(ItemRepairCategory.Electronic);
					bke.a(ItemRepairCategory.Electronic);
				}
				if (a1k != null)
				{
					bke.g("Крылатое " + bke.az());
					bke bke15 = bke;
					bke15.i(bke15.a0() + " " + qv.b("Items\\Mods/wingedSpear"));
					double a_6 = Math.Round(0.2 + (double)fv3.QualityLevel * 0.005, 2);
					double a_7 = Math.Round(0.05 + (double)fv3.QualityLevel * 0.001, 2);
					int a_8 = 1 + Math.Min(3, fv3.QualityLevel / 45);
					c6o.a(bke, new ee5(a_8, a_6, a_7));
					bke bke16 = bke;
					bke16.b(bke16.bf() + (double)fv3.SingleItemValue);
					bke bke17 = bke;
					bke17.f(bke17.a3() + ".w");
				}
				bke bke18 = bke;
				bke18.b(bke18.bf() * (double)2);
				return result;
			}
		}
		return null;
	}

	// Token: 0x04003AC1 RID: 15041
	public new static readonly string a = "metal";

	// Token: 0x04003AC2 RID: 15042
	public new static readonly string b = "shaft";

	// Token: 0x04003AC3 RID: 15043
	public static readonly string c = "wings";

	// Token: 0x04003AC4 RID: 15044
	public new static readonly string d = "module";

	// Token: 0x04003AC5 RID: 15045
	public static readonly string e = "core";
}
