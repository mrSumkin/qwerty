using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B96 RID: 7062
[dgg("shiv")]
public sealed class bd4 : cwp
{
	// Token: 0x0600994A RID: 39242 RVA: 0x003BC084 File Offset: 0x003BA284
	public override string bt()
	{
		return "荖Заточка";
	}

	// Token: 0x0600994B RID: 39243 RVA: 0x003BC08C File Offset: 0x003BA28C
	public override string bu()
	{
		return "shiv";
	}

	// Token: 0x0600994C RID: 39244 RVA: 0x003BC094 File Offset: 0x003BA294
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x0600994D RID: 39245 RVA: 0x003BC098 File Offset: 0x003BA298
	public override int dq()
	{
		return 1;
	}

	// Token: 0x0600994E RID: 39246 RVA: 0x003BC09C File Offset: 0x003BA29C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x0600994F RID: 39247 RVA: 0x003BC0A0 File Offset: 0x003BA2A0
	public bd4()
	{
		base.Slots.Add("metalSpike", new cgo(new eh0(new string[]
		{
			"steelSpikes",
			"tiChromeSpikes",
			"tungstenSpikes"
		}, 121), "Металлический шип", false, 1, 0.1f, false, false, null));
		base.Slots.Add("rag", new cgo(new eh0(new string[]
		{
			"dirtyRag"
		}, 76), "Тряпка", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009950 RID: 39248 RVA: 0x003BC138 File Offset: 0x003BA338
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<bke>("Weapons\\shiv");
			if (bit != null)
			{
				return new cd1(bit);
			}
		}
		return null;
	}
}
