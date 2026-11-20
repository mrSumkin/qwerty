using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000885 RID: 2181
public sealed class ciq : el4
{
	// Token: 0x060035E9 RID: 13801 RVA: 0x00148BB0 File Offset: 0x00146DB0
	protected override esj a3()
	{
		return new esj(12, 10);
	}

	// Token: 0x060035EA RID: 13802 RVA: 0x00148BBC File Offset: 0x00146DBC
	public override string a4()
	{
		return "XPBL_WW_FLJ_VS_MERCHS_Y";
	}

	// Token: 0x060035EB RID: 13803 RVA: 0x00148BC4 File Offset: 0x00146DC4
	public override string a5()
	{
		return "Freelooters vs Merchants Jet-to-ship Battle Y";
	}

	// Token: 0x060035EC RID: 13804 RVA: 0x00148BD0 File Offset: 0x00146DD0
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035ED RID: 13805 RVA: 0x00148C7C File Offset: 0x00146E7C
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x060035EE RID: 13806 RVA: 0x00148C84 File Offset: 0x00146E84
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035EF RID: 13807 RVA: 0x00148C88 File Offset: 0x00146E88
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035F0 RID: 13808 RVA: 0x00148CA0 File Offset: 0x00146EA0
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035F1 RID: 13809 RVA: 0x00148CA4 File Offset: 0x00146EA4
	public ciq() : base(new string[]
	{
		ega.bn,
		ega.bm
	})
	{
	}

	// Token: 0x060035F2 RID: 13810 RVA: 0x00148CC4 File Offset: 0x00146EC4
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
				c5x = gx.a(csd2, new int?(15), "Generic_Jetski", "Флибустьер", asp.ar, "Sailors", null, true, null, false);
			}
			if (c5x != null)
			{
				base.iy(c5x);
			}
		}
	}

	// Token: 0x060035F3 RID: 13811 RVA: 0x00148E9C File Offset: 0x0014709C
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
