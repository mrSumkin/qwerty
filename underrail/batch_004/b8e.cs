using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B94 RID: 7060
[dgg("Motion")]
public sealed class b8e : cwp
{
	// Token: 0x0600993E RID: 39230 RVA: 0x003BBE34 File Offset: 0x003BA034
	public override string bt()
	{
		return "莥Движение";
	}

	// Token: 0x0600993F RID: 39231 RVA: 0x003BBE3C File Offset: 0x003BA03C
	public override string bu()
	{
		return "Motion";
	}

	// Token: 0x06009940 RID: 39232 RVA: 0x003BBE44 File Offset: 0x003BA044
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x06009941 RID: 39233 RVA: 0x003BBE48 File Offset: 0x003BA048
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009942 RID: 39234 RVA: 0x003BBE50 File Offset: 0x003BA050
	public b8e()
	{
		base.Slots.Add("catalyst", new cgo(new eh0("psionicCatalyst", 55), "Ненасыщенный псионический катализатор", false, 3, 0.1f, false, false, null));
		base.Slots.Add("gyromitrin", new cgo(new eh0("gyromitrin", 57), "Гиромитрин", false, 2, 0.1f, false, false, null));
		base.Slots.Add("spore", new cgo(new eh0("psychodelicSpore", 124), "Психоделическая спора", false, 10, 0.1f, false, false, null));
		base.Slots.Add("oxygenTank", new cgo(new eh0("smallOxygenTank", 107), "Малый кислородный баллон", false, 1, 0.1f, false, false, null));
		base.Slots.Add("filter", new cgo(new eh0("spongeFilter", 108), "Губчатые фильтры", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009943 RID: 39235 RVA: 0x003BBF54 File Offset: 0x003BA154
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\motion");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
