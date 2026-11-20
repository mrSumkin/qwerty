using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BEA RID: 7146
[dgg("gr")]
public sealed class cjr : cwp
{
	// Token: 0x06009BAF RID: 39855 RVA: 0x003D07A0 File Offset: 0x003CE9A0
	public override string bt()
	{
		return "荡Граната";
	}

	// Token: 0x06009BB0 RID: 39856 RVA: 0x003D07A8 File Offset: 0x003CE9A8
	public override string bu()
	{
		return "gr";
	}

	// Token: 0x06009BB1 RID: 39857 RVA: 0x003D07B0 File Offset: 0x003CE9B0
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009BB2 RID: 39858 RVA: 0x003D07B4 File Offset: 0x003CE9B4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Grenades;
	}

	// Token: 0x06009BB3 RID: 39859 RVA: 0x003D07BC File Offset: 0x003CE9BC
	public cjr()
	{
		base.Slots.Add("casing", new cgo(new c6s(ms.l, 13), "Корпус гранаты", false, 1, 0.1f, false, false, null));
		base.Slots.Add("primaryEx", new cgo(new c6s(ms.m, 11), "Основной взрывчатый заряд", false, 1, 0.1f, false, false, null));
		base.Slots.Add("secondaryEx", new cgo(new c6s(ms.m, 11), "Дополнительный взрывчатый заряд", true, 1, 1.25f, false, false, null));
	}

	// Token: 0x06009BB4 RID: 39860 RVA: 0x003D0858 File Offset: 0x003CEA58
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet("casing", null);
		fv fv2 = A_1.SafeGet("primaryEx", null);
		fv fv3 = A_1.SafeGet("secondaryEx", null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string text;
			if (fv.TypedDefinition.a5() == "thinGrenadeCase")
			{
				text = "Grenades\\He";
			}
			else if (fv.TypedDefinition.a5() == "fragGrenadeCase")
			{
				text = "Grenades\\Frag";
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
						bit bit = ez2.CreateDefinitonProvider<cdk>(text + num.ToString());
						if (bit != null)
						{
							return new acz(bit);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x04003B8D RID: 15245
	private new const string a = "casing";

	// Token: 0x04003B8E RID: 15246
	private new const string b = "primaryEx";

	// Token: 0x04003B8F RID: 15247
	private const string c = "secondaryEx";
}
