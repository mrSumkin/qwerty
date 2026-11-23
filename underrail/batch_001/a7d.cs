using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BBE RID: 7102
[dgg("irongut")]
public sealed class a7d : cwp
{
	// Token: 0x06009A6D RID: 39533 RVA: 0x003C16E0 File Offset: 0x003BF8E0
	public override string bt()
	{
		return "莝Стальной желудок";
	}

	// Token: 0x06009A6E RID: 39534 RVA: 0x003C16E8 File Offset: 0x003BF8E8
	public override string bu()
	{
		return "irongut";
	}

	// Token: 0x06009A6F RID: 39535 RVA: 0x003C16F0 File Offset: 0x003BF8F0
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A70 RID: 39536 RVA: 0x003C16F4 File Offset: 0x003BF8F4
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009A71 RID: 39537 RVA: 0x003C16F8 File Offset: 0x003BF8F8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A72 RID: 39538 RVA: 0x003C1700 File Offset: 0x003BF900
	public a7d()
	{
		base.Slots.Add("taurine", new cgo(new eh0("taurine", 69), "Таурин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("gizzardEnzymes", new cgo(new eh0("gizzardEnzymes", 74), "Желудочные ферменты", false, 1, 0.1f, false, false, null));
		base.Slots.Add("capsule", new cgo(new eh0("capsule", 73), "Капсула", false, 3, 0.1f, false, false, null));
	}

	// Token: 0x06009A73 RID: 39539 RVA: 0x003C17A4 File Offset: 0x003BF9A4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("taurine", null);
		fv fv2 = A_1.SafeGet("gizzardEnzymes", null);
		fv fv3 = A_1.SafeGet("capsule", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Irongut");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003AFE RID: 15102
	private new const string a = "taurine";

	// Token: 0x04003AFF RID: 15103
	private new const string b = "gizzardEnzymes";

	// Token: 0x04003B00 RID: 15104
	private const string c = "capsule";
}
