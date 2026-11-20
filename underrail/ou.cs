using System;

// Token: 0x02000E34 RID: 3636
[e79("Lux_HephaestusCrewLeaves")]
public sealed class ou : dgy
{
	// Token: 0x06004CA6 RID: 19622 RVA: 0x00218A80 File Offset: 0x00216C80
	public ou()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("c1634ec4-bc97-434b-983b-7aedf599c550"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("f705a683-cd0b-4f93-98be-9d0b61f7f3f8"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("f8f8320a-6ef0-42c2-9128-405fc2b5899d"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("5795a142-6c61-4cb9-8256-0dd7e638bb7e"), c5x.Area).ao() as c5x;
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
				if (c5x4 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(c5x4));
					a3.c(true);
					array4[num4] = a3;
					base.a(array4);
				}
				if (c5x5 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a4 = new a5();
					a4.a(new ar7(c5x5));
					a4.c(true);
					array5[num5] = a4;
					base.a(array5);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array6[num6] = c8s;
				base.a(array6);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
