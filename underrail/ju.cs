using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B92 RID: 7058
[dgg("lockpicks")]
public sealed class ju : cwp
{
	// Token: 0x06009931 RID: 39217 RVA: 0x003BBBF0 File Offset: 0x003B9DF0
	public override string bt()
	{
		return "荎Отмычки";
	}

	// Token: 0x06009932 RID: 39218 RVA: 0x003BBBF8 File Offset: 0x003B9DF8
	public override string bu()
	{
		return "lockpicks";
	}

	// Token: 0x06009933 RID: 39219 RVA: 0x003BBC00 File Offset: 0x003B9E00
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009934 RID: 39220 RVA: 0x003BBC04 File Offset: 0x003B9E04
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009935 RID: 39221 RVA: 0x003BBC08 File Offset: 0x003B9E08
	public ju()
	{
		base.Slots.Add(ju.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009936 RID: 39222 RVA: 0x003BBC48 File Offset: 0x003B9E48
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(ju.a, null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string str = "";
			if (fv.QualityLevel >= 100)
			{
				str = "3";
			}
			else if (fv.QualityLevel >= 50)
			{
				str = "2";
			}
			if (ez2.GetItemDefinition<ebz>("Devices\\Lockpick" + str, true) != null)
			{
				d48 d = new d48(ez2.CreateDefinitonProvider<ebz>("Devices\\Lockpick" + str));
				d.Stacks = 5;
				if (fv.QualityLevel > 100)
				{
					d.Stacks += (fv.QualityLevel - 100) / 15;
				}
				return d;
			}
		}
		return null;
	}

	// Token: 0x04003AAD RID: 15021
	public new static readonly string a = "metal";
}
