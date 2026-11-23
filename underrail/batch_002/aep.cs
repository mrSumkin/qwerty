using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086F RID: 2159
public sealed class aep : ezl
{
	// Token: 0x0600350E RID: 13582 RVA: 0x00145D90 File Offset: 0x00143F90
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x0600350F RID: 13583 RVA: 0x00145D9C File Offset: 0x00143F9C
	public aep() : base(3)
	{
	}

	// Token: 0x06003510 RID: 13584 RVA: 0x00145DA8 File Offset: 0x00143FA8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt3_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt3_dog", StringComparison.OrdinalIgnoreCase))
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
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] != null && random.Next(0, 101) > 50)
				{
					c5x a_2 = gx.a(list2[j], "lu_ironheads_dogs", "Dog", null, false, null);
					this.iy(a_2);
				}
			}
		}
	}
}
