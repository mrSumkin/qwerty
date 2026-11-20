using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000592 RID: 1426
public sealed class e26 : LocaleSubInterfaceController<cef, object>, b9n
{
	// Token: 0x060024EE RID: 9454 RVA: 0x000D04F8 File Offset: 0x000CE6F8
	public e26(dka A_0) : base(A_0, false, true, true)
	{
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x000D0504 File Offset: 0x000CE704
	public void avt()
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.QuitGameFromLocale, new object[0]));
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x000D0520 File Offset: 0x000CE720
	protected override bool n1(object A_0)
	{
		base.a(new cef(this));
		base.h().k.c(new EventHandler<b25>(this.a));
		base.h().Location = new Point((base.g().ac().Size.c - base.h().Size.c) / 2, (base.g().ac().Size.d - base.h().Size.d) / 2);
		base.g().ac().aox(base.h());
		base.g().amh();
		base.g().amf();
		base.g().aml();
		return true;
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x000D05F0 File Offset: 0x000CE7F0
	protected override void n2(el5 A_0)
	{
		base.g().ami();
		base.g().amg();
		base.g().amm();
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x000D0620 File Offset: 0x000CE820
	protected override bool ow()
	{
		return base.g().ac().m().Visible && base.g().ac().m().Enabled && base.g().ac().m().e().Enabled;
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x000D0680 File Offset: 0x000CE880
	private void a(object A_0, b25 A_1)
	{
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		t1 t = new t1(false);
		t.Focusable = true;
		serviceOrThrow.aau().aox(t);
		t.a9();
	}
}
