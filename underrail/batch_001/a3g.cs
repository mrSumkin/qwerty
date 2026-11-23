using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA6 RID: 7078
[dgg("psionicAccelerator")]
public sealed class a3g : cwp
{
	// Token: 0x060099BB RID: 39355 RVA: 0x003BEE5C File Offset: 0x003BD05C
	public override string bt()
	{
		return "莡Пси-ускоритель";
	}

	// Token: 0x060099BC RID: 39356 RVA: 0x003BEE64 File Offset: 0x003BD064
	public override string bu()
	{
		return "psionicAccelerator";
	}

	// Token: 0x060099BD RID: 39357 RVA: 0x003BEE6C File Offset: 0x003BD06C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099BE RID: 39358 RVA: 0x003BEE70 File Offset: 0x003BD070
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060099BF RID: 39359 RVA: 0x003BEE78 File Offset: 0x003BD078
	public a3g()
	{
		base.Slots.Add("catalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 2, 0.1f, false, false, null));
		base.Slots.Add("gyromitrin", new cgo(new eh0("gyromitrin", 57), "Гиромитрин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("psiSomaticAgent", new cgo(new eh0("psiSomaticAgent", 53), "Пси-соматический агент", false, 1, 0.1f, false, false, null));
		base.Slots.Add("ampule", new cgo(new c6s(new ms[]
		{
			ms.f
		}, 5), "Ампула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099C0 RID: 39360 RVA: 0x003BEF50 File Offset: 0x003BD150
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Xpbl\\PsionicAccelerator");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
