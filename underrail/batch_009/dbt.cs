using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085E RID: 2142
public sealed class dbt : bvc
{
	// Token: 0x060034D7 RID: 13527 RVA: 0x00144898 File Offset: 0x00142A98
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x001448A4 File Offset: 0x00142AA4
	public dbt() : base(1)
	{
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x001448B0 File Offset: 0x00142AB0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt1_guard", StringComparison.OrdinalIgnoreCase))
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
