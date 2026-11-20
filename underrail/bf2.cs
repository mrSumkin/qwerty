using System;

// Token: 0x02000C42 RID: 3138
public sealed class bf2 : jn
{
	// Token: 0x060046B4 RID: 18100 RVA: 0x001D2AC0 File Offset: 0x001D0CC0
	public bf2() : base("vera", "creature\\characters\\vera")
	{
	}

	// Token: 0x060046B5 RID: 18101 RVA: 0x001D2AD8 File Offset: 0x001D0CD8
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("introDone", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ezra_finalTalk", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_sgs_finalCouncil", new bool?(false)).Value)
		{
			return "StationAlpha-Level4";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value)
		{
			bool value = A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value;
			return "StationAlpha-Level4";
		}
		return "StationAlpha-Level4";
	}

	// Token: 0x060046B6 RID: 18102 RVA: 0x001D2BA8 File Offset: 0x001D0DA8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value)
			{
				cgh.a(A_0 as c5x, "global:vera:council");
			}
			else
			{
				cgh.a(A_0 as c5x, "global:vera");
			}
			if (A_0.GetAspect<ery>() == null)
			{
				ery aspect = new ery(A_0 as c5x);
				A_0.SetAspect<ery>(aspect);
			}
		}
	}

	// Token: 0x060046B7 RID: 18103 RVA: 0x001D2C48 File Offset: 0x001D0E48
	public override string ce(cyt A_0, string A_1)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value)
		{
			return "council";
		}
		return null;
	}
}
