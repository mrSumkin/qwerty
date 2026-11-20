using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B73 RID: 7027
[dgg("rocket_84_highExplosive")]
public sealed class dop : cwp
{
	// Token: 0x0600984A RID: 38986 RVA: 0x003B4D24 File Offset: 0x003B2F24
	public override string bt()
	{
		return "荅84мм фугасная ракета";
	}

	// Token: 0x0600984B RID: 38987 RVA: 0x003B4D2C File Offset: 0x003B2F2C
	public override string bu()
	{
		return "rocket_84_highExplosive";
	}

	// Token: 0x0600984C RID: 38988 RVA: 0x003B4D34 File Offset: 0x003B2F34
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x0600984D RID: 38989 RVA: 0x003B4D38 File Offset: 0x003B2F38
	public override int dq()
	{
		return 3;
	}

	// Token: 0x0600984E RID: 38990 RVA: 0x003B4D3C File Offset: 0x003B2F3C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600984F RID: 38991 RVA: 0x003B4D44 File Offset: 0x003B2F44
	public dop()
	{
		base.Slots.Add("case_metal", new cgo(new eh0("steel", 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 2, 0.1f, false, false, null));
		base.Slots.Add("hexogen", new cgo(new eh0("hexogen", 11), "Гексоген", false, 2, 0.1f, false, false, null));
		base.Slots.Add("propellant", new cgo(new eh0("rocketPropellant", 138), "Ракетное топливо", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009850 RID: 38992 RVA: 0x003B4E1C File Offset: 0x003B301C
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "case_metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009851 RID: 38993 RVA: 0x003B4E44 File Offset: 0x003B3044
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\rocket_84_he";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
