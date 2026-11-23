using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA3 RID: 7075
[dgg("thirdEye")]
public sealed class enm : cwp
{
	// Token: 0x060099A9 RID: 39337 RVA: 0x003BEAE4 File Offset: 0x003BCCE4
	public override string bt()
	{
		return "莫Третий глаз";
	}

	// Token: 0x060099AA RID: 39338 RVA: 0x003BEAEC File Offset: 0x003BCCEC
	public override string bu()
	{
		return "thirdEye";
	}

	// Token: 0x060099AB RID: 39339 RVA: 0x003BEAF4 File Offset: 0x003BCCF4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099AC RID: 39340 RVA: 0x003BEAF8 File Offset: 0x003BCCF8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060099AD RID: 39341 RVA: 0x003BEAFC File Offset: 0x003BCCFC
	public enm()
	{
		base.Slots.Add("salivinine", new cgo(new eh0("salivinine", 57), "Саливинин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("blackVitreous", new cgo(new eh0("blackVitreous", 68), "Чёрное стекло", false, 1, 0.1f, false, false, null));
		base.Slots.Add("lophimidrine", new cgo(new eh0("lophimidrine", 97), "Лофимидрин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("capsule", new cgo(new eh0("capsule", 73), "Капсула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099AE RID: 39342 RVA: 0x003BEBD0 File Offset: 0x003BCDD0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Xpbl\\ThirdEye");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
