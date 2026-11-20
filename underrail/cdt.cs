using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B93 RID: 7059
[dgg("nervosomnifer")]
public sealed class cdt : cwp
{
	// Token: 0x06009938 RID: 39224 RVA: 0x003BBD10 File Offset: 0x003B9F10
	public override string bt()
	{
		return "莛Нервосомнифер";
	}

	// Token: 0x06009939 RID: 39225 RVA: 0x003BBD18 File Offset: 0x003B9F18
	public override string bu()
	{
		return "nervosomnifer";
	}

	// Token: 0x0600993A RID: 39226 RVA: 0x003BBD20 File Offset: 0x003B9F20
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x0600993B RID: 39227 RVA: 0x003BBD24 File Offset: 0x003B9F24
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x0600993C RID: 39228 RVA: 0x003BBD28 File Offset: 0x003B9F28
	public cdt()
	{
		base.Slots.Add("morphine", new cgo(new eh0("morphine", 65), "Морфин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("spore", new cgo(new eh0("psychodelicSpore", 124), "Психоделическая спора", false, 30, 0.1f, false, false, null));
		base.Slots.Add("blackVitreous", new cgo(new eh0("blackVitreous", 68), "Чёрное стекло", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x0600993D RID: 39229 RVA: 0x003BBDFC File Offset: 0x003B9FFC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Nervosomnifer");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
