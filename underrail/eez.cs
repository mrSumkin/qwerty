using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BEB RID: 7147
[dgg("tntc")]
public sealed class eez : cwp
{
	// Token: 0x06009BB5 RID: 39861 RVA: 0x003D097C File Offset: 0x003CEB7C
	public override string bt()
	{
		return "荠Заряд тротила";
	}

	// Token: 0x06009BB6 RID: 39862 RVA: 0x003D0984 File Offset: 0x003CEB84
	public override string bu()
	{
		return "tntc";
	}

	// Token: 0x06009BB7 RID: 39863 RVA: 0x003D098C File Offset: 0x003CEB8C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009BB8 RID: 39864 RVA: 0x003D0990 File Offset: 0x003CEB90
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009BB9 RID: 39865 RVA: 0x003D0994 File Offset: 0x003CEB94
	public eez()
	{
		base.Slots.Add("container", new cgo(new eh0("cardboardContainer", 10), "Картонная коробка", false, 1, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 5, 0.1f, false, false, null));
		base.Slots.Add("timer", new cgo(new eh0("digitalTimer", 12), "Цифровой таймер", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009BBA RID: 39866 RVA: 0x003D0A38 File Offset: 0x003CEC38
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("container", null);
		fv fv2 = A_1.SafeGet("tnt", null);
		fv fv3 = A_1.SafeGet("timer", null);
		bit bit = ez2.CreateDefinitonProvider<qb>("expendables\\explosives\\tnt");
		if (bit != null && bit.wl() != null && bit.wl().a5() != null && fv != null && fv2 != null && fv3 != null)
		{
			return new d48(bit);
		}
		return null;
	}

	// Token: 0x04003B90 RID: 15248
	private new const string a = "container";

	// Token: 0x04003B91 RID: 15249
	private new const string b = "tnt";

	// Token: 0x04003B92 RID: 15250
	private const string c = "timer";
}
