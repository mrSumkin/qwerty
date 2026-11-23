using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007FE RID: 2046
public sealed class c6u : el4
{
	// Token: 0x06003397 RID: 13207 RVA: 0x00140E10 File Offset: 0x0013F010
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003398 RID: 13208 RVA: 0x00140E1C File Offset: 0x0013F01C
	public override string a4()
	{
		return "FD_PT1Y";
	}

	// Token: 0x06003399 RID: 13209 RVA: 0x00140E24 File Offset: 0x0013F024
	public override string a5()
	{
		return "Free Drones Patrol 1 Y";
	}

	// Token: 0x0600339A RID: 13210 RVA: 0x00140E2C File Offset: 0x0013F02C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value;
	}

	// Token: 0x0600339B RID: 13211 RVA: 0x00140E70 File Offset: 0x0013F070
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600339C RID: 13212 RVA: 0x00140E74 File Offset: 0x0013F074
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x0600339D RID: 13213 RVA: 0x00140E8C File Offset: 0x0013F08C
	public c6u() : base(new string[]
	{
		ega.q
	})
	{
	}

	// Token: 0x0600339E RID: 13214 RVA: 0x00140EA8 File Offset: 0x0013F0A8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		Random random = new Random();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fd-pt1y_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("global_freeDronesPatrols_killed");
		list2.Add(x);
		List<cze> a_ = list2;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x c5x;
				if (random.Next(0, 101) > 30)
				{
					c5x = gx.a(list[i], new int?(15), "Lurkers", "Free Drone Fighter", asp.dc, null, "randomEvents\\fd_patrol1", true, a_, false);
				}
				else
				{
					c5x = gx.a(list[i], new int?(10), "Ironheads", "Free Drone Fighter", asp.dc, null, "randomEvents\\fd_patrol1", true, a_, false);
				}
				this.iy(c5x);
				e3l e3l = c5x.GetAspect<e3l>();
				if (e3l == null)
				{
					e3l = new e3l(c5x);
					c5x.SetAspect<e3l>(e3l);
				}
				e3l.a.Add("SurvivingSnitch");
				if (c5x.h.b != null)
				{
					c5x.h.b.aa().HostilityBroadcastMode = c2n.c;
				}
			}
		}
	}
}
