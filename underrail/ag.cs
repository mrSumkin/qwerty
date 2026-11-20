using System;

// Token: 0x02000BF5 RID: 3061
public sealed class ag : jn
{
	// Token: 0x060045B0 RID: 17840 RVA: 0x001C5E30 File Offset: 0x001C4030
	public ag() : base("cc_arenaMessenger", "creature\\characters\\support\\cc_arenaMessenger")
	{
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x001C5E44 File Offset: 0x001C4044
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_arena_masterExploderDefeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_ola_talkAcceptFamily", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_ola_gaveRewardRepairs", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_arenaMessenger_met", new bool?(false)).Value)
		{
			return "cc11";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_arena_masterExploderDefeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_harlan_talkAcceptFamily", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_ct_defendWarehouseCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_arenaMessenger_met", new bool?(false)).Value)
		{
			return "cc11";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_arena_masterExploderDefeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_stratford_talkAcceptFamily", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_ps_ClearWarehouseCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_arenaMessenger_met", new bool?(false)).Value)
		{
			return "cc11";
		}
		return null;
	}
}
