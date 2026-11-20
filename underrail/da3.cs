using System;

// Token: 0x02000C1C RID: 3100
public sealed class da3 : jn
{
	// Token: 0x06004646 RID: 17990 RVA: 0x001CECA8 File Offset: 0x001CCEA8
	public da3() : base("sgs_chester", "creature\\characters\\sgs_chester")
	{
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x001CECC0 File Offset: 0x001CCEC0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater_killedBoss", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater_completed", new bool?(false)).Value)
		{
			return "jy2";
		}
		return null;
	}
}
