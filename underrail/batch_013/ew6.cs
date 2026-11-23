using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F2 RID: 2034
public sealed class ew6 : el4
{
	// Token: 0x06003332 RID: 13106 RVA: 0x0013EDDC File Offset: 0x0013CFDC
	protected override esj a3()
	{
		return new esj(4, 9);
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x0013EDE8 File Offset: 0x0013CFE8
	public override string a4()
	{
		return "PRO_PT_VS_EV1Y";
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x0013EDF0 File Offset: 0x0013CFF0
	public override string a5()
	{
		return "Protectorate Patrol vs Everyone 1 Y";
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x0013EDF8 File Offset: 0x0013CFF8
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x0013EE60 File Offset: 0x0013D060
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003337 RID: 13111 RVA: 0x0013EE64 File Offset: 0x0013D064
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003338 RID: 13112 RVA: 0x0013EE7C File Offset: 0x0013D07C
	public ew6() : base(new string[]
	{
		ega.o,
		ega.s
	})
	{
	}

	// Token: 0x06003339 RID: 13113 RVA: 0x0013EE9C File Offset: 0x0013D09C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt-vs-ev1y", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		Random random = new Random();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("global_protectoratePatrols_killed");
		list2.Add(x);
		List<cze> a_ = list2;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev1y_pro"))
			{
				c5x c5x = gx.a(list[i], new int?(10), "Protectorate", null, asp.be, null, "randomEvents\\pr_patrol1", false, a_, false);
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev1y_ev"))
			{
				c5x c5x;
				if (A_2.g().Contains("tchortistPatrolX") || A_2.g().Contains("tchortistPatrolY"))
				{
					c5x = gx.a(list[i], new int?(15), "Lunatics", null, null, null, null, false, null, false);
				}
				else if (random.Next(0, 101) > 50)
				{
					c5x = gx.a(list[i], new int?(15), "Lurkers", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				else
				{
					c5x = gx.a(list[i], new int?(15), "Ironheads", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				this.iy(c5x);
			}
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev1y_dog") && random.Next(0, 101) > 30)
			{
				if (dk2.b("xpbl") && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev1y_dogpro"))
				{
					c5x a_2 = gx.a(list[i], "protectorate_dogs", "Doberman", null, true, "support\\dog");
					this.iy(a_2);
				}
				else if (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))
				{
					if (dk2.b("xpbl") && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev1y_dogev") && random.Next(0, 101) > 50)
					{
						c5x a_3 = gx.a(list[i], "up_bandit_dogs_agr", "Pitbull", null, false, null);
						this.iy(a_3);
					}
					else if (list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev1y_dogev"))
					{
						c5x a_4 = gx.a(list[i], "up_bandit_dogs_agr", "Dog", null, false, null);
						this.iy(a_4);
					}
				}
			}
		}
	}
}
