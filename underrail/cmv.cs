using System;

// Token: 0x02000C48 RID: 3144
public sealed class cmv : jn
{
	// Token: 0x060046C7 RID: 18119 RVA: 0x001D30D4 File Offset: 0x001D12D4
	public cmv() : base("jy_grover", "creature\\characters\\jy_grover")
	{
	}

	// Token: 0x060046C8 RID: 18120 RVA: 0x001D30E8 File Offset: 0x001D12E8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jygrover_stealCoreAccepted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_GroversPlan_letBothGo", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_jygrover_helpedGrover", new bool?(false)).Value)
		{
			return "jy7";
		}
		return "jy2";
	}

	// Token: 0x060046C9 RID: 18121 RVA: 0x001D316C File Offset: 0x001D136C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && string.Equals(A_2, "jy7", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("quests_jy_groversPlan_completedThroughGEP", new bool?(false)).Value)
		{
			serviceOrThrow.aqz().atc("jy_GroversPlan", true);
			A_1.r()["quests_jy_groversPlan_completedThroughGEP"] = true;
		}
	}
}
