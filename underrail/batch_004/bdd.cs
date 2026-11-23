using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BE3 RID: 7139
[dgg("MetalArmor")]
public sealed class bdd : cwp
{
	// Token: 0x06009B76 RID: 39798 RVA: 0x003CCC8C File Offset: 0x003CAE8C
	public override string bt()
	{
		return "茒Металлический доспех";
	}

	// Token: 0x06009B77 RID: 39799 RVA: 0x003CCC94 File Offset: 0x003CAE94
	public override string bu()
	{
		return "MetalArmor";
	}

	// Token: 0x06009B78 RID: 39800 RVA: 0x003CCC9C File Offset: 0x003CAE9C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B79 RID: 39801 RVA: 0x003CCCA0 File Offset: 0x003CAEA0
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B7A RID: 39802 RVA: 0x003CCCA4 File Offset: 0x003CAEA4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009B7B RID: 39803 RVA: 0x003CCCA8 File Offset: 0x003CAEA8
	public bdd()
	{
		base.Slots.Add(bdd.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bdd.b, new cgo(new c6s(ms.aa, 20), "Разгрузочный жилет", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bdd.c, new cgo(new c6s(new ms[]
		{
			ms.ad,
			ms.ac
		}, 24), "Улучшение 1", true, 1, 0.1f, false, false, null));
		base.Slots.Add(bdd.d, new cgo(new c6s(new ms[]
		{
			ms.ad,
			ms.ac
		}, 24), "Улучшение 2", true, 1, 0.1f, false, false, null));
		base.Slots.Add(bdd.e, new cgo(new c6s(new ms[]
		{
			ms.ad,
			ms.ac
		}, 24), "Улучшение 3", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B7C RID: 39804 RVA: 0x003CCDC8 File Offset: 0x003CAFC8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bdd.a, null);
		fv fv2 = A_1.SafeGet(bdd.b, null);
		if (fv != null && fv2 != null)
		{
			ett ett = fv.TypedDefinition as ett;
			ett ett2 = fv2.TypedDefinition as ett;
			if (ett != null && ett2 != null)
			{
				string text = ett.a7().GetClassPropertyValue<string>("Material") ?? "";
				c43 c = new c43();
				c.a(ett.bc());
				c.b(new double?((double)((fv.SingleItemValue + fv2.SingleItemValue) * 3)));
				c.h(fv.SingleItemWeight);
				c.g((int)Math.Ceiling(cwp.a(fv)));
				c.a("mt");
				c.a(new ai5?(ai5.g));
				c.g(ett2.a7().GetClassPropertyValue<string>("VestType") + " " + text + " доспех");
				c.a(ItemStealingCategory.ArmorHeavy);
				c.a(a0.l);
				c8d c8d = new c8d(new IndependentItemDefinitionProvider<c43>(c));
				c6o.a(c, ett, fv.QualityLevel);
				c6o.a(A_0, c8d, ett, fv.QualityLevel, false, 1.0, true);
				c6o.a(c, ett2, fv2.QualityLevel);
				c6o.a(A_0, c8d, ett2, fv2.QualityLevel, false, 1.0, true);
				for (int i = 0; i < c.i().Count; i++)
				{
					if (c.i()[i].b() == DamageType.Electricity)
					{
						du2 value = c.i()[i];
						value = new du2(DamageType.Electricity, (value.a() == 0) ? 0 : Math.Max(1, value.a() / 2), (value.c() == 0.0) ? 0.0 : Math.Max(0.01, value.c() / 2.0));
						c.i()[i] = value;
						break;
					}
				}
				if (A_0 != null && A_0.Feats.Contains<e>())
				{
					c6o.a(c, new du2(DamageType.Mechanical, global::e.a + A_0.GetSpecializationValue<av3>(true) * av3.a, 0.0));
				}
				if (ett2.a5() == "sturdyVest")
				{
					c6o.a(c, new dxd(fv2.QualityLevel));
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				int num = 1;
				this.a(A_0, A_1.SafeGet(bdd.c, null), c8d, ref flag, ref flag2, ref flag3, ref num);
				this.a(A_0, A_1.SafeGet(bdd.d, null), c8d, ref flag, ref flag2, ref flag3, ref num);
				this.a(A_0, A_1.SafeGet(bdd.e, null), c8d, ref flag, ref flag2, ref flag3, ref num);
				if (flag2)
				{
					c.g("Покрыт. лезвиями " + c.az());
				}
				if (flag)
				{
					c.g("Шипованн. " + c.az());
				}
				c.i(string.Format("Это комплект {0} брони. Под защитными пластинами {1}.", text.ToLowerInvariant(), ett2.a7().GetClassPropertyValue<string>("ArmorDescription2")));
				if (flag3)
				{
					c43 c2 = c;
					c2.i(c2.a0() + " Он усилен дополнительными металлическими пластинами.");
				}
				if (flag2 && flag)
				{
					c43 c3 = c;
					c3.i(c3.a0() + " Он усеян лезвиями и шипами, наносящими дополнительный урон вашим оппонентам в рукопашной.");
				}
				else if (flag2)
				{
					c43 c4 = c;
					c4.i(c4.a0() + " Он усеян зазубренными лезвиями, наносящими дополнительный урон вашим оппонентам в рукопашной.");
				}
				else if (flag)
				{
					c43 c5 = c;
					c5.i(c5.a0() + " Он усеян шипами, наносящими дополнительный урон вашим оппонентам в рукопашной.");
				}
				c.f("Armor.Metal." + ett.a7().GetClassPropertyValue<string>("Material").Replace(" ", ""));
				if (flag2 || flag)
				{
					c43 c6 = c;
					c6.f(c6.a3() + ".Offensive");
				}
				if (num > 0)
				{
					c43 c7 = c;
					c7.b(c7.bf() * (1.0 + (double)num * 0.1));
				}
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("MetalArmorVisualVariant");
				if (classPropertyValue != null)
				{
					c.a(classPropertyValue);
				}
				return c8d;
			}
		}
		return null;
	}

	// Token: 0x06009B7D RID: 39805 RVA: 0x003CD294 File Offset: 0x003CB494
	private void a(efk A_0, fv A_1, c8d A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref int A_6)
	{
		if (A_1 != null)
		{
			ett ett = A_1.TypedDefinition as ett;
			if (ett != null)
			{
				if (!A_3)
				{
					A_3 = ett.a7().GetPrimitivePropertyValue<bool>("IsSpike", new bool?(false)).Value;
				}
				if (!A_4)
				{
					A_4 = ett.a7().GetPrimitivePropertyValue<bool>("IsBlade", new bool?(false)).Value;
				}
				bool value = ett.a7().GetPrimitivePropertyValue<bool>("IsMetalPlate", new bool?(false)).Value;
				if (!A_5)
				{
					A_5 = value;
				}
				c6o.a(A_2.fu(), ett, A_1.QualityLevel);
				c6o.a(A_0, A_2, ett, A_1.QualityLevel / 2, value, value ? 0.35 : 1.0, true);
				c43 c = A_2.fu();
				c.b(c.bf() + (double)A_1.SingleItemValue);
				if (value)
				{
					bk3 bk = A_2.Definition;
					bk.h(bk.a4() + Math.Round(A_1.SingleItemWeight / 10.0, 1));
				}
				else
				{
					bk3 bk2 = A_2.Definition;
					bk2.h(bk2.a4() + A_1.SingleItemWeight);
				}
				A_6++;
			}
		}
	}

	// Token: 0x04003B74 RID: 15220
	public new static readonly string a = "metalPlate";

	// Token: 0x04003B75 RID: 15221
	public new static readonly string b = "carrier";

	// Token: 0x04003B76 RID: 15222
	public static readonly string c = "enhancement1";

	// Token: 0x04003B77 RID: 15223
	public new static readonly string d = "enhancement2";

	// Token: 0x04003B78 RID: 15224
	public static readonly string e = "enhancement3";
}
