using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007E9 RID: 2025
public sealed class bj4 : el4
{
	// Token: 0x060032DB RID: 13019 RVA: 0x0013DC40 File Offset: 0x0013BE40
	protected override esj a3()
	{
		return new esj(3, 8);
	}

	// Token: 0x060032DC RID: 13020 RVA: 0x0013DC4C File Offset: 0x0013BE4C
	public override string a4()
	{
		return "TCH_PT_VS_L1Y";
	}

	// Token: 0x060032DD RID: 13021 RVA: 0x0013DC54 File Offset: 0x0013BE54
	public override string a5()
	{
		return "Tchortist Patrol vs Lunatics 1 Y";
	}

	// Token: 0x060032DE RID: 13022 RVA: 0x0013DC5C File Offset: 0x0013BE5C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value;
	}

	// Token: 0x060032DF RID: 13023 RVA: 0x0013DCA0 File Offset: 0x0013BEA0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060032E0 RID: 13024 RVA: 0x0013DCA4 File Offset: 0x0013BEA4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x060032E1 RID: 13025 RVA: 0x0013DCBC File Offset: 0x0013BEBC
	public bj4() : base(new string[]
	{
		ega.s
	})
	{
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x0013DCD8 File Offset: 0x0013BED8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_tch-pt-vs-l1y", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("global_tchortistPatrols_killed");
		list2.Add(x);
		List<cze> a_ = list2;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_tch-pt-vs-l1y_tch"))
			{
				c5x c5x = gx.a(list[i], new int?(10), "Tchortists", null, asp.et, null, "randomEvents\\tch_patrol", false, a_, false);
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_tch-pt-vs-l1y_lnt"))
			{
				c5x a_2 = gx.a(list[i], new int?(15), "Lunatics", null, null, null, null, false, null, false);
				this.iy(a_2);
			}
		}
	}
}
