using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000863 RID: 2147
public sealed class awp : cfz
{
	// Token: 0x060034EC RID: 13548 RVA: 0x00144F74 File Offset: 0x00143174
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x00144F80 File Offset: 0x00143180
	public awp() : base(6)
	{
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x00144F8C File Offset: 0x0014318C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt6_guard", StringComparison.OrdinalIgnoreCase))
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
