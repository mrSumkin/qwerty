using System;

// Token: 0x02000C33 RID: 3123
public sealed class a2h : jn
{
	// Token: 0x0600468D RID: 18061 RVA: 0x001D1D80 File Offset: 0x001CFF80
	public a2h() : base("ezra", "creature\\characters\\ezra")
	{
	}

	// Token: 0x0600468E RID: 18062 RVA: 0x001D1D98 File Offset: 0x001CFF98
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ezra_leadToTannersRoom", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_ezra_finalTalk", new bool?(false)).Value)
		{
			return "StationAlpha-Level5";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ezra_finalTalk", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_sgs_finalCouncil", new bool?(false)).Value)
		{
			return "StationAlpha-Level4";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value)
		{
			return "StationAlpha-Level4";
		}
		return "StationAlpha-Level7";
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x001D1E90 File Offset: 0x001D0090
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "StationAlpha-Level5", StringComparison.OrdinalIgnoreCase))
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_ezra_spokeInFrontOfRoom", new bool?(false)).Value)
			{
				return "outside";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_sgs_discoverSecretRoom", new bool?(false)).Value)
			{
				return "room";
			}
		}
		return null;
	}
}
