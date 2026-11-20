using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE0 RID: 7136
[dgg("sledgehammer")]
public sealed class bib : c4r, bd3
{
	// Token: 0x06009B5E RID: 39774 RVA: 0x003CB3B8 File Offset: 0x003C95B8
	public override string bt()
	{
		return "荐Кувалда";
	}

	// Token: 0x06009B5F RID: 39775 RVA: 0x003CB3C0 File Offset: 0x003C95C0
	public override string bu()
	{
		return "sledgehammer";
	}

	// Token: 0x06009B60 RID: 39776 RVA: 0x003CB3C8 File Offset: 0x003C95C8
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B61 RID: 39777 RVA: 0x003CB3CC File Offset: 0x003C95CC
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B62 RID: 39778 RVA: 0x003CB3D0 File Offset: 0x003C95D0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B63 RID: 39779 RVA: 0x003CB3D4 File Offset: 0x003C95D4
	public bib()
	{
		base.Slots.Add(bib.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bib.b, new cgo(new c6s(ms.ag, 26), "Ручка", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bib.c, new cgo(new eh0(new string[]
		{
			"electroshockGenerator",
			"Component.SerratedSteelBlade",
			"Component.SerratedTungstenSteelBlade",
			"Component.SerratedTiChromeBlade",
			"steelSpikes",
			"tungstenSpikes",
			"tiChromeSpikes"
		}, 123), "Улучшение", true, 1, 0.1f, false, false, null));
		base.Slots.Add(bib.d, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B64 RID: 39780 RVA: 0x003CB4D8 File Offset: 0x003C96D8
	public List<bj8> bz()
	{
		int num = 17;
		int num2 = 0;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 4; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("sledgehammer.{0}", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				bj = new bj8();
				bj.a(string.Format("sledgehammer.{0}.{1}", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
				bj.a().Add(new d8h(a_, new Point(num + j + 1, num2 + i), 1f));
				list.Add(bj);
			}
		}
		return list;
	}

	// Token: 0x06009B65 RID: 39781 RVA: 0x003CB5E8 File Offset: 0x003C97E8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bib.a, null);
		fv fv2 = A_1.SafeGet(bib.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			ett ett = fv.TypedDefinition as ett;
			if (ett != null)
			{
				double num = cwp.a(fv);
				bke bke = new bke();
				bke.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
				bke.h(fv.SingleItemWeight + fv2.SingleItemWeight);
				bke.g((int)Math.Ceiling(num));
				bke.a(ett.bc());
				bke.a(bhx.d);
				bke.a(esu.f);
				bke.b("s");
				bke.b(ett.c());
				bke.a(AmmoType.Sledgehammer);
				bke.a(new WeaponSubtype?(WeaponSubtype.Sledgehammer));
				bke.a(ItemStealingCategory.WeaponHeavy);
				bke.a(a0.g);
				bke.aa().Add(new edm("ST", 0.1, 1, true));
				c4r.a(bke, btz.g, WeaponSubtype.Sledgehammer, null);
				if (A_0 != null && A_0.Feats.Contains<e8m>())
				{
					bke bke2 = bke;
					bke2.f(bke2.ai() + (e8m.a + (double)A_0.GetSpecializationValue<bu9>(true) * bu9.a));
				}
				b1j? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
				WeaponSubtype a_ = WeaponSubtype.Sledgehammer;
				double a_2 = num;
				double a_3 = 1.0;
				b1j? a_4 = primitivePropertyValue;
				b1j b1j = c4r.a(A_0, a_, a_2, a_3, null, a_4);
				bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
				bke.g("кувалда");
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("Material");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					bke.g(classPropertyValue + " " + bke.az());
				}
				bke.i(qv.b("Items\\Weapons/Sledgehammer"));
				bke.f(string.Format("sledgehammer.{0}", fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("MaterialIndex", new int?(1)).Value));
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
							bke.aa()[0].Chance += 0.05;
							bke bke4 = bke;
							bke4.f(bke4.ai() + 0.03);
							bke bke5 = bke;
							bke5.a(bke5.v() - 2);
						}
					}
					else
					{
						bke bke6 = bke;
						bke6.a(bke6.v() - 3);
					}
				}
				else
				{
					bke bke7 = bke;
					bke7.c(bke7.y() + 0.2);
					bke bke8 = bke;
					bke8.f(bke8.ai() - 0.01);
				}
				fv fv3 = A_1.SafeGet(bib.c, null);
				a1k a1k = (fv3 != null) ? fv3.TypedDefinition : null;
				fv fv4 = A_1.SafeGet(bib.d, null);
				a1k a1k2 = (fv4 != null) ? fv4.TypedDefinition : null;
				if (a1k == null && a1k2 != null)
				{
					A_2 = "Энергетическое ядро ничего не питает.";
				}
				else if (a1k != null)
				{
					if (a1k.a5() == "electroshockGenerator")
					{
						if (a1k2 == null)
						{
							A_2 = "Для питания модуля необходимо энергетическое ядро.";
						}
						else
						{
							if (a1k.bc() > bke.bc())
							{
								bke.a(a1k.bc());
							}
							if (a1k.a5() == "electroshockGenerator")
							{
								bke.aa().Add(new edm("electroshockAoe", 1.0, fv3.QualityLevel, true));
								bke.c(new int?(c6o.a(fv4, A_0)));
								bke bke9 = bke;
								bke9.f(bke9.a3() + ".1");
								bke.g("Шоков. " + bke.az());
								bke bke10 = bke;
								bke10.i(bke10.a0() + " " + qv.b("Items\\Mods/electroshockSledgehammer"));
								bke bke11 = bke;
								bke11.b(bke11.bf() + (double)(fv3.SingleItemValue + fv4.SingleItemValue));
								bke bke12 = bke;
								bke12.h(bke12.a4() + (fv3.SingleItemWeight + fv4.SingleItemWeight));
								bke.a(ItemRepairCategory.Electronic);
							}
							bke.a(ItemRepairCategory.Electronic);
						}
					}
					else
					{
						if (a1k2 != null)
						{
							A_2 = "Энергетическое ядро не требуется для питания этого улучшения.";
						}
						if (a1k.a5().EndsWith("Spikes"))
						{
							double num2 = (0.1 + (double)fv3.QualityLevel * 0.001) / 3.0;
							a1q a1q = bke.l()[0];
							a1q item = new a1q(DamageType.Mechanical, Convert.ToInt32((double)a1q.LowerBoundary * num2), Convert.ToInt32((double)a1q.UpperBoundary * num2));
							if (item.LowerBoundary == item.UpperBoundary)
							{
								int num3 = item.UpperBoundary;
								item.UpperBoundary = num3 + 1;
							}
							for (int i = 0; i < 3; i++)
							{
								bke.l().Add(item);
							}
							bke.a7()[dii.a] = true;
							bke bke13 = bke;
							bke13.i(bke13.a0() + " " + qv.b("Items\\Mods/spikedSledgehammer"));
							bke.g("Шипованн. " + bke.az());
							bke bke14 = bke;
							bke14.f(bke14.a3() + ".2");
							bke bke15 = bke;
							bke15.b(bke15.bf() + (double)fv3.SingleItemValue);
						}
						else
						{
							int a_5 = 15 + fv3.QualityLevel / 4;
							bke.aa().Add(new edm("bleedingWound", 0.35, a_5, true));
							bke.a7()[dii.a] = true;
							bke bke16 = bke;
							bke16.i(bke16.a0() + " " + qv.b("Items\\Mods/bladedSledgehammer"));
							bke.g("Покрыт. лезвиями " + bke.az());
							bke bke17 = bke;
							bke17.f(bke17.a3() + ".3");
							bke bke18 = bke;
							bke18.b(bke18.bf() + (double)fv3.SingleItemValue);
						}
					}
				}
				bke bke19 = bke;
				bke19.b(bke19.bf() * (double)2);
				return result;
			}
		}
		return null;
	}

	// Token: 0x04003B6A RID: 15210
	public new static readonly string a = "metal";

	// Token: 0x04003B6B RID: 15211
	public new static readonly string b = "handle";

	// Token: 0x04003B6C RID: 15212
	public static readonly string c = "module";

	// Token: 0x04003B6D RID: 15213
	public new static readonly string d = "core";
}
