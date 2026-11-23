using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B6F RID: 7023
[dgg("rocket_40_tandemCharge")]
public sealed class er7 : cwp
{
	// Token: 0x0600982A RID: 38954 RVA: 0x003B47DC File Offset: 0x003B29DC
	public override string bt()
	{
		return "荄40мм ракета с тандемным зарядом";
	}

	// Token: 0x0600982B RID: 38955 RVA: 0x003B47E4 File Offset: 0x003B29E4
	public override string bu()
	{
		return "rocket_40_tandemCharge";
	}

	// Token: 0x0600982C RID: 38956 RVA: 0x003B47EC File Offset: 0x003B29EC
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x0600982D RID: 38957 RVA: 0x003B47F0 File Offset: 0x003B29F0
	public override int dq()
	{
		return 6;
	}

	// Token: 0x0600982E RID: 38958 RVA: 0x003B47F4 File Offset: 0x003B29F4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600982F RID: 38959 RVA: 0x003B47FC File Offset: 0x003B29FC
	public er7()
	{
		base.Slots.Add("case_metal", new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 2, 0.1f, false, false, null));
		base.Slots.Add("triggers", new cgo(new eh0("Component.BoltTrigger", 48), "Арбалетный запал", false, this.BatchSize, 0.1f, false, false, null));
		base.Slots.Add("hexogen", new cgo(new eh0("hexogen", 11), "Гексоген", false, 2, 0.1f, false, false, null));
		base.Slots.Add("propellant", new cgo(new eh0("rocketPropellant", 138), "Ракетное топливо", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x06009830 RID: 38960 RVA: 0x003B4908 File Offset: 0x003B2B08
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "case_metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009831 RID: 38961 RVA: 0x003B4930 File Offset: 0x003B2B30
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\rocket_40_tandem";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
