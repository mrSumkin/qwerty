using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B99 RID: 7065
[dgg("shockShurikens")]
public sealed class b5l : cwp
{
	// Token: 0x0600995F RID: 39263 RVA: 0x003BC2FC File Offset: 0x003BA4FC
	public override string bt()
	{
		return "荕Шоковые сюрикены";
	}

	// Token: 0x06009960 RID: 39264 RVA: 0x003BC304 File Offset: 0x003BA504
	public override string bu()
	{
		return "shockShurikens";
	}

	// Token: 0x06009961 RID: 39265 RVA: 0x003BC30C File Offset: 0x003BA50C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009962 RID: 39266 RVA: 0x003BC310 File Offset: 0x003BA510
	public override int dq()
	{
		return 10;
	}

	// Token: 0x06009963 RID: 39267 RVA: 0x003BC314 File Offset: 0x003BA514
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009964 RID: 39268 RVA: 0x003BC318 File Offset: 0x003BA518
	public b5l()
	{
		base.Slots.Add(b5l.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(b5l.b, new cgo(new eh0(new string[]
		{
			"Battery.ScLiCell",
			"Battery.FusionCell",
			"Battery.PlasmaCell"
		}, 37), "Батарея", false, 1, 0.1f, false, false, null));
		base.Slots.Add(b5l.c, new cgo(new eh0(new string[]
		{
			"microElectroshockDischarger"
		}, 47), "Основной микроразрядник", false, 3, 0.5f, false, true, null));
	}

	// Token: 0x06009965 RID: 39269 RVA: 0x003BC3DC File Offset: 0x003BA5DC
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		string path = "Weapons\\ShockShuriken";
		if (ez2.GetItemDefinition<cdk>(path, true) != null)
		{
			return new acz(ez2.CreateDefinitonProvider<cdk>(path));
		}
		return null;
	}

	// Token: 0x04003AB3 RID: 15027
	public new static readonly string a = "metal";

	// Token: 0x04003AB4 RID: 15028
	public new static readonly string b = "bat";

	// Token: 0x04003AB5 RID: 15029
	public static readonly string c = "pd";
}
