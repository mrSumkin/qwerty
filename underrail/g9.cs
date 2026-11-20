using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000862 RID: 2146
public sealed class g9 : cfz
{
	// Token: 0x060034E9 RID: 13545 RVA: 0x00144E70 File Offset: 0x00143070
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x00144E7C File Offset: 0x0014307C
	public g9() : base(7)
	{
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x00144E88 File Offset: 0x00143088
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt7_guard", StringComparison.OrdinalIgnoreCase))
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
