using System;

// Token: 0x02000C00 RID: 3072
public sealed class cm2 : jn
{
	// Token: 0x060045D2 RID: 17874 RVA: 0x001C6FAC File Offset: 0x001C51AC
	public cm2() : base("fo_mayor", "creature\\characters\\fo_mayor")
	{
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x001C6FC0 File Offset: 0x001C51C0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_fo1_finalCutsceneEnded", new bool?(false)).Value)
		{
			return "fo1";
		}
		return "fo2";
	}

	// Token: 0x060045D4 RID: 17876 RVA: 0x001C7020 File Offset: 0x001C5220
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
