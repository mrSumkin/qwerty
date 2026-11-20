using System;

// Token: 0x02000C52 RID: 3154
public sealed class amx : jn
{
	// Token: 0x060046EC RID: 18156 RVA: 0x001D45B8 File Offset: 0x001D27B8
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x001D45C0 File Offset: 0x001D27C0
	public amx() : base("le_technician", "creature\\characters\\support\\xpbl\\le_technician")
	{
	}

	// Token: 0x060046EE RID: 18158 RVA: 0x001D45D4 File Offset: 0x001D27D4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_technician_discovered", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value && cky.a != h.a)
		{
			return "xpbl_e6";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_started", new bool?(false)).Value)
		{
			return "xpbl_d5";
		}
		return "xpbl_d6";
	}

	// Token: 0x060046EF RID: 18159 RVA: 0x001D4734 File Offset: 0x001D2934
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
		{
			return "light";
		}
		return "cell";
	}
}
