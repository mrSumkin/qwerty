using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000865 RID: 2149
public sealed class c05 : cfz
{
	// Token: 0x060034F2 RID: 13554 RVA: 0x0014517C File Offset: 0x0014337C
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x00145188 File Offset: 0x00143388
	public c05() : base(4)
	{
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x00145194 File Offset: 0x00143394
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt4_guard", StringComparison.OrdinalIgnoreCase))
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
