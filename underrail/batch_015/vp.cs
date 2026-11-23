using System;

// Token: 0x02000BEA RID: 3050
public sealed class vp : jn
{
	// Token: 0x06004593 RID: 17811 RVA: 0x001C4944 File Offset: 0x001C2B44
	public vp() : base("sgs_lenox", "creature\\characters\\sgs_lenox")
	{
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x001C4958 File Offset: 0x001C2B58
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_watch_SGSMurderCompleted", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_watch_SGSMurder_accuseBret", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_sgs_bret_dead", new bool?(false)).Value)
			{
				return "StationAlpha-Level8";
			}
			return null;
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_gaveFirstMissions", new bool?(false)).Value)
			{
				return "StationAlpha-Level3";
			}
			return null;
		}
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x001C4A00 File Offset: 0x001C2C00
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		bm6 aspect2 = A_0.GetAspect<bm6>();
		if (aspect != null && aspect2 != null)
		{
			if (string.Equals(A_2, "StationAlpha-Level8", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.j;
				aspect2.ad().RemoveProperty("Civilian");
				return;
			}
			if (string.Equals(A_2, "StationAlpha-Level3", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.f;
				aspect2.ad()["Civilian"] = true;
			}
		}
	}
}
