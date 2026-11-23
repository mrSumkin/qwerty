using System;

// Token: 0x02000C3E RID: 3134
public sealed class e7 : jn
{
	// Token: 0x060046AB RID: 18091 RVA: 0x001D273C File Offset: 0x001D093C
	public e7() : base("jyt_rocks3", "objects\\natural\\BigRockPile")
	{
	}

	// Token: 0x060046AC RID: 18092 RVA: 0x001D2750 File Offset: 0x001D0950
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger2_talkedToPlayer", new bool?(false)).Value)
		{
			return null;
		}
		return "jyt5";
	}
}
