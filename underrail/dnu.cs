using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BBA RID: 7098
[dgg("incendiaryGrenade")]
public sealed class dnu : cwp
{
	// Token: 0x06009A52 RID: 39506 RVA: 0x003C1130 File Offset: 0x003BF330
	public override string bt()
	{
		return "荥Зажигательная граната";
	}

	// Token: 0x06009A53 RID: 39507 RVA: 0x003C1138 File Offset: 0x003BF338
	public override string bu()
	{
		return "incendiaryGrenade";
	}

	// Token: 0x06009A54 RID: 39508 RVA: 0x003C1140 File Offset: 0x003BF340
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009A55 RID: 39509 RVA: 0x003C1144 File Offset: 0x003BF344
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x06009A56 RID: 39510 RVA: 0x003C1148 File Offset: 0x003BF348
	public dnu()
	{
		base.Slots.Add(dnu.a, new cgo(new eh0("bottle", 75), "Пустая бутылка", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dnu.b, new cgo(new c6s(ms.a1, 49), "Горючее", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dnu.c, new cgo(new eh0(new string[]
		{
			"dirtyRag"
		}, 76), "Тряпка", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A57 RID: 39511 RVA: 0x003C11F4 File Offset: 0x003BF3F4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dnu.a, null);
		fv fv2 = A_1.SafeGet(dnu.b, null);
		fv fv3 = A_1.SafeGet(dnu.c, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			string classPropertyValue = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("IncendiaryGrenadeName");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string path = "grenades\\" + classPropertyValue;
				if (ez2.GetItemDefinition<cdk>(path, true) != null)
				{
					return new acz(ez2.CreateDefinitonProvider<cdk>(path));
				}
			}
		}
		return null;
	}

	// Token: 0x04003AF1 RID: 15089
	public new static readonly string a = "bottle";

	// Token: 0x04003AF2 RID: 15090
	public new static readonly string b = "inc";

	// Token: 0x04003AF3 RID: 15091
	public static readonly string c = "rag";
}
