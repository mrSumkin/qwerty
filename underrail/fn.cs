using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F5 RID: 2037
public sealed class fn : el4
{
	// Token: 0x0600334A RID: 13130 RVA: 0x0013FBB8 File Offset: 0x0013DDB8
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x0013FBC4 File Offset: 0x0013DDC4
	public override string a4()
	{
		return "PRO_PT3Y";
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x0013FBCC File Offset: 0x0013DDCC
	public override string a5()
	{
		return "Protectorate Patrol 3 Y";
	}

	// Token: 0x0600334D RID: 13133 RVA: 0x0013FBD4 File Offset: 0x0013DDD4
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x0013FC3C File Offset: 0x0013DE3C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x0013FC40 File Offset: 0x0013DE40
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x0013FC58 File Offset: 0x0013DE58
	public fn() : base(new string[]
	{
		ega.o,
		ega.s
	})
	{
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x0013FC78 File Offset: 0x0013DE78
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt3y_guard", StringComparison.OrdinalIgnoreCase))
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
				c5x c5x = gx.a(list[i], new int?(10), "Protectorate", null, null, null, "randomEvents\\pr_patrol1", false, a_, false);
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
