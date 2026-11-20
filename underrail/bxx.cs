using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000864 RID: 2148
public sealed class bxx : cfz
{
	// Token: 0x060034EF RID: 13551 RVA: 0x00145078 File Offset: 0x00143278
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x00145084 File Offset: 0x00143284
	public bxx() : base(5)
	{
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x00145090 File Offset: 0x00143290
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt5_guard", StringComparison.OrdinalIgnoreCase))
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
