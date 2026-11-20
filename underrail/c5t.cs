using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB0 RID: 7088
[dgg("superHealthHypo")]
public sealed class c5t : cwp
{
	// Token: 0x06009A04 RID: 39428 RVA: 0x003BFF64 File Offset: 0x003BE164
	public override string bt()
	{
		return "莒Суперстимулятор";
	}

	// Token: 0x06009A05 RID: 39429 RVA: 0x003BFF6C File Offset: 0x003BE16C
	public override string bu()
	{
		return "superHealthHypo";
	}

	// Token: 0x06009A06 RID: 39430 RVA: 0x003BFF74 File Offset: 0x003BE174
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x06009A07 RID: 39431 RVA: 0x003BFF78 File Offset: 0x003BE178
	public override int dq()
	{
		return 1;
	}

	// Token: 0x06009A08 RID: 39432 RVA: 0x003BFF7C File Offset: 0x003BE17C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A09 RID: 39433 RVA: 0x003BFF80 File Offset: 0x003BE180
	public c5t()
	{
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 5, 0.1f, false, false, null));
		base.Slots.Add("fusingEnzyme", new cgo(new eh0("fusingEnzyme", 53), "Плавящий фермент", false, 1, 0.1f, false, false, null));
		base.Slots.Add("gyromitrin", new cgo(new eh0("gyromitrin", 57), "Гиромитрин", false, 3, 0.1f, false, false, null));
		base.Slots.Add("crawlerPoison", new cgo(new eh0("poison.CrawlerPoison", 57), "Яд краулера", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x06009A0A RID: 39434 RVA: 0x003C0080 File Offset: 0x003BE280
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\SuperHealthHypo" + c6o.a(A_0));
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
