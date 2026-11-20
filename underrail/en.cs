using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F7 RID: 2039
public sealed class en : el4
{
	// Token: 0x0600335A RID: 13146 RVA: 0x0014001C File Offset: 0x0013E21C
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x00140028 File Offset: 0x0013E228
	public override string a4()
	{
		return "PRO_PT2Y";
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x00140030 File Offset: 0x0013E230
	public override string a5()
	{
		return "Protectorate Patrol 2 Y";
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x00140038 File Offset: 0x0013E238
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x001400A0 File Offset: 0x0013E2A0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x001400A4 File Offset: 0x0013E2A4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x001400BC File Offset: 0x0013E2BC
	public en() : base(new string[]
	{
		ega.o,
		ega.s
	})
	{
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x001400DC File Offset: 0x0013E2DC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt2y_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt2y_dog", StringComparison.OrdinalIgnoreCase))
			{
				list2.Add(csd);
			}
		}
		gx gx = new gx();
		List<cze> list3 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("global_protectoratePatrols_killed");
		list3.Add(x);
		List<cze> a_ = list3;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
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
		}
		if (Enumerable.Any<csd>(list2))
		{
			Random random = new Random();
			random.Next(0, 101);
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] != null && random.Next(0, 101) > 30 && dk2.b("xpbl"))
				{
					c5x a_2 = gx.a(list2[j], "protectorate_dogs", "Doberman", null, true, "support\\dog");
					this.iy(a_2);
				}
			}
		}
	}
}
