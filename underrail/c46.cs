using System;

// Token: 0x02000C01 RID: 3073
public sealed class c46 : jn
{
	// Token: 0x060045D5 RID: 17877 RVA: 0x001C7084 File Offset: 0x001C5284
	public c46() : base("fo_hugo", "creature\\characters\\fo_hugo")
	{
	}

	// Token: 0x060045D6 RID: 17878 RVA: 0x001C7098 File Offset: 0x001C5298
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_hugo_saved", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_barkeeper_toldAboutHugo", new bool?(false)).Value)
		{
			return "lu-b26x";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("cc_ps_acidHunters_started", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("cc_ct_acidHunters_started", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("cc_jkk_acidHunters_started", new bool?(false)).Value)
		{
			return null;
		}
		return "fo3";
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x001C7164 File Offset: 0x001C5364
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && string.Equals(A_2, "lu-b26x", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = "foundry_hugo";
			}
		}
	}
}
