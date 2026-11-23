using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086C RID: 2156
public sealed class ael : ezl
{
	// Token: 0x06003505 RID: 13573 RVA: 0x00145998 File Offset: 0x00143B98
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003506 RID: 13574 RVA: 0x001459A4 File Offset: 0x00143BA4
	public ael() : base(6)
	{
	}

	// Token: 0x06003507 RID: 13575 RVA: 0x001459B0 File Offset: 0x00143BB0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt6_guard", StringComparison.OrdinalIgnoreCase))
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
