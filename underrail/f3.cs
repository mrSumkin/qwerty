using System;
using TimelapseVertigo.Common;

// Token: 0x0200061F RID: 1567
public sealed class f3 : bad, e86
{
	// Token: 0x0600286A RID: 10346 RVA: 0x000E8970 File Offset: 0x000E6B70
	public override lu eg()
	{
		return new ik();
	}

	// Token: 0x0600286B RID: 10347 RVA: 0x000E8978 File Offset: 0x000E6B78
	public f3(ya A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600286C RID: 10348 RVA: 0x000E8988 File Offset: 0x000E6B88
	public override TimelapseCursor? eh(object A_0)
	{
		return new TimelapseCursor?(TimelapseCursor.AreaTransition);
	}

	// Token: 0x0600286D RID: 10349 RVA: 0x000E8994 File Offset: 0x000E6B94
	public sealed override void f1(c1a A_0)
	{
		bpo.GetServiceOrThrow<cnk>().aqu().v().b().GetAspect<ale>().a(base.a() as ak1, this.a);
	}

	// Token: 0x0600286E RID: 10350 RVA: 0x000E89D0 File Offset: 0x000E6BD0
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
				bsc bsc = new bsc();
				bsc.d = base.a();
				bsc.e = "MOVE_TO_TILE";
				bsc.a = new k0(djk.a(c5x.k.b, aju.ag, ak));
				if (this.a is cdo)
				{
					bsc.b = euf.b().ZoneTransitionApCost;
				}
				return bsc;
			}
		}
		return null;
	}

	// Token: 0x04001657 RID: 5719
	private new ya a;
}
