using System;

// Token: 0x02000C40 RID: 3136
public sealed class e8x : jn
{
	// Token: 0x060046AF RID: 18095 RVA: 0x001D27D8 File Offset: 0x001D09D8
	public e8x() : base("jyt_rocks1", "objects\\natural\\BigRockPile")
	{
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x001D27F0 File Offset: 0x001D09F0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger2_talkedToPlayer", new bool?(false)).Value)
		{
			return null;
		}
		return "jyt2";
	}
}
