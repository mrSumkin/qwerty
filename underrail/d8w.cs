using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB3 RID: 7091
[dgg("infusedLeather")]
public sealed class d8w : cwp
{
	// Token: 0x06009A18 RID: 39448 RVA: 0x003C02EC File Offset: 0x003BE4EC
	public override string bt()
	{
		return "茗Укреплённая кожа";
	}

	// Token: 0x06009A19 RID: 39449 RVA: 0x003C02F4 File Offset: 0x003BE4F4
	public override string bu()
	{
		return "infusedLeather";
	}

	// Token: 0x06009A1A RID: 39450 RVA: 0x003C02FC File Offset: 0x003BE4FC
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x06009A1B RID: 39451 RVA: 0x003C0300 File Offset: 0x003BE500
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009A1C RID: 39452 RVA: 0x003C0304 File Offset: 0x003BE504
	public d8w()
	{
		base.Slots.Add(d8w.a, new cgo(new c6r(1), "Кожа", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d8w.b, new cgo(new eh0(new string[]
		{
			"supersteelFiber"
		}, 79), "Волокно", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A1D RID: 39453 RVA: 0x003C037C File Offset: 0x003BE57C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(d8w.a, null);
		fv fv2 = A_1.SafeGet(d8w.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("SourceCreature");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string classPropertyValue2 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("DLC");
				string text = string.IsNullOrEmpty(classPropertyValue2) ? "" : (classPropertyValue2 + "\\");
				string classPropertyValue3 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("CustomInfusionLeatherType");
				string classPropertyValue4 = fv.TypedDefinition.a7().GetClassPropertyValue<string>("CustomInfusionLeatherTypeFilenameSuffix");
				string path = string.Concat(new string[]
				{
					"components\\Leather\\",
					text,
					"Infused",
					classPropertyValue.Replace(" ", ""),
					(classPropertyValue4 ?? classPropertyValue3) ?? "Leather"
				});
				if (ez2.GetItemDefinition<a1k>(path, true) != null)
				{
					fv fv3 = new fv(ez2.CreateDefinitonProvider<a1k>(path));
					int num = (int)((double)fv.QualityLevel * 0.55 + (double)fv2.QualityLevel * 0.75);
					int num2 = Math.Min(100, num);
					if (num > 100)
					{
						int i = num - 100;
						double num3 = 1.0;
						while (i > 0)
						{
							num3 *= 0.8;
							int num4 = Math.Min(i, 15);
							i -= num4;
							num2 += (int)(num3 * (double)num4);
						}
					}
					if (fv.QualityLevel > num2 && fv2.QualityLevel > num2)
					{
						num2 = fv.QualityLevel;
					}
					fv3.QualityLevel = num2;
					return fv3;
				}
			}
			A_2 = "Эту кожу нельзя укрепить волокном";
		}
		return null;
	}

	// Token: 0x04003ADC RID: 15068
	public new static readonly string a = "leather";

	// Token: 0x04003ADD RID: 15069
	public new static readonly string b = "fiber";
}
