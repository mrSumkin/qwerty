using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000572 RID: 1394
public sealed class cr8 : LocaleSubInterfaceController<ax3, object>
{
	// Token: 0x060023F5 RID: 9205 RVA: 0x000C70CC File Offset: 0x000C52CC
	public cr8(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x000C70D8 File Offset: 0x000C52D8
	protected override bool n1(object A_0)
	{
		base.a(base.g().ac().o());
		return true;
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x000C70FC File Offset: 0x000C52FC
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled && base.g().ac().m().i().Enabled;
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x000C715C File Offset: 0x000C535C
	protected override void n2(el5 A_0)
	{
		chr service = bpo.GetService<chr>();
		if (service != null && service.aw())
		{
			service.ay();
		}
	}
}
