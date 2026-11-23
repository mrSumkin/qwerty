using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000616 RID: 1558
[e7l(SpellTargetType.TrappableSpot)]
public class bc6 : bww
{
	// Token: 0x06002850 RID: 10320 RVA: 0x000E82A8 File Offset: 0x000E64A8
	public bc6(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x000E82B4 File Offset: 0x000E64B4
	public override bool ajz(ak1 A_0)
	{
		return base.ajz(A_0) && (!A_0.Formation.b(2L) || A_0.Formation.b(128L));
	}
}
