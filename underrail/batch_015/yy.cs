using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BA7 RID: 7079
[dgg("plasmaMine")]
public sealed class yy : cwp
{
	// Token: 0x060099C1 RID: 39361 RVA: 0x003BEF88 File Offset: 0x003BD188
	public override string bt()
	{
		return "荲Плазменная мина";
	}

	// Token: 0x060099C2 RID: 39362 RVA: 0x003BEF90 File Offset: 0x003BD190
	public override string bu()
	{
		return "plasmaMine";
	}

	// Token: 0x060099C3 RID: 39363 RVA: 0x003BEF98 File Offset: 0x003BD198
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x060099C4 RID: 39364 RVA: 0x003BEF9C File Offset: 0x003BD19C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Traps;
	}

	// Token: 0x060099C5 RID: 39365 RVA: 0x003BEFA4 File Offset: 0x003BD1A4
	public yy()
	{
		base.Slots.Add(yy.d, new cgo(new eh0("plasmaMineCase", 96), "Корпус плазменной мины", false, 1, 0.1f, false, false, null));
		base.Slots.Add(yy.c, new cgo(new eh0("plasmaMicroDischarger", 89), "Основной плазменный микроразрядник", false, 1, 0.1f, false, false, null));
		base.Slots.Add(yy.e, new cgo(new eh0(new string[]
		{
			"Battery.FusionCell",
			"Battery.PlasmaCell"
		}, 37), "Батарея", false, 1, 0.1f, false, false, null));
		base.Slots.Add(yy.a, new cgo(new eh0("plasmaMicroDischarger", 89), "Дополнительный плазменный микроразрядник", true, 1, 1f, false, false, null));
		base.Slots.Add(yy.b, new cgo(new eh0("plasmaMicroDischarger", 89), "Дополнительный плазменный микроразрядник", true, 1, 1f, false, false, null));
	}

	// Token: 0x060099C6 RID: 39366 RVA: 0x003BF0B8 File Offset: 0x003BD2B8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(yy.c, null);
		fv fv2 = A_1.SafeGet(yy.d, null);
		d48 d = A_1.SafeGet(yy.e, null);
		fv fv3 = A_1.SafeGet(yy.a, null);
		fv fv4 = A_1.SafeGet(yy.b, null);
		if (fv != null && fv2 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null && d != null && d.fu() != null)
		{
			int num = 1;
			if (fv3 != null)
			{
				num++;
			}
			if (fv4 != null)
			{
				num++;
			}
			string path = "traps\\xpbl\\PlasmaMine" + num.ToString();
			if (ez2.GetItemDefinition<c4j>(path, true) != null)
			{
				return new d48(ez2.CreateDefinitonProvider<c4j>(path));
			}
			A_2 = "Этот плазменный разрядник нельзя использовать для создания мины.";
		}
		return null;
	}

	// Token: 0x04003AC6 RID: 15046
	public new static readonly string a = "secondDischarger";

	// Token: 0x04003AC7 RID: 15047
	public new static readonly string b = "thirdDischarger";

	// Token: 0x04003AC8 RID: 15048
	public static readonly string c = "discharger";

	// Token: 0x04003AC9 RID: 15049
	public new static readonly string d = "case";

	// Token: 0x04003ACA RID: 15050
	public static readonly string e = "battery";
}
