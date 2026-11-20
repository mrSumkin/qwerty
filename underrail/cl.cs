using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B9A RID: 7066
[dgg("throwingNet")]
public sealed class cl : cwp
{
	// Token: 0x06009967 RID: 39271 RVA: 0x003BC42C File Offset: 0x003BA62C
	public override string bt()
	{
		return "荷Ловчая сеть";
	}

	// Token: 0x06009968 RID: 39272 RVA: 0x003BC434 File Offset: 0x003BA634
	public override string bu()
	{
		return "throwingNet";
	}

	// Token: 0x06009969 RID: 39273 RVA: 0x003BC43C File Offset: 0x003BA63C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600996A RID: 39274 RVA: 0x003BC440 File Offset: 0x003BA640
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x0600996B RID: 39275 RVA: 0x003BC444 File Offset: 0x003BA644
	public cl()
	{
		base.Slots.Add("scraps", new cgo(new eh0(new string[]
		{
			"fabricScraps"
		}, 106), "Детали", false, 50, 0.1f, false, false, null));
	}

	// Token: 0x0600996C RID: 39276 RVA: 0x003BC494 File Offset: 0x003BA694
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		bit bit = ez2.CreateDefinitonProvider<cdk>("Devices\\ThrowingNet");
		if (bit != null)
		{
			return new acz(bit);
		}
		return null;
	}

	// Token: 0x04003AB6 RID: 15030
	private new const string a = "scraps";
}
