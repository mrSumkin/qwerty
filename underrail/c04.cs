using System;

// Token: 0x02000C32 RID: 3122
public sealed class c04 : jn
{
	// Token: 0x0600468B RID: 18059 RVA: 0x001D1C98 File Offset: 0x001CFE98
	public c04() : base("oldJonas", "creature\\characters\\oldJonas")
	{
	}

	// Token: 0x0600468C RID: 18060 RVA: 0x001D1CAC File Offset: 0x001CFEAC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value)
		{
			return "StationAlpha-Level4";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ezra_finalTalk", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_sgs_finalCouncil", new bool?(false)).Value)
		{
			return "StationAlpha-Level4";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		return "CrossroadCaves";
	}
}
