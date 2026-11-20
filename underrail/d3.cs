using System;
using TimelapseVertigo.Common;

// Token: 0x02001863 RID: 6243
[e79(TimelapseWorkflows.LoadGameFromMainMenu)]
public sealed class d3 : b8q
{
	// Token: 0x06008501 RID: 34049 RVA: 0x003748E8 File Offset: 0x00372AE8
	public d3(a3r A_0)
	{
		base.ErrorHandling = d3s.c;
		base.f().Add(new cqx());
		base.f().Add(new dky());
		base.f().Add(new c6v());
		base.f().Add(new c8s());
		base.f().Add(new dtj(A_0.FolderName, A_0.Transitional));
		base.f().Add(new cnd());
		base.f().Add(new cqx());
		if (A_0.Transitional)
		{
			base.f().Add(new eif());
		}
		base.f().Add(new dky());
		base.f().Add(new dzv());
		base.f().Add(new cg());
		base.f().Add(new c8s());
		base.f().Add(new by());
		base.f().Add(new ehb());
	}

	// Token: 0x06008502 RID: 34050 RVA: 0x003749FC File Offset: 0x00372BFC
	public override btm ev(Exception A_0, btm A_1)
	{
		return new b1k(A_0);
	}
}
