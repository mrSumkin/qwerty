using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x020005AD RID: 1453
public sealed class agw : LocaleSubInterfaceController<iw, bxm>
{
	// Token: 0x060026CE RID: 9934 RVA: 0x000E1520 File Offset: 0x000DF720
	public agw(dka A_0) : base(A_0, true, true, true)
	{
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x000E1530 File Offset: 0x000DF730
	protected override bool n1(bxm A_0)
	{
		base.a(base.g().ac().a(A_0.a));
		this.a = A_0.b;
		base.g().amh();
		base.g().amf();
		base.g().aml();
		return true;
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000E1588 File Offset: 0x000DF788
	protected override void n2(el5 A_0)
	{
		if (base.h().h() == a9m.b && A_0.a() == cku.b && this.a != null)
		{
			bpo.GetServiceOrThrow<cnk>().aqu().v().a(this.a);
		}
		base.g().ami();
		base.g().amg();
		base.g().amm();
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000E15F8 File Offset: 0x000DF7F8
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled && base.g().ac().m().j().Enabled;
	}

	// Token: 0x0400161C RID: 5660
	private new dnj a;
}
