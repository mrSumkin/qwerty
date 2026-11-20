using System;

// Token: 0x02000C41 RID: 3137
public sealed class aqe : jn
{
	// Token: 0x060046B1 RID: 18097 RVA: 0x001D2828 File Offset: 0x001D0A28
	public aqe() : base("abram", "creature\\characters\\abram")
	{
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x001D2840 File Offset: 0x001D0A40
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_gaveFirstMissions", new bool?(false)).Value)
		{
			return "wa-mf";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_meetAbramInCoreCityStarted", new bool?(false)).Value)
		{
			return "cc_bar";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger2_talkedToPlayer", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_abram_rejectedRescueMissionOffer", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_jyrescueMission_finished", new bool?(false)).Value)
			{
				return null;
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_jyrescueMission_started", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_maura_dead", new bool?(false)).Value)
			{
				return null;
			}
			return "jyt5";
		}
		else
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_jypetDelivery_finished", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_abram_detectedYourJunkyardTreason", new bool?(false)).Value)
			{
				return "jy2";
			}
			return null;
		}
	}

	// Token: 0x060046B3 RID: 18099 RVA: 0x001D29A8 File Offset: 0x001D0BA8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (A_2 == "jyt5")
		{
			if (aspect != null && euf.o(aspect.aa().Offense.u()) && !euf.o(aspect.aa().Offense.q()))
			{
				aspect.aa().Offense.k();
			}
		}
		else if (aspect != null && !euf.o(aspect.aa().Offense.u()) && euf.o(aspect.aa().Offense.q()))
		{
			aspect.aa().Offense.k();
		}
		if (aspect != null)
		{
			if (string.Equals(A_2, "wa-mf", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.l;
				return;
			}
			if (string.Equals(A_2, "cc_bar", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.di;
				return;
			}
			aspect.aa().FactionId = asp.bu;
		}
	}
}
