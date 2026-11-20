using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086A RID: 2154
public sealed class aer : ezl
{
	// Token: 0x060034FF RID: 13567 RVA: 0x001455B8 File Offset: 0x001437B8
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x001455C4 File Offset: 0x001437C4
	public aer() : base(8)
	{
	}

	// Token: 0x06003501 RID: 13569 RVA: 0x001455D0 File Offset: 0x001437D0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt8_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt8_dog", StringComparison.OrdinalIgnoreCase))
			{
				list2.Add(csd);
			}
		}
		gx gx = new gx();
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
				if (list2[j] != null && random.Next(0, 101) > 30)
				{
					if (dk2.b("xpbl") && num > 50)
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
