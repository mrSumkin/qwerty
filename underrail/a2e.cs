using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DE6 RID: 3558
[e79("Dc_RepairBotLeaves")]
public sealed class a2e : dgy
{
	// Token: 0x06004C02 RID: 19458 RVA: 0x00211480 File Offset: 0x0020F680
	public a2e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a2e.a a = new a2e.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				c5x c5x = new ar7(new Guid("44518e0a-2110-45c3-9520-a926e2e69246"), a.a.Area).ao() as c5x;
				new ar7(new Guid("5da66943-14ac-44fa-8fe0-ddcf9cad0f5b"), a.a.Area).ao();
				if (c5x != null)
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
					s5 s = new s5();
					s.a(new ar7(c5x));
					s.a(new bt4("guard_bot"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
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
	}

	// Token: 0x02000DE7 RID: 3559
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C04 RID: 19460 RVA: 0x00211608 File Offset: 0x0020F808
		internal bool a(e6d A_0)
		{
			a72 a = new a72();
			a.b("interfacing\\dc_repairGate");
			a.d("interface");
			a.c("Механизм ворот");
			a.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001EB0 RID: 7856
		public c5x a;
	}
}
