using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BAB RID: 7083
[dgg("plasmaGrenade")]
public sealed class eb0 : cwp
{
	// Token: 0x060099E1 RID: 39393 RVA: 0x003BF83C File Offset: 0x003BDA3C
	public override string bt()
	{
		return "荤Плазменная граната";
	}

	// Token: 0x060099E2 RID: 39394 RVA: 0x003BF844 File Offset: 0x003BDA44
	public override string bu()
	{
		return "plasmaGrenade";
	}

	// Token: 0x060099E3 RID: 39395 RVA: 0x003BF84C File Offset: 0x003BDA4C
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x060099E4 RID: 39396 RVA: 0x003BF850 File Offset: 0x003BDA50
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x060099E5 RID: 39397 RVA: 0x003BF858 File Offset: 0x003BDA58
	public eb0()
	{
		base.Slots.Add(eb0.b, new cgo(new eh0("thinGrenadeCase", 36), "Тонкий корпус гранаты", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eb0.a, new cgo(new eh0("plasmaMicroDischarger", 89), "Основной плазменный микроразрядник", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eb0.c, new cgo(new eh0(new string[]
		{
			"Battery.FusionCell",
			"Battery.PlasmaCell"
		}, 37), "Батарея", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eb0.d, new cgo(new eh0("plasmaMicroDischarger", 89), "Дополнительный плазменный микроразрядник", true, 1, 1f, false, false, null));
		base.Slots.Add(eb0.e, new cgo(new eh0("plasmaMicroDischarger", 89), "Дополнительный плазменный микроразрядник", true, 1, 1f, false, false, null));
	}

	// Token: 0x060099E6 RID: 39398 RVA: 0x003BF96C File Offset: 0x003BDB6C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(eb0.a, null);
		fv fv2 = A_1.SafeGet(eb0.d, null);
		fv fv3 = A_1.SafeGet(eb0.e, null);
		fv fv4 = A_1.SafeGet(eb0.b, null);
		d48 d = A_1.SafeGet(eb0.c, null);
		if (fv != null && fv4 != null && fv.TypedDefinition != null && fv4.TypedDefinition != null && d != null && d.fu() != null)
		{
			int num = 1;
			if (fv2 != null)
			{
				num++;
			}
			if (fv3 != null)
			{
				num++;
			}
			string path = "grenades\\xpbl\\PlasmaGrenade" + num.ToString();
			if (ez2.GetItemDefinition<cdk>(path, true) != null)
			{
				return new acz(ez2.CreateDefinitonProvider<cdk>(path));
			}
		}
		return null;
	}

	// Token: 0x04003AD2 RID: 15058
	public new static readonly string a = "discharger";

	// Token: 0x04003AD3 RID: 15059
	public new static readonly string b = "case";

	// Token: 0x04003AD4 RID: 15060
	public static readonly string c = "battery";

	// Token: 0x04003AD5 RID: 15061
	public new static readonly string d = "secondDischarger";

	// Token: 0x04003AD6 RID: 15062
	public static readonly string e = "thirdDischarger";
}
