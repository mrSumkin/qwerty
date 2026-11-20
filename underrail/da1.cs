using System;

// Token: 0x02000BEF RID: 3055
public sealed class da1 : jn
{
	// Token: 0x060045A3 RID: 17827 RVA: 0x001C5584 File Offset: 0x001C3784
	public da1() : base("fd_mlady", "creature\\characters\\fd_mlady")
	{
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x001C5598 File Offset: 0x001C3798
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_GetEquipmentFromJunkyardStarted", new bool?(false)).Value)
		{
			return "jyfd";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("faction_FreeDrones_joined", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_rc_envoy_dead", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_rc_envoy_letHimEscape", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_toldBaseCode", new bool?(false)).Value)
		{
			return "jy1";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_pissedOff", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_toldBaseCode", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_rc_herve_toldNoTrainSearch", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_freeDrones_attacked", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_FreeDrones_joined", new bool?(false)).Value)
		{
			return "cc_cityEnter";
		}
		return null;
	}
}
