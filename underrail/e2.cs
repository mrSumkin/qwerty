using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F9 RID: 2041
public sealed class e2 : el4
{
	// Token: 0x0600336A RID: 13162 RVA: 0x001405EC File Offset: 0x0013E7EC
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x001405F8 File Offset: 0x0013E7F8
	public override string a4()
	{
		return "PRO_PT1Y";
	}

	// Token: 0x0600336C RID: 13164 RVA: 0x00140600 File Offset: 0x0013E800
	public override string a5()
	{
		return "Protectorate Patrol 1 Y";
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x00140608 File Offset: 0x0013E808
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x00140670 File Offset: 0x0013E870
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x00140674 File Offset: 0x0013E874
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x0014068C File Offset: 0x0013E88C
	public e2() : base(new string[]
	{
		ega.o,
		ega.s
	})
	{
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x001406AC File Offset: 0x0013E8AC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-pt1y_guard", StringComparison.OrdinalIgnoreCase))
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
