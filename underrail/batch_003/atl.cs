using System;

// Token: 0x02000621 RID: 1569
public sealed class atl : bad, e86
{
	// Token: 0x06002873 RID: 10355 RVA: 0x000E8CE8 File Offset: 0x000E6EE8
	public override lu eg()
	{
		return new ik();
	}

	// Token: 0x06002874 RID: 10356 RVA: 0x000E8CF0 File Offset: 0x000E6EF0
	public override bool io()
	{
		efk efk = ces.c();
		return base.io() && efk != null && efk.IsMobile;
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x000E8D1C File Offset: 0x000E6F1C
	public sealed override void f1(c1a A_0)
	{
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		if (c5x != null && c5x.Zone != null && c5x.i.b != null && c5x.k.b != null)
		{
			c5x.k.b.a(base.a() as ak1, aju.ag, 10, 500, true);
		}
	}

	// Token: 0x06002876 RID: 10358 RVA: 0x000E8DA0 File Offset: 0x000E6FA0
	public bsc ei()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInControl)
		{
			bpo.GetService<d02>();
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			ak1 ak = base.a() as ak1;
			if (c5x != null && ak != null && ak.a(serviceOrThrow.aqu().v().a().d))
			{
				return new bsc
				{
					d = base.a(),
					e = "MOVE_TO_TILE",
					a = new k0(djk.a(c5x.k.b, aju.ag, ak))
				};
			}
		}
		return null;
	}
}
