using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000801 RID: 2049
public sealed class eyt : el4
{
	// Token: 0x060033B0 RID: 13232 RVA: 0x0014160C File Offset: 0x0013F80C
	protected override esj a3()
	{
		return new esj(8, 4);
	}

	// Token: 0x060033B1 RID: 13233 RVA: 0x00141618 File Offset: 0x0013F818
	public override string a4()
	{
		return "FOG_PT_VS_IH1X";
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x00141620 File Offset: 0x0013F820
	public override string a5()
	{
		return "Foundry Guard Patrol vs Ironheads 1 X";
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x00141628 File Offset: 0x0013F828
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("npc_balor_dead", new bool?(false)).Value;
	}

	// Token: 0x060033B4 RID: 13236 RVA: 0x0014166C File Offset: 0x0013F86C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x00141670 File Offset: 0x0013F870
	public override double ke()
	{
		return 0.06;
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x0014167C File Offset: 0x0013F87C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x00141694 File Offset: 0x0013F894
	public eyt() : base(new string[]
	{
		ega.t
	})
	{
	}

	// Token: 0x060033B8 RID: 13240 RVA: 0x001416AC File Offset: 0x0013F8AC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_fog-pt-vs-ih1x", StringComparison.OrdinalIgnoreCase))
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
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_fog-pt-vs-ih1x_fog"))
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
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_fog-pt-vs-ih1x_ih"))
			{
				c5x a_2 = gx.a(list[i], new int?(10), "Ironheads", null, null, null, null, false, null, false);
				this.iy(a_2);
			}
			else if (list[i] != null && list[i].Name.StartsWith("randomEvent_fog-pt-vs-ih1x_dog"))
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
