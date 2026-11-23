using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BC6 RID: 7110
[dgg("processPlant")]
public sealed class cqo : cwp
{
	// Token: 0x06009AA1 RID: 39585 RVA: 0x003C32F0 File Offset: 0x003C14F0
	public override string bt()
	{
		return "莪Переработать растение или гриб";
	}

	// Token: 0x06009AA2 RID: 39586 RVA: 0x003C32F8 File Offset: 0x003C14F8
	public override string bu()
	{
		return "processPlant";
	}

	// Token: 0x06009AA3 RID: 39587 RVA: 0x003C3300 File Offset: 0x003C1500
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009AA4 RID: 39588 RVA: 0x003C3304 File Offset: 0x003C1504
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009AA5 RID: 39589 RVA: 0x003C330C File Offset: 0x003C150C
	public cqo()
	{
		base.Slots.Add(cqo.a, new cgo(new c6s(new ms[]
		{
			ms.h,
			ms.g
		}, 64), "Растение или гриб", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cqo.b, new cgo(new c6s(ms.f, 5), "Ампула", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009AA6 RID: 39590 RVA: 0x003C3384 File Offset: 0x003C1584
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cqo.a, null);
		fv fv2 = A_1.SafeGet(cqo.b, null);
		if (fv != null && fv2 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null)
		{
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Product");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string path = "components\\chemicals\\" + classPropertyValue;
				if (ez2.GetItemDefinition<a1k>(path, true) != null)
				{
					return new fv(ez2.CreateDefinitonProvider<a1k>(path));
				}
			}
			A_2 = "Нельзя ничего извлечь из этого.";
		}
		return null;
	}

	// Token: 0x04003B11 RID: 15121
	public new static readonly string a = "plant";

	// Token: 0x04003B12 RID: 15122
	public new static readonly string b = "ampule";
}
