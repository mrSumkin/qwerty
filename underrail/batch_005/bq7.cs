using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BBC RID: 7100
[dgg("focusStim")]
public sealed class bq7 : cwp
{
	// Token: 0x06009A60 RID: 39520 RVA: 0x003C1410 File Offset: 0x003BF610
	public override string bt()
	{
		return "莦Стимулятор внимания";
	}

	// Token: 0x06009A61 RID: 39521 RVA: 0x003C1418 File Offset: 0x003BF618
	public override string bu()
	{
		return "focusStim";
	}

	// Token: 0x06009A62 RID: 39522 RVA: 0x003C1420 File Offset: 0x003BF620
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A63 RID: 39523 RVA: 0x003C1424 File Offset: 0x003BF624
	public override int dq()
	{
		return 1;
	}

	// Token: 0x06009A64 RID: 39524 RVA: 0x003C1428 File Offset: 0x003BF628
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A65 RID: 39525 RVA: 0x003C1430 File Offset: 0x003BF630
	public bq7()
	{
		base.Slots.Add("adrenaline", new cgo(new eh0("adrenaline", 53), "Необработанный адреналин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("taurine", new cgo(new eh0("taurine", 69), "Таурин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 3, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A66 RID: 39526 RVA: 0x003C1500 File Offset: 0x003BF700
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("adrenaline", null);
		fv fv2 = A_1.SafeGet("taurine", null);
		fv fv3 = A_1.SafeGet("blood", null);
		fv fv4 = A_1.SafeGet("syringe", null);
		if (fv != null && fv.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\FocusStim");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003AF7 RID: 15095
	private new const string a = "adrenaline";

	// Token: 0x04003AF8 RID: 15096
	private new const string b = "taurine";

	// Token: 0x04003AF9 RID: 15097
	private const string c = "blood";

	// Token: 0x04003AFA RID: 15098
	private new const string d = "syringe";
}
