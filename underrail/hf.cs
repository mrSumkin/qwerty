using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BD2 RID: 7122
[dgg("mine")]
public sealed class hf : cwp
{
	// Token: 0x06009AF7 RID: 39671 RVA: 0x003C6460 File Offset: 0x003C4660
	public override string bt()
	{
		return "荰Мина";
	}

	// Token: 0x06009AF8 RID: 39672 RVA: 0x003C6468 File Offset: 0x003C4668
	public override string bu()
	{
		return "mine";
	}

	// Token: 0x06009AF9 RID: 39673 RVA: 0x003C6470 File Offset: 0x003C4670
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009AFA RID: 39674 RVA: 0x003C6474 File Offset: 0x003C4674
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Traps;
	}

	// Token: 0x06009AFB RID: 39675 RVA: 0x003C647C File Offset: 0x003C467C
	public hf()
	{
		base.Slots.Add("casing", new cgo(new c6s(ms.az, 45), "Корпус мины", false, 1, 0.1f, false, false, null));
		base.Slots.Add("primaryEx", new cgo(new c6s(ms.m, 11), "Основной взрывчатый заряд", false, 1, 0.1f, false, false, null));
		base.Slots.Add("secondaryEx", new cgo(new c6s(ms.m, 11), "Дополнительный взрывчатый заряд", true, 1, 1.25f, false, false, null));
	}

	// Token: 0x06009AFC RID: 39676 RVA: 0x003C6518 File Offset: 0x003C4718
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("casing", null);
		fv fv2 = A_1.SafeGet("primaryEx", null);
		fv fv3 = A_1.SafeGet("secondaryEx", null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string text;
			if (fv.TypedDefinition.a5() == "thinMineCase")
			{
				text = "Traps\\HeMine";
			}
			else if (fv.TypedDefinition.a5() == "fragMineCase")
			{
				text = "Traps\\FragMine";
			}
			else
			{
				text = null;
			}
			if (text != null)
			{
				string str = (fv2 != null && fv2.TypedDefinition != null) ? fv2.TypedDefinition.a5() : null;
				string str2 = (fv3 != null && fv3.TypedDefinition != null) ? fv3.TypedDefinition.a5() : null;
				string a_ = str + str2;
				if (fv2 != null)
				{
					int num = c6o.a(a_);
					if (num > 0)
					{
						bit bit = ez2.CreateDefinitonProvider<c4j>(text + num.ToString());
						if (bit != null)
						{
							return new d48(bit);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x04003B39 RID: 15161
	private new const string a = "casing";

	// Token: 0x04003B3A RID: 15162
	private new const string b = "primaryEx";

	// Token: 0x04003B3B RID: 15163
	private const string c = "secondaryEx";
}
