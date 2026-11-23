using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BCF RID: 7119
[dgg("incendiaryBolt")]
public sealed class bqz : cwp
{
	// Token: 0x06009AE0 RID: 39648 RVA: 0x003C5DA8 File Offset: 0x003C3FA8
	public override string bt()
	{
		return "莅Зажигательный болт";
	}

	// Token: 0x06009AE1 RID: 39649 RVA: 0x003C5DB0 File Offset: 0x003C3FB0
	public override string bu()
	{
		return "incendiaryBolt";
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x003C5DB8 File Offset: 0x003C3FB8
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x003C5DBC File Offset: 0x003C3FBC
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009AE4 RID: 39652 RVA: 0x003C5DC0 File Offset: 0x003C3FC0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009AE5 RID: 39653 RVA: 0x003C5DC8 File Offset: 0x003C3FC8
	public bqz()
	{
		base.Slots.Add(bqz.a, new cgo(new eh0("Ammo.Bolt", 33), "Болт", false, 3, 0.1f, false, false, null));
		base.Slots.Add(bqz.b, new cgo(new c6s(ms.a1, 49), "Горючее", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bqz.c, new cgo(new eh0(new string[]
		{
			"Component.BoltTrigger"
		}, 48), "Арбалетный запал", false, 3, 0.1f, false, false, null));
	}

	// Token: 0x06009AE6 RID: 39654 RVA: 0x003C5E74 File Offset: 0x003C4074
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		dng dng = A_1.SafeGet(bqz.a, null);
		fv fv = A_1.SafeGet(bqz.b, null);
		fv fv2 = A_1.SafeGet(bqz.c, null);
		if (dng != null && dng.TypedDefinition != null && fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
		{
			string path = "ammo\\IncendiaryBolt" + fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("power", new int?(1)).Value.ToString();
			if (ez2.GetItemDefinition<cdk>(path, true) != null)
			{
				return new acz(ez2.CreateDefinitonProvider<cdk>(path));
			}
		}
		return null;
	}

	// Token: 0x04003B2C RID: 15148
	public new static readonly string a = "bolt";

	// Token: 0x04003B2D RID: 15149
	public new static readonly string b = "inc";

	// Token: 0x04003B2E RID: 15150
	public static readonly string c = "tr";
}
