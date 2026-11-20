using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE9 RID: 7145
[dgg("xbow")]
public sealed class bg : c4r, bd3
{
	// Token: 0x06009BA5 RID: 39845 RVA: 0x003CF9AC File Offset: 0x003CDBAC
	public override string bt()
	{
		return "莂Арбалет";
	}

	// Token: 0x06009BA6 RID: 39846 RVA: 0x003CF9B4 File Offset: 0x003CDBB4
	public override string bu()
	{
		return "xbow";
	}

	// Token: 0x06009BA7 RID: 39847 RVA: 0x003CF9BC File Offset: 0x003CDBBC
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009BA8 RID: 39848 RVA: 0x003CF9C0 File Offset: 0x003CDBC0
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009BA9 RID: 39849 RVA: 0x003CF9C4 File Offset: 0x003CDBC4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009BAA RID: 39850 RVA: 0x003CF9CC File Offset: 0x003CDBCC
	public bg()
	{
		base.Slots.Add(bg.a, new cgo(new c6s(ms.n, 14), "Основные детали арбалета", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bg.b, new cgo(new c6s(new ms[]
		{
			ms.q,
			ms.p,
			ms.o
		}, 15), "Улучшение арбалета", true, 1, 0f, false, false, null));
		base.Slots.Add(bg.c, new cgo(new c6s(new ms[]
		{
			ms.q,
			ms.p,
			ms.o
		}, 15), "Улучшение арбалета", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009BAB RID: 39851 RVA: 0x003CFA8C File Offset: 0x003CDC8C
	public List<bj8> bz()
	{
		int num = 1;
		int num2 = 4;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 5; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("crossbow.{0}.parts", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.r", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 2, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.s", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 3, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.d", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 4, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.f", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.g", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 6, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.rs", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 2, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 3, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.rd", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 2, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 4, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.rf", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 2, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 5, num2 + i), 1f));
			list.Add(bj);
			bj = new bj8();
			bj.a(string.Format("crossbow.{0}.rg", i + 1));
			bj.a().Add(new d8h(a_, new Point(num + 1, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 2, num2 + i), 1f));
			bj.a().Add(new d8h(a_, new Point(num + 6, num2 + i), 1f));
			list.Add(bj);
		}
		return list;
	}

	// Token: 0x06009BAC RID: 39852 RVA: 0x003CFFCC File Offset: 0x003CE1CC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bg.a, null);
		fv fv2 = A_1.SafeGet(bg.b, null);
		fv fv3 = A_1.SafeGet(bg.c, null);
		if (fv != null)
		{
			if (fv2 == null || fv3 == null || fv2.TypedDefinition.i() != fv3.TypedDefinition.i())
			{
				double a_ = cwp.a(fv);
				b1j? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpread", null);
				string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
				bke bke = new bke();
				bke.a(AmmoType.Bolts);
				bke.d(1.0);
				bke.b(new double?((double)fv.SingleItemValue));
				bke.h(fv.SingleItemWeight);
				bke.g((int)Math.Ceiling(a_));
				bke.a(fv.TypedDefinition.bc());
				bke.a(bhx.g);
				bke.a(0.1f);
				bke.b(0.10000000149011612);
				bke.a(ItemStealingCategory.Weapon);
				bke.a(a0.h);
				c4r.a(bke, btz.f, WeaponSubtype.Crossbow, fv.TypedDefinition);
				if (A_0 != null && A_0.Feats.Contains<ng>())
				{
					bke bke2 = bke;
					bke2.c(bke2.y() + (ng.a + (double)A_0.GetSpecializationValue<dhp>(true) * dhp.a));
				}
				bool flag = (fv2 != null && fv2.TypedDefinition.i() == ms.q) || (fv3 != null && fv3.TypedDefinition.i() == ms.q);
				bool flag2 = (fv2 != null && fv2.TypedDefinition.a5() == "reflexSight") || (fv3 != null && fv3.TypedDefinition.a5() == "reflexSight");
				object obj = (fv2 != null && fv2.TypedDefinition.i() == ms.p) || (fv3 != null && fv3.TypedDefinition.i() == ms.p);
				bool flag3 = (fv2 != null && fv2.TypedDefinition.i() == ms.o) || (fv3 != null && fv3.TypedDefinition.i() == ms.o);
				float num = 1f;
				if (fv2 != null)
				{
					this.a(bke, fv2, ref num, ref A_2);
				}
				if (fv3 != null)
				{
					this.a(bke, fv3, ref num, ref A_2);
				}
				b1j b1j = c4r.a(A_0, WeaponSubtype.Crossbow, a_, (double)num, primitivePropertyValue, null);
				bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
				bke.f(fv.TypedDefinition.a3().Substring(0, fv.TypedDefinition.a3().Length - 6));
				bke.g("арбалет");
				bke.i(qv.b("Items\\Weapons/" + bke.a3()));
				if (!string.IsNullOrWhiteSpace(classPropertyValue))
				{
					bke.g(classPropertyValue + " " + bke.az());
				}
				object obj2 = obj;
				if ((obj2 | flag) != null)
				{
					bke bke3 = bke;
					bke3.f(bke3.a3() + ".");
				}
				if (flag3)
				{
					bke.g("Мощн. " + bke.az());
					bke bke4 = bke;
					bke4.i(bke4.a0() + " В нём используется очень мощная тетива.");
				}
				if (obj2 != null)
				{
					bke.g("Пневматическ. " + bke.az());
					bke bke5 = bke;
					bke5.f(bke5.a3() + "r");
					bke bke6 = bke;
					bke6.i(bke6.a0() + " Скорость перезарядки повышена, благодаря пневматическому зарядному механизму, установленному по бокам.");
				}
				if (flag)
				{
					if (flag2)
					{
						bke.g("Тактическ. " + bke.az());
					}
					else
					{
						bke.g("Оснащённ. прицелом " + bke.az());
					}
					fv fv4 = (fv2 != null && fv2.TypedDefinition.i() == ms.q) ? fv2 : fv3;
					if (fv4 != null)
					{
						if (fv4.TypedDefinition.a5() == "anatomicallyAwareScope")
						{
							bke bke7 = bke;
							bke7.i(bke7.a0() + " Прицел со встроенным компьютером способен распознавать анатомию млекопитающих и насекомых.");
							bke bke8 = bke;
							bke8.f(bke8.a3() + "d");
						}
						else if (fv4.TypedDefinition.a5() == "highResolutionDigitalScope")
						{
							bke bke9 = bke;
							bke9.i(bke9.a0() + " Цифровой прицел облегчает точность стрельбы, благодаря захвату цели.");
							bke bke10 = bke;
							bke10.f(bke10.a3() + "f");
						}
						else if (fv4.TypedDefinition.a5() == "reflexSight")
						{
							bke bke11 = bke;
							bke11.i(bke11.a0() + " Имеет коллиматорный прицел, позволяющий быстро захватывать цель.");
							bke bke12 = bke;
							bke12.f(bke12.a3() + "g");
						}
						else
						{
							bke bke13 = bke;
							bke13.i(bke13.a0() + " Точность стрельбы повышена, благодаря установленному прицелу.");
							bke bke14 = bke;
							bke14.f(bke14.a3() + "s");
						}
					}
				}
				bke bke15 = bke;
				bke15.b(bke15.bf() * (double)3);
				if (fv2 != null && fv3 != null)
				{
					bke bke16 = bke;
					bke16.b(bke16.bf() * 1.2);
				}
				return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
			}
			A_2 = "Нельзя установить два улучшения одного типа.";
		}
		return null;
	}

