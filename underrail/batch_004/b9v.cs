using System;

// Token: 0x02000BF2 RID: 3058
public sealed class b9v : jn
{
	// Token: 0x060045AA RID: 17834 RVA: 0x001C5A48 File Offset: 0x001C3C48
	public b9v() : base("cc_daniel", "creature\\characters\\cc_daniel")
	{
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x001C5A60 File Offset: 0x001C3C60
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_watch_DanielArdaStarted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_watch_DanielArdaCompleted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_daniel_exposed", new bool?(false)).Value)
		{
			return "cc10";
		}
		return null;
	}
}
