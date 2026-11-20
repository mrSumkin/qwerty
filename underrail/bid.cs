using System;

// Token: 0x02000D69 RID: 3433
[e79("Xpbl_D5ChiefLeaves")]
public sealed class bid : dgy
{
	// Token: 0x06004AEA RID: 19178 RVA: 0x00202D20 File Offset: 0x00200F20
	public bid()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			c5x a_ = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), c5x.Area).ao() as c5x;
			c5x a_2 = new ar7(new Guid("5e069237-f790-4a3d-a505-d667f88f2d83"), c5x.Area).ao() as c5x;
			c5x a_3 = new ar7(new Guid("9a9e435f-ea2b-46f9-94bd-13cf592b262d"), c5x.Area).ao() as c5x;
			if (c5x != null)
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
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				a5 a = new a5();
				a.a(new ar7(a_));
				a.c(true);
				array2[num2] = a;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				a5 a2 = new a5();
				a2.a(new ar7(a_2));
				a2.c(true);
				array3[num3] = a2;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				a5 a3 = new a5();
				a3.a(new ar7(a_3));
				a3.c(true);
				array4[num4] = a3;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array5[num5] = c8s;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
