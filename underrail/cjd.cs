using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085A RID: 2138
public sealed class cjd : bvc
{
	// Token: 0x060034CB RID: 13515 RVA: 0x001442E0 File Offset: 0x001424E0
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x001442EC File Offset: 0x001424EC
	public cjd() : base(8)
	{
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x001442F8 File Offset: 0x001424F8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt8_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_lrk-pt8_dog", StringComparison.OrdinalIgnoreCase))
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
				if (list2[j] != null && random.Next(0, 101) > 30)
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
