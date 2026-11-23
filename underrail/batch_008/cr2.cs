using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BEE RID: 7150
[dgg("PsiBooster")]
public sealed class cr2 : cwp
{
	// Token: 0x06009BC9 RID: 39881 RVA: 0x003D0ED4 File Offset: 0x003CF0D4
	public override string bt()
	{
		return "莠Пси-усилитель";
	}

	// Token: 0x06009BCA RID: 39882 RVA: 0x003D0EDC File Offset: 0x003CF0DC
	public override string bu()
	{
		return "PsiBooster";
	}

	// Token: 0x06009BCB RID: 39883 RVA: 0x003D0EE4 File Offset: 0x003CF0E4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009BCC RID: 39884 RVA: 0x003D0EE8 File Offset: 0x003CF0E8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009BCD RID: 39885 RVA: 0x003D0EF0 File Offset: 0x003CF0F0
	public cr2()
	{
		base.Slots.Add("catalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 3, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009BCE RID: 39886 RVA: 0x003D0F60 File Offset: 0x003CF160
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("catalyst", null);
		fv fv2 = A_1.SafeGet("syringe", null);
		bit bit = ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\psiBooster");
		if (bit != null && bit.wl() != null && bit.wl().a5() != null && fv != null && fv2 != null)
		{
			return new d48(bit);
		}
		return null;
	}

	// Token: 0x04003B9E RID: 15262
	private new const string a = "catalyst";

	// Token: 0x04003B9F RID: 15263
	private new const string b = "syringe";
}
