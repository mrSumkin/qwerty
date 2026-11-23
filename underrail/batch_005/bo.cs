using System;
using TimelapseVertigo.Game.Events.Handlers;

// Token: 0x0200056D RID: 1389
public sealed class bo : LocaleControllerEventHandlerBase<dwq>
{
	// Token: 0x060023EA RID: 9194 RVA: 0x000C6F04 File Offset: 0x000C5104
	public bo(dka A_0) : base(A_0)
	{
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x000C6F10 File Offset: 0x000C5110
	public override void cr(dwq A_0)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu().v().b() == A_0.e())
		{
			base.a().amr(true, null, true);
		}
	}
}
