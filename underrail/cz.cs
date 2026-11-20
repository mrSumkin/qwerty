using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B6E RID: 7022
[dgg("rocket_84_caveShaker")]
public sealed class cz : cwp
{
	// Token: 0x06009822 RID: 38946 RVA: 0x003B4680 File Offset: 0x003B2880
	public override string bt()
	{
		return "荂84мм ракета сотрясатель пещер";
	}

	// Token: 0x06009823 RID: 38947 RVA: 0x003B4688 File Offset: 0x003B2888
	public override string bu()
	{
		return "rocket_84_caveShaker";
	}

	// Token: 0x06009824 RID: 38948 RVA: 0x003B4690 File Offset: 0x003B2890
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x06009825 RID: 38949 RVA: 0x003B4694 File Offset: 0x003B2894
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009826 RID: 38950 RVA: 0x003B4698 File Offset: 0x003B2898
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009827 RID: 38951 RVA: 0x003B46A0 File Offset: 0x003B28A0
	public cz()
	{
		base.Slots.Add("case_metal", new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 3, 0.1f, false, false, null));
		base.Slots.Add("hexogen", new cgo(new eh0("hexogen", 11), "Гексоген", false, 3, 0.1f, false, false, null));
		base.Slots.Add("propellant", new cgo(new eh0("rocketPropellant", 138), "Ракетное топливо", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009828 RID: 38952 RVA: 0x003B4778 File Offset: 0x003B2978
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "case_metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009829 RID: 38953 RVA: 0x003B47A0 File Offset: 0x003B29A0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\rocket_84_cs";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
