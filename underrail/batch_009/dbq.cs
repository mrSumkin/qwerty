using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200087C RID: 2172
public sealed class dbq : el4
{
	// Token: 0x0600358C RID: 13708 RVA: 0x00147048 File Offset: 0x00145248
	protected override esj a3()
	{
		return new esj(6, 12);
	}

	// Token: 0x0600358D RID: 13709 RVA: 0x00147054 File Offset: 0x00145254
	public override string a4()
	{
		return "XPBL_WW_PIRJ_VS_PROTJ_Y";
	}

	// Token: 0x0600358E RID: 13710 RVA: 0x0014705C File Offset: 0x0014525C
	public override string a5()
	{
		return "Pirates vs Protectorate Jet-to-jet Battle Y";
	}

	// Token: 0x0600358F RID: 13711 RVA: 0x00147064 File Offset: 0x00145264
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("faction_protectorate_coreCity_jetSkiersKilled", new int?(0)).Value < 20 && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x06003590 RID: 13712 RVA: 0x0014717C File Offset: 0x0014537C
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x06003591 RID: 13713 RVA: 0x00147184 File Offset: 0x00145384
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x00147188 File Offset: 0x00145388
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x001471A0 File Offset: 0x001453A0
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003594 RID: 13716 RVA: 0x001471A4 File Offset: 0x001453A4
	public dbq() : base(new string[]
	{
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x06003595 RID: 13717 RVA: 0x001471C4 File Offset: 0x001453C4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		List<cze> list = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("faction_protectorate_coreCity_jetSkiersKilled");
		list.Add(x);
		List<cze> a_ = list;
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x = null;
			if (csd.Name.Contains("_protJet"))
			{
				c5x = gx.a(csd, new int?(10), "Protectorate_Jetski", null, asp.bg, null, "support\\xpbl\\pr_jetPatrols1", false, a_, false);
				if (c5x != null)
				{
					c5x.b("protectorate_attacked");
				}
			}
			if (csd.Name.Contains("_pirateJet"))
			{
				c5x = gx.a(csd, new int?(10), "Pirates_Jetski", null, asp.fw, null, "support\\xpbl\\pir_raiders", false, null, false);
			}
			if (c5x != null)
			{
				if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.fw)
				{
					c5x.h.b.aa().HostilityBroadcastMode = c2n.c;
				}
				base.iy(c5x);
			}
		}
	}
}
