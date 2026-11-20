using System;

// Token: 0x02000C34 RID: 3124
public sealed class cfq : jn
{
	// Token: 0x06004690 RID: 18064 RVA: 0x001D1F04 File Offset: 0x001D0104
	public cfq() : base("tanner", "creature\\characters\\tanner")
	{
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x001D1F18 File Offset: 0x001D0118
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_talkedAboutInvasion", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("introDone", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value)
		{
			return "StationAlpha-Level4";
		}
		return "StationAlpha-Level3";
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x001D2010 File Offset: 0x001D0210
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		string a_;
		string a_2;
		if (A_2 == "StationAlpha-Level3" && A_1.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_tanner_talkedAboutInvasion", new bool?(false)).Value)
		{
			a_ = "events\\sgs_invasionMeeting";
			a_2 = "tanner2";
		}
		else
		{
			a_ = "characters\\tanner1";
			a_2 = "global:tanner";
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(a_);
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			aspect.y6()[ddq.ay] = new bt4(a_2);
		}
		if (A_0.GetAspect<ery>() == null)
		{
			ery aspect2 = new ery(A_0 as c5x);
			A_0.SetAspect<ery>(aspect2);
		}
	}
}
