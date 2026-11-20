using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BD3 RID: 7123
[dgg("combatKnife")]
public sealed class dqx : c4r, bd3
{
	// Token: 0x06009AFD RID: 39677 RVA: 0x003C663C File Offset: 0x003C483C
	public override string bt()
	{
		return "荓Боевой нож";
	}

	// Token: 0x06009AFE RID: 39678 RVA: 0x003C6644 File Offset: 0x003C4844
	public override string bu()
	{
		return "combatKnife";
	}

	// Token: 0x06009AFF RID: 39679 RVA: 0x003C664C File Offset: 0x003C484C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B00 RID: 39680 RVA: 0x003C6650 File Offset: 0x003C4850
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B01 RID: 39681 RVA: 0x003C6654 File Offset: 0x003C4854
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009B02 RID: 39682 RVA: 0x003C6658 File Offset: 0x003C4858
	public dqx()
	{
		base.Slots.Add(dqx.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, true, false, null));
		base.Slots.Add(dqx.c, new cgo(new c6s(ms.aj, 28), "Форма", false, 1, 0.1f, true, false, null));
		base.Slots.Add(dqx.b, new cgo(new c6s(ms.ai, 27), "Ручка", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dqx.d, new cgo(new eh0(new string[]
		{
			"electroshockGenerator",
			"energyEdgeEmitter"
		}, 43), "Силовой модуль", true, 1, 0.1f, false, false, null));
		base.Slots.Add(dqx.e, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B03 RID: 39683 RVA: 0x003C6760 File Offset: 0x003C4960
	public List<bj8> bz()
	{
		int num = 22;
		int num2 = 0;
		string a_ = "Weapons";
		int num3 = 4;
		int num4 = 3;
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num4; j++)
			{
				bj8 bj = new bj8();
				bj.a(string.Format("knife.{0}.{1}", i + 1, j + 1));
				bj.a().Add(new d8h(a_, new Point(num + j, num2 + i), 1f));
				list.Add(bj);
				for (int k = 0; k < 2; k++)
				{
					bj = new bj8();
					bj.a(string.Format("knife.{0}.{1}.m{2}", i + 1, j + 1, k));
					if (k == 0)
					{
						bj.a().Add(new d8h(a_, new Point(num + j, num2 + i + num3), 1f));
					}
					else if (k == 1)
					{
						bj.a().Add(new d8h("xpbl_Weapons", new Point(j, 10 + i), 1f));
						bj.a().Add(new d8h("xpbl_Weapons", new Point(j + num4, 10 + i), 0.7f));
						bj.a().Add(new d8h("xpbl_Weapons", new Point(j + num4 * 2, 10 + i), 0.45f));
					}
					list.Add(bj);
				}
			}
		}
		return list;
	}

