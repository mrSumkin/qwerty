using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B7F RID: 7039
[dgg("adrenalineShot")]
public sealed class c9e : cwp
{
	// Token: 0x060098A7 RID: 39079 RVA: 0x003B960C File Offset: 0x003B780C
	public override string bt()
	{
		return "莗Инъекция адреналина";
	}

	// Token: 0x060098A8 RID: 39080 RVA: 0x003B9614 File Offset: 0x003B7814
	public override string bu()
	{
		return "adrenalineShot";
	}

	// Token: 0x060098A9 RID: 39081 RVA: 0x003B961C File Offset: 0x003B781C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060098AA RID: 39082 RVA: 0x003B9620 File Offset: 0x003B7820
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060098AB RID: 39083 RVA: 0x003B9628 File Offset: 0x003B7828
	public c9e()
	{
		base.Slots.Add("adrenaline", new cgo(new eh0("adrenaline", 53), "Адреналин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098AC RID: 39084 RVA: 0x003B9698 File Offset: 0x003B7898
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("adrenaline", null);
		fv fv2 = A_1.SafeGet("syringe", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\AdrenalineShot");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003A85 RID: 14981
	private new const string a = "adrenaline";

	// Token: 0x04003A86 RID: 14982
	private new const string b = "syringe";
}
