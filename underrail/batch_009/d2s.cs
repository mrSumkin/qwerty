using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000858 RID: 2136
public sealed class d2s : bvc
{
	// Token: 0x060034C5 RID: 13509 RVA: 0x00144004 File Offset: 0x00142204
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x00144010 File Offset: 0x00142210
	public d2s() : base(6)
	{
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x0014401C File Offset: 0x0014221C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt6_guard", StringComparison.OrdinalIgnoreCase))
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
