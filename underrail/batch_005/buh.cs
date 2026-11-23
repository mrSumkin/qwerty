using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CCD RID: 3277
[e79("Xpbl_Ferry_ToddClimbsAboard")]
public sealed class buh : dgy
{
	// Token: 0x06004999 RID: 18841 RVA: 0x001EB524 File Offset: 0x001E9724
	public buh()
	{
		buh.a a = new buh.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			a.c = (new ar7(new Guid("7bb4a093-c4a3-4201-95af-5a11007a64da"), a.b.Area).ao() as c5x);
			if (a.b != null && a.c != null)
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
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
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

	// Token: 0x02000CCE RID: 3278
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600499B RID: 18843 RVA: 0x001EB6BC File Offset: 0x001E98BC
		internal bool b(e6d A_0)
		{
			b2p.d(this.a.aqu(), this.b.Zone);
			return true;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x001EB6DC File Offset: 0x001E98DC
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D27 RID: 7463
		public cnk a;

		// Token: 0x04001D28 RID: 7464
		public c5x b;

		// Token: 0x04001D29 RID: 7465
		public c5x c;
	}
}
