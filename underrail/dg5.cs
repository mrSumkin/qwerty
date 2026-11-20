using System;

// Token: 0x02000BDF RID: 3039
public sealed class dg5 : jn
{
	// Token: 0x0600456F RID: 17775 RVA: 0x001C36B0 File Offset: 0x001C18B0
	public dg5() : base("tch_messenger", "creature\\characters\\support\\tch_messenger")
	{
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x001C36C4 File Offset: 0x001C18C4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<int>("loc_tch_completedEnoughInvestigationQuests", new int?(0)).Value >= 6 && (!A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_messenger_met", new bool?(false)).Value || (!A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_messenger_gaveBelt", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_eidein_choseInvestigation", new bool?(false)).Value)))
		{
			return "tch-ew2";
		}
		return null;
	}
}
