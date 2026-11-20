using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BCE RID: 7118
[dgg("healthHypo")]
public sealed class ayg : cwp
{
	// Token: 0x06009AD9 RID: 39641 RVA: 0x003C5C0C File Offset: 0x003C3E0C
	public override string bt()
	{
		return "莐Стимулятор";
	}

	// Token: 0x06009ADA RID: 39642 RVA: 0x003C5C14 File Offset: 0x003C3E14
	public override string bu()
	{
		return "healthHypo";
	}

	// Token: 0x06009ADB RID: 39643 RVA: 0x003C5C1C File Offset: 0x003C3E1C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x003C5C20 File Offset: 0x003C3E20
	public override int dq()
	{
		return 2;
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x003C5C24 File Offset: 0x003C3E24
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009ADE RID: 39646 RVA: 0x003C5C28 File Offset: 0x003C3E28
	public ayg()
	{
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 3, 0.1f, false, false, null));
		base.Slots.Add("saliva", new cgo(new eh0("insectoidSaliva", 57), "Слюна насекомого", false, 1, 0.1f, false, false, null));
		base.Slots.Add("anticoagulant", new cgo(new eh0("anticoagulant", 53), "Антикоагулянт", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x06009ADF RID: 39647 RVA: 0x003C5CF8 File Offset: 0x003C3EF8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("blood", null);
		fv fv2 = A_1.SafeGet("saliva", null);
		fv fv3 = A_1.SafeGet("anticoagulant", null);
		fv fv4 = A_1.SafeGet("syringe", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\HealthHypo" + c6o.a(A_0));
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003B28 RID: 15144
	private new const string a = "blood";

	// Token: 0x04003B29 RID: 15145
	private new const string b = "saliva";

	// Token: 0x04003B2A RID: 15146
	private const string c = "anticoagulant";

	// Token: 0x04003B2B RID: 15147
	private new const string d = "syringe";
}
