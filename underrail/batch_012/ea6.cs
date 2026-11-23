using System;

// Token: 0x02000C3F RID: 3135
public sealed class ea6 : jn
{
	// Token: 0x060046AD RID: 18093 RVA: 0x001D2788 File Offset: 0x001D0988
	public ea6() : base("jyt_rocks2", "objects\\natural\\BigRockPile")
	{
	}

	// Token: 0x060046AE RID: 18094 RVA: 0x001D27A0 File Offset: 0x001D09A0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger2_talkedToPlayer", new bool?(false)).Value)
		{
			return null;
		}
		return "jyt5";
	}
}
