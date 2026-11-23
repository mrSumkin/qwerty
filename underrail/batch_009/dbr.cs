using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200087D RID: 2173
public sealed class dbr : el4
{
	// Token: 0x06003596 RID: 13718 RVA: 0x00147348 File Offset: 0x00145548
	protected override esj a3()
	{
		return new esj(12, 6);
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x00147354 File Offset: 0x00145554
	public override string a4()
	{
		return "XPBL_WW_PIRJ_VS_PROTJ_X";
	}

	// Token: 0x06003598 RID: 13720 RVA: 0x0014735C File Offset: 0x0014555C
	public override string a5()
	{
		return "Pirates vs Protectorate Jet-to-jet Battle X";
	}

	// Token: 0x06003599 RID: 13721 RVA: 0x00147364 File Offset: 0x00145564
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("faction_protectorate_coreCity_jetSkiersKilled", new int?(0)).Value < 20 && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x0600359A RID: 13722 RVA: 0x0014747C File Offset: 0x0014567C
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x0600359B RID: 13723 RVA: 0x00147484 File Offset: 0x00145684
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600359C RID: 13724 RVA: 0x00147488 File Offset: 0x00145688
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x0600359D RID: 13725 RVA: 0x001474A0 File Offset: 0x001456A0
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600359E RID: 13726 RVA: 0x001474A4 File Offset: 0x001456A4
	public dbr() : base(new string[]
	{
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x0600359F RID: 13727 RVA: 0x001474C4 File Offset: 0x001456C4
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
