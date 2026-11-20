using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000884 RID: 2180
public sealed class wd : el4
{
	// Token: 0x060035DE RID: 13790 RVA: 0x001487BC File Offset: 0x001469BC
	protected override esj a3()
	{
		return new esj(10, 12);
	}

	// Token: 0x060035DF RID: 13791 RVA: 0x001487C8 File Offset: 0x001469C8
	public override string a4()
	{
		return "XPBL_WW_PIRJ_VS_MERCHS_X";
	}

	// Token: 0x060035E0 RID: 13792 RVA: 0x001487D0 File Offset: 0x001469D0
	public override string a5()
	{
		return "Pirates vs Merchants Jet-to-ship Battle X";
	}

	// Token: 0x060035E1 RID: 13793 RVA: 0x001487DC File Offset: 0x001469DC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035E2 RID: 13794 RVA: 0x00148888 File Offset: 0x00146A88
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x060035E3 RID: 13795 RVA: 0x00148890 File Offset: 0x00146A90
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035E4 RID: 13796 RVA: 0x00148894 File Offset: 0x00146A94
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035E5 RID: 13797 RVA: 0x001488AC File Offset: 0x00146AAC
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035E6 RID: 13798 RVA: 0x001488B0 File Offset: 0x00146AB0
	public wd() : base(new string[]
	{
		ega.bl,
		ega.bk
	})
	{
	}

	// Token: 0x060035E7 RID: 13799 RVA: 0x001488D0 File Offset: 0x00146AD0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		List<string> list = d06.c(null, "X");
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

	// Token: 0x060035E8 RID: 13800 RVA: 0x00148AFC File Offset: 0x00146CFC
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
