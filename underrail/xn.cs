using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA0 RID: 7072
[dgg("coagulationShot")]
public sealed class xn : cwp
{
	// Token: 0x06009990 RID: 39312 RVA: 0x003BD3FC File Offset: 0x003BB5FC
	public override string bt()
	{
		return "莜Коагуляционный инъектор";
	}

	// Token: 0x06009991 RID: 39313 RVA: 0x003BD404 File Offset: 0x003BB604
	public override string bu()
	{
		return "coagulationShot";
	}

	// Token: 0x06009992 RID: 39314 RVA: 0x003BD40C File Offset: 0x003BB60C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009993 RID: 39315 RVA: 0x003BD410 File Offset: 0x003BB610
	public override int dq()
	{
		return 1;
	}

	// Token: 0x06009994 RID: 39316 RVA: 0x003BD414 File Offset: 0x003BB614
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009995 RID: 39317 RVA: 0x003BD418 File Offset: 0x003BB618
	public xn()
	{
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 3, 0.1f, false, false, null));
		base.Slots.Add("electrolyte", new cgo(new eh0("organicGelElectrolyte", 68), "Органический гель-электролит", false, 1, 0.1f, false, false, null));
		base.Slots.Add("blackCollagen", new cgo(new eh0("blackCollagen", 97), "Чёрный коллаген", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009996 RID: 39318 RVA: 0x003BD4E8 File Offset: 0x003BB6E8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Xpbl\\CoagulationShot");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
