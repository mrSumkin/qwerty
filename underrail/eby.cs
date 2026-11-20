using System;

// Token: 0x02000DD5 RID: 3541
[e79("Sgs_StartTutorial")]
public sealed class eby : dgy
{
	// Token: 0x06004BE2 RID: 19426 RVA: 0x0020FD24 File Offset: 0x0020DF24
	public eby()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Zone != null)
			{
				c5x a_ = new ar7(new Guid("3ffe2517-6ac6-47ec-b32d-de984bee5d30"), c5x.Area).ao() as c5x;
				btm[] array = new btm[1];
				int num = 0;
				d92 d = new d92();
				d.a("characters\\sgs_vencel");
				d.b(new ar7(a_));
				d.a(new ar7(c5x));
				array[num] = d;
				base.a(array);
			}
		}
	}
}
