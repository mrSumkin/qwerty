using System;

// Token: 0x02000C37 RID: 3127
public sealed class pr : jn
{
	// Token: 0x06004699 RID: 18073 RVA: 0x001D233C File Offset: 0x001D053C
	public pr() : base("jye_rocks1", "object\\plot\\jye_rocks1")
	{
	}

	// Token: 0x0600469A RID: 18074 RVA: 0x001D2350 File Offset: 0x001D0550
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jyambramsmessenger2_talkedToPlayer", new bool?(false)).Value)
		{
			return "jye2";
		}
		return null;
	}
}
