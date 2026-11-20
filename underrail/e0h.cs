using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000889 RID: 2185
public sealed class e0h : el4
{
	// Token: 0x06003615 RID: 13845 RVA: 0x00149E9C File Offset: 0x0014809C
	protected override esj a3()
	{
		return new esj(14, 14);
	}

	// Token: 0x06003616 RID: 13846 RVA: 0x00149EA8 File Offset: 0x001480A8
	public override string a4()
	{
		return "XPBL_WW_PIRS_VS_MERCHS_X";
	}

	// Token: 0x06003617 RID: 13847 RVA: 0x00149EB0 File Offset: 0x001480B0
	public override string a5()
	{
		return "Pirates vs Merchants Ship-to-ship Battle X";
	}

	// Token: 0x06003618 RID: 13848 RVA: 0x00149EBC File Offset: 0x001480BC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x06003619 RID: 13849 RVA: 0x00149F68 File Offset: 0x00148168
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x0600361A RID: 13850 RVA: 0x00149F70 File Offset: 0x00148170
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600361B RID: 13851 RVA: 0x00149F74 File Offset: 0x00148174
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x0600361C RID: 13852 RVA: 0x00149F8C File Offset: 0x0014818C
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600361D RID: 13853 RVA: 0x00149F90 File Offset: 0x00148190
	public e0h() : base(new string[]
	{
		ega.bl,
		ega.bk
	})
	{
	}

	// Token: 0x0600361E RID: 13854 RVA: 0x00149FB0 File Offset: 0x001481B0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.c(null, "X");
		List<string> list2 = d06.b(null, "X");
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

	// Token: 0x0600361F RID: 13855 RVA: 0x0014A290 File Offset: 0x00148490
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
