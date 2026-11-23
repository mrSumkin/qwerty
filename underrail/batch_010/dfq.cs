using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BCD RID: 7117
[dgg("repairKit")]
public sealed class dfq : cwp
{
	// Token: 0x06009AD3 RID: 39635 RVA: 0x003C5A8C File Offset: 0x003C3C8C
	public override string bt()
	{
		return "茅Ремонтный набор";
	}

	// Token: 0x06009AD4 RID: 39636 RVA: 0x003C5A94 File Offset: 0x003C3C94
	public override string bu()
	{
		return "repairKit";
	}

	// Token: 0x06009AD5 RID: 39637 RVA: 0x003C5A9C File Offset: 0x003C3C9C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009AD6 RID: 39638 RVA: 0x003C5AA0 File Offset: 0x003C3CA0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009AD7 RID: 39639 RVA: 0x003C5AA4 File Offset: 0x003C3CA4
	public dfq()
	{
		base.Slots.Add("primaryScraps", new cgo(new eh0(new string[]
		{
			"metalScraps",
			"electronicScraps",
			"fabricScraps"
		}, 59), "Детали", false, 40, 0.1f, false, false, null));
		base.Slots.Add("secondaryScraps", new cgo(new eh0(new string[]
		{
			"metalScraps",
			"electronicScraps",
			"fabricScraps"
		}, 59), "Детали", true, 40, 1f, false, false, null));
	}

	// Token: 0x06009AD8 RID: 39640 RVA: 0x003C5B4C File Offset: 0x003C3D4C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("primaryScraps", null);
		fv fv2 = A_1.SafeGet("secondaryScraps", null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("RepairKitName");
			if (classPropertyValue != null)
			{
				int num = 1;
				if (fv2 != null && fv2.TypedDefinition != null)
				{
					if (fv2.TypedDefinition.a5() != fv.TypedDefinition.a5())
					{
						A_2 = "Нельзя сочетать разные типы деталей.";
						return null;
					}
					num = 2;
				}
				bit bit = ez2.CreateDefinitonProvider<ebz>(string.Format("Devices\\{0}{1}", classPropertyValue, num));
				if (bit != null)
				{
					return new d48(bit);
				}
			}
		}
		return null;
	}

	// Token: 0x04003B26 RID: 15142
	private new const string a = "primaryScraps";

	// Token: 0x04003B27 RID: 15143
	private new const string b = "secondaryScraps";
}
