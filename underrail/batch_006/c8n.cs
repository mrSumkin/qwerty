using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B7D RID: 7037
[dgg("chemicalAmmo")]
public sealed class c8n : cwp
{
	// Token: 0x06009899 RID: 39065 RVA: 0x003B9184 File Offset: 0x003B7384
	public override string bt()
	{
		return "莁Химический боеприпас";
	}

	// Token: 0x0600989A RID: 39066 RVA: 0x003B918C File Offset: 0x003B738C
	public override string bu()
	{
		return "chemicalAmmo";
	}

	// Token: 0x0600989B RID: 39067 RVA: 0x003B9194 File Offset: 0x003B7394
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600989C RID: 39068 RVA: 0x003B9198 File Offset: 0x003B7398
	public override int dq()
	{
		return 10;
	}

	// Token: 0x0600989D RID: 39069 RVA: 0x003B919C File Offset: 0x003B739C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600989E RID: 39070 RVA: 0x003B91A0 File Offset: 0x003B73A0
	public c8n()
	{
		base.Slots.Add(c8n.a, new cgo(new eh0(new string[]
		{
			"acid.regular",
			"acid.corrosive",
			"acid.rusting",
			"liquidNitrogen",
			"Component.Gasoline",
			"Component.MagnesiumPowder",
			"Component.NapalmC"
		}, 55), "Химикат", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c8n.b, new cgo(new eh0("bondingAgent", 53), "Связующее вещество", false, 1, 0.1f, false, false, null));
		base.Slots.Add(c8n.c, new cgo(new eh0("vial", 54), "Колба", false, 10, 0.1f, false, false, null));
	}

	// Token: 0x0600989F RID: 39071 RVA: 0x003B9280 File Offset: 0x003B7480
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(c8n.a, null);
		fv fv2 = A_1.SafeGet(c8n.b, null);
		fv fv3 = A_1.SafeGet(c8n.c, null);
		if (fv != null && fv2 != null && fv3 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null && fv3.TypedDefinition != null)
		{
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("ChemicalAmmo");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string path = "ammo\\" + classPropertyValue;
				if (ez2.GetItemDefinition<dgr>(path, true) != null)
				{
					int value = fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ChemicalAmmoMultiplier", new int?(1)).Value;
					return new dng(ez2.CreateDefinitonProvider<dgr>(path))
					{
						Stacks = value
					};
				}
			}
			A_2 = "Нельзя создать боеприпас из этого химиката.";
		}
		return null;
	}

	// Token: 0x04003A7E RID: 14974
	public new static readonly string a = "chem";

	// Token: 0x04003A7F RID: 14975
	public new static readonly string b = "bondingAgent";

	// Token: 0x04003A80 RID: 14976
	public static readonly string c = "vial";
}
