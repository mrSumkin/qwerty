using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B98 RID: 7064
[dgg("thinGrenadeCase")]
public sealed class bwk : cwp
{
	// Token: 0x06009958 RID: 39256 RVA: 0x003BC238 File Offset: 0x003BA438
	public override string bt()
	{
		return "荩Тонкий корпус гранаты";
	}

	// Token: 0x06009959 RID: 39257 RVA: 0x003BC240 File Offset: 0x003BA440
	public override string bu()
	{
		return "thinGrenadeCase";
	}

	// Token: 0x0600995A RID: 39258 RVA: 0x003BC248 File Offset: 0x003BA448
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600995B RID: 39259 RVA: 0x003BC24C File Offset: 0x003BA44C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x0600995C RID: 39260 RVA: 0x003BC250 File Offset: 0x003BA450
	public bwk()
	{
		base.Slots.Add(bwk.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x0600995D RID: 39261 RVA: 0x003BC290 File Offset: 0x003BA490
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bwk.a, null);
		if (fv != null && fv.TypedDefinition != null && ez2.GetItemDefinition<a1k>("Components\\Containers\\ThinGrenadeCase", true) != null)
		{
			return new fv(ez2.CreateDefinitonProvider<a1k>("Components\\Containers\\ThinGrenadeCase"))
			{
				Stacks = 5 + fv.QualityLevel / 30
			};
		}
		return null;
	}

	// Token: 0x04003AB2 RID: 15026
	public new static readonly string a = "metal";
}
