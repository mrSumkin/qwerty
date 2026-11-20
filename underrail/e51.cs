using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000859 RID: 2137
public sealed class e51 : bvc
{
	// Token: 0x060034C8 RID: 13512 RVA: 0x00144108 File Offset: 0x00142308
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x00144114 File Offset: 0x00142314
	public e51() : base(7)
	{
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00144120 File Offset: 0x00142320
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt7_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt7_dog", StringComparison.OrdinalIgnoreCase))
			{
				list2.Add(csd);
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
		if (Enumerable.Any<csd>(list2))
		{
			Random random = new Random();
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] != null && random.Next(0, 101) > 40)
				{
					if (dk2.b("xpbl"))
					{
						c5x a_2 = gx.a(list2[j], "lu_lurkers_dogs", "Pitbull", null, false, null);
						this.iy(a_2);
					}
					else
					{
						c5x a_3 = gx.a(list2[j], "lu_lurkers_dogs", "Dog", null, false, null);
						this.iy(a_3);
					}
				}
			}
		}
	}
}
