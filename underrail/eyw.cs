using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000645 RID: 1605
[e7l(SpellTargetType.PoweredItem)]
public sealed class eyw : atd
{
	// Token: 0x060028EC RID: 10476 RVA: 0x000E9FB0 File Offset: 0x000E81B0
	public eyw(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x000E9FC4 File Offset: 0x000E81C4
	protected override bool c4(coh A_0)
	{
		return A_0.MaxBattery > 0 && A_0.Battery < (double)A_0.MaxBattery && (A_0.Definition.bd() || this.a == null || this.a.b8() == null || !this.a.b8().IsInCombat);
	}

	// Token: 0x04001663 RID: 5731
	private av a;
}
