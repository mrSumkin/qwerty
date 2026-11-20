using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BC7 RID: 7111
[dgg("mechanicalBolt")]
public sealed class e57 : cwp
{
	// Token: 0x06009AA8 RID: 39592 RVA: 0x003C3438 File Offset: 0x003C1638
	public override string bt()
	{
		return "莃Зазубренный болт";
	}

	// Token: 0x06009AA9 RID: 39593 RVA: 0x003C3440 File Offset: 0x003C1640
	public override string bu()
	{
		return "mechanicalBolt";
	}

	// Token: 0x06009AAA RID: 39594 RVA: 0x003C3448 File Offset: 0x003C1648
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009AAB RID: 39595 RVA: 0x003C344C File Offset: 0x003C164C
	public override int dq()
	{
		return 10;
	}

	// Token: 0x06009AAC RID: 39596 RVA: 0x003C3450 File Offset: 0x003C1650
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009AAD RID: 39597 RVA: 0x003C3454 File Offset: 0x003C1654
	public e57()
	{
		base.Slots.Add(e57.a, new cgo(new eh0("Ammo.Bolt", 33), "Болт", false, 10, 0.1f, false, false, null));
		base.Slots.Add(e57.b, new cgo(new eh0(new string[]
		{
			"Component.SerratedSteelBlade",
			"Component.SerratedTungstenSteelBlade",
			"Component.SerratedTiChromeBlade"
		}, 63), "Зазубренное лезвие", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009AAE RID: 39598 RVA: 0x003C34E4 File Offset: 0x003C16E4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		dng dng = A_1.SafeGet(e57.a, null);
		fv fv = A_1.SafeGet(e57.b, null);
		if (dng != null && dng.TypedDefinition != null && fv != null && fv.TypedDefinition != null)
		{
			string text = "serratedBolt";
			if (!string.IsNullOrEmpty(text))
			{
				string path = "ammo\\" + text;
				if (ez2.GetItemDefinition<cdk>(path, true) != null)
				{
					return new acz(ez2.CreateDefinitonProvider<cdk>(path));
				}
			}
			A_2 = "Нельзя использовать этот материал.";
		}
		return null;
	}

	// Token: 0x04003B13 RID: 15123
	public new static readonly string a = "bolt";

	// Token: 0x04003B14 RID: 15124
	public new static readonly string b = "tipMat";
}
