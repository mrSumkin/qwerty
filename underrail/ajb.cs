using System;
using System.Collections.Generic;

// Token: 0x020015D7 RID: 5591
[euj]
public sealed class ajb
{
	// Token: 0x06007B53 RID: 31571 RVA: 0x00337D84 File Offset: 0x00335F84
	[ayh("IceWall_Tick")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		object obj;
		if (A_2 != null && A_1 != null && A_1.Zone != null && A_2.TryGetValue("totalTime", out obj) && obj is int)
		{
			int num = (int)obj;
			a3f aspect = A_1.GetAspect<a3f>();
			int num2;
			if (aspect != null)
			{
				num2 = aspect.a().GetPrimitivePropertyValue<int>("Duration", new int?(d0u.b)).Value;
			}
			else
			{
				num2 = d0u.b;
			}
			if (num >= num2)
			{
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				ad6 ad = new ad6(A_1);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(dz6.a(0.00075));
				qy.ad().Add(ad);
				List<auv> list = qy.ad();
				c7 c = new c7(A_1, false, false, true, false);
				c.a(true);
				list.Add(c);
				A_1.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
	}
}
