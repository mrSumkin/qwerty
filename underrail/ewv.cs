using System;
using TimelapseVertigo.Game.Events.Handlers;

// Token: 0x0200056F RID: 1391
public sealed class ewv : LocaleControllerEventHandlerBase<d2e>
{
	// Token: 0x060023EE RID: 9198 RVA: 0x000C6FB0 File Offset: 0x000C51B0
	public ewv(dka A_0) : base(A_0)
	{
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x000C6FBC File Offset: 0x000C51BC
	public override void cr(d2e A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0.d() == serviceOrThrow.aqu().v().b())
		{
			if (A_0 is bsh)
			{
				base.a().a(A_0.d(), A_0.c());
				return;
			}
			if (A_0 is md)
			{
				base.a().am9();
			}
		}
	}
}
