using System;
using TimelapseVertigo.Game.Events.Handlers;

// Token: 0x0200056B RID: 1387
public sealed class bx4 : LocaleControllerEventHandlerBase<epm>
{
	// Token: 0x060023E5 RID: 9189 RVA: 0x000C6E54 File Offset: 0x000C5054
	public bx4(dka A_0) : base(A_0)
	{
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x000C6E60 File Offset: 0x000C5060
	public override void cr(epm A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0.d() == serviceOrThrow.aqu().v().b())
		{
			if (A_0 is nq)
			{
				base.a().a(A_0.d(), A_0.c());
				return;
			}
			if (A_0 is ehk)
			{
				base.a().anb(null);
			}
		}
	}
}
