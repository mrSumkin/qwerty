using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B97 RID: 7063
[dgg("thinMineCase")]
public sealed class bji : cwp
{
	// Token: 0x06009951 RID: 39249 RVA: 0x003BC170 File Offset: 0x003BA370
	public override string bt()
	{
		return "荴Тонкий корпус мины";
	}

	// Token: 0x06009952 RID: 39250 RVA: 0x003BC178 File Offset: 0x003BA378
	public override string bu()
	{
		return "thinMineCase";
	}

	// Token: 0x06009953 RID: 39251 RVA: 0x003BC180 File Offset: 0x003BA380
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009954 RID: 39252 RVA: 0x003BC184 File Offset: 0x003BA384
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009955 RID: 39253 RVA: 0x003BC18C File Offset: 0x003BA38C
	public bji()
	{
		base.Slots.Add(bji.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009956 RID: 39254 RVA: 0x003BC1CC File Offset: 0x003BA3CC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bji.a, null);
		if (fv != null && fv.TypedDefinition != null && ez2.GetItemDefinition<a1k>("Components\\Containers\\ThinMineCase", true) != null)
		{
			return new fv(ez2.CreateDefinitonProvider<a1k>("Components\\Containers\\ThinMineCase"))
			{
				Stacks = 3 + fv.QualityLevel / 45
			};
		}
		return null;
	}

	// Token: 0x04003AB1 RID: 15025
	public new static readonly string a = "metal";
}
