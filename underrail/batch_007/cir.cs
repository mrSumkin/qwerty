using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000886 RID: 2182
public sealed class cir : el4
{
	// Token: 0x060035F4 RID: 13812 RVA: 0x00148F50 File Offset: 0x00147150
	protected override esj a3()
	{
		return new esj(10, 12);
	}

	// Token: 0x060035F5 RID: 13813 RVA: 0x00148F5C File Offset: 0x0014715C
	public override string a4()
	{
		return "XPBL_WW_FLJ_VS_MERCHS_X";
	}

	// Token: 0x060035F6 RID: 13814 RVA: 0x00148F64 File Offset: 0x00147164
	public override string a5()
	{
		return "Freelooters vs Merchants Jet-to-ship Battle X";
	}

	// Token: 0x060035F7 RID: 13815 RVA: 0x00148F70 File Offset: 0x00147170
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035F8 RID: 13816 RVA: 0x0014901C File Offset: 0x0014721C
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x060035F9 RID: 13817 RVA: 0x00149024 File Offset: 0x00147224
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035FA RID: 13818 RVA: 0x00149028 File Offset: 0x00147228
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035FB RID: 13819 RVA: 0x00149040 File Offset: 0x00147240
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035FC RID: 13820 RVA: 0x00149044 File Offset: 0x00147244
	public cir() : base(new string[]
	{
		ega.bl
	})
	{
	}

	// Token: 0x060035FD RID: 13821 RVA: 0x0014905C File Offset: 0x0014725C
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
				c5x = gx.a(csd2, new int?(15), "Generic_Jetski", "Флибустьер", asp.ar, "Sailors", null, true, null, false);
			}
			if (c5x != null)
			{
				base.iy(c5x);
			}
		}
	}

	// Token: 0x060035FE RID: 13822 RVA: 0x00149234 File Offset: 0x00147434
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
