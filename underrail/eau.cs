using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B8D RID: 7053
[dgg("fragMineCase")]
public sealed class eau : cwp
{
	// Token: 0x0600990D RID: 39181 RVA: 0x003BB610 File Offset: 0x003B9810
	public override string bt()
	{
		return "荳Корпус осколочной мины";
	}

	// Token: 0x0600990E RID: 39182 RVA: 0x003BB618 File Offset: 0x003B9818
	public override string bu()
	{
		return "fragMineCase";
	}

	// Token: 0x0600990F RID: 39183 RVA: 0x003BB620 File Offset: 0x003B9820
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009910 RID: 39184 RVA: 0x003BB624 File Offset: 0x003B9824
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009911 RID: 39185 RVA: 0x003BB628 File Offset: 0x003B9828
	public eau()
	{
		base.Slots.Add(eau.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009912 RID: 39186 RVA: 0x003BB668 File Offset: 0x003B9868
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(eau.a, null);
		if (fv != null && fv.TypedDefinition != null && ez2.GetItemDefinition<a1k>("Components\\Containers\\FragMineCase", true) != null)
		{
			return new fv(ez2.CreateDefinitonProvider<a1k>("Components\\Containers\\FragMineCase"))
			{
				Stacks = 3 + fv.QualityLevel / 45
			};
		}
		return null;
	}

	// Token: 0x04003AAC RID: 15020
	public new static readonly string a = "metal";
}
