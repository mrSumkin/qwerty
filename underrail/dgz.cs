using System;
using TimelapseVertigo.Game.Events.Handlers;

// Token: 0x0200056E RID: 1390
public sealed class dgz : LocaleControllerEventHandlerBase<f8>
{
	// Token: 0x060023EC RID: 9196 RVA: 0x000C6F54 File Offset: 0x000C5154
	public dgz(dka A_0) : base(A_0)
	{
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x000C6F60 File Offset: 0x000C5160
	public override void cr(f8 A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0.h() != null && A_0.h().b == serviceOrThrow.aqu().v().FactionId)
		{
			base.a().y();
		}
	}
}
