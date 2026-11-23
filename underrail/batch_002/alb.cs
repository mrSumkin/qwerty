using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B7E RID: 7038
[dgg("chemicalBlobTrap")]
public sealed class alb : cwp
{
	// Token: 0x060098A1 RID: 39073 RVA: 0x003B9388 File Offset: 0x003B7588
	public override string bt()
	{
		return "荸Химическая ловушка";
	}

	// Token: 0x060098A2 RID: 39074 RVA: 0x003B9390 File Offset: 0x003B7590
	public override string bu()
	{
		return "chemicalBlobTrap";
	}

	// Token: 0x060098A3 RID: 39075 RVA: 0x003B9398 File Offset: 0x003B7598
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060098A4 RID: 39076 RVA: 0x003B939C File Offset: 0x003B759C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Traps;
	}

	// Token: 0x060098A5 RID: 39077 RVA: 0x003B93A0 File Offset: 0x003B75A0
	public alb()
	{
		base.Slots.Add("casing", new cgo(new eh0("chemicalTrapCase", 56), "Корпус химической ловушки", false, 1, 0.1f, false, false, null));
		base.Slots.Add("dispenser", new cgo(new eh0("blobDispenser", 51), "Химический дозатор", false, 1, 0.1f, false, false, null));
		base.Slots.Add("bondingAgent", new cgo(new eh0("bondingAgent", 53), "Связующее вещество", false, 1, 0.1f, false, false, null));
		base.Slots.Add("chemical", new cgo(new eh0(new string[]
		{
			"acid.regular",
			"liquidNitrogen",
			"Component.Gasoline",
			"Component.MagnesiumPowder",
			"Component.NapalmC",
			"acid.corrosive",
			"acid.rusting"
		}, 55), "Химикат", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098A6 RID: 39078 RVA: 0x003B94AC File Offset: 0x003B76AC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("casing", null);
		fv fv2 = A_1.SafeGet("dispenser", null);
		fv fv3 = A_1.SafeGet("bondingAgent", null);
		fv fv4 = A_1.SafeGet("chemical", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			string classPropertyValue = fv4.TypedDefinition.a7().GetClassPropertyValue<string>("BlobTrap");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				int num;
				if (fv4.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("ChemicalPowerBlobTrap", new bool?(false)).Value)
				{
					num = fv4.TypedDefinition.a7().GetPrimitivePropertyValue<int>("power", new int?(1)).Value;
				}
				else if (fv2.QualityLevel >= 75)
				{
					num = 3;
				}
				else if (fv2.QualityLevel >= 55)
				{
					num = 2;
				}
				else
				{
					num = 1;
				}
				bit bit = ez2.CreateDefinitonProvider<c4j>(string.Format("Traps\\{0}{1}", classPropertyValue, num));
				if (bit != null)
				{
					return new d48(bit);
				}
			}
			else
			{
				A_2 = "Нельзя использовать этот химикат.";
			}
		}
		return null;
	}

	// Token: 0x04003A81 RID: 14977
	private new const string a = "casing";

	// Token: 0x04003A82 RID: 14978
	private new const string b = "dispenser";

	// Token: 0x04003A83 RID: 14979
	private const string c = "bondingAgent";

	// Token: 0x04003A84 RID: 14980
	private new const string d = "chemical";
}
