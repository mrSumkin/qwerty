using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000867 RID: 2151
public sealed class aqa : cfz
{
	// Token: 0x060034F8 RID: 13560 RVA: 0x00145384 File Offset: 0x00143584
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034F9 RID: 13561 RVA: 0x00145390 File Offset: 0x00143590
	public aqa() : base(2)
	{
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x0014539C File Offset: 0x0014359C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt2_guard", StringComparison.OrdinalIgnoreCase))
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
