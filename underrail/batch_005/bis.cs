using System;
using TimelapseVertigo.Game.Controllers;

// Token: 0x0200057D RID: 1405
public sealed class bis : LocaleSubInterfaceController<b6o, aim>
{
	// Token: 0x0600243F RID: 9279 RVA: 0x000CACD8 File Offset: 0x000C8ED8
	public bis(dka A_0) : base(A_0, false, false, true)
	{
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000CACE4 File Offset: 0x000C8EE4
	public eg a()
	{
		return this.a.a();
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x000CACF4 File Offset: 0x000C8EF4
	protected override bool n1(aim A_0)
	{
		czh.a(A_0, "context");
		this.a = A_0;
		base.a(base.g().ac().a(A_0.a(), A_0.b()));
		return true;
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x000CAD38 File Offset: 0x000C8F38
	protected override void n2(el5 A_0)
	{
		if (this.a.c() != null && this.a.c().i != null && this.a.c().i.b != null)
		{
			this.a.c().i.b.a(m7.h, true, false);
		}
		if (this.a.d() != null && this.a.d().i != null && this.a.d().i.b != null)
		{
			this.a.d().i.b.a(m7.h, true, false);
		}
	}

	// Token: 0x04001509 RID: 5385
	private new aim a;
}
