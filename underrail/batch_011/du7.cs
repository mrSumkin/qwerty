using System;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000643 RID: 1603
[e7l(SpellTargetType.RepairableMechanicalItem)]
public sealed class du7 : atd
{
	// Token: 0x060028E6 RID: 10470 RVA: 0x000E9EA0 File Offset: 0x000E80A0
	public du7(av A_0)
	{
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x000E9EAC File Offset: 0x000E80AC
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return (cd == null || cd.TypedDefinition == null || !cd.TypedDefinition.ao) && (A_0.Definition != null && !A_0.Definition.a9() && A_0.MaxDurability > 0 && (int)A_0.Durability < A_0.MaxDurability) && A_0.Definition.ay() == ItemRepairCategory.Mechanical;
	}

	// Token: 0x060028E8 RID: 10472 RVA: 0x000E9F2C File Offset: 0x000E812C
	public override bcw c5()
	{
		return bcw.c;
	}
}
