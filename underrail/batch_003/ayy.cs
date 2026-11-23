using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200088A RID: 2186
public sealed class ayy : el4
{
	// Token: 0x06003620 RID: 13856 RVA: 0x0014A3D8 File Offset: 0x001485D8
	protected override esj a3()
	{
		return new esj(14, 12);
	}

	// Token: 0x06003621 RID: 13857 RVA: 0x0014A3E4 File Offset: 0x001485E4
	public override string a4()
	{
		return "XPBL_WW_FLS_VS_MERCHS_Y";
	}

	// Token: 0x06003622 RID: 13858 RVA: 0x0014A3EC File Offset: 0x001485EC
	public override string a5()
	{
		return "Freelooters vs Merchants Ship-to-ship Battle Y";
	}

	// Token: 0x06003623 RID: 13859 RVA: 0x0014A3F8 File Offset: 0x001485F8
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x0014A4A4 File Offset: 0x001486A4
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x0014A4AC File Offset: 0x001486AC
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x0014A4B0 File Offset: 0x001486B0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003627 RID: 13863 RVA: 0x0014A4C8 File Offset: 0x001486C8
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003628 RID: 13864 RVA: 0x0014A4CC File Offset: 0x001486CC
	public ayy() : base(new string[]
	{
		ega.bn,
		ega.bm
	})
	{
	}

	// Token: 0x06003629 RID: 13865 RVA: 0x0014A4EC File Offset: 0x001486EC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.c(null, "Y");
		List<string> list2 = d06.c(new List<string>
		{
			"Merchant"
		}, "Y");
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

	// Token: 0x0600362A RID: 13866 RVA: 0x0014A808 File Offset: 0x00148A08
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
