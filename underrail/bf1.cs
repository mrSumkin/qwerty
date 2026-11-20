using System;

// Token: 0x02000BDA RID: 3034
public sealed class bf1 : jn
{
	// Token: 0x0600455C RID: 17756 RVA: 0x001C304C File Offset: 0x001C124C
	public bf1() : base("up_detritus", "creature\\characters\\up_detritus")
	{
	}

	// Token: 0x0600455D RID: 17757 RVA: 0x001C3060 File Offset: 0x001C1260
	public override string b1(cyt A_0)
	{
		cky cky = A_0.ac().abu(asp.a, asp.es);
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_tch_rista_findHealthCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_invasionStarted", new bool?(false)).Value && cky.a != h.a)
		{
			return "tch-entry";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_up_detritus_talkedInside", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_tch_rista_findHealthCompleted", new bool?(false)).Value)
		{
			return "tch-mainhall";
		}
		return null;
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x001C3128 File Offset: 0x001C1328
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "tch-mainhall", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.es;
				return;
			}
			aspect.aa().FactionId = asp.ez;
		}
	}
}
