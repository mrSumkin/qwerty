using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B80 RID: 7040
[dgg("caltrops")]
public sealed class d6m : cwp
{
	// Token: 0x060098AD RID: 39085 RVA: 0x003B9700 File Offset: 0x003B7900
	public override string bt()
	{
		return "荶Колючки";
	}

	// Token: 0x060098AE RID: 39086 RVA: 0x003B9708 File Offset: 0x003B7908
	public override string bu()
	{
		return "caltrops";
	}

	// Token: 0x060098AF RID: 39087 RVA: 0x003B9710 File Offset: 0x003B7910
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060098B0 RID: 39088 RVA: 0x003B9714 File Offset: 0x003B7914
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x060098B1 RID: 39089 RVA: 0x003B971C File Offset: 0x003B791C
	public d6m()
	{
		base.Slots.Add(d6m.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d6m.b, new cgo(new c6s(new ms[]
		{
			ms.aq
		}, 5), "Яд", true, 1, 0f, false, false, null));
	}

	// Token: 0x060098B2 RID: 39090 RVA: 0x003B9794 File Offset: 0x003B7994
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(d6m.a, null);
		fv fv2 = A_1.SafeGet(d6m.b, null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string text = "";
			if (fv2 != null && fv2.TypedDefinition != null)
			{
				text = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("PoisonCode");
				if (!string.IsNullOrEmpty(text))
				{
					text = text.Replace(" ", "");
				}
			}
			string path = string.Format("Devices\\{0}Caltrops", text);
			if (ez2.GetItemDefinition<cdk>(path, true) != null)
			{
				acz acz = new acz(ez2.CreateDefinitonProvider<cdk>(path));
				if (!string.IsNullOrEmpty(text))
				{
					acz.Stacks = 5;
				}
				else
				{
					acz.Stacks = 10;
				}
				return acz;
			}
			A_2 = "Нельзя использовать этот химикат.";
		}
		return null;
	}

	// Token: 0x04003A87 RID: 14983
	public new static readonly string a = "metal";

	// Token: 0x04003A88 RID: 14984
	public new static readonly string b = "poison";
}
