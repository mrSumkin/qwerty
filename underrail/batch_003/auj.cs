using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D30 RID: 3376
[e79("Cc_RepairHydraulicGenerator")]
public sealed class auj : dgy
{
	// Token: 0x06004A6C RID: 19052 RVA: 0x001F9618 File Offset: 0x001F7818
	public auj()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			auj.a a = new auj.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
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
				btm[] array3 = new btm[1];
				int num3 = 0;
				egx egx = new egx();
				egx.a("Ух, кажется всё готово.");
				array3[num3] = new ace(egx)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array3);
			}
		}
	}

	// Token: 0x02000D31 RID: 3377
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A6E RID: 19054 RVA: 0x001F9780 File Offset: 0x001F7980
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "repairHydraulic", true);
			return true;
		}

		// Token: 0x04001DBC RID: 7612
		public c5x a;
	}
}
