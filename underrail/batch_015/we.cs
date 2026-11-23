using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000883 RID: 2179
public sealed class we : el4
{
	// Token: 0x060035D3 RID: 13779 RVA: 0x001483C0 File Offset: 0x001465C0
	protected override esj a3()
	{
		return new esj(12, 10);
	}

	// Token: 0x060035D4 RID: 13780 RVA: 0x001483CC File Offset: 0x001465CC
	public override string a4()
	{
		return "XPBL_WW_PIRJ_VS_MERCHS_Y";
	}

	// Token: 0x060035D5 RID: 13781 RVA: 0x001483D4 File Offset: 0x001465D4
	public override string a5()
	{
		return "Pirates vs Merchants Jet-to-ship Battle Y";
	}

	// Token: 0x060035D6 RID: 13782 RVA: 0x001483E0 File Offset: 0x001465E0
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035D7 RID: 13783 RVA: 0x0014848C File Offset: 0x0014668C
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x060035D8 RID: 13784 RVA: 0x00148494 File Offset: 0x00146694
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035D9 RID: 13785 RVA: 0x00148498 File Offset: 0x00146698
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035DA RID: 13786 RVA: 0x001484B0 File Offset: 0x001466B0
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035DB RID: 13787 RVA: 0x001484B4 File Offset: 0x001466B4
	public we() : base(new string[]
	{
		ega.bm,
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x060035DC RID: 13788 RVA: 0x001484DC File Offset: 0x001466DC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		List<string> list = d06.c(null, "Y");
		string fi = asp.fi;
		string text = list[cuo.a.Next(0, list.Count)];
		string value = "randomEvents_" + text;
		csd csd = A_1.g("randomEvents_boat");
		A_0.r()[A_1.y8() + "_ferryFight_boatPath"] = text;
		A_0.r()[A_1.y8() + "_ferryFight_boatWaypointName"] = csd.Name;
		A_1.g("Dump").Name = text + "Dump";
		erb.a(A_0, A_1, text, csd);
		d06.a(A_1, fi);
		string a_ = d06.a();
		foreach (csd csd2 in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x = null;
			if (csd2.Name.Contains(value))
			{
				d06.a(csd2, fi, 13, a_, true, false);
			}
			int num;
			if (csd2.Name.Contains("_jet") && ((int.TryParse(csd2.Name.Substring(csd2.Name.Length - 1, 1), out num) && num <= 3) || cuo.a.Next(0, 101) <= 65))
			{
				c5x = gx.a(csd2, new int?(10), "Pirates_Jetski", null, asp.fw, null, "support\\xpbl\\pir_raiders", false, null, false);
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

	// Token: 0x060035DD RID: 13789 RVA: 0x00148708 File Offset: 0x00146908
	public override bool kg(cyt A_0, c1a A_1)
	{
		if (base.kg(A_0, A_1))
		{
			string classPropertyValue = A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ferryFight_boatPath");
			if (classPropertyValue != null)
			{
				erb.a(classPropertyValue, A_1.g(A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ferryFight_boatWaypointName")));
				Enumerable.ToList<csd>(A_1.Waypoints).Remove(A_1.g(classPropertyValue + "Dump"));
				A_0.r().RemoveProperty(classPropertyValue);
				A_0.r().RemoveProperty(A_1.y8() + "_ferryFight_boatWaypointName");
			}
			return true;
		}
		return false;
	}
}
