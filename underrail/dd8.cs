using System;

// Token: 0x02000C4B RID: 3147
public sealed class dd8 : jn
{
	// Token: 0x060046D1 RID: 18129 RVA: 0x001D3A7C File Offset: 0x001D1C7C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046D2 RID: 18130 RVA: 0x001D3A84 File Offset: 0x001D1C84
	public dd8() : base("xpbl_aegisJetSkier", "creature\\characters\\support\\xpbl\\aegisJetSkier")
	{
	}

	// Token: 0x060046D3 RID: 18131 RVA: 0x001D3A98 File Offset: 0x001D1C98
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_erwin_inCoreCity", new bool?(false)).Value && string.Equals(A_0.c().b(), "xpbl_c4", StringComparison.OrdinalIgnoreCase))
		{
			A_0.r()["npc_xpbl_le_erwin_inCoreCity"] = false;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_jetSkier_fastTravelAllowed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
		{
			int? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0));
			int num = 10;
			if (primitivePropertyValue.GetValueOrDefault() > num & primitivePropertyValue != null)
			{
				if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_erwin_inCoreCity", new bool?(false)).Value)
				{
					return "cc_dock";
				}
				if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_underAttack", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_underAttack", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_leavingDueToProfessorsDeath", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_expedition_playerFired", new bool?(false)).Value)
				{
					return "xpbl_d5";
				}
			}
		}
		return null;
	}
}
