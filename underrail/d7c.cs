using System;
using TimelapseVertigo.Game.Events.Handlers;

// Token: 0x02000569 RID: 1385
public sealed class d7c : LocaleControllerEventHandlerBase<czu>
{
	// Token: 0x060023E0 RID: 9184 RVA: 0x000C6DAC File Offset: 0x000C4FAC
	public d7c(dka A_0) : base(A_0)
	{
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x000C6DB8 File Offset: 0x000C4FB8
	public override void cr(czu A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0.c() == serviceOrThrow.aqu().v().b())
		{
			if (A_0 is ed7)
			{
				base.a().a(A_0.c(), A_0.d());
				return;
			}
			if (A_0 is t9)
			{
				base.a().x();
			}
		}
	}
}
