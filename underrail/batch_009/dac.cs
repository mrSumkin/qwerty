using System;

// Token: 0x02000E46 RID: 3654
[e79("Fo_TodorLeaves")]
public sealed class dac : dgy
{
	// Token: 0x06004CC7 RID: 19655 RVA: 0x0021ADF8 File Offset: 0x00218FF8
	public dac()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				c5x c5x2 = new ar7(new Guid("f6667db1-2de2-4330-b37e-ffb7a6c35df0"), c5x.Area).ao() as c5x;
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
