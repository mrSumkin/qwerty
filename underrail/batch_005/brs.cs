using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000868 RID: 2152
public sealed class brs : cfz
{
	// Token: 0x060034FB RID: 13563 RVA: 0x00145488 File Offset: 0x00143688
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034FC RID: 13564 RVA: 0x00145494 File Offset: 0x00143694
	public brs() : base(1)
	{
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x001454A0 File Offset: 0x001436A0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt1_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x a_ = gx.a(list[i], new int?(value), "Lunatics", null, null, null, null, false, null, false);
				this.iy(a_);
			}
		}
	}
}
