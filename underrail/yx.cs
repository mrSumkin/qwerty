using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BD0 RID: 7120
[dgg("shockBolt")]
public sealed class yx : cwp
{
	// Token: 0x06009AE8 RID: 39656 RVA: 0x003C5F54 File Offset: 0x003C4154
	public override string bt()
	{
		return "莆Электрошоковый болт";
	}

	// Token: 0x06009AE9 RID: 39657 RVA: 0x003C5F5C File Offset: 0x003C415C
	public override string bu()
	{
		return "shockBolt";
	}

	// Token: 0x06009AEA RID: 39658 RVA: 0x003C5F64 File Offset: 0x003C4164
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009AEB RID: 39659 RVA: 0x003C5F68 File Offset: 0x003C4168
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009AEC RID: 39660 RVA: 0x003C5F6C File Offset: 0x003C416C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009AED RID: 39661 RVA: 0x003C5F70 File Offset: 0x003C4170
	public yx()
	{
		base.Slots.Add(yx.a, new cgo(new eh0("Ammo.Bolt", 33), "Болт", false, 3, 0.1f, false, false, null));
		base.Slots.Add(yx.b, new cgo(new eh0(new string[]
		{
			"Battery.ScLiCell",
			"Battery.FusionCell",
			"Battery.PlasmaCell"
		}, 37), "Батарея", false, 1, 0.1f, false, false, null));
		base.Slots.Add(yx.c, new cgo(new eh0(new string[]
		{
			"microElectroshockDischarger"
		}, 47), "Основной микроразрядник", false, 3, 0.1f, false, false, null));
		base.Slots.Add(yx.d, new cgo(new eh0(new string[]
		{
			"microElectroshockDischarger"
		}, 47), "Дополнительный микроразрядник", true, 3, 1f, false, false, null));
		base.Slots.Add(yx.e, new cgo(new eh0(new string[]
		{
			"microElectroshockDischarger"
		}, 47), "Дополнительный микроразрядник", true, 3, 1f, false, false, null));
	}

	// Token: 0x06009AEE RID: 39662 RVA: 0x003C60A8 File Offset: 0x003C42A8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		dng dng = A_1.SafeGet(yx.a, null);
		d48 d = A_1.SafeGet(yx.b, null);
		fv fv = A_1.SafeGet(yx.c, null);
		if (dng != null && dng.TypedDefinition != null && d != null && d.fu() != null && fv != null && fv.TypedDefinition != null)
		{
			fv fv2 = A_1.SafeGet(yx.d, null);
			fv fv3 = A_1.SafeGet(yx.e, null);
			int num;
			if (fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
			{
				num = 3;
				if (d.fu().a5() != "Battery.PlasmaCell")
				{
					A_2 = "Этой батареи недостаточно, чтобы зарядить электрошоковый болт такой мощности.";
				}
			}
			else if ((fv2 != null && fv2.TypedDefinition != null) || (fv3 != null && fv3.TypedDefinition != null))
			{
				num = 2;
				if (d.fu().a5() == "Battery.ScLiCell")
				{
					A_2 = "Этой батареи недостаточно, чтобы зарядить электрошоковый болт такой мощности.";
				}
			}
			else
			{
				num = 1;
			}
			if (A_2 == null)
			{
				string path = "ammo\\ShockBolt" + num.ToString();
				if (ez2.GetItemDefinition<cdk>(path, true) != null)
				{
					return new acz(ez2.CreateDefinitonProvider<cdk>(path));
				}
			}
		}
		return null;
	}

	// Token: 0x04003B2F RID: 15151
	public new static readonly string a = "bolt";

	// Token: 0x04003B30 RID: 15152
	public new static readonly string b = "bat";

	// Token: 0x04003B31 RID: 15153
	public static readonly string c = "pd";

	// Token: 0x04003B32 RID: 15154
	public new static readonly string d = "sd";

	// Token: 0x04003B33 RID: 15155
	public static readonly string e = "td";
}
