using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000882 RID: 2178
public sealed class q4 : el4
{
	// Token: 0x060035C8 RID: 13768 RVA: 0x00147FD8 File Offset: 0x001461D8
	protected override esj a3()
	{
		return new esj(10, 8);
	}

	// Token: 0x060035C9 RID: 13769 RVA: 0x00147FE4 File Offset: 0x001461E4
	public override string a4()
	{
		return "XPBL_WW_PIRJ_VS_PROTS_Y";
	}

	// Token: 0x060035CA RID: 13770 RVA: 0x00147FEC File Offset: 0x001461EC
	public override string a5()
	{
		return "Pirates vs Protectorate Jet-to-ship Battle Y";
	}

	// Token: 0x060035CB RID: 13771 RVA: 0x00147FF4 File Offset: 0x001461F4
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035CC RID: 13772 RVA: 0x001480E8 File Offset: 0x001462E8
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x060035CD RID: 13773 RVA: 0x001480F0 File Offset: 0x001462F0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035CE RID: 13774 RVA: 0x001480F4 File Offset: 0x001462F4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035CF RID: 13775 RVA: 0x0014810C File Offset: 0x0014630C
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035D0 RID: 13776 RVA: 0x00148110 File Offset: 0x00146310
	public q4() : base(new string[]
	{
		ega.bk,
		ega.bh
	})
	{
	}

	// Token: 0x060035D1 RID: 13777 RVA: 0x00148130 File Offset: 0x00146330
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		List<string> list = d06.a(null, "Y");
		string text = list[cuo.a.Next(0, list.Count)];
		csd csd = A_1.g("randomEvents_boat");
		A_0.r()[A_1.y8() + "_ferryFight_boatPath"] = text;
		A_0.r()[A_1.y8() + "_ferryFight_boatWaypointName"] = csd.Name;
		A_1.g("Dump").Name = text + "Dump";
		erb.a(A_0, A_1, text, csd);
		foreach (csd csd2 in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x = null;
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

	// Token: 0x060035D2 RID: 13778 RVA: 0x0014830C File Offset: 0x0014650C
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
