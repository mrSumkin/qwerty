using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB2 RID: 7090
[dgg("flashbang")]
public sealed class bq2 : cwp
{
	// Token: 0x06009A11 RID: 39441 RVA: 0x003C01D8 File Offset: 0x003BE3D8
	public override string bt()
	{
		return "荢Светошумовая граната";
	}

	// Token: 0x06009A12 RID: 39442 RVA: 0x003C01E0 File Offset: 0x003BE3E0
	public override string bu()
	{
		return "flashbang";
	}

	// Token: 0x06009A13 RID: 39443 RVA: 0x003C01E8 File Offset: 0x003BE3E8
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009A14 RID: 39444 RVA: 0x003C01EC File Offset: 0x003BE3EC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x06009A15 RID: 39445 RVA: 0x003C01F0 File Offset: 0x003BE3F0
	public bq2()
	{
		base.Slots.Add(bq2.a, new cgo(new eh0("thinGrenadeCase", 36), "Тонкий корпус гранаты", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bq2.b, new cgo(new eh0(new string[]
		{
			"Component.MagnesiumPowder"
		}, 68), "Порошок магния", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A16 RID: 39446 RVA: 0x003C026C File Offset: 0x003BE46C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bq2.a, null);
		fv fv2 = A_1.SafeGet(bq2.b, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			string path = "grenades\\flashbang";
			ez2.GetItemDefinition<cdk>(path, true);
			return new acz(ez2.CreateDefinitonProvider<cdk>(path));
		}
		return null;
	}

	// Token: 0x04003ADA RID: 15066
	public new static readonly string a = "case";

	// Token: 0x04003ADB RID: 15067
	public new static readonly string b = "magnesium";
}
