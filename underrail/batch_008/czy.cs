using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B7A RID: 7034
[dgg("concussiveLauncherGrenade")]
public sealed class czy : cwp
{
	// Token: 0x0600987C RID: 39036 RVA: 0x003B788C File Offset: 0x003B5A8C
	public override string bt()
	{
		return "茻Ошеломляющая граната для гранатомёта";
	}

	// Token: 0x0600987D RID: 39037 RVA: 0x003B7894 File Offset: 0x003B5A94
	public override string bu()
	{
		return "concussiveLauncherGrenade";
	}

	// Token: 0x0600987E RID: 39038 RVA: 0x003B789C File Offset: 0x003B5A9C
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x0600987F RID: 39039 RVA: 0x003B78A0 File Offset: 0x003B5AA0
	public override int dq()
	{
		return 5;
	}

	// Token: 0x06009880 RID: 39040 RVA: 0x003B78A4 File Offset: 0x003B5AA4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009881 RID: 39041 RVA: 0x003B78AC File Offset: 0x003B5AAC
	public czy()
	{
		base.Slots.Add("case", new cgo(new eh0("case.Grenade_25", 92), "25мм корпус гранаты для гранатомёта", false, 5, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add("magnesium", new cgo(new eh0(new string[]
		{
			"Component.MagnesiumPowder"
		}, 68), "Порошок магния", false, 1, 0.5f, false, true, null));
		base.Slots.Add("oxygenTank", new cgo(new eh0("smallOxygenTank", 107), "Малый кислородный баллон", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009882 RID: 39042 RVA: 0x003B7988 File Offset: 0x003B5B88
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\Grenade_25_Concussive";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
