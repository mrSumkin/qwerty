using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007FF RID: 2047
public sealed class e4d : el4
{
	// Token: 0x0600339F RID: 13215 RVA: 0x00141070 File Offset: 0x0013F270
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060033A0 RID: 13216 RVA: 0x0014107C File Offset: 0x0013F27C
	public override string a4()
	{
		return "FD_PT1X";
	}

	// Token: 0x060033A1 RID: 13217 RVA: 0x00141084 File Offset: 0x0013F284
	public override string a5()
	{
		return "Free Drones Patrol 1 X";
	}

	// Token: 0x060033A2 RID: 13218 RVA: 0x0014108C File Offset: 0x0013F28C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value;
	}

	// Token: 0x060033A3 RID: 13219 RVA: 0x001410D0 File Offset: 0x0013F2D0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033A4 RID: 13220 RVA: 0x001410D4 File Offset: 0x0013F2D4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x060033A5 RID: 13221 RVA: 0x001410EC File Offset: 0x0013F2EC
	public e4d() : base(new string[]
	{
		ega.p
	})
	{
	}

	// Token: 0x060033A6 RID: 13222 RVA: 0x00141108 File Offset: 0x0013F308
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		Random random = new Random();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fd-pt1x_guard", StringComparison.OrdinalIgnoreCase))
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
