using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B71 RID: 7025
[dgg("rocket_66_incendiary")]
public sealed class b5z : cwp
{
	// Token: 0x0600983A RID: 38970 RVA: 0x003B4A68 File Offset: 0x003B2C68
	public override string bt()
	{
		return "荀66мм зажигательная ракета";
	}

	// Token: 0x0600983B RID: 38971 RVA: 0x003B4A70 File Offset: 0x003B2C70
	public override string bu()
	{
		return "rocket_66_incendiary";
	}

	// Token: 0x0600983C RID: 38972 RVA: 0x003B4A78 File Offset: 0x003B2C78
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x0600983D RID: 38973 RVA: 0x003B4A7C File Offset: 0x003B2C7C
	public override int dq()
	{
		return 5;
	}

	// Token: 0x0600983E RID: 38974 RVA: 0x003B4A80 File Offset: 0x003B2C80
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600983F RID: 38975 RVA: 0x003B4A88 File Offset: 0x003B2C88
	public b5z()
	{
		base.Slots.Add("case_metal", new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add("napalmC", new cgo(new eh0("Component.NapalmC", 78), "Напалм C", false, 3, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add("propellant", new cgo(new eh0("rocketPropellant", 138), "Ракетное топливо", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009840 RID: 38976 RVA: 0x003B4B60 File Offset: 0x003B2D60
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "case_metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009841 RID: 38977 RVA: 0x003B4B88 File Offset: 0x003B2D88
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\rocket_66_incendiary";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