	// Token: 0x06009BAD RID: 39853 RVA: 0x003D05F4 File Offset: 0x003CE7F4
	private void a(bke A_0, fv A_1, ref float A_2, ref string A_3)
	{
		double num = 0.0;
		if (A_1.TypedDefinition.i() == ms.q)
		{
			if (A_1.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("IsGrenadeLauncherScope", new bool?(false)).Value)
			{
				A_3 = "Несовместимый тип прицела.";
				return;
			}
			e6l.a(A_1).a(A_0, 1.0);
			num = 2.0;
		}
		else if (A_1.TypedDefinition.i() == ms.o)
		{
			A_2 = A_1.TypedDefinition.a7().GetPrimitivePropertyValue<float>("DamageModifier", new float?(A_2)).Value;
			A_0.a(bhx.f);
			num = 3.0;
		}
		else if (A_1.TypedDefinition.i() == ms.p)
		{
			A_0.a(A_0.v() - A_1.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ApCostReduction", new int?(0)).Value);
			num = 2.0;
		}
		int num2 = (int)Math.Min(A_0.bf().Value * num, (double)A_1.SingleItemValue);
		A_0.b(A_0.bf() + (double)num2);
		A_0.h(A_0.a4() + A_1.SingleItemWeight);
	}

	// Token: 0x04003B8A RID: 15242
	public new static readonly string a = "basicParts";

	// Token: 0x04003B8B RID: 15243
	public new static readonly string b = "enhancement1";

	// Token: 0x04003B8C RID: 15244
	public static readonly string c = "enhancement2";
}
