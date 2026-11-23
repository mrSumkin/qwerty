using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BD1 RID: 7121
[dgg("empMine")]
public sealed class ehe : cwp
{
	// Token: 0x06009AF0 RID: 39664 RVA: 0x003C6234 File Offset: 0x003C4434
	public override string bt()
	{
		return "荱ЭМИ-мина";
	}

	// Token: 0x06009AF1 RID: 39665 RVA: 0x003C623C File Offset: 0x003C443C
	public override string bu()
	{
		return "empMine";
	}

	// Token: 0x06009AF2 RID: 39666 RVA: 0x003C6244 File Offset: 0x003C4444
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009AF3 RID: 39667 RVA: 0x003C6248 File Offset: 0x003C4448
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Traps;
	}

	// Token: 0x06009AF4 RID: 39668 RVA: 0x003C624C File Offset: 0x003C444C
	public ehe()
	{
		base.Slots.Add(ehe.d, new cgo(new c6s(ms.a0, 46), "Корпус ЭМИ-мины", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ehe.c, new cgo(new c6s(ms.@as, 35), "Электромагнитный разрядник", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ehe.e, new cgo(new eh0(new string[]
		{
			"Battery.FusionCell",
			"Battery.PlasmaCell"
		}, 37), "Батарея", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ehe.a, new cgo(new c6s(ms.@as, 35), "Дополнительный электромагнитный разрядник", true, 1, 1f, false, false, null));
		base.Slots.Add(ehe.b, new cgo(new c6s(ms.@as, 35), "Дополнительный электромагнитный разрядник", true, 1, 1f, false, false, null));
	}

	// Token: 0x06009AF5 RID: 39669 RVA: 0x003C6354 File Offset: 0x003C4554
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(ehe.c, null);
		fv fv2 = A_1.SafeGet(ehe.d, null);
		d48 d = A_1.SafeGet(ehe.e, null);
		fv fv3 = A_1.SafeGet(ehe.a, null);
		fv fv4 = A_1.SafeGet(ehe.b, null);
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
			string path = "traps\\empMine" + num.ToString();
			if (ez2.GetItemDefinition<c4j>(path, true) != null)
			{
				return new d48(ez2.CreateDefinitonProvider<c4j>(path));
			}
			A_2 = "Этот разрядник нельзя использовать для создания мины.";
		}
		return null;
	}

	// Token: 0x04003B34 RID: 15156
	public new static readonly string a = "secondDischarger";

	// Token: 0x04003B35 RID: 15157
	public new static readonly string b = "thirdDischarger";

	// Token: 0x04003B36 RID: 15158
	public static readonly string c = "discharger";

	// Token: 0x04003B37 RID: 15159
	public new static readonly string d = "case";

	// Token: 0x04003B38 RID: 15160
	public static readonly string e = "battery";
}
