using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007FA RID: 2042
public sealed class at2 : el4
{
	// Token: 0x06003372 RID: 13170 RVA: 0x00140820 File Offset: 0x0013EA20
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003373 RID: 13171 RVA: 0x0014082C File Offset: 0x0013EA2C
	public override string a4()
	{
		return "PRO_PT1X";
	}

	// Token: 0x06003374 RID: 13172 RVA: 0x00140834 File Offset: 0x0013EA34
	public override string a5()
	{
		return "Protectorate Patrol 1 X";
	}

	// Token: 0x06003375 RID: 13173 RVA: 0x0014083C File Offset: 0x0013EA3C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x06003376 RID: 13174 RVA: 0x001408A4 File Offset: 0x0013EAA4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003377 RID: 13175 RVA: 0x001408A8 File Offset: 0x0013EAA8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003378 RID: 13176 RVA: 0x001408C0 File Offset: 0x0013EAC0
	public at2() : base(new string[]
	{
		ega.n,
		ega.r
	})
	{
	}

	// Token: 0x06003379 RID: 13177 RVA: 0x001408E0 File Offset: 0x0013EAE0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt1x_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("global_protectoratePatrols_killed");
		list2.Add(x);
		List<cze> a_ = list2;
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
	}
}
