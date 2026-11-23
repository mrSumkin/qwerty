using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BC5 RID: 7109
[dgg("morphineShot")]
public sealed class af1 : cwp
{
	// Token: 0x06009A9B RID: 39579 RVA: 0x003C31FC File Offset: 0x003C13FC
	public override string bt()
	{
		return "莚Инъекция морфина";
	}

	// Token: 0x06009A9C RID: 39580 RVA: 0x003C3204 File Offset: 0x003C1404
	public override string bu()
	{
		return "morphineShot";
	}

	// Token: 0x06009A9D RID: 39581 RVA: 0x003C320C File Offset: 0x003C140C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009A9E RID: 39582 RVA: 0x003C3210 File Offset: 0x003C1410
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A9F RID: 39583 RVA: 0x003C3218 File Offset: 0x003C1418
	public af1()
	{
		base.Slots.Add("morphine", new cgo(new eh0("morphine", 65), "Морфин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009AA0 RID: 39584 RVA: 0x003C3288 File Offset: 0x003C1488
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("morphine", null);
		fv fv2 = A_1.SafeGet("syringe", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\MorphineShot");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003B0F RID: 15119
	private new const string a = "morphine";

	// Token: 0x04003B10 RID: 15120
	private new const string b = "syringe";
}
