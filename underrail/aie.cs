using System;

// Token: 0x02000C47 RID: 3143
public sealed class aie : jn
{
	// Token: 0x060046C5 RID: 18117 RVA: 0x001D3038 File Offset: 0x001D1238
	public aie() : base("jy_treasa", "creature\\characters\\jy_treasa")
	{
	}

	// Token: 0x060046C6 RID: 18118 RVA: 0x001D3050 File Offset: 0x001D1250
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jygrover_stealCoreAccepted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_GroversPlan_turnedOnGroverFirst", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_GroversPlan_letBothGo", new bool?(false)).Value)
		{
			return "jy7";
		}
		return "jy3";
	}
}
