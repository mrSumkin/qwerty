using System;

// Token: 0x02000C50 RID: 3152
public sealed class hh : jn
{
	// Token: 0x060046E6 RID: 18150 RVA: 0x001D443C File Offset: 0x001D263C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x001D4444 File Offset: 0x001D2644
	public hh() : base("xpbl_woundedSecTrooper", "creature\\characters\\support\\xpbl\\aegis_woundedSecTrooper")
	{
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x001D4458 File Offset: 0x001D2658
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rf_locatedMicrochipEncoder", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_hc_locatedDispatcherConsole", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_woundedSecTropper_died", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_allInvadersKilled", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value) && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return "xpbl_d6";
		}
		return null;
	}
}
