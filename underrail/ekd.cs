using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x0200059F RID: 1439
public sealed class ekd : LocaleSubInterfaceController<ckj, object>
{
	// Token: 0x0600263C RID: 9788 RVA: 0x000D838C File Offset: 0x000D658C
	public ekd(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x000D839C File Offset: 0x000D659C
	protected override bool n1(object A_0)
	{
		base.a(base.g().ac().u());
		return true;
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x000D83C0 File Offset: 0x000D65C0
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled;
	}
}
