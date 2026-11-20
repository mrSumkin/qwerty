using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007EB RID: 2027
public sealed class dr9 : el4
{
	// Token: 0x060032EB RID: 13035 RVA: 0x0013E140 File Offset: 0x0013C340
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060032EC RID: 13036 RVA: 0x0013E14C File Offset: 0x0013C34C
	public override string a4()
	{
		return "TCH_PT1Y";
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x0013E154 File Offset: 0x0013C354
	public override string a5()
	{
		return "Tchortist Patrol 1 Y";
	}

	// Token: 0x060032EE RID: 13038 RVA: 0x0013E15C File Offset: 0x0013C35C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value;
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x0013E1A0 File Offset: 0x0013C3A0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060032F0 RID: 13040 RVA: 0x0013E1A4 File Offset: 0x0013C3A4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x060032F1 RID: 13041 RVA: 0x0013E1BC File Offset: 0x0013C3BC
	public dr9() : base(new string[]
	{
		ega.s
	})
	{
	}

	// Token: 0x060032F2 RID: 13042 RVA: 0x0013E1D8 File Offset: 0x0013C3D8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_tch-pt1y_guard", StringComparison.OrdinalIgnoreCase))
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
			if (list[i] != null)
			{
				c5x c5x = gx.a(list[i], new int?(10), "Tchortists", null, null, null, "randomEvents\\tch_patrol", false, a_, false);
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
