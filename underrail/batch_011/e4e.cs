using System;

// Token: 0x02000CDF RID: 3295
[e79("Cc_AcidHuntersLeave")]
public sealed class e4e : dgy
{
	// Token: 0x060049C5 RID: 18885 RVA: 0x001EDBF4 File Offset: 0x001EBDF4
	public e4e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				foreach (string g in new string[]
				{
					"2ec4fc90-d6aa-45ef-bdea-24cec633aa51",
					"ab7c7c03-fa87-47d4-b479-ced7899b7580",
					"468550ac-1468-4ac7-a6e6-0e91ee3f66c5"
				})
				{
					btm[] array3 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.a(new ar7(new Guid(g), c5x.Area));
					a.c(true);
					array3[num2] = a;
					base.a(array3);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array4[num3] = c8s;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
