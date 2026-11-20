using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F6 RID: 2038
public sealed class aft : el4
{
	// Token: 0x06003352 RID: 13138 RVA: 0x0013FDE8 File Offset: 0x0013DFE8
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x0013FDF4 File Offset: 0x0013DFF4
	public override string a4()
	{
		return "PRO_PT3X";
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x0013FDFC File Offset: 0x0013DFFC
	public override string a5()
	{
		return "Protectorate Patrol 3 X";
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x0013FE04 File Offset: 0x0013E004
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x0013FE6C File Offset: 0x0013E06C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x0013FE70 File Offset: 0x0013E070
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x0013FE88 File Offset: 0x0013E088
	public aft() : base(new string[]
	{
		ega.n,
		ega.r
	})
	{
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x0013FEA8 File Offset: 0x0013E0A8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt3x_guard", StringComparison.OrdinalIgnoreCase))
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
