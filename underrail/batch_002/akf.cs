using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x0200115C RID: 4444
public static class akf
{
	// Token: 0x06005F22 RID: 24354 RVA: 0x0028564C File Offset: 0x0028384C
	public static void a(aud A_0, doq A_1, int A_2, Point A_3, Action<c5x> A_4 = null)
	{
		acu.a(A_1);
		c1a c1a = A_0.Zone;
		List<ah7> list = new List<ah7>();
		foreach (ah7 ah in A_1.b())
		{
			if (c1a.i(ah.Name) == null)
			{
				akf.a(ah, A_2);
				c1a.a(ah);
				list.Add(ah);
			}
		}
		foreach (ego ego in A_1.f())
		{
			if (c1a.m(ego.Name) == null)
			{
				akf.a(ego, A_2);
				c1a.b(ego);
			}
		}
		foreach (csd csd in A_1.d())
		{
			if (c1a.g(csd.Name) == null)
			{
				csd.Location += A_3.a();
				csd.AreaName = A_0.y8();
				akf.a(csd, A_2);
				c1a.a(csd);
			}
		}
		if (A_0 != null)
		{
			cpe cpe = Enumerable.FirstOrDefault<cpe>(A_1.e());
			if (A_4 != null)
			{
				foreach (b0b b0b in cpe.Entities)
				{
					c5x obj = (c5x)b0b;
					A_4(obj);
				}
			}
			if (cpe != null)
			{
				nf.a(A_0, cpe, A_2, A_3, null);
			}
		}
		foreach (ah7 ah2 in list)
		{
			if (c1a.Initialized)
			{
				ah2.bc(true);
			}
		}
	}

	// Token: 0x06005F23 RID: 24355 RVA: 0x00285898 File Offset: 0x00283A98
	private static void a(bvq A_0, int A_1)
	{
		if (A_1 > 0)
		{
			A_0.m5(A_1);
		}
	}
}
