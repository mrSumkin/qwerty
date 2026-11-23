using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000800 RID: 2048
public sealed class adj : el4
{
	// Token: 0x060033A7 RID: 13223 RVA: 0x001412D0 File Offset: 0x0013F4D0
	protected override esj a3()
	{
		return new esj(4, 8);
	}

	// Token: 0x060033A8 RID: 13224 RVA: 0x001412DC File Offset: 0x0013F4DC
	public override string a4()
	{
		return "FOG_PT_VS_IH1Y";
	}

	// Token: 0x060033A9 RID: 13225 RVA: 0x001412E4 File Offset: 0x0013F4E4
	public override string a5()
	{
		return "Foundry Guard Patrol vs Ironheads 1 Y";
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x001412EC File Offset: 0x0013F4EC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("npc_balor_dead", new bool?(false)).Value;
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x00141330 File Offset: 0x0013F530
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x00141334 File Offset: 0x0013F534
	public override double ke()
	{
		return 0.06;
	}

	// Token: 0x060033AD RID: 13229 RVA: 0x00141340 File Offset: 0x0013F540
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060033AE RID: 13230 RVA: 0x00141358 File Offset: 0x0013F558
	public adj() : base(new string[]
	{
		ega.u
	})
	{
	}

	// Token: 0x060033AF RID: 13231 RVA: 0x00141370 File Offset: 0x0013F570
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fog-pt-vs-ih1y", StringComparison.OrdinalIgnoreCase))
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
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_fog-pt-vs-ih1y_fog"))
			{
				c5x c5x = gx.a(list[i], new int?(10), "Foundry", null, asp.c1, null, "randomEvents\\fo_guardPatrol", false, a_, false);
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_fog-pt-vs-ih1y_ih"))
			{
				c5x a_2 = gx.a(list[i], new int?(10), "Ironheads", null, null, null, null, false, null, false);
				this.iy(a_2);
			}
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_fog-pt-vs-ih1y_dog"))
			{
				Random random = new Random();
				int num = random.Next(0, 101);
				if (random.Next(0, 101) > 30)
				{
					if (dk2.b("xpbl") && num > 60)
					{
						c5x a_3 = gx.a(list[i], "lu_ironheads_dogs", "Doberman", null, false, null);
						this.iy(a_3);
					}
					else
					{
						c5x a_4 = gx.a(list[i], "lu_ironheads_dogs", "Dog", null, false, null);
						this.iy(a_4);
					}
				}
			}
		}
	}
}
