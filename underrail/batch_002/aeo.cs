using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000870 RID: 2160
public sealed class aeo : ezl
{
	// Token: 0x06003511 RID: 13585 RVA: 0x00145F2C File Offset: 0x0014412C
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003512 RID: 13586 RVA: 0x00145F38 File Offset: 0x00144138
	public aeo() : base(2)
	{
	}

	// Token: 0x06003513 RID: 13587 RVA: 0x00145F44 File Offset: 0x00144144
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt2_guard", StringComparison.OrdinalIgnoreCase))
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
