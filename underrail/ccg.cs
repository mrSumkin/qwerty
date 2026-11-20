using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F3 RID: 2035
public sealed class ccg : el4
{
	// Token: 0x0600333A RID: 13114 RVA: 0x0013F298 File Offset: 0x0013D498
	protected override esj a3()
	{
		return new esj(9, 4);
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x0013F2A4 File Offset: 0x0013D4A4
	public override string a4()
	{
		return "PRO_PT_VS_EV2X";
	}

	// Token: 0x0600333C RID: 13116 RVA: 0x0013F2AC File Offset: 0x0013D4AC
	public override string a5()
	{
		return "Protectorate Patrol vs Everyone 2 X";
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x0013F2B4 File Offset: 0x0013D4B4
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x0013F31C File Offset: 0x0013D51C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x0013F320 File Offset: 0x0013D520
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003340 RID: 13120 RVA: 0x0013F338 File Offset: 0x0013D538
	public ccg() : base(new string[]
	{
		ega.n,
		ega.r
	})
	{
	}

	// Token: 0x06003341 RID: 13121 RVA: 0x0013F358 File Offset: 0x0013D558
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt-vs-ev2x", StringComparison.OrdinalIgnoreCase))
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
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2x_pro"))
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2x_ev"))
			{
				c5x c5x;
				if (A_2.g().Contains("tchortistPatrolX") || A_2.g().Contains("tchortistPatrolY"))
				{
					c5x = gx.a(list[i], new int?(15), "Lunatics", null, null, null, null, false, null, false);
				}
				else if (random.Next(0, 101) > 50)
				{
					c5x = gx.a(list[i], new int?(25), "Lurkers", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				else
				{
					c5x = gx.a(list[i], new int?(25), "Ironheads", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				this.iy(c5x);
			}
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2x_dog") && random.Next(0, 101) > 30 && !A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))
			{
				if (dk2.b("xpbl") && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2x_dogev") && random.Next(0, 101) > 50)
				{
					c5x a_2 = gx.a(list[i], "up_bandit_dogs_agr", "Pitbull", null, false, null);
					this.iy(a_2);
				}
				else if (list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2x_dogev"))
				{
					c5x a_3 = gx.a(list[i], "up_bandit_dogs_agr", "Dog", null, false, null);
					this.iy(a_3);
				}
			}
		}
	}
}
