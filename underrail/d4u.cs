using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BED RID: 7149
[dgg("MindDarts")]
public sealed class d4u : cwp
{
	// Token: 0x06009BC2 RID: 39874 RVA: 0x003D0D94 File Offset: 0x003CEF94
	public override string bt()
	{
		return "莢Пси-рывок";
	}

	// Token: 0x06009BC3 RID: 39875 RVA: 0x003D0D9C File Offset: 0x003CEF9C
	public override string bu()
	{
		return "MindDarts";
	}

	// Token: 0x06009BC4 RID: 39876 RVA: 0x003D0DA4 File Offset: 0x003CEFA4
	public override cr1 bv()
	{
		return cr1.e;
	}

	// Token: 0x06009BC5 RID: 39877 RVA: 0x003D0DA8 File Offset: 0x003CEFA8
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009BC6 RID: 39878 RVA: 0x003D0DAC File Offset: 0x003CEFAC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x06009BC7 RID: 39879 RVA: 0x003D0DB4 File Offset: 0x003CEFB4
	public d4u()
	{
		base.Slots.Add("mindshroom", new cgo(new eh0("mindshroom", 4), "Мозгляк", false, 1, 0.1f, false, false, null));
		base.Slots.Add("redDreamMushroom", new cgo(new eh0("redDreamMushroom", 6), "Гриб красный сон", false, 3, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 3, 0.1f, false, false, null));
	}

	// Token: 0x06009BC8 RID: 39880 RVA: 0x003D0E54 File Offset: 0x003CF054
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("redDreamMushroom", null);
		fv fv2 = A_1.SafeGet("mindshroom", null);
		fv fv3 = A_1.SafeGet("syringe", null);
		bit bit = ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\mindDart");
		if (bit != null && bit.wl() != null && bit.wl().a5() != null && fv2 != null && fv3 != null && fv != null)
		{
			return new d48(bit);
		}
		return null;
	}

	// Token: 0x04003B9B RID: 15259
	private new const string a = "mindshroom";

	// Token: 0x04003B9C RID: 15260
	private new const string b = "redDreamMushroom";

	// Token: 0x04003B9D RID: 15261
	private const string c = "syringe";
}
