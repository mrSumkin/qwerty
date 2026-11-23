using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200088B RID: 2187
public sealed class dr4 : el4
{
	// Token: 0x0600362B RID: 13867 RVA: 0x0014A950 File Offset: 0x00148B50
	protected override esj a3()
	{
		return new esj(14, 14);
	}

	// Token: 0x0600362C RID: 13868 RVA: 0x0014A95C File Offset: 0x00148B5C
	public override string a4()
	{
		return "XPBL_WW_FLS_VS_MERCHS_X";
	}

	// Token: 0x0600362D RID: 13869 RVA: 0x0014A964 File Offset: 0x00148B64
	public override string a5()
	{
		return "Freelooters vs Merchants Ship-to-ship Battle X";
	}

	// Token: 0x0600362E RID: 13870 RVA: 0x0014A970 File Offset: 0x00148B70
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x0600362F RID: 13871 RVA: 0x0014AA1C File Offset: 0x00148C1C
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x06003630 RID: 13872 RVA: 0x0014AA24 File Offset: 0x00148C24
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003631 RID: 13873 RVA: 0x0014AA28 File Offset: 0x00148C28
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003632 RID: 13874 RVA: 0x0014AA40 File Offset: 0x00148C40
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003633 RID: 13875 RVA: 0x0014AA44 File Offset: 0x00148C44
	public dr4() : base(new string[]
	{
		ega.bl
	})
	{
	}

	// Token: 0x06003634 RID: 13876 RVA: 0x0014AA5C File Offset: 0x00148C5C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.c(null, "X");
		List<string> list2 = d06.c(new List<string>
		{
			"Merchant"
		}, "X");
		string a_;
		string a_2;
		string text;
		string text2;
		if (cuo.a.Next(0, 2) == 0)
		{
			a_ = asp.fi;
			a_2 = asp.ar;
			text = list[cuo.a.Next(0, list.Count)];
			if (list2.Contains(text))
			{
				list2.Remove(text);
			}
			text2 = list2[cuo.a.Next(0, list2.Count)];
		}
		else
		{
			a_ = asp.ar;
			a_2 = asp.fi;
			text = list2[cuo.a.Next(0, list2.Count)];
			if (list.Contains(text))
			{
				list.Remove(text);
			}
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
		d06.b(A_1, "S");
		d06.a(A_1, a_);
		erb.a(A_0, A_1, text2, csd2);
		d06.b(A_1, "N");
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

	// Token: 0x06003635 RID: 13877 RVA: 0x0014AD78 File Offset: 0x00148F78
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
