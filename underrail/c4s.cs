using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA5 RID: 7077
[dgg("hypercerebrix")]
public sealed class c4s : cwp
{
	// Token: 0x060099B5 RID: 39349 RVA: 0x003BED34 File Offset: 0x003BCF34
	public override string bt()
	{
		return "莨Гиперцеребрикс";
	}

	// Token: 0x060099B6 RID: 39350 RVA: 0x003BED3C File Offset: 0x003BCF3C
	public override string bu()
	{
		return "hypercerebrix";
	}

	// Token: 0x060099B7 RID: 39351 RVA: 0x003BED44 File Offset: 0x003BCF44
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099B8 RID: 39352 RVA: 0x003BED48 File Offset: 0x003BCF48
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060099B9 RID: 39353 RVA: 0x003BED50 File Offset: 0x003BCF50
	public c4s()
	{
		base.Slots.Add("caveEarPoison", new cgo(new eh0("poison.CaveEarPoison", 57), "Яд пещерного уха", false, 1, 0.1f, false, false, null));
		base.Slots.Add("gyromitrin", new cgo(new eh0("gyromitrin", 57), "Гиромитрин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("phototannin", new cgo(new eh0("phototannin", 97), "Фототаннин", false, 3, 0.1f, false, false, null));
		base.Slots.Add("capsule", new cgo(new eh0("capsule", 73), "Капсула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099BA RID: 39354 RVA: 0x003BEE24 File Offset: 0x003BD024
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\Xpbl\\Hypercerebrix");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
