using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000597 RID: 1431
public sealed class aiq : LocaleSubInterfaceController<c15, ece>
{
	// Token: 0x06002519 RID: 9497 RVA: 0x000D2788 File Offset: 0x000D0988
	public object a()
	{
		return this.a;
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000D2790 File Offset: 0x000D0990
	public aiq(dka A_0) : base(A_0, true, false, false)
	{
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000D279C File Offset: 0x000D099C
	public void b()
	{
		if (base.h() != null)
		{
			base.h().d();
		}
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x000D27B4 File Offset: 0x000D09B4
	protected override bool n1(ece A_0)
	{
		czh.a(A_0, "context");
		this.a = A_0.c();
		base.a(base.g().ac().a(A_0.e(), A_0.d(), A_0.a(), A_0.b()));
		return true;
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x000D2808 File Offset: 0x000D0A08
	protected override void n2(el5 A_0)
	{
		chr service = bpo.GetService<chr>();
		if (service != null && service.aw())
		{
			service.ay();
		}
		ny aspect = ces.c().b().GetAspect<ny>();
		if (aspect != null)
		{
			aspect.a(m7.g, true, false);
		}
	}

	// Token: 0x04001588 RID: 5512
	private new object a;
}
