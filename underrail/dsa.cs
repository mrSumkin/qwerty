using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007EC RID: 2028
public sealed class dsa : el4
{
	// Token: 0x060032F3 RID: 13043 RVA: 0x0013E348 File Offset: 0x0013C548
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x0013E354 File Offset: 0x0013C554
	public override string a4()
	{
		return "TCH_PT1X";
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x0013E35C File Offset: 0x0013C55C
	public override string a5()
	{
		return "Tchortist Patrol 1 X";
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x0013E364 File Offset: 0x0013C564
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value;
	}

	// Token: 0x060032F7 RID: 13047 RVA: 0x0013E3A8 File Offset: 0x0013C5A8
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060032F8 RID: 13048 RVA: 0x0013E3AC File Offset: 0x0013C5AC
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x0013E3C4 File Offset: 0x0013C5C4
	public dsa() : base(new string[]
	{
		ega.r
	})
	{
	}

	// Token: 0x060032FA RID: 13050 RVA: 0x0013E3E0 File Offset: 0x0013C5E0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_tch-pt1x_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("cglobal_tchortistPatrols_killed");
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
