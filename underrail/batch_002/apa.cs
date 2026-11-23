using System;

// Token: 0x02000BFE RID: 3070
public sealed class apa : jn
{
	// Token: 0x060045CD RID: 17869 RVA: 0x001C6E64 File Offset: 0x001C5064
	public apa() : base("fo_plasmaSentry", "creature\\characters\\support\\fo_plasmaSentry")
	{
	}

	// Token: 0x060045CE RID: 17870 RVA: 0x001C6E78 File Offset: 0x001C5078
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_helpedFinalFight", new bool?(false)).Value)
		{
			return "fo5";
		}
		return null;
	}
}
