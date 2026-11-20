using System;

// Token: 0x02000C5E RID: 3166
public sealed class csh : jn
{
	// Token: 0x0600471E RID: 18206 RVA: 0x001D5710 File Offset: 0x001D3910
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x0600471F RID: 18207 RVA: 0x001D5718 File Offset: 0x001D3918
	public csh() : base("xphw_wilkos", "creature\\characters\\xphw\\wilkos")
	{
	}

	// Token: 0x06004720 RID: 18208 RVA: 0x001D572C File Offset: 0x001D392C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_theTripContinues", new bool?(false)).Value)
		{
			return "xphw_exobase_tun";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_started", new bool?(false)).Value)
		{
			return "xphw_darkTer2";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_gatheredCrew", new bool?(false)).Value)
		{
			return "xphw_up";
		}
		if (am9.c())
		{
			return "up-cc";
		}
		return null;
	}
}
