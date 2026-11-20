using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B91 RID: 7057
[dgg("thermobaricLauncherGrenade")]
public sealed class afv : cwp
{
	// Token: 0x0600992A RID: 39210 RVA: 0x003BBAF4 File Offset: 0x003B9CF4
	public override string bt()
	{
		return "茾Термобарическая граната для гранатомёта";
	}

	// Token: 0x0600992B RID: 39211 RVA: 0x003BBAFC File Offset: 0x003B9CFC
	public override string bu()
	{
		return "thermobaricLauncherGrenade";
	}

	// Token: 0x0600992C RID: 39212 RVA: 0x003BBB04 File Offset: 0x003B9D04
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x0600992D RID: 39213 RVA: 0x003BBB08 File Offset: 0x003B9D08
	public override int dq()
	{
		return 3;
	}

	// Token: 0x0600992E RID: 39214 RVA: 0x003BBB0C File Offset: 0x003B9D0C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600992F RID: 39215 RVA: 0x003BBB10 File Offset: 0x003B9D10
	public afv()
	{
		base.Slots.Add("case", new cgo(new eh0("case.Grenade_40", 92), "40мм корпус гранаты для гранатомёта", false, 3, 0.1f, false, false, null));
		base.Slots.Add("hexogen", new cgo(new eh0("hexogen", 11), "Гексоген", false, 3, 1f, false, true, null));
		base.Slots.Add("magnesium", new cgo(new eh0("Component.MagnesiumPowder", 11), "Порошок магния", false, 1, 0.25f, false, true, null));
	}

	// Token: 0x06009930 RID: 39216 RVA: 0x003BBBB4 File Offset: 0x003B9DB4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\Grenade_40_Thermobaric";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
