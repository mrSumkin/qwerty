using System;

// Token: 0x02000BFA RID: 3066
public sealed class o5 : jn
{
	// Token: 0x060045C2 RID: 17858 RVA: 0x001C67D0 File Offset: 0x001C49D0
	public o5() : base("cc_garry", "creature\\characters\\cc_garry")
	{
	}

	// Token: 0x060045C3 RID: 17859 RVA: 0x001C67E8 File Offset: 0x001C49E8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_arena_pulverizerReward", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_garry_getReady", new bool?(false)).Value)
		{
			return "cc11";
		}
		return null;
	}
}
