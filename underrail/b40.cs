using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BBD RID: 7101
[dgg("trance")]
public sealed class b40 : cwp
{
	// Token: 0x06009A67 RID: 39527 RVA: 0x003C15A4 File Offset: 0x003BF7A4
	public override string bt()
	{
		return "莧Транс";
	}

	// Token: 0x06009A68 RID: 39528 RVA: 0x003C15AC File Offset: 0x003BF7AC
	public override string bu()
	{
		return "trance";
	}

	// Token: 0x06009A69 RID: 39529 RVA: 0x003C15B4 File Offset: 0x003BF7B4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A6A RID: 39530 RVA: 0x003C15B8 File Offset: 0x003BF7B8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009A6B RID: 39531 RVA: 0x003C15BC File Offset: 0x003BF7BC
	public b40()
	{
		base.Slots.Add("PsiCatalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 3, 0.1f, false, false, null));
		base.Slots.Add("blackVitreous", new cgo(new eh0("blackVitreous", 68), "Чёрное стекло", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A6C RID: 39532 RVA: 0x003C165C File Offset: 0x003BF85C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("PsiCatalyst", null);
		fv fv2 = A_1.SafeGet("blackVitreous", null);
		fv fv3 = A_1.SafeGet("syringe", null);
		if (fv != null && fv.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Trance");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003AFB RID: 15099
	private new const string a = "PsiCatalyst";

	// Token: 0x04003AFC RID: 15100
	private new const string b = "blackVitreous";

	// Token: 0x04003AFD RID: 15101
	private const string c = "syringe";
}
