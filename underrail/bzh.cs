using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BDA RID: 7130
[dgg("Goggles")]
public sealed class bzh : cwp
{
	// Token: 0x06009B30 RID: 39728 RVA: 0x003C92A8 File Offset: 0x003C74A8
	public override string bt()
	{
		return "茔Тактические очки";
	}

	// Token: 0x06009B31 RID: 39729 RVA: 0x003C92B0 File Offset: 0x003C74B0
	public override string bu()
	{
		return "Goggles";
	}

	// Token: 0x06009B32 RID: 39730 RVA: 0x003C92B8 File Offset: 0x003C74B8
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B33 RID: 39731 RVA: 0x003C92BC File Offset: 0x003C74BC
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B34 RID: 39732 RVA: 0x003C92C0 File Offset: 0x003C74C0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x06009B35 RID: 39733 RVA: 0x003C92C8 File Offset: 0x003C74C8
	public bzh()
	{
		base.Slots.Add(bzh.a, new cgo(new c6s(ms.aw, 41), "Линзы или объектив", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bzh.b, new cgo(new c6s(ms.av, 42), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bzh.c, new cgo(new c6s(ms.ax, 43), "Модуль обработки изображения", true, 1, 0.1f, false, false, null));
		base.Slots.Add(bzh.d, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", true, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B36 RID: 39734 RVA: 0x003C9390 File Offset: 0x003C7590
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bzh.a, null);
		fv fv2 = A_1.SafeGet(bzh.b, null);
		if (fv != null && fv2 != null)
		{
			a1k a1k = fv.TypedDefinition;
			a1k a1k2 = fv2.TypedDefinition;
			if (a1k != null && a1k2 != null)
			{
				bqu bqu = new bqu();
				bqu.a(a1k.bc());
				bqu.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
				bqu.h(fv.SingleItemWeight + fv2.SingleItemWeight);
				bqu.g((int)Math.Ceiling(cwp.a(fv)));
				bqu.e(true);
				bqu.f("Helmet.Goggles.L:" + (a1k.a7().GetClassPropertyValue<string>("NamePrefix") ?? "").Replace(" ", ""));
				bqu.a(a0.o);
				bqu.g("очки");
				this.a(fv, bqu);
				fv fv3 = A_1.SafeGet(bzh.c, null);
				a1k a1k3 = (fv3 != null) ? fv3.TypedDefinition : null;
				fv fv4 = A_1.SafeGet(bzh.d, null);
				a1k a1k4 = (fv4 != null) ? fv4.TypedDefinition : null;
				int num = 0;
				if (a1k4 != null)
				{
					num = c6o.a(fv4, A_0);
				}
				if (a1k3 != null && a1k4 == null)
				{
					A_2 = "Для питания модуля обработки изображения необходимо энергетическое ядро.";
				}
				else if (a1k3 == null && a1k4 != null)
				{
					A_2 = "Энергетическое ядро ничего не питает.";
				}
				else if (a1k3 != null && a1k4 != null)
				{
					bqu.i(false);
					string classPropertyValue = a1k3.a7().GetClassPropertyValue<string>("Prefix");
					if (!string.IsNullOrEmpty(classPropertyValue))
					{
						bqu.g(classPropertyValue + " " + bqu.az());
					}
					bqu.f("Helmet.Goggles.M:" + a1k3.a7().GetClassPropertyValue<string>("IconParam"));
					string classPropertyValue2 = a1k3.a7().GetClassPropertyValue<string>("Capability");
					double value = a1k3.a7().GetPrimitivePropertyValue<double>("PowerPerTurnCost", new double?((double)1)).Value;
					double num2 = (double)((int)Math.Min(value * 3.0, (double)(num / 2)));
					if (classPropertyValue2 != null)
					{
						bqu.a2().Add(new aia(classPropertyValue2));
						bqu.a7()["PowerPerTurnCost"] = value;
						bqu.a7()["PowerOnCost"] = num2;
					}
					bqu.a(ItemRepairCategory.Electronic);
					bqu bqu2 = bqu;
					bqu2.b(bqu2.bf() + (double)(fv3.SingleItemValue + fv4.SingleItemValue));
					bqu bqu3 = bqu;
					bqu3.h(bqu3.a4() + (fv3.SingleItemWeight + fv4.SingleItemWeight));
					bqu.g((int)Math.Max((double)bqu.a8(), Math.Ceiling(cwp.a(fv3))));
				}
				if (a1k3 != null && a1k4 != null)
				{
					bqu.i(string.Format("Эти тактические очки имеют {0} и {1}.", a1k.a7().GetClassPropertyValue<string>("DescPlural"), a1k3.a7().GetClassPropertyValue<string>("Desc")));
				}
				else
				{
					bqu.i(string.Format("Эти тактические очки имеют {0}.", a1k.a7().GetClassPropertyValue<string>("DescPlural")));
				}
				string classPropertyValue3 = a1k.a7().GetClassPropertyValue<string>("NamePrefix");
				if (!string.IsNullOrEmpty(classPropertyValue3))
				{
					bqu.g(classPropertyValue3 + " " + bqu.az());
				}
				bqu bqu4 = bqu;
				bqu4.b(bqu4.bf() * (double)2);
				coh result = new k7(new IndependentItemDefinitionProvider<bqu>(bqu));
				bqu.c(new int?(num));
				return result;
			}
		}
		return null;
	}

	// Token: 0x06009B37 RID: 39735 RVA: 0x003C97BC File Offset: 0x003C79BC
	private void a(fv A_0, bqu A_1)
	{
		int value = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<int>("PerceptionModifier", new int?(0)).Value;
		if (value != 0)
		{
			A_1.ar().Add(new ax6("Perception", value));
		}
		float value2 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<float>("DodgeModifier", new float?(0f)).Value;
		if (value2 != 0f)
		{
			A_1.ar().Add(new d19(value2)
			{
				Priority = int.MaxValue
			});
		}
		double value3 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseCritChanceBonus", new double?(0.0)).Value;
		double value4 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("CritChanceBonusPerQuality", new double?(0.0)).Value;
		double num = value3 + value4 * (double)A_0.QualityLevel;
		if (num != 0.0)
		{
			dvq item = new dvq(num, cs5.c);
			A_1.ar().Add(item);
		}
		double value5 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseSpecialAttackBonus", new double?(0.0)).Value;
		double value6 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("SpecialAttackBonusPerQuality", new double?(0.0)).Value;
		double num2 = value5 + value6 * (double)A_0.QualityLevel;
		if (num2 != 0.0)
		{
			efx item2 = new efx(num2, cs5.c);
			A_1.ar().Add(item2);
		}
		double value7 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("BaseDetectionModifier", new double?(0.0)).Value;
		double value8 = A_0.TypedDefinition.a7().GetPrimitivePropertyValue<double>("DetectionModifierPerQuality", new double?(0.0)).Value;
		double num3 = value7 + value8 * (double)A_0.QualityLevel;
		if (num3 != 0.0)
		{
			d0d item3 = new d0d((float)num3);
			A_1.ar().Add(item3);
		}
	}

	// Token: 0x04003B53 RID: 15187
	public new static readonly string a = "lens";

	// Token: 0x04003B54 RID: 15188
	public new static readonly string b = "frame";

	// Token: 0x04003B55 RID: 15189
	public static readonly string c = "module";

	// Token: 0x04003B56 RID: 15190
	public new static readonly string d = "core";
}
