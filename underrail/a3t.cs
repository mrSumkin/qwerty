using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000F2F RID: 3887
[e79("Xpbl_Mu_SpawnMedicalSuppliesIfInsideZone")]
public sealed class a3t : dgy
{
	// Token: 0x06004EF7 RID: 20215 RVA: 0x002386AC File Offset: 0x002368AC
	public a3t()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a3t.a a = new a3t.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
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
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
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
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F30 RID: 3888
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EF9 RID: 20217 RVA: 0x002387F8 File Offset: 0x002369F8
		internal bool a(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_b7_L2") + ".uzl");
			this.a.Area.Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x0400205D RID: 8285
		public c5x a;
	}
}
