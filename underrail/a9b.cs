using System;

// Token: 0x02000CE9 RID: 3305
[e79("Cc_JonTheBeautifulLeaves")]
public sealed class a9b : dgy
{
	// Token: 0x060049D2 RID: 18898 RVA: 0x001EE8FC File Offset: 0x001ECAFC
	public a9b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x.i.b.a(true, false);
				c5x c5x2 = new ar7(new Guid("a0735df6-b749-42fc-9fe6-fa1c592c3b6f"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.i.b.a(true, false);
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
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.c(true);
					a.a(new ar7(c5x2));
					array2[num2] = a;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
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
}
