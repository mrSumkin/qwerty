using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000804 RID: 2052
public sealed class czn : el4
{
	// Token: 0x060033C9 RID: 13257 RVA: 0x00141CE0 File Offset: 0x0013FEE0
	protected override esj a3()
	{
		return new esj(5, 9);
	}

	// Token: 0x060033CA RID: 13258 RVA: 0x00141CEC File Offset: 0x0013FEEC
	public override string a4()
	{
		return "FL_PT1Y";
	}

	// Token: 0x060033CB RID: 13259 RVA: 0x00141CF4 File Offset: 0x0013FEF4
	public override string a5()
	{
		return "Protectorate Patrol 1 Y";
	}

	// Token: 0x060033CC RID: 13260 RVA: 0x00141CFC File Offset: 0x0013FEFC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value);
	}

	// Token: 0x060033CD RID: 13261 RVA: 0x00141D64 File Offset: 0x0013FF64
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033CE RID: 13262 RVA: 0x00141D68 File Offset: 0x0013FF68
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060033CF RID: 13263 RVA: 0x00141D80 File Offset: 0x0013FF80
	public czn() : base(new string[]
	{
		ega.w
	})
	{
	}

	// Token: 0x060033D0 RID: 13264 RVA: 0x00141D98 File Offset: 0x0013FF98
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fl-pt1y", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_fl-pt1y_guard", StringComparison.OrdinalIgnoreCase))
			{
				c5x c5x;
				if (list[i].Name == "randomEvent_fl-pt1y_guard1")
				{
					c5x = gx.a(list[i], new int?(10), "Faceless", null, "faceless_patrol", null, "randomEvents\\fl_patrol1", false, null, false);
					if (c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.bc] = "npc_rnd_facelessPatrol_met";
						c5x.t.b.y6()[ddq.bd] = 8;
					}
				}
				else
				{
					c5x = gx.a(list[i], new int?(10), "Faceless", null, "faceless_patrol", null, "support\\dc_faceless", false, null, false);
				}
				this.iy(c5x);
				if (c5x.h.b != null)
				{
					c5x.h.b.aa().HostilityBroadcastMode = c2n.c;
				}
			}
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_fl-pt1y_rat", StringComparison.OrdinalIgnoreCase))
			{
				Random random = new Random();
				random.Next(0, 101);
				if (list[i] != null && random.Next(0, 101) > 40)
				{
					c5x a_ = gx.a(list[i], "faceless_patrol_rathounds", "AugRat", null, false, null);
					this.iy(a_);
				}
			}
		}
	}
}
