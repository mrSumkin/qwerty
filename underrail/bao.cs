using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B8F RID: 7055
[dgg("clusterLauncherGrenade")]
public sealed class bao : cwp
{
	// Token: 0x0600991B RID: 39195 RVA: 0x003BB838 File Offset: 0x003B9A38
	public override string bt()
	{
		return "茽Кассетная граната для гранатомёта";
	}

	// Token: 0x0600991C RID: 39196 RVA: 0x003BB840 File Offset: 0x003B9A40
	public override string bu()
	{
		return "clusterLauncherGrenade";
	}

	// Token: 0x0600991D RID: 39197 RVA: 0x003BB848 File Offset: 0x003B9A48
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x0600991E RID: 39198 RVA: 0x003BB84C File Offset: 0x003B9A4C
	public override int dq()
	{
		return 3;
	}

	// Token: 0x0600991F RID: 39199 RVA: 0x003BB850 File Offset: 0x003B9A50
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009920 RID: 39200 RVA: 0x003BB854 File Offset: 0x003B9A54
	public bao()
	{
		base.Slots.Add("case", new cgo(new eh0("case.Grenade_40", 92), "40мм корпус гранаты для гранатомёта", false, 3, 0.5f, false, true, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 3, 1f, false, false, null));
		base.Slots.Add("metal", new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add("starter", new cgo(new eh0(new string[]
		{
			"Component.StarterMixture"
		}, 77), "Запальный состав", false, 1, 1f, false, true, null));
	}

	// Token: 0x06009921 RID: 39201 RVA: 0x003BB930 File Offset: 0x003B9B30
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x06009922 RID: 39202 RVA: 0x003BB958 File Offset: 0x003B9B58
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\Grenade_40_Cluster";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
