using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x020005B0 RID: 1456
public sealed class dkq : LocaleSubInterfaceController<ekj, object>
{
	// Token: 0x060026E6 RID: 9958 RVA: 0x000E2804 File Offset: 0x000E0A04
	public dkq(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x000E2814 File Offset: 0x000E0A14
	protected override bool n1(object A_0)
	{
		base.a(base.g().ac().t());
		return true;
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x000E2838 File Offset: 0x000E0A38
	protected override bool ow()
	{
		return base.g().ac().n().Visible && base.g().ac().n().Enabled && base.g().ac().n().k().Enabled;
	}
}
