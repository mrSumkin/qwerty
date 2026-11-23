using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BD6 RID: 7126
[dgg("chemicalBolt")]
public sealed class ci6 : cwp
{
	// Token: 0x06009B15 RID: 39701 RVA: 0x003C7F5C File Offset: 0x003C615C
	public override string bt()
	{
		return "莇Химический болт";
	}

	// Token: 0x06009B16 RID: 39702 RVA: 0x003C7F64 File Offset: 0x003C6164
	public override string bu()
	{
		return "chemicalBolt";
	}

	// Token: 0x06009B17 RID: 39703 RVA: 0x003C7F6C File Offset: 0x003C616C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B18 RID: 39704 RVA: 0x003C7F70 File Offset: 0x003C6170
	public override int dq()
	{
		return 5;
	}

	// Token: 0x06009B19 RID: 39705 RVA: 0x003C7F74 File Offset: 0x003C6174
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009B1A RID: 39706 RVA: 0x003C7F7C File Offset: 0x003C617C
	public ci6()
	{
		base.Slots.Add(ci6.a, new cgo(new eh0("Ammo.Bolt", 33), "Болт", false, 5, 0.1f, false, false, null));
		base.Slots.Add(ci6.b, new cgo(new c6s(ms.ao, 34), "Шприц", false, 5, 0.1f, false, false, null));
		base.Slots.Add(ci6.c, new cgo(new c6s(new ms[]
		{
			ms.aq,
			ms.ar,
			ms.a2
		}, 5), "Химикат", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B1B RID: 39707 RVA: 0x003C802C File Offset: 0x003C622C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		dng dng = A_1.SafeGet(ci6.a, null);
		fv fv = A_1.SafeGet(ci6.c, null);
		fv fv2 = A_1.SafeGet(ci6.b, null);
		if (dng != null && dng.TypedDefinition != null && fv != null && fv2 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null)
		{
			string text = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Bolt");
			if (string.IsNullOrEmpty(text))
			{
				string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("PoisonCode");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					text = string.Format("{0}Bolt", classPropertyValue);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				string path = "ammo\\" + text;
				if (ez2.GetItemDefinition<cdk>(path, true) != null)
				{
					return new acz(ez2.CreateDefinitonProvider<cdk>(path));
				}
			}
			A_2 = "Нельзя использовать этот химикат.";
		}
		return null;
	}

	// Token: 0x04003B47 RID: 15175
	public new static readonly string a = "bolt";

	// Token: 0x04003B48 RID: 15176
	public new static readonly string b = "syringe";

	// Token: 0x04003B49 RID: 15177
	public static readonly string c = "chemical";
}
