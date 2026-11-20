using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BAD RID: 7085
[dgg("theJuice")]
public sealed class ber : cwp
{
	// Token: 0x060099EF RID: 39407 RVA: 0x003BFB8C File Offset: 0x003BDD8C
	public override string bt()
	{
		return "莪Сок";
	}

	// Token: 0x060099F0 RID: 39408 RVA: 0x003BFB94 File Offset: 0x003BDD94
	public override string bu()
	{
		return "theJuice";
	}

	// Token: 0x060099F1 RID: 39409 RVA: 0x003BFB9C File Offset: 0x003BDD9C
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x060099F2 RID: 39410 RVA: 0x003BFBA0 File Offset: 0x003BDDA0
	public override int dq()
	{
		return 1;
	}

	// Token: 0x060099F3 RID: 39411 RVA: 0x003BFBA4 File Offset: 0x003BDDA4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060099F4 RID: 39412 RVA: 0x003BFBA8 File Offset: 0x003BDDA8
	public ber()
	{
		base.Slots.Add("mushroomBrew", new cgo(new eh0("food.mushroomBrew", 87), "Грибной самогон", false, 1, 0.1f, false, false, null));
		base.Slots.Add("psiCatalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 3, 0.1f, false, false, null));
		base.Slots.Add("morphine", new cgo(new eh0("morphine", 65), "Морфин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("gyromitrin", new cgo(new eh0("gyromitrin", 57), "Гиромитрин", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x060099F5 RID: 39413 RVA: 0x003BFC7C File Offset: 0x003BDE7C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\TheJuice");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
