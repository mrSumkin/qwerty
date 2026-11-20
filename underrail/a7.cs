using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000866 RID: 2150
public sealed class a7 : cfz
{
	// Token: 0x060034F5 RID: 13557 RVA: 0x00145280 File Offset: 0x00143480
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034F6 RID: 13558 RVA: 0x0014528C File Offset: 0x0014348C
	public a7() : base(3)
	{
	}

	// Token: 0x060034F7 RID: 13559 RVA: 0x00145298 File Offset: 0x00143498
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt3_guard", StringComparison.OrdinalIgnoreCase))
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
