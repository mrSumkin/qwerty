using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BDB RID: 7131
[dgg("MetalHelmet")]
public sealed class dae : cwp
{
	// Token: 0x06009B39 RID: 39737 RVA: 0x003C9A30 File Offset: 0x003C7C30
	public override string bt()
	{
		return "茓Металлический шлем";
	}

	// Token: 0x06009B3A RID: 39738 RVA: 0x003C9A38 File Offset: 0x003C7C38
	public override string bu()
	{
		return "MetalHelmet";
	}

	// Token: 0x06009B3B RID: 39739 RVA: 0x003C9A40 File Offset: 0x003C7C40
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B3C RID: 39740 RVA: 0x003C9A44 File Offset: 0x003C7C44
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B3D RID: 39741 RVA: 0x003C9A48 File Offset: 0x003C7C48
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009B3E RID: 39742 RVA: 0x003C9A4C File Offset: 0x003C7C4C
	public dae()
	{
		base.Slots.Add(dae.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, true, false, null));
		base.Slots.Add(dae.b, new cgo(new c6s(ms.e, 2), "Подкладка", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dae.c, new cgo(new eh0(new string[]
		{
			"visor",
			"shadedVisor"
		}, 40), "Щиток", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dae.d, new cgo(new eh0(new string[]
		{
			"headlight"
		}, 109), "Налобный фонарь", true, 1, 0.1f, false, false, null));
		base.Slots.Add(dae.e, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B3F RID: 39743 RVA: 0x003C9B5C File Offset: 0x003C7D5C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dae.a, null);
		fv fv2 = A_1.SafeGet(dae.b, null);
		fv fv3 = A_1.SafeGet(dae.c, null);
		if (fv != null && fv2 != null && fv3 != null)
		{
			ett ett = fv.TypedDefinition as ett;
			ett ett2 = fv2.TypedDefinition as ett;
			a1k a1k = fv3.TypedDefinition;
			if (ett != null && ett2 != null && a1k != null)
			{
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("Material");
				bqu bqu = new bqu();
				bqu.a(ett.bc());
				bqu.b(new double?((double)((fv.SingleItemValue + fv2.SingleItemValue + fv3.SingleItemValue) * 2)));
				bqu.h(Math.Round(fv.SingleItemWeight / 20.0, 2) + Math.Round(fv2.SingleItemWeight / 3.0, 2) + fv3.SingleItemWeight);
				bqu.g((int)Math.Ceiling(cwp.a(fv)));
				bqu.a(ItemStealingCategory.Armor);
				bqu.a(a0.p);
				k7 k = new k7(new IndependentItemDefinitionProvider<bqu>(bqu));
				c6o.a(bqu, ett, fv.QualityLevel);
				c6o.a(A_0, k, ett, fv.QualityLevel, true, 0.3, true);
				c6o.a(A_0, k, ett2, fv2.QualityLevel, false, 0.3499999940395355, true);
				double num = 1.0;
				if (A_0 != null && A_0.Feats.Contains<dcs>() && ett2.i() == ms.ac)
				{
					num -= dcs.a + (double)A_0.GetSpecializationValue<b4e>(true) * b4e.a;
				}
				bqu bqu2 = bqu;
				bqu2.b(bqu2.h() + ett2.f() * num / 2.0);
				bqu.b(0);
				double value = ett.a7().GetPrimitivePropertyValue<double>("HelmetCritModifier", new double?(0.0)).Value;
				double value2 = ett2.a7().GetPrimitivePropertyValue<double>("MetalHelmetCritModifierBase", new double?((double)1)).Value;
				double value3 = ett2.a7().GetPrimitivePropertyValue<double>("MetalHelmetCritModifierPerQuality", new double?(0.0)).Value;
				double num2 = value * (value2 + value3 * (double)fv2.QualityLevel);
				bqu.ar().Add(new l5(-num2));
				string text = ett.a7().GetClassPropertyValue<string>("Material") ?? "";
				bqu.f("Helmet.Metal." + text.Replace(" ", ""));
				bqu.g(classPropertyValue + " шлем");
				bqu.i(string.Format("Это {0} шлем.", classPropertyValue.ToLowerInvariant()));
				string classPropertyValue2 = ett2.a7().GetClassPropertyValue<string>("MetalHelmetPrefix");
				if (!string.IsNullOrEmpty(classPropertyValue2))
				{
					bqu.g(classPropertyValue2 + " " + bqu.az());
				}
				string classPropertyValue3 = ett2.a7().GetClassPropertyValue<string>("MetalHelmetDesc");
				if (!string.IsNullOrEmpty(classPropertyValue3))
				{
					bqu bqu3 = bqu;
					bqu3.i(bqu3.a0() + " " + classPropertyValue3);
				}
				if (a1k.a5() == "shadedVisor")
				{
					bqu.g("Затенённый " + bqu.az());
					bqu bqu4 = bqu;
					bqu4.f(bqu4.a3() + ".Shaded");
					bqu.ar().Add(new awe(CharacterImmunities.Blind));
				}
				c6o.a(bqu, new ax6("Perception", -1));
				c6o.a(bqu, new d0d(-0.3f)
				{
					Priority = int.MaxValue
				});
				fv fv4 = A_1.SafeGet(dae.d, null);
				a1k a1k2 = (fv4 != null) ? fv4.TypedDefinition : null;
				fv fv5 = A_1.SafeGet(dae.e, null);
				a1k a1k3 = (fv5 != null) ? fv5.TypedDefinition : null;
				if (a1k3 != null)
				{
					bqu.c(new int?(c6o.a(fv5, A_0)));
				}
				if (a1k2 != null && a1k3 == null)
				{
					A_2 = "Для питания налобного фонаря необходимо энергетическое ядро.";
				}
				else if (a1k2 == null && a1k3 != null)
				{
					A_2 = "Энергетическое ядро ничего не питает.";
				}
				else if (a1k2 != null && a1k3 != null)
				{
					bqu.i(false);
					bqu.@as().Add(new aia("HelmetLanternAura"));
					bqu.a7()["helmetLanternQuality"] = fv4.QualityLevel;
					bqu.a(ItemRepairCategory.Electronic);
					bqu bqu5 = bqu;
					bqu5.b(bqu5.bf() + (double)(fv4.SingleItemValue + fv5.SingleItemValue));
					bqu bqu6 = bqu;
					bqu6.h(bqu6.a4() + (fv4.SingleItemWeight + fv5.SingleItemWeight));
					bqu bqu7 = bqu;
					bqu7.b(bqu7.bf() * 1.25);
					bqu bqu8 = bqu;
					bqu8.g(bqu8.az() + " с налобным фонарём");
					bqu bqu9 = bqu;
					bqu9.i(bqu9.a0() + " Он оборудован тактическим фонарём.");
					bqu bqu10 = bqu;
					bqu10.f(bqu10.a3() + ".Headlight");
				}
				return k;
			}
		}
		return null;
	}

	// Token: 0x04003B57 RID: 15191
	public new static readonly string a = "metalPlate";

	// Token: 0x04003B58 RID: 15192
	public new static readonly string b = "padding";

	// Token: 0x04003B59 RID: 15193
	public static readonly string c = "visor";

	// Token: 0x04003B5A RID: 15194
	public new static readonly string d = "headlight";

	// Token: 0x04003B5B RID: 15195
	public static readonly string e = "core";
}
