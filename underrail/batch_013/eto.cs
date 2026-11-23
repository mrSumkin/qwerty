using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B90 RID: 7056
[dgg("parafibroticRegenerationCatalyst")]
public sealed class eto : cwp
{
	// Token: 0x06009923 RID: 39203 RVA: 0x003BB994 File Offset: 0x003B9B94
	public override string bt()
	{
		return "莔Катализатор парафиброзной регенерации";
	}

	// Token: 0x06009924 RID: 39204 RVA: 0x003BB99C File Offset: 0x003B9B9C
	public override string bu()
	{
		return "parafibroticRegenerationCatalyst";
	}

	// Token: 0x06009925 RID: 39205 RVA: 0x003BB9A4 File Offset: 0x003B9BA4
	public override cr1 bv()
	{
		return cr1.e;
	}

	// Token: 0x06009926 RID: 39206 RVA: 0x003BB9A8 File Offset: 0x003B9BA8
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009927 RID: 39207 RVA: 0x003BB9AC File Offset: 0x003B9BAC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009928 RID: 39208 RVA: 0x003BB9B4 File Offset: 0x003B9BB4
	public eto()
	{
		base.Slots.Add("blood", new cgo(new eh0("blood", 55), "Кровь", false, 5, 0.1f, false, false, null));
		base.Slots.Add("electrolyte", new cgo(new eh0("organicGelElectrolyte", 68), "Органический гель-электролит", false, 2, 0.1f, false, false, null));
		base.Slots.Add("morphine", new cgo(new eh0("morphine", 65), "Необработанный морфин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("macrophageFluid", new cgo(new eh0("macrophageFluid", 55), "Взвесь макрофагов", false, 1, 0.1f, false, false, null));
		base.Slots.Add("ampule", new cgo(new c6s(new ms[]
		{
			ms.f
		}, 5), "Ампула", false, 3, 0.1f, false, false, null));
	}

	// Token: 0x06009929 RID: 39209 RVA: 0x003BBABC File Offset: 0x003B9CBC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Xphw\\ParafibroticRegenerationCatalyst");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
