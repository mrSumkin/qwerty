using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x020005A7 RID: 1447
public sealed class evf : LocaleSubInterfaceController<dhn, object>
{
	// Token: 0x0600267A RID: 9850 RVA: 0x000DAA60 File Offset: 0x000D8C60
	public evf(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x000DAA70 File Offset: 0x000D8C70
	protected override bool n1(object A_0)
	{
		bpo.GetServiceOrThrow<cnk>();
		base.a(base.g().ac().h());
		return true;
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x000DAA9C File Offset: 0x000D8C9C
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled;
	}
}
