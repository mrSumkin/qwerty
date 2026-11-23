using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E0B RID: 3595
[e79("Tch_AmeliaLeavesFirstTime")]
public sealed class emp : dgy
{
	// Token: 0x06004C53 RID: 19539 RVA: 0x00214FCC File Offset: 0x002131CC
	public emp()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			emp.a a = new emp.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("849a5ff2-d4d0-4327-8a3d-660a7e5b7edf"), a.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array2[num2] = c8s;
				base.a(array2);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E0C RID: 3596
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C55 RID: 19541 RVA: 0x00215134 File Offset: 0x00213334
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EDF RID: 7903
		public c5x a;

		// Token: 0x04001EE0 RID: 7904
		public c5x b;
	}
}
