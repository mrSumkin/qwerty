using System;
using System.Collections.Generic;

// Token: 0x02000BE6 RID: 3046
public sealed class bnt : jn
{
	// Token: 0x06004584 RID: 17796 RVA: 0x001C4110 File Offset: 0x001C2310
	public bnt() : base("cc_sophie", "creature\\characters\\cc_sophie")
	{
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x001C4124 File Offset: 0x001C2324
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_wa_oldManNosek_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_wa_oldManNosek_finished", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_sophie_gaveLarva", new bool?(false)).Value)
		{
			return "cc10";
		}
		return "cc_tm";
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x001C41A8 File Offset: 0x001C23A8
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
					"global:cc_sophie",
					"sophie_terrace"
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
				aspect.y6()[ddq.ay] = new bt4("global:cc_sophie");
				if (aspect2 != null)
				{
					aspect2.aa().FactionId = "coreCity";
				}
			}
		}
	}
}
