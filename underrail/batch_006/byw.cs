using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E44 RID: 3652
[e79("Fo_EndTodorVisit")]
public sealed class byw : dgy
{
	// Token: 0x06004CC4 RID: 19652 RVA: 0x0021AC78 File Offset: 0x00218E78
	public byw()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				byw.a a = new byw.a();
				a.a = (new ar7(new Guid("f6667db1-2de2-4330-b37e-ffb7a6c35df0"), c5x.Area).ao() as c5x);
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
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
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
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E45 RID: 3653
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CC6 RID: 19654 RVA: 0x0021ADE0 File Offset: 0x00218FE0
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "global:fo_todor", true);
			return true;
		}

		// Token: 0x04001F36 RID: 7990
		public c5x a;
	}
}
