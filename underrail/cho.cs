using System;

// Token: 0x0200054E RID: 1358
public static class cho
{
	// Token: 0x060022C3 RID: 8899 RVA: 0x000B8240 File Offset: 0x000B6440
	public static bool a(object A_0)
	{
		bool flag = false;
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			c3g aspect = c5x.GetAspect<c3g>();
			if (aspect != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				flag = !aspect.a(serviceOrThrow.aqu().v());
				if (flag)
				{
					bool flag2 = c5x.s.b is cnb;
					d2b aspect2 = c5x.GetAspect<d2b>();
					if (flag2 && aspect2 != null)
					{
						if (aspect2.n())
						{
							flag = (aspect2.o() > d1c.a);
						}
						else
						{
							flag = (aspect2.o() == d1c.c);
						}
					}
				}
			}
		}
		return flag;
	}
}
