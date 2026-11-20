using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085D RID: 2141
public sealed class d78 : bvc
{
	// Token: 0x060034D4 RID: 13524 RVA: 0x00144794 File Offset: 0x00142994
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x001447A0 File Offset: 0x001429A0
	public d78() : base(2)
	{
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x001447AC File Offset: 0x001429AC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt2_guard", StringComparison.OrdinalIgnoreCase))
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