	// Token: 0x06009B04 RID: 39684 RVA: 0x003C6914 File Offset: 0x003C4B14
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dqx.a, null);
		fv fv2 = A_1.SafeGet(dqx.b, null);
		fv fv3 = A_1.SafeGet(dqx.c, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			ett ett = fv.TypedDefinition as ett;
			if (ett != null)
			{
				WeaponSubtype value = fv3.TypedDefinition.a7().GetPrimitivePropertyValue<WeaponSubtype>("KnifeType", new WeaponSubtype?(WeaponSubtype.Knife)).Value;
				double a_ = cwp.a(fv);
				bke bke = new bke();
				bke.b(new double?((double)(fv.SingleItemValue / 5 + fv2.SingleItemValue + fv3.SingleItemValue)));
				bke.h(Math.Round(fv.SingleItemWeight / 20.0, 2));
				bke.g((int)Math.Ceiling(a_));
				bke.a(fv.TypedDefinition.bc());
				bke.a(bhx.b);
				bke.a(esu.b);
				bke.b("k");
				bke.a((value == WeaponSubtype.Dagger) ? AmmoType.Dagger : AmmoType.Knife);
				bke.a(new WeaponSubtype?(value));
				bke.a(ItemStealingCategory.Weapon);
				bke.a(a0.g);
				c4r.a(bke, btz.g, value, null);
				b1j b1j = c4r.a(A_0, value, a_, 1.0, null, null);
				bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
				if (A_0 != null && A_0.Feats.Contains<e8m>())
				{
					bke bke2 = bke;
					bke2.f(bke2.ai() + (e8m.a + (double)A_0.GetSpecializationValue<bu9>(true) * bu9.a));
				}
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("Material");
				string format = fv3.TypedDefinition.a7().GetClassPropertyValue<string>("KnifeName") ?? "{0} Нож";
				try
				{
					bke.g(string.Format(format, classPropertyValue));
				}
				catch
				{
				}
				try
				{
					bke.i(qv.a("Items\\Weapons/" + value.ToString(), new object[]
					{
						(classPropertyValue ?? "metal").ToLowerInvariant()
					}));
				}
				catch
				{
				}
				bke.f(string.Format("knife.{0}.{1}", fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("MaterialIndex", new int?(1)).Value, value - WeaponSubtype.Knife + 1));
				if (value == WeaponSubtype.SerratedKnife)
				{
					bke.aa().Add(new edm("bleedingWound", 0.25, 100, true));
				}
				cd1 result = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
				fv fv4 = A_1.SafeGet(dqx.d, null);
				a1k a1k = (fv4 != null) ? fv4.TypedDefinition : null;
				fv fv5 = A_1.SafeGet(dqx.e, null);
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
						bke.aa().Add(new edm("electroshockAoe", 1.0, (int)((double)fv4.QualityLevel * 0.35), true));
						bke.g("Шоков. " + bke.az());
						bke bke3 = bke;
						bke3.i(bke3.a0() + " " + qv.a("Items\\Mods/electroshockKnife", new object[]
						{
							(value == WeaponSubtype.Dagger) ? "кинжале" : "ноже"
						}));
						bke bke4 = bke;
						bke4.f(bke4.a3() + ".m0");
					}
					else if (a1k.a5() == "energyEdgeEmitter")
					{
						bke.aa().Add(new edm("energyCut", 1.0, (int)((double)fv4.QualityLevel * 0.55), true));
						bke.g("Энергетическ. " + bke.az());
						bke bke5 = bke;
						bke5.i(bke5.a0() + " " + qv.b("Items\\Mods/energyEdgeKnife"));
						bke bke6 = bke;
						bke6.f(bke6.a3() + ".m1");
						for (int i = 0; i < bke.l().Count; i++)
						{
							a1q a1q = bke.l()[i];
							if (a1q.DamageType == DamageType.Mechanical)
							{
								bke.l()[i] = new a1q(DamageType.Mechanical, (int)((double)a1q.LowerBoundary * 0.9), (int)((double)a1q.UpperBoundary * 0.9));
							}
						}
					}
					bke bke7 = bke;
					bke7.b(bke7.bf() + (double)(fv4.SingleItemValue + fv5.SingleItemValue));
					bke bke8 = bke;
					bke8.h(bke8.a4() + (fv4.SingleItemWeight + fv5.SingleItemWeight));
					bke.c(new int?(c6o.a(fv5, A_0)));
					bke.a(ItemRepairCategory.Electronic);
				}
				string text = ett.a5();
				if (!(text == "tungstenSteel"))
				{
					if (!(text == "triChrome"))
					{
						if (!(text == "supersteel"))
						{
							bke bke9 = bke;
							bke9.f(bke9.ai() + 0.02);
						}
						else
						{
							bke.a(new double?(as3.bn + 0.15));
							bke bke10 = bke;
							bke10.f(bke10.ai() + 0.01);
							bke bke11 = bke;
							bke11.g(bke11.ab() + 0.05);
						}
					}
					else
					{
						bke bke12 = bke;
						bke12.a(bke12.v() - 1);
					}
				}
				else
				{
					bke bke13 = bke;
					bke13.c(bke13.y() + 0.2);
				}
				return result;
			}
		}
		return null;
	}

	// Token: 0x04003B3C RID: 15164
	public new static readonly string a = "metal";

	// Token: 0x04003B3D RID: 15165
	public new static readonly string b = "handle";

	// Token: 0x04003B3E RID: 15166
	public static readonly string c = "mold";

	// Token: 0x04003B3F RID: 15167
	public new static readonly string d = "module";

	// Token: 0x04003B40 RID: 15168
	public static readonly string e = "core";
}
