using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086D RID: 2157
public sealed class aek : ezl
{
	// Token: 0x06003508 RID: 13576 RVA: 0x00145A9C File Offset: 0x00143C9C
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003509 RID: 13577 RVA: 0x00145AA8 File Offset: 0x00143CA8
	public aek() : base(5)
	{
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x00145AB4 File Offset: 0x00143CB4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt5_guard", StringComparison.OrdinalIgnoreCase))
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
