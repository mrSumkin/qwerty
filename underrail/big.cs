using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B8E RID: 7054
[dgg("fragLauncherGrenade")]
public sealed class big : cwp
{
	// Token: 0x06009914 RID: 39188 RVA: 0x003BB6D4 File Offset: 0x003B98D4
	public override string bt()
	{
		return "茼Осколочная граната для гранатомёта";
	}

	// Token: 0x06009915 RID: 39189 RVA: 0x003BB6DC File Offset: 0x003B98DC
	public override string bu()
	{
		return "fragLauncherGrenade";
	}

	// Token: 0x06009916 RID: 39190 RVA: 0x003BB6E4 File Offset: 0x003B98E4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009917 RID: 39191 RVA: 0x003BB6E8 File Offset: 0x003B98E8
	public override int dq()
	{
		return 10;
	}

	// Token: 0x06009918 RID: 39192 RVA: 0x003BB6EC File Offset: 0x003B98EC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009919 RID: 39193 RVA: 0x003BB6F0 File Offset: 0x003B98F0
	public big()
	{
		base.Slots.Add("case", new cgo(new c6s(ms.bt, 92), "Любой корпус гранаты для гранатомёта", false, 10, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 2, 0.1f, false, false, null));
		base.Slots.Add("scraps", new cgo(new eh0(new string[]
		{
			"metalScraps"
		}, 86), "Металлолом", false, 80, 0.1f, false, false, null));
	}

	// Token: 0x0600991A RID: 39194 RVA: 0x003BB79C File Offset: 0x003B999C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			AmmoType? primitivePropertyValue = A_1.SafeGet("case", null).TypedDefinition.a7().GetPrimitivePropertyValue<AmmoType>("CaseType", null);
			if (primitivePropertyValue == null)
			{
				A_2 = "Несовместимый корпус гранаты.";
				return null;
			}
			string path = "ammo\\xphw\\" + primitivePropertyValue.Value.ToString() + "_Frag";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
