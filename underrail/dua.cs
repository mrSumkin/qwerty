using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B72 RID: 7026
[dgg("rocket_84_whitePhosphorus")]
public sealed class dua : cwp
{
	// Token: 0x06009842 RID: 38978 RVA: 0x003B4BC4 File Offset: 0x003B2DC4
	public override string bt()
	{
		return "荁84мм ракета с белым фосфором";
	}

	// Token: 0x06009843 RID: 38979 RVA: 0x003B4BCC File Offset: 0x003B2DCC
	public override string bu()
	{
		return "rocket_84_whitePhosphorus";
	}

	// Token: 0x06009844 RID: 38980 RVA: 0x003B4BD4 File Offset: 0x003B2DD4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009845 RID: 38981 RVA: 0x003B4BD8 File Offset: 0x003B2DD8
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009846 RID: 38982 RVA: 0x003B4BDC File Offset: 0x003B2DDC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009847 RID: 38983 RVA: 0x003B4BE4 File Offset: 0x003B2DE4
	public dua()
	{
		base.Slots.Add("case_metal", new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add("whitePhosphorus", new cgo(new eh0("whitePhosphorus", 139), "Белый фосфор", false, 2, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 2, 0.1f, false, false, null));
		base.Slots.Add("propellant", new cgo(new eh0("rocketPropellant", 138), "Ракетное топливо", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009848 RID: 38984 RVA: 0x003B4CC0 File Offset: 0x003B2EC0
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "case_metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009849 RID: 38985 RVA: 0x003B4CE8 File Offset: 0x003B2EE8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\rocket_84_wp";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
