using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B83 RID: 7043
[dgg("advancedHealthHypo")]
public sealed class drk : cwp
{
	// Token: 0x060098C4 RID: 39108 RVA: 0x003BA598 File Offset: 0x003B8798
	public override string bt()
	{
		return "莑Улучшенный стимулятор";
	}

	// Token: 0x060098C5 RID: 39109 RVA: 0x003BA5A0 File Offset: 0x003B87A0
	public override string bu()
	{
		return "advancedHealthHypo";
	}

	// Token: 0x060098C6 RID: 39110 RVA: 0x003BA5A8 File Offset: 0x003B87A8
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060098C7 RID: 39111 RVA: 0x003BA5AC File Offset: 0x003B87AC
	public override int dq()
	{
		return 1;
	}

	// Token: 0x060098C8 RID: 39112 RVA: 0x003BA5B0 File Offset: 0x003B87B0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060098C9 RID: 39113 RVA: 0x003BA5B8 File Offset: 0x003B87B8
	public drk()
	{
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 3, 0.1f, false, false, null));
		base.Slots.Add("electrolyte", new cgo(new eh0("organicGelElectrolyte", 68), "Органический гель-электролит", false, 1, 0.1f, false, false, null));
		base.Slots.Add("taurine", new cgo(new eh0("taurine", 69), "Таурин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098CA RID: 39114 RVA: 0x003BA688 File Offset: 0x003B8888
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("blood", null);
		fv fv2 = A_1.SafeGet("electrolyte", null);
		fv fv3 = A_1.SafeGet("taurine", null);
		fv fv4 = A_1.SafeGet("syringe", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\AdvancedHealthHypo" + c6o.a(A_0));
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003A8F RID: 14991
	private new const string a = "blood";

	// Token: 0x04003A90 RID: 14992
	private new const string b = "electrolyte";

	// Token: 0x04003A91 RID: 14993
	private const string c = "taurine";

	// Token: 0x04003A92 RID: 14994
	private new const string d = "syringe";
}
