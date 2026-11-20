using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F1 RID: 2033
public sealed class exn : el4
{
	// Token: 0x0600332A RID: 13098 RVA: 0x0013E97C File Offset: 0x0013CB7C
	protected override esj a3()
	{
		return new esj(4, 9);
	}

	// Token: 0x0600332B RID: 13099 RVA: 0x0013E988 File Offset: 0x0013CB88
	public override string a4()
	{
		return "PRO_PT_VS_EV2Y";
	}

	// Token: 0x0600332C RID: 13100 RVA: 0x0013E990 File Offset: 0x0013CB90
	public override string a5()
	{
		return "Protectorate Patrol vs Everyone 2 Y";
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x0013E99C File Offset: 0x0013CB9C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600332E RID: 13102 RVA: 0x0013EA04 File Offset: 0x0013CC04
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x0013EA08 File Offset: 0x0013CC08
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x0013EA20 File Offset: 0x0013CC20
	public exn() : base(new string[]
	{
		ega.o,
		ega.s
	})
	{
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x0013EA40 File Offset: 0x0013CC40
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt-vs-ev2y", StringComparison.OrdinalIgnoreCase))
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
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2y_pro"))
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2y_ev"))
			{
				if (A_2.g().Contains("tchortistPatrolX") || A_2.g().Contains("tchortistPatrolY"))
				{
					c5x c5x = gx.a(list[i], new int?(15), "Lunatics", null, null, null, null, false, null, false);
				}
				else if (random.Next(0, 101) > 50)
				{
					c5x c5x = gx.a(list[i], new int?(15), "Lurkers", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				else
				{
					c5x c5x = gx.a(list[i], new int?(15), "Ironheads", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
			}
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2y_dog") && random.Next(0, 101) > 30 && !A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))
			{
				if (dk2.b("xpbl") && list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2y_dogev") && random.Next(0, 101) > 50)
				{
					c5x a_2 = gx.a(list[i], "up_bandit_dogs_agr", "Pitbull", null, false, null);
					this.iy(a_2);
				}
				else if (list[i].Name.StartsWith("randomEvent_pro-pt-vs-ev2y_dogev"))
				{
					c5x a_3 = gx.a(list[i], "up_bandit_dogs_agr", "Dog", null, false, null);
					this.iy(a_3);
				}
			}
		}
	}
}
