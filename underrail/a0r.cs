using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B89 RID: 7049
[dgg("bullhead")]
public sealed class a0r : cwp
{
	// Token: 0x060098EF RID: 39151 RVA: 0x003BB0AC File Offset: 0x003B92AC
	public override string bt()
	{
		return "莞Болван";
	}

	// Token: 0x060098F0 RID: 39152 RVA: 0x003BB0B4 File Offset: 0x003B92B4
	public override string bu()
	{
		return "bullhead";
	}

	// Token: 0x060098F1 RID: 39153 RVA: 0x003BB0BC File Offset: 0x003B92BC
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x060098F2 RID: 39154 RVA: 0x003BB0C0 File Offset: 0x003B92C0
	public override int dq()
	{
		return 2;
	}

	// Token: 0x060098F3 RID: 39155 RVA: 0x003BB0C4 File Offset: 0x003B92C4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060098F4 RID: 39156 RVA: 0x003BB0C8 File Offset: 0x003B92C8
	public a0r()
	{
		base.Slots.Add("morphine", new cgo(new eh0("morphine", 65), "Морфин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("nidamentalGel", new cgo(new eh0("nidamentalGel", 68), "Нидаментальный гель", false, 1, 0.1f, false, false, null));
		base.Slots.Add("gizzardEnzymes", new cgo(new eh0("gizzardEnzymes", 74), "Желудочные ферменты", false, 1, 0.1f, false, false, null));
		base.Slots.Add("capsule", new cgo(new eh0("capsule", 73), "Капсула", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x060098F5 RID: 39157 RVA: 0x003BB19C File Offset: 0x003B939C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("morphine", null);
		fv fv2 = A_1.SafeGet("gizzardEnzymes", null);
		fv fv3 = A_1.SafeGet("nidamentalGel", null);
		fv fv4 = A_1.SafeGet("capsule", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv4 != null && fv4.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Bullhead");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003AA2 RID: 15010
	private new const string a = "morphine";

	// Token: 0x04003AA3 RID: 15011
	private new const string b = "nidamentalGel";

	// Token: 0x04003AA4 RID: 15012
	private const string c = "gizzardEnzymes";

	// Token: 0x04003AA5 RID: 15013
	private new const string d = "capsule";
}
