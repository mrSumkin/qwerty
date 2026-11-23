using System;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000642 RID: 1602
[e7l(SpellTargetType.RepairableElectronicItem)]
public sealed class evi : atd
{
	// Token: 0x060028E3 RID: 10467 RVA: 0x000E9E10 File Offset: 0x000E8010
	public evi(av A_0)
	{
	}

	// Token: 0x060028E4 RID: 10468 RVA: 0x000E9E1C File Offset: 0x000E801C
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return (cd == null || cd.TypedDefinition == null || !cd.TypedDefinition.ao) && (A_0.Definition != null && !A_0.Definition.a9() && A_0.MaxDurability > 0 && (int)A_0.Durability < A_0.MaxDurability) && A_0.Definition.ay() == ItemRepairCategory.Electronic;
	}

	// Token: 0x060028E5 RID: 10469 RVA: 0x000E9E9C File Offset: 0x000E809C
	public override bcw c5()
	{
		return bcw.c;
	}
}
