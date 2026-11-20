using System;

// Token: 0x02000C2E RID: 3118
public sealed class d9t : jn
{
	// Token: 0x0600467F RID: 18047 RVA: 0x001D1914 File Offset: 0x001CFB14
	public d9t() : base("newton", "creature\\characters\\newton")
	{
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x001D1928 File Offset: 0x001CFB28
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_newton_survives", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_newton_survives", new bool?(false)).Value)
		{
			return "StationAlpha-Level6";
		}
		return "MushroomCoveBase";
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x001D19B0 File Offset: 0x001CFBB0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_2 == "StationAlpha-Level6")
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && !euf.o(aspect.aa().Offense.u()) && euf.o(aspect.aa().Offense.q()))
			{
				aspect.aa().Offense.k();
			}
		}
	}
}
