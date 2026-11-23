using System;

// Token: 0x02000E49 RID: 3657
[e79("Jy_GroverAndTreasaLeave")]
public sealed class dm2 : dgy
{
	// Token: 0x06004CCC RID: 19660 RVA: 0x0021B198 File Offset: 0x00219398
	public dm2()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("3bd83d3b-0321-4728-8668-8adb0de9ee14"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("aadea96c-0088-42dd-b661-e15cf4c00eeb"), c5x.Area).ao() as c5x;
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
				if (c5x2 != null)
				{
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.a(new ar7(c5x2));
					a.c(true);
					array2[num2] = a;
					base.a(array2);
				}
				if (c5x3 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x3));
					a2.c(true);
					array3[num3] = a2;
					base.a(array3);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array4[num4] = c8s;
				base.a(array4);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
