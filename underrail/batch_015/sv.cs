using System;

// Token: 0x02000BFB RID: 3067
public sealed class sv : jn
{
	// Token: 0x060045C4 RID: 17860 RVA: 0x001C6844 File Offset: 0x001C4A44
	public sv() : base("cc_luben", "creature\\characters\\cc_luben")
	{
	}

	// Token: 0x060045C5 RID: 17861 RVA: 0x001C6858 File Offset: 0x001C4A58
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_locateICPDStarted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_luben_escaped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_locateICPDCompleted", new bool?(false)).Value)
		{
			return "cc5";
		}
		return null;
	}
}
