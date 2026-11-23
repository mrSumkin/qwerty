using System;

// Token: 0x02000C5C RID: 3164
public sealed class dik : jn
{
	// Token: 0x06004717 RID: 18199 RVA: 0x001D559C File Offset: 0x001D379C
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x06004718 RID: 18200 RVA: 0x001D55A4 File Offset: 0x001D37A4
	public dik() : base("xphw_torrence", "creature\\characters\\xphw\\torrence")
	{
	}

	// Token: 0x06004719 RID: 18201 RVA: 0x001D55B8 File Offset: 0x001D37B8
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
		return null;
	}
}
