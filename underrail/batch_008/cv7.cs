using System;
using System.Collections.Generic;

// Token: 0x02000BE5 RID: 3045
public sealed class cv7 : jn
{
	// Token: 0x06004581 RID: 17793 RVA: 0x001C3F40 File Offset: 0x001C2140
	public cv7() : base("cc_maxim", "creature\\characters\\cc_maxim")
	{
	}

	// Token: 0x06004582 RID: 17794 RVA: 0x001C3F54 File Offset: 0x001C2154
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_wa_oldManNosek_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_wa_oldManNosek_finished", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_maxim_inviteAsGladiator", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_maxim_inviteAsGirl", new bool?(false)).Value)
		{
			return "cc11";
		}
		return "cc_tm";
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x001C3FF8 File Offset: 0x001C21F8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "cc_tm", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.k] = new List<string>
				{
					"global:cc_maxim",
					"maxim_livingRoom"
				};
				aspect.y6()[ddq.l] = 25000;
				aspect.y6()[ddq.n] = true;
				aspect.y6().RemoveProperty(ddq.ay);
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "coreCity_taloski_manor";
					return;
				}
			}
			else
			{
				aspect.y6().RemoveProperty(ddq.k);
				aspect.y6().RemoveProperty(ddq.l);
				aspect.y6().RemoveProperty(ddq.n);
				aspect.y6()[ddq.ay] = new bt4("global:cc_maxim");
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "coreCity";
				}
			}
		}
	}
}
