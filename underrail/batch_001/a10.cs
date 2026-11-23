using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B95 RID: 7061
[dgg("PsiInhalant")]
public sealed class a10 : cwp
{
	// Token: 0x06009944 RID: 39236 RVA: 0x003BBF8C File Offset: 0x003BA18C
	public override string bt()
	{
		return "莣Пси-ингалянт";
	}

	// Token: 0x06009945 RID: 39237 RVA: 0x003BBF94 File Offset: 0x003BA194
	public override string bu()
	{
		return "PsiInhalant";
	}

	// Token: 0x06009946 RID: 39238 RVA: 0x003BBF9C File Offset: 0x003BA19C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009947 RID: 39239 RVA: 0x003BBFA0 File Offset: 0x003BA1A0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009948 RID: 39240 RVA: 0x003BBFA8 File Offset: 0x003BA1A8
	public a10()
	{
		base.Slots.Add("catalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 3, 0.1f, false, false, null));
		base.Slots.Add("oxygenTank", new cgo(new eh0("smallOxygenTank", 107), "Малый кислородный баллон", false, 1, 0.1f, false, false, null));
		base.Slots.Add("filter", new cgo(new eh0("spongeFilter", 108), "Губчатые фильтры", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009949 RID: 39241 RVA: 0x003BC04C File Offset: 0x003BA24C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\psiInhalant");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}

	// Token: 0x04003AAE RID: 15022
	private new const string a = "catalyst";

	// Token: 0x04003AAF RID: 15023
	private new const string b = "oxygenTank";

	// Token: 0x04003AB0 RID: 15024
	private const string c = "filter";
}
