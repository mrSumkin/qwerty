using System;
using TimelapseVertigo.Common;

// Token: 0x02001862 RID: 6242
[e79(TimelapseWorkflows.LoadGameFromLocale)]
public sealed class dgm : b8q
{
	// Token: 0x060084FF RID: 34047 RVA: 0x00374768 File Offset: 0x00372968
	public dgm(a3r A_0)
	{
		base.ErrorHandling = d3s.c;
		base.f().Add(new e55());
		base.f().Add(new cqx());
		base.f().Add(new d08());
		base.f().Add(new dky());
		base.f().Add(new av2());
		base.f().Add(new c6v());
		base.f().Add(new c8s());
		base.f().Add(new bfl());
		base.f().Add(new e4r());
		base.f().Add(new d6k());
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

	// Token: 0x06008500 RID: 34048 RVA: 0x003748DC File Offset: 0x00372ADC
	public override btm ev(Exception A_0, btm A_1)
	{
		return new b1k(A_0);
	}
}
