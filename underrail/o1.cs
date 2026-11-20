using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007EA RID: 2026
public sealed class o1 : el4
{
	// Token: 0x060032E3 RID: 13027 RVA: 0x0013DEC0 File Offset: 0x0013C0C0
	protected override esj a3()
	{
		return new esj(8, 3);
	}

	// Token: 0x060032E4 RID: 13028 RVA: 0x0013DECC File Offset: 0x0013C0CC
	public override string a4()
	{
		return "TCH_PT_VS_L1X";
	}

	// Token: 0x060032E5 RID: 13029 RVA: 0x0013DED4 File Offset: 0x0013C0D4
	public override string a5()
	{
		return "Tchortist Patrol vs Lunatics 1 X";
	}

	// Token: 0x060032E6 RID: 13030 RVA: 0x0013DEDC File Offset: 0x0013C0DC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value;
	}

	// Token: 0x060032E7 RID: 13031 RVA: 0x0013DF20 File Offset: 0x0013C120
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060032E8 RID: 13032 RVA: 0x0013DF24 File Offset: 0x0013C124
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x0013DF3C File Offset: 0x0013C13C
	public o1() : base(new string[]
	{
		ega.r
	})
	{
	}

	// Token: 0x060032EA RID: 13034 RVA: 0x0013DF58 File Offset: 0x0013C158
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_tch-pt-vs-l1x", StringComparison.OrdinalIgnoreCase))
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
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_tch-pt-vs-l1x_tch"))
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_tch-pt-vs-l1x_lnt"))
			{
				c5x a_2 = gx.a(list[i], new int?(15), "Lunatics", null, null, null, null, false, null, false);
				this.iy(a_2);
			}
		}
	}
}
