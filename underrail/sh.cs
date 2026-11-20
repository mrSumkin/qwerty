using System;

// Token: 0x02000C51 RID: 3153
public sealed class sh : jn
{
	// Token: 0x060046E9 RID: 18153 RVA: 0x001D4540 File Offset: 0x001D2740
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046EA RID: 18154 RVA: 0x001D4548 File Offset: 0x001D2748
	public sh() : base("xpbl_secJenkins", "creature\\characters\\support\\xpbl\\le_jenkins")
	{
	}

	// Token: 0x060046EB RID: 18155 RVA: 0x001D455C File Offset: 0x001D275C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_investigateDepotStarted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_jenkins_met", new bool?(false)).Value)
		{
			return "xpbl_d5";
		}
		return null;
	}
}
