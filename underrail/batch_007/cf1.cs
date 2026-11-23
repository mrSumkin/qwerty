using System;

// Token: 0x02000E84 RID: 3716
[e79("Rc_JaredArrested")]
public sealed class cf1 : dgy
{
	// Token: 0x06004D43 RID: 19779 RVA: 0x002212E8 File Offset: 0x0021F4E8
	public cf1()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("dca53356-09b6-432b-8089-13d47d34d6b4"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
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
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.c(false);
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
