using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000574 RID: 1396
public sealed class bd2 : LocaleSubInterfaceController<zj, b22>
{
	// Token: 0x06002407 RID: 9223 RVA: 0x000C8004 File Offset: 0x000C6204
	public object a()
	{
		return this.a;
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000C800C File Offset: 0x000C620C
	public bd2(dka A_0) : base(A_0, true, false, false)
	{
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x000C8018 File Offset: 0x000C6218
	public void b()
	{
		if (base.h() != null)
		{
			base.h().g();
		}
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x000C8030 File Offset: 0x000C6230
	protected override bool n1(b22 A_0)
	{
		czh.a(A_0, "context");
		this.a = A_0.a();
		base.a(base.g().ac().a(A_0.b(), A_0.e(), A_0.d(), A_0.a()));
		return true;
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000C8084 File Offset: 0x000C6284
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

	// Token: 0x040014DB RID: 5339
	private new object a;
}
