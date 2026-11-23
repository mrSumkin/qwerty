using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000861 RID: 2145
public sealed class eoi : cfz
{
	// Token: 0x060034E6 RID: 13542 RVA: 0x00144D6C File Offset: 0x00142F6C
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x00144D78 File Offset: 0x00142F78
	public eoi() : base(8)
	{
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x00144D84 File Offset: 0x00142F84
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lnt-pt8_guard", StringComparison.OrdinalIgnoreCase))
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
