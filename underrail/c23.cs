using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x020005AB RID: 1451
public sealed class c23 : LocaleSubInterfaceController<dm1, object>
{
	// Token: 0x060026AE RID: 9902 RVA: 0x000DD634 File Offset: 0x000DB834
	public c23(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x000DD640 File Offset: 0x000DB840
	protected override bool n1(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		base.a(base.g().ac().a(serviceOrThrow.aqu().v()));
		return true;
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x000DD678 File Offset: 0x000DB878
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled;
	}
}
