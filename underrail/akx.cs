using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085B RID: 2139
public sealed class akx : bvc
{
	// Token: 0x060034CE RID: 13518 RVA: 0x001444B8 File Offset: 0x001426B8
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x001444C4 File Offset: 0x001426C4
	public akx() : base(4)
	{
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x001444D0 File Offset: 0x001426D0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt4_guard", StringComparison.OrdinalIgnoreCase))
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
