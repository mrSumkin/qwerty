using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086B RID: 2155
public sealed class aem : ezl
{
	// Token: 0x06003502 RID: 13570 RVA: 0x001457A8 File Offset: 0x001439A8
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003503 RID: 13571 RVA: 0x001457B4 File Offset: 0x001439B4
	public aem() : base(7)
	{
	}

	// Token: 0x06003504 RID: 13572 RVA: 0x001457C0 File Offset: 0x001439C0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt7_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt7_dog", StringComparison.OrdinalIgnoreCase))
			{
				list2.Add(csd);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x a_ = gx.a(list[i], new int?(value), "Ironheads", null, null, null, null, false, null, false);
				this.iy(a_);
			}
		}
		if (Enumerable.Any<csd>(list2))
		{
			Random random = new Random();
			int num = random.Next(0, 101);
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] != null && random.Next(0, 101) > 40)
				{
					if (dk2.b("xpbl") && num > 70)
					{
						c5x a_2 = gx.a(list2[j], "lu_ironheads_dogs", "Doberman", null, false, null);
						this.iy(a_2);
					}
					else
					{
						c5x a_3 = gx.a(list2[j], "lu_ironheads_dogs", "Dog", null, false, null);
						this.iy(a_3);
					}
				}
			}
		}
	}
}
