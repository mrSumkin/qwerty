using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B8C RID: 7052
[dgg("fragGrenadeCase")]
public sealed class cs7 : cwp
{
	// Token: 0x06009906 RID: 39174 RVA: 0x003BB548 File Offset: 0x003B9748
	public override string bt()
	{
		return "荨Корпус осколочной гранаты";
	}

	// Token: 0x06009907 RID: 39175 RVA: 0x003BB550 File Offset: 0x003B9750
	public override string bu()
	{
		return "fragGrenadeCase";
	}

	// Token: 0x06009908 RID: 39176 RVA: 0x003BB558 File Offset: 0x003B9758
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009909 RID: 39177 RVA: 0x003BB55C File Offset: 0x003B975C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x0600990A RID: 39178 RVA: 0x003BB564 File Offset: 0x003B9764
	public cs7()
	{
		base.Slots.Add(cs7.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x0600990B RID: 39179 RVA: 0x003BB5A4 File Offset: 0x003B97A4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cs7.a, null);
		if (fv != null && fv.TypedDefinition != null && ez2.GetItemDefinition<a1k>("Components\\Containers\\FragGrenadeCase", true) != null)
		{
			return new fv(ez2.CreateDefinitonProvider<a1k>("Components\\Containers\\FragGrenadeCase"))
			{
				Stacks = 5 + fv.QualityLevel / 30
			};
		}
		return null;
	}

	// Token: 0x04003AAB RID: 15019
	public new static readonly string a = "metal";
}
