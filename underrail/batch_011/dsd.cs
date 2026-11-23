using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000887 RID: 2183
public sealed class dsd : el4
{
	// Token: 0x060035FF RID: 13823 RVA: 0x001492E8 File Offset: 0x001474E8
	protected override esj a3()
	{
		return new esj(8, 8);
	}

	// Token: 0x06003600 RID: 13824 RVA: 0x001492F4 File Offset: 0x001474F4
	public override string a4()
	{
		return "XPBL_WW_PIRS_VS_PROTS_Y";
	}

	// Token: 0x06003601 RID: 13825 RVA: 0x001492FC File Offset: 0x001474FC
	public override string a5()
	{
		return "Pirates vs Protectorate Ship-to-ship Battle Y";
	}

	// Token: 0x06003602 RID: 13826 RVA: 0x00149304 File Offset: 0x00147504
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x06003603 RID: 13827 RVA: 0x001493F8 File Offset: 0x001475F8
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x06003604 RID: 13828 RVA: 0x00149400 File Offset: 0x00147600
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003605 RID: 13829 RVA: 0x00149404 File Offset: 0x00147604
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x06003606 RID: 13830 RVA: 0x0014941C File Offset: 0x0014761C
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x06003607 RID: 13831 RVA: 0x00149420 File Offset: 0x00147620
	public dsd() : base(new string[]
	{
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x06003608 RID: 13832 RVA: 0x00149440 File Offset: 0x00147640
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<string> list = d06.a(null, "Y");
		List<string> list2 = d06.b(null, "Y");
		string text;
		string text2;
		string text3;
		string text4;
		if (cuo.a.Next(0, 2) == 0)
		{
			text = asp.bg;
			text2 = asp.fw;
			text3 = list[cuo.a.Next(0, list.Count)];
			text4 = list2[cuo.a.Next(0, list2.Count)];
		}
		else
		{
			text = asp.fw;
			text2 = asp.bg;
			text3 = list2[cuo.a.Next(0, list2.Count)];
			text4 = list[cuo.a.Next(0, list.Count)];
		}
		string value = "randomEvents_" + text3;
		string value2 = "randomEvents_" + text4;
		csd csd = A_1.g("randomEvents_boat1_large");
		csd csd2 = A_1.g("randomEvents_boat2_large");
		if (text3 != null && text3.Contains("small"))
		{
			csd = A_1.g("randomEvents_boat1_small");
		}
		if (text4 != null && text4.Contains("small"))
		{
			csd2 = A_1.g("randomEvents_boat2_small");
		}
		A_0.r()[A_1.y8() + "_ferryFight_boat1Path"] = text3;
		A_0.r()[A_1.y8() + "_ferryFight_boat2Path"] = text4;
		A_0.r()[A_1.y8() + "_ferryFight_boat1WaypointName"] = csd.Name;
		A_0.r()[A_1.y8() + "_ferryFight_boat2WaypointName"] = csd2.Name;
		A_1.g("Dump1").Name = text3 + "Dump";
		A_1.g("Dump2").Name = text4 + "Dump";
		erb.a(A_0, A_1, text3, csd);
		d06.b(A_1, "E");
		d06.a(A_1, text);
		erb.a(A_0, A_1, text4, csd2);
		d06.b(A_1, "W");
		d06.a(A_1, text2);
		foreach (aud aud in Enumerable.ToList<aud>(A_1.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.bg)
				{
					c5x.b("protectorate_attacked");
				}
			}
		}
		foreach (csd csd3 in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x2 = null;
			if (csd3.Name.Contains(value) && text != asp.bg)
			{
				d06.a(csd3, text, 13, null, false, false);
			}
			else if (csd3.Name.Contains(value2) && text2 != asp.bg)
			{
				d06.a(csd3, text2, 13, null, false, false);
			}
			if (c5x2 != null)
			{
				base.iy(c5x2);
			}
		}
	}

	// Token: 0x06003609 RID: 13833 RVA: 0x00149810 File Offset: 0x00147A10
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
