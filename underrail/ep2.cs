using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB1 RID: 7089
[dgg("PsiReinvigorator")]
public sealed class ep2 : cwp
{
	// Token: 0x06009A0B RID: 39435 RVA: 0x003C00C0 File Offset: 0x003BE2C0
	public override string bt()
	{
		return "莤Пси-активатор";
	}

	// Token: 0x06009A0C RID: 39436 RVA: 0x003C00C8 File Offset: 0x003BE2C8
	public override string bu()
	{
		return "PsiReinvigorator";
	}

	// Token: 0x06009A0D RID: 39437 RVA: 0x003C00D0 File Offset: 0x003BE2D0
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A0E RID: 39438 RVA: 0x003C00D4 File Offset: 0x003BE2D4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A0F RID: 39439 RVA: 0x003C00D8 File Offset: 0x003BE2D8
	public ep2()
	{
		base.Slots.Add("catalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 5, 0.1f, false, false, null));
		base.Slots.Add("adrenaline", new cgo(new eh0("adrenaline", 53), "Адреналин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("statolith", new cgo(new eh0("statolith", 55), "Статолит", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A10 RID: 39440 RVA: 0x003C01A8 File Offset: 0x003BE3A8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		bit a_ = ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\psiReinvigorator");
		if (base.b(A_1))
		{
			return new d48(a_);
		}
		return null;
	}
}
