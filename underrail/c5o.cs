using System;
using TimelapseVertigo.Common;

// Token: 0x0200061E RID: 1566
public sealed class c5o : bad, e86
{
	// Token: 0x06002865 RID: 10341 RVA: 0x000E883C File Offset: 0x000E6A3C
	public override lu eg()
	{
		return new c5d();
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x000E8844 File Offset: 0x000E6A44
	public override TimelapseCursor? eh(object A_0)
	{
		return new TimelapseCursor?(TimelapseCursor.Talk);
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x000E8850 File Offset: 0x000E6A50
	public override void f1(c1a A_0)
	{
		bpo.GetServiceOrThrow<cnk>().aqu().v().b().GetAspect<j7>().a((base.a() as b0b).GetAspect<j7>(), false, null, false);
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x000E8890 File Offset: 0x000E6A90
	public bsc ei()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().IsInControl)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				c5x c5x2 = base.a() as c5x;
				if (c5x != null && c5x.h.b != null && c5x2 != null)
				{
					return new bsc
					{
						d = base.a(),
						e = "TALK",
						a = d7x.a(c5x, base.a(), aju.q, null, null, 0),
						b = 0
					};
				}
			}
		}
		return null;
	}
}
