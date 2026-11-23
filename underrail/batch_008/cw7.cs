using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B86 RID: 7046
[dgg("aegis")]
public sealed class cw7 : cwp
{
	// Token: 0x060098D6 RID: 39126 RVA: 0x003BAB20 File Offset: 0x003B8D20
	public override string bt()
	{
		return "莙Эгида";
	}

	// Token: 0x060098D7 RID: 39127 RVA: 0x003BAB28 File Offset: 0x003B8D28
	public override string bu()
	{
		return "aegis";
	}

	// Token: 0x060098D8 RID: 39128 RVA: 0x003BAB30 File Offset: 0x003B8D30
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060098D9 RID: 39129 RVA: 0x003BAB34 File Offset: 0x003B8D34
	public override int dq()
	{
		return 1;
	}

	// Token: 0x060098DA RID: 39130 RVA: 0x003BAB38 File Offset: 0x003B8D38
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060098DB RID: 39131 RVA: 0x003BAB40 File Offset: 0x003B8D40
	public cw7()
	{
		base.Slots.Add("adrenaline", new cgo(new eh0("adrenaline", 53), "Необработанный адреналин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("morphine", new cgo(new eh0("morphine", 65), "Необработанный морфин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("gizzardEnzymes", new cgo(new eh0("gizzardEnzymes", 74), "Желудочные ферменты", false, 1, 0.1f, false, false, null));
		base.Slots.Add("ampule", new cgo(new c6s(new ms[]
		{
			ms.f
		}, 5), "Ампула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098DC RID: 39132 RVA: 0x003BAC18 File Offset: 0x003B8E18
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("adrenaline", null);
		fv fv2 = A_1.SafeGet("morphine", null);
		fv fv3 = A_1.SafeGet("gizzardEnzymes", null);
		fv fv4 = A_1.SafeGet("ampule", null);
		if (fv != null && fv.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Aegis");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003A96 RID: 14998
	private new const string a = "adrenaline";

	// Token: 0x04003A97 RID: 14999
	private new const string b = "morphine";

	// Token: 0x04003A98 RID: 15000
	private const string c = "gizzardEnzymes";

	// Token: 0x04003A99 RID: 15001
	private new const string d = "ampule";
}
