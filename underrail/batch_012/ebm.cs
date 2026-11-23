using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000579 RID: 1401
public sealed class ebm : LocaleSubInterfaceController<ewq, object>
{
	// Token: 0x06002432 RID: 9266 RVA: 0x000CA9B8 File Offset: 0x000C8BB8
	public ebm(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x000CA9C8 File Offset: 0x000C8BC8
	protected override bool n1(object A_0)
	{
		base.g().amh();
		base.g().amf();
		base.g().aml();
		base.a(base.g().ac().f());
		return true;
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000CAA10 File Offset: 0x000C8C10
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled && base.g().ac().m().g() != null && base.g().ac().m().g().Enabled;
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x000CAA88 File Offset: 0x000C8C88
	protected override void n2(el5 A_0)
	{
		base.g().ami();
		base.g().amg();
		base.g().amm();
	}
}
