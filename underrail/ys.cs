using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000802 RID: 2050
public sealed class ys : el4
{
	// Token: 0x060033B9 RID: 13241 RVA: 0x00141948 File Offset: 0x0013FB48
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x00141954 File Offset: 0x0013FB54
	public override string a4()
	{
		return "FOG_PT1Y";
	}

	// Token: 0x060033BB RID: 13243 RVA: 0x0014195C File Offset: 0x0013FB5C
	public override string a5()
	{
		return "Foundry Guard Patrol 1 Y";
	}

	// Token: 0x060033BC RID: 13244 RVA: 0x00141964 File Offset: 0x0013FB64
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033BD RID: 13245 RVA: 0x00141968 File Offset: 0x0013FB68
	public override double ke()
	{
		return 0.06;
	}

	// Token: 0x060033BE RID: 13246 RVA: 0x00141974 File Offset: 0x0013FB74
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060033BF RID: 13247 RVA: 0x0014198C File Offset: 0x0013FB8C
	public ys() : base(new string[]
	{
		ega.u
	})
	{
	}

	// Token: 0x060033C0 RID: 13248 RVA: 0x001419A4 File Offset: 0x0013FBA4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fog-pt1y_guard", StringComparison.OrdinalIgnoreCase))
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
