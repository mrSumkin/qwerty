using System;

// Token: 0x02000BFF RID: 3071
public sealed class d94 : jn
{
	// Token: 0x060045CF RID: 17871 RVA: 0x001C6ED4 File Offset: 0x001C50D4
	public d94() : base("fo_chief", "creature\\characters\\fo_chief")
	{
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x001C6EE8 File Offset: 0x001C50E8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_fo1_finalCutsceneEnded", new bool?(false)).Value)
		{
			return "fo1";
		}
		return "fo2";
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x001C6F48 File Offset: 0x001C5148
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bn5 aspect = A_0.GetAspect<bn5>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "fo1", StringComparison.OrdinalIgnoreCase))
				{
					aspect.b().Equals(false);
				}
				if (string.Equals(A_2, "fo2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.b().Equals(true);
				}
			}
		}
	}
}
