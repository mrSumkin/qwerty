using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000805 RID: 2053
public sealed class e4s : el4
{
	// Token: 0x060033D1 RID: 13265 RVA: 0x00141FEC File Offset: 0x001401EC
	protected override esj a3()
	{
		return new esj(9, 5);
	}

	// Token: 0x060033D2 RID: 13266 RVA: 0x00141FF8 File Offset: 0x001401F8
	public override string a4()
	{
		return "FL_PT1X";
	}

	// Token: 0x060033D3 RID: 13267 RVA: 0x00142000 File Offset: 0x00140200
	public override string a5()
	{
		return "Protectorate Patrol 1 X";
	}

	// Token: 0x060033D4 RID: 13268 RVA: 0x00142008 File Offset: 0x00140208
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value);
	}

	// Token: 0x060033D5 RID: 13269 RVA: 0x00142070 File Offset: 0x00140270
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033D6 RID: 13270 RVA: 0x00142074 File Offset: 0x00140274
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060033D7 RID: 13271 RVA: 0x0014208C File Offset: 0x0014028C
	public e4s() : base(new string[]
	{
		ega.v
	})
	{
	}

	// Token: 0x060033D8 RID: 13272 RVA: 0x001420A4 File Offset: 0x001402A4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fl-pt1x", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_fl-pt1x_guard", StringComparison.OrdinalIgnoreCase))
			{
				c5x c5x;
				if (list[i].Name == "randomEvent_fl-pt1x_guard1")
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_fl-pt1x_rat", StringComparison.OrdinalIgnoreCase))
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
