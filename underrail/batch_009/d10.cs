using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B82 RID: 7042
[dgg("bearTrap")]
public sealed class d10 : cwp
{
	// Token: 0x060098BD RID: 39101 RVA: 0x003BA40C File Offset: 0x003B860C
	public override string bt()
	{
		return "荵Капкан";
	}

	// Token: 0x060098BE RID: 39102 RVA: 0x003BA414 File Offset: 0x003B8614
	public override string bu()
	{
		return "bearTrap";
	}

	// Token: 0x060098BF RID: 39103 RVA: 0x003BA41C File Offset: 0x003B861C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060098C0 RID: 39104 RVA: 0x003BA420 File Offset: 0x003B8620
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Traps;
	}

	// Token: 0x060098C1 RID: 39105 RVA: 0x003BA428 File Offset: 0x003B8628
	public d10()
	{
		base.Slots.Add(d10.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d10.b, new cgo(new c6s(new ms[]
		{
			ms.aq
		}, 5), "Яд", true, 1, 0f, false, false, null));
	}

	// Token: 0x060098C2 RID: 39106 RVA: 0x003BA4A0 File Offset: 0x003B86A0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(d10.a, null);
		fv fv2 = A_1.SafeGet(d10.b, null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string text = "";
			if (fv2 != null && fv2.TypedDefinition != null)
			{
				text = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("PoisonCode");
				if (!string.IsNullOrEmpty(text))
				{
					text = text.Replace(" ", "");
				}
				else
				{
					text = "invalidPoison";
				}
			}
			string path = string.Format("Traps\\{0}BearTrap", text);
			if (ez2.GetItemDefinition<c4j>(path, true) != null)
			{
				d48 d = new d48(ez2.CreateDefinitonProvider<dj3>(path));
				if (!string.IsNullOrEmpty(text))
				{
					d.Stacks = 5;
				}
				else
				{
					d.Stacks = 10;
				}
				return d;
			}
			A_2 = "Нельзя использовать этот химикат.";
		}
		return null;
	}

	// Token: 0x04003A8D RID: 14989
	public new static readonly string a = "metal";

	// Token: 0x04003A8E RID: 14990
	public new static readonly string b = "poison";
}
