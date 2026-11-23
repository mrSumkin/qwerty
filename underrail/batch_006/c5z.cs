using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000857 RID: 2135
public sealed class c5z : bvc
{
	// Token: 0x060034C2 RID: 13506 RVA: 0x00143F00 File Offset: 0x00142100
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x00143F0C File Offset: 0x0014210C
	public c5z() : base(5)
	{
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x00143F18 File Offset: 0x00142118
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt5_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x a_ = gx.a(list[i], new int?(value), "Lurkers", null, null, null, null, false, null, false);
				this.iy(a_);
			}
		}
	}
}
