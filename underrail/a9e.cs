using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA4 RID: 7076
[dgg("twitch")]
public sealed class a9e : cwp
{
	// Token: 0x060099AF RID: 39343 RVA: 0x003BEC08 File Offset: 0x003BCE08
	public override string bt()
	{
		return "莩Рывок";
	}

	// Token: 0x060099B0 RID: 39344 RVA: 0x003BEC10 File Offset: 0x003BCE10
	public override string bu()
	{
		return "twitch";
	}

	// Token: 0x060099B1 RID: 39345 RVA: 0x003BEC18 File Offset: 0x003BCE18
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099B2 RID: 39346 RVA: 0x003BEC1C File Offset: 0x003BCE1C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060099B3 RID: 39347 RVA: 0x003BEC24 File Offset: 0x003BCE24
	public a9e()
	{
		base.Slots.Add("adrenaline", new cgo(new eh0("adrenaline", 53), "Адреналин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("dexytol", new cgo(new eh0("dexytol", 55), "Декситол", false, 1, 0.1f, false, false, null));
		base.Slots.Add("retrolyticEnzyme", new cgo(new eh0("retrolyticEnzyme", 53), "Ретролитический фермент", false, 1, 0.1f, false, false, null));
		base.Slots.Add("ampule", new cgo(new c6s(new ms[]
		{
			ms.f
		}, 5), "Ампула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099B4 RID: 39348 RVA: 0x003BECFC File Offset: 0x003BCEFC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Xpbl\\Twitch");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
