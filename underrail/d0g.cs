using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B70 RID: 7024
[dgg("rocket_84_kinetic")]
public sealed class d0g : cwp
{
	// Token: 0x06009832 RID: 38962 RVA: 0x003B496C File Offset: 0x003B2B6C
	public override string bt()
	{
		return "荃84мм кинетическая ракета";
	}

	// Token: 0x06009833 RID: 38963 RVA: 0x003B4974 File Offset: 0x003B2B74
	public override string bu()
	{
		return "rocket_84_kinetic";
	}

	// Token: 0x06009834 RID: 38964 RVA: 0x003B497C File Offset: 0x003B2B7C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009835 RID: 38965 RVA: 0x003B4980 File Offset: 0x003B2B80
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009836 RID: 38966 RVA: 0x003B4984 File Offset: 0x003B2B84
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009837 RID: 38967 RVA: 0x003B498C File Offset: 0x003B2B8C
	public d0g()
	{
		base.Slots.Add("tungsten0", new cgo(new eh0("tungstenSteel", 93), "Вольфрамо-стальная пластина", false, 1, 0.1f, false, false, null));
		base.Slots.Add("propellant0", new cgo(new eh0("rocketPropellant", 138), "Ракетное топливо", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x06009838 RID: 38968 RVA: 0x003B4A04 File Offset: 0x003B2C04
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "tungsten0")
		{
			return cwp.a(SkillEnum.Mechanics, 60, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009839 RID: 38969 RVA: 0x003B4A2C File Offset: 0x003B2C2C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\rocket_84_kin";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
