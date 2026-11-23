using System;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000641 RID: 1601
[e7l(SpellTargetType.RepairableFabricItem)]
public sealed class dyu : atd
{
	// Token: 0x060028E0 RID: 10464 RVA: 0x000E9D80 File Offset: 0x000E7F80
	public dyu(av A_0)
	{
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x000E9D8C File Offset: 0x000E7F8C
	protected override bool c4(coh A_0)
	{
		cd1 cd = A_0 as cd1;
		return (cd == null || cd.TypedDefinition == null || !cd.TypedDefinition.ao) && (A_0.Definition != null && !A_0.Definition.a9() && A_0.MaxDurability > 0 && (int)A_0.Durability < A_0.MaxDurability) && A_0.Definition.ay() == ItemRepairCategory.Fabric;
	}

	// Token: 0x060028E2 RID: 10466 RVA: 0x000E9E0C File Offset: 0x000E800C
	public override bcw c5()
	{
		return bcw.c;
	}
}
