using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000871 RID: 2161
public sealed class aen : ezl
{
	// Token: 0x06003514 RID: 13588 RVA: 0x00146030 File Offset: 0x00144230
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003515 RID: 13589 RVA: 0x0014603C File Offset: 0x0014423C
	public aen() : base(1)
	{
	}

	// Token: 0x06003516 RID: 13590 RVA: 0x00146048 File Offset: 0x00144248
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt1_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
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
	}
}
