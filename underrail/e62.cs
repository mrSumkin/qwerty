using System;
using System.Collections.Generic;

// Token: 0x02000BD2 RID: 3026
public sealed class e62 : jn
{
	// Token: 0x06004546 RID: 17734 RVA: 0x001C27E0 File Offset: 0x001C09E0
	public e62() : base("sgs_explorerHLH", "creature\\characters\\sgs_explorerHLH")
	{
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x001C27F4 File Offset: 0x001C09F4
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_dun_lup-a_explorer_ready", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_sgs_dun_investigateUnderPassages_completed", new bool?(false)).Value)
		{
			return "lup-a1";
		}
		return "dun_lup-a";
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x001C2854 File Offset: 0x001C0A54
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0.GetAspect<amc>() != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (string.Equals(A_2, "lup-a1", StringComparison.OrdinalIgnoreCase) && aspect != null)
			{
				aspect.y6()[ddq.k] = new List<string>
				{
					"explorer_p1",
					"explorer_p2",
					"explorer_p3",
					"global:sgs_explorerHLH"
				};
			}
		}
	}
}
