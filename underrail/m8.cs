using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BBB RID: 7099
[dgg("jumpingBean")]
public sealed class m8 : cwp
{
	// Token: 0x06009A59 RID: 39513 RVA: 0x003C12C8 File Offset: 0x003BF4C8
	public override string bt()
	{
		return "莗Прыгающий боб";
	}

	// Token: 0x06009A5A RID: 39514 RVA: 0x003C12D0 File Offset: 0x003BF4D0
	public override string bu()
	{
		return "jumpingBean";
	}

	// Token: 0x06009A5B RID: 39515 RVA: 0x003C12D8 File Offset: 0x003BF4D8
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A5C RID: 39516 RVA: 0x003C12DC File Offset: 0x003BF4DC
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009A5D RID: 39517 RVA: 0x003C12E0 File Offset: 0x003BF4E0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A5E RID: 39518 RVA: 0x003C12E8 File Offset: 0x003BF4E8
	public m8()
	{
		base.Slots.Add("electrolyte", new cgo(new eh0("organicGelElectrolyte", 68), "Органический гель-электролит", false, 1, 0.1f, false, false, null));
		base.Slots.Add("saliva", new cgo(new eh0("insectoidSaliva", 57), "Слюна насекомого", false, 1, 0.1f, false, false, null));
		base.Slots.Add("capsule", new cgo(new eh0("capsule", 73), "Капсула", false, 3, 0.1f, false, false, null));
	}

	// Token: 0x06009A5F RID: 39519 RVA: 0x003C138C File Offset: 0x003BF58C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("electrolyte", null);
		fv fv2 = A_1.SafeGet("saliva", null);
		fv fv3 = A_1.SafeGet("capsule", null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\JumpingBean");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003AF4 RID: 15092
	private new const string a = "electrolyte";

	// Token: 0x04003AF5 RID: 15093
	private new const string b = "saliva";

	// Token: 0x04003AF6 RID: 15094
	private const string c = "capsule";
}
