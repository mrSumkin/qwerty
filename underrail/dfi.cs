using System;

// Token: 0x02000EB3 RID: 3763
[e79("Fls_RatkingLeaves")]
public sealed class dfi : dgy
{
	// Token: 0x06004DA8 RID: 19880 RVA: 0x00227A04 File Offset: 0x00225C04
	public dfi()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("5f53e231-393f-4b05-9569-8e40245652cd"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("d7aafa30-04fd-4e68-9ca4-6b6e744990e3"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("abb4e654-7bbb-4ff6-8dd8-abd0f243adcc"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("7fe378ab-1f9f-479e-b1bd-8f2bc601cc7b"), c5x.Area).ao() as c5x;
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
					array2[num2] = a;
					base.a(array2);
				}
				if (c5x3 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x3));
					array3[num3] = a2;
					base.a(array3);
				}
				if (c5x4 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(c5x4));
					array4[num4] = a3;
					base.a(array4);
				}
				if (c5x5 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a4 = new a5();
					a4.a(new ar7(c5x5));
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
			}
		}
	}
}
