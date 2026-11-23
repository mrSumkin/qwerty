using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BDC RID: 7132
[dgg("empGrenade")]
public sealed class eu4 : cwp
{
	// Token: 0x06009B41 RID: 39745 RVA: 0x003CA154 File Offset: 0x003C8354
	public override string bt()
	{
		return "荣ЭМИ-граната";
	}

	// Token: 0x06009B42 RID: 39746 RVA: 0x003CA15C File Offset: 0x003C835C
	public override string bu()
	{
		return "empGrenade";
	}

	// Token: 0x06009B43 RID: 39747 RVA: 0x003CA164 File Offset: 0x003C8364
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B44 RID: 39748 RVA: 0x003CA168 File Offset: 0x003C8368
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x06009B45 RID: 39749 RVA: 0x003CA170 File Offset: 0x003C8370
	public eu4()
	{
		base.Slots.Add(eu4.b, new cgo(new eh0("thinGrenadeCase", 36), "Тонкий корпус гранаты", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eu4.a, new cgo(new c6s(ms.@as, 35), "Основной электромагнитный разрядник", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eu4.c, new cgo(new eh0(new string[]
		{
			"Battery.FusionCell",
			"Battery.PlasmaCell"
		}, 37), "Батарея", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eu4.d, new cgo(new c6s(ms.@as, 35), "Дополнительный электромагнитный разрядник", true, 1, 1f, false, false, null));
		base.Slots.Add(eu4.e, new cgo(new c6s(ms.@as, 35), "Дополнительный электромагнитный разрядник", true, 1, 1f, false, false, null));
	}

	// Token: 0x06009B46 RID: 39750 RVA: 0x003CA27C File Offset: 0x003C847C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(eu4.a, null);
		fv fv2 = A_1.SafeGet(eu4.d, null);
		fv fv3 = A_1.SafeGet(eu4.e, null);
		fv fv4 = A_1.SafeGet(eu4.b, null);
		d48 d = A_1.SafeGet(eu4.c, null);
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
			string path = "grenades\\emp" + num.ToString();
			if (ez2.GetItemDefinition<cdk>(path, true) != null)
			{
				return new acz(ez2.CreateDefinitonProvider<cdk>(path));
			}
			A_2 = "Этот разрядник нельзя использовать для создания гранаты.";
		}
		return null;
	}

	// Token: 0x04003B5C RID: 15196
	public new static readonly string a = "discharger";

	// Token: 0x04003B5D RID: 15197
	public new static readonly string b = "case";

	// Token: 0x04003B5E RID: 15198
	public static readonly string c = "battery";

	// Token: 0x04003B5F RID: 15199
	public new static readonly string d = "secondDischarger";

	// Token: 0x04003B60 RID: 15200
	public static readonly string e = "thirdDischarger";
}
