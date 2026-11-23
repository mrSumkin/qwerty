using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000803 RID: 2051
public sealed class yr : el4
{
	// Token: 0x060033C1 RID: 13249 RVA: 0x00141B14 File Offset: 0x0013FD14
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060033C2 RID: 13250 RVA: 0x00141B20 File Offset: 0x0013FD20
	public override string a4()
	{
		return "FOG_PT1X";
	}

	// Token: 0x060033C3 RID: 13251 RVA: 0x00141B28 File Offset: 0x0013FD28
	public override string a5()
	{
		return "Foundry Guard Patrol 1 X";
	}

	// Token: 0x060033C4 RID: 13252 RVA: 0x00141B30 File Offset: 0x0013FD30
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033C5 RID: 13253 RVA: 0x00141B34 File Offset: 0x0013FD34
	public override double ke()
	{
		return 0.06;
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x00141B40 File Offset: 0x0013FD40
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060033C7 RID: 13255 RVA: 0x00141B58 File Offset: 0x0013FD58
	public yr() : base(new string[]
	{
		ega.t
	})
	{
	}

	// Token: 0x060033C8 RID: 13256 RVA: 0x00141B70 File Offset: 0x0013FD70
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fog-pt1x_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("global_foundryPatrols_killed");
		list2.Add(x);
		List<cze> a_ = list2;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x c5x = gx.a(list[i], new int?(10), "Foundry", null, null, null, "randomEvents\\fo_guardPatrol", false, a_, false);
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
