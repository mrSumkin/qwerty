using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000595 RID: 1429
public sealed class b59 : LocaleSubInterfaceController<evh, object>
{
	// Token: 0x06002501 RID: 9473 RVA: 0x000D0DE4 File Offset: 0x000CEFE4
	public b59(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x000D0DF4 File Offset: 0x000CEFF4
	protected override bool n1(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		base.a(base.g().ac().b(serviceOrThrow.aqu().v()));
		return true;
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x000D0E2C File Offset: 0x000CF02C
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled && base.g().ac().m().d().Enabled;
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x000D0E8C File Offset: 0x000CF08C
	protected override void n2(el5 A_0)
	{
		chr service = bpo.GetService<chr>();
		if (service != null && service.aw())
		{
			service.ay();
		}
	}
}
