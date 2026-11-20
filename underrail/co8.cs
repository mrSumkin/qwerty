using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C8D RID: 3213
[e79("Dun_Lup_BoostLab_WorkbenchFade")]
public sealed class co8 : dgy
{
	// Token: 0x060048E2 RID: 18658 RVA: 0x001DB5DC File Offset: 0x001D97DC
	public co8()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			co8.a a = new co8.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && new ar7(new Guid("743dd730-3758-4e4e-b98f-7306f1e274f2"), a.a.Area).ao() is c5x)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000C8F RID: 3215
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060048EA RID: 18666 RVA: 0x001DB984 File Offset: 0x001D9B84
		internal bool a(e6d A_0)
		{
			a72 a = new a72();
			a.b("interfacing\\dun_lup_boostLab_workbench");
			a.d("interface");
			a.c("Workbench");
			a.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001CC9 RID: 7369
		public c5x a;
	}
}
