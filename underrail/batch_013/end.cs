using System;

// Token: 0x02000C5B RID: 3163
public sealed class end : jn
{
	// Token: 0x06004713 RID: 18195 RVA: 0x001D54A0 File Offset: 0x001D36A0
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x06004714 RID: 18196 RVA: 0x001D54A8 File Offset: 0x001D36A8
	public end() : base("xphw_buckNimble", "creature\\characters\\xphw\\buckNimble")
	{
	}

	// Token: 0x06004715 RID: 18197 RVA: 0x001D54C0 File Offset: 0x001D36C0
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
		return "xphw_up";
	}

	// Token: 0x06004716 RID: 18198 RVA: 0x001D5524 File Offset: 0x001D3724
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null && A_1.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_gatheredCrew", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xphw_nimble_meeting", new bool?(false)).Value)
		{
			aspect.y6()[ddq.bc] = "npc_xphw_nimble_meeting";
		}
	}
}
