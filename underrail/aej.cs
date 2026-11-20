using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086E RID: 2158
public sealed class aej : ezl
{
	// Token: 0x0600350B RID: 13579 RVA: 0x00145BA0 File Offset: 0x00143DA0
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x0600350C RID: 13580 RVA: 0x00145BAC File Offset: 0x00143DAC
	public aej() : base(4)
	{
	}

	// Token: 0x0600350D RID: 13581 RVA: 0x00145BB8 File Offset: 0x00143DB8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		int value = base.a(A_0);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt4_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_irh-pt4_dog", StringComparison.OrdinalIgnoreCase))
			{
				list2.Add(csd);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x a_ = gx.a(list[i], new int?(value), "Ironheads", null, null, null, null, false, null, false);
				this.iy(a_);
			}
		}
		if (Enumerable.Any<csd>(list2))
		{
			Random random = new Random();
			int num = random.Next(0, 101);
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] != null && random.Next(0, 101) > 40)
				{
					if (dk2.b("xpbl") && num > 80)
					{
						c5x a_2 = gx.a(list2[j], "lu_ironheads_dogs", "Doberman", null, false, null);
						this.iy(a_2);
					}
					else
					{
						c5x a_3 = gx.a(list2[j], "lu_ironheads_dogs", "Dog", null, false, null);
						this.iy(a_3);
					}
				}
			}
		}
	}
}
