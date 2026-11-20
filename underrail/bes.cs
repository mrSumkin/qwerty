using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x020005A9 RID: 1449
public sealed class bes : LocaleSubInterfaceController<eed, object>
{
	// Token: 0x06002689 RID: 9865 RVA: 0x000DB3B8 File Offset: 0x000D95B8
	public bes(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x000DB3C4 File Offset: 0x000D95C4
	protected override bool n1(object A_0)
	{
		base.a(base.g().ac().i());
		return true;
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x000DB3E8 File Offset: 0x000D95E8
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled;
	}
}
