using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000888 RID: 2184
public sealed class e0i : el4
{
	// Token: 0x0600360A RID: 13834 RVA: 0x00149958 File Offset: 0x00147B58
	protected override esj a3()
	{
		return new esj(14, 12);
	}

	// Token: 0x0600360B RID: 13835 RVA: 0x00149964 File Offset: 0x00147B64
	public override string a4()
	{
		return "XPBL_WW_PIRS_VS_MERCHS_Y";
	}

	// Token: 0x0600360C RID: 13836 RVA: 0x0014996C File Offset: 0x00147B6C
	public override string a5()
	{
		return "Pirates vs Merchants Ship-to-ship Battle Y";
	}

	// Token: 0x0600360D RID: 13837 RVA: 0x00149978 File Offset: 0x00147B78
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x0600360E RID: 13838 RVA: 0x00149A24 File Offset: 0x00147C24
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x0600360F RID: 13839 RVA: 0x00149A2C File Offset: 0x00147C2C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003610 RID: 13840 RVA: 0x00149A30 File Offset: 0x00147C30
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003611 RID: 13841 RVA: 0x00149A48 File Offset: 0x00147C48
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003612 RID: 13842 RVA: 0x00149A4C File Offset: 0x00147C4C
	public e0i() : base(new string[]
	{
		ega.bm,
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x06003613 RID: 13843 RVA: 0x00149A74 File Offset: 0x00147C74
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.c(null, "Y");
		List<string> list2 = d06.b(null, "Y");
		string a_;
		string a_2;
		string text;
		string text2;
		if (cuo.a.Next(0, 2) == 0)
		{
			a_ = asp.fi;
			a_2 = asp.fw;
			text = list[cuo.a.Next(0, list.Count)];
			text2 = list2[cuo.a.Next(0, list2.Count)];
		}
		else
		{
			a_ = asp.fw;
			a_2 = asp.fi;
			text = list2[cuo.a.Next(0, list2.Count)];
			text2 = list[cuo.a.Next(0, list.Count)];
		}
		string value = "randomEvents_" + text;
		string value2 = "randomEvents_" + text2;
		csd csd = A_1.g("randomEvents_boat1_large");
		csd csd2 = A_1.g("randomEvents_boat2_large");
		if (text != null && text.Contains("small"))
		{
			csd = A_1.g("randomEvents_boat1_small");
		}
		if (text2 != null && text2.Contains("small"))
		{
			csd2 = A_1.g("randomEvents_boat2_small");
		}
		A_0.r()[A_1.y8() + "_ferryFight_boat1Path"] = text;
		A_0.r()[A_1.y8() + "_ferryFight_boat2Path"] = text2;
		A_0.r()[A_1.y8() + "_ferryFight_boat1WaypointName"] = csd.Name;
		A_0.r()[A_1.y8() + "_ferryFight_boat2WaypointName"] = csd2.Name;
		A_1.g("Dump1").Name = text + "Dump";
		A_1.g("Dump2").Name = text2 + "Dump";
		erb.a(A_0, A_1, text, csd);
		d06.b(A_1, "E");
		d06.a(A_1, a_);
		erb.a(A_0, A_1, text2, csd2);
		d06.b(A_1, "W");
		d06.a(A_1, a_2);
		string a_3 = d06.a();
		foreach (csd csd3 in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x = null;
			if (csd3.Name.Contains(value))
			{
				d06.a(csd3, a_, 13, a_3, true, false);
			}
			else if (csd3.Name.Contains(value2))
			{
				d06.a(csd3, a_2, 13, a_3, true, false);
			}
			if (c5x != null)
			{
				base.iy(c5x);
			}
		}
	}

	// Token: 0x06003614 RID: 13844 RVA: 0x00149D54 File Offset: 0x00147F54
	public override bool kg(cyt A_0, c1a A_1)
	{
		if (base.kg(A_0, A_1))
		{
			string classPropertyValue = A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ferryFight_boat1Path");
			string classPropertyValue2 = A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ferryFight_boat2Path");
			if (classPropertyValue != null)
			{
				erb.a(classPropertyValue, A_1.g(A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ferryFight_boat1WaypointName")));
				Enumerable.ToList<csd>(A_1.Waypoints).Remove(A_1.g(classPropertyValue + "Dump"));
				A_0.r().RemoveProperty(classPropertyValue);
				A_0.r().RemoveProperty(A_1.y8() + "_ferryFight_boat1WaypointName");
			}
			if (classPropertyValue2 != null)
			{
				erb.a(classPropertyValue2, A_1.g(A_0.r().GetClassPropertyValue<string>(A_1.y8() + "_ferryFight_boat2WaypointName")));
				Enumerable.ToList<csd>(A_1.Waypoints).Remove(A_1.g(classPropertyValue2 + "Dump"));
				A_0.r().RemoveProperty(classPropertyValue2);
				A_0.r().RemoveProperty(A_1.y8() + "_ferryFight_boat2WaypointName");
			}
			return true;
		}
		return false;
	}
}
