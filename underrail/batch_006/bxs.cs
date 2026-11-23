using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CA5 RID: 3237
[e79("lux_uwa_ritualEnd")]
public sealed class bxs : dgy
{
	// Token: 0x0600491B RID: 18715 RVA: 0x001DE6CC File Offset: 0x001DC8CC
	public bxs()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bxs.a a = new bxs.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			a.b = (new ar7(new Guid("f4eedc64-e18b-4aa7-b1ef-58ad8ba948b9"), a.a.Area).ao() as c5x);
			if (a.a != null && a.b != null)
			{
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.IsAsync = true;
				dva.a(new Func<e6d, bool>(a.a));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
			}
		}
	}

	// Token: 0x0600491C RID: 18716 RVA: 0x001DE830 File Offset: 0x001DCA30
	[CompilerGenerated]
	public object a()
	{
		return this.a;
	}

	// Token: 0x04001CE6 RID: 7398
	[CompilerGenerated]
	private new readonly object a;

	// Token: 0x02000CA6 RID: 3238
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600491E RID: 18718 RVA: 0x001DE844 File Offset: 0x001DCA44
		internal bool a(e6d A_0)
		{
			af7 af = ea5.b("LUWAJETR");
			if (af != null)
			{
				af(this.a, this.a, null);
			}
			return true;
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x001DE878 File Offset: 0x001DCA78
		internal bool b(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001CE7 RID: 7399
		public c5x a;

		// Token: 0x04001CE8 RID: 7400
		public c5x b;
	}
}
