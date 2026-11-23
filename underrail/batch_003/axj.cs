using System;

// Token: 0x02000E43 RID: 3651
[e79("Rc_ProtectorateEnvoyLeaves")]
public sealed class axj : dgy
{
	// Token: 0x06004CC3 RID: 19651 RVA: 0x0021AB28 File Offset: 0x00218D28
	public axj()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("40f43159-5e76-4774-8484-269b1f4806d8"), c5x.Area).ao() as c5x;
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
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
