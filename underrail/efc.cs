using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x020005A5 RID: 1445
public sealed class efc : LocaleSubInterfaceController<a5r, object>
{
	// Token: 0x06002656 RID: 9814 RVA: 0x000D91D8 File Offset: 0x000D73D8
	public efc(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x000D91E4 File Offset: 0x000D73E4
	protected override bool n1(object A_0)
	{
		base.a(base.g().ac().g());
		return true;
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x000D9208 File Offset: 0x000D7408
	protected override void n2(el5 A_0)
	{
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x000D920C File Offset: 0x000D740C
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled;
	}
}
