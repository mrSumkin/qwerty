using System;

// Token: 0x02000E7E RID: 3710
[e79("Ch_BeckLeaves")]
public sealed class c50 : dgy
{
	// Token: 0x06004D3A RID: 19770 RVA: 0x00220AD4 File Offset: 0x0021ECD4
	public c50()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("47d3dc37-3dbc-4514-9404-56ceebd19983"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("ce0c147a-b0af-42ff-99f9-4d1c155bb665"), c5x.Area).ao() as c5x;
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
				if (c5x3 != null && c5x3.t.b != null)
				{
					c5x3.t.b.y6()[ddq.ay] = new bt4("global:ch_sarine:atHome");
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
