using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B9C RID: 7068
[dgg("highExplosiveLauncherGrenade")]
public sealed class cre : cwp
{
	// Token: 0x06009974 RID: 39284 RVA: 0x003BC618 File Offset: 0x003BA818
	public override string bt()
	{
		return "茿Фугасная граната для гранатомёта";
	}

	// Token: 0x06009975 RID: 39285 RVA: 0x003BC620 File Offset: 0x003BA820
	public override string bu()
	{
		return "highExplosiveLauncherGrenade";
	}

	// Token: 0x06009976 RID: 39286 RVA: 0x003BC628 File Offset: 0x003BA828
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009977 RID: 39287 RVA: 0x003BC62C File Offset: 0x003BA82C
	public override int dq()
	{
		return 10;
	}

	// Token: 0x06009978 RID: 39288 RVA: 0x003BC630 File Offset: 0x003BA830
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009979 RID: 39289 RVA: 0x003BC634 File Offset: 0x003BA834
	public cre()
	{
		base.Slots.Add("case", new cgo(new c6s(ms.bt, 92), "Любой корпус гранаты для гранатомёта", false, 10, 0.1f, false, false, null));
		base.Slots.Add("hexogen", new cgo(new eh0("hexogen", 11), "Гексоген", false, 1, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 2, 0.1f, false, false, null));
	}

	// Token: 0x0600997A RID: 39290 RVA: 0x003BC6D8 File Offset: 0x003BA8D8
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
			string path = "ammo\\xphw\\" + primitivePropertyValue.Value.ToString() + "_He";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
