using System;

// Token: 0x02000BF8 RID: 3064
public sealed class kj : jn
{
	// Token: 0x060045BA RID: 17850 RVA: 0x001C6364 File Offset: 0x001C4564
	public kj() : base("cc_sneaky", "creature\\characters\\cc_sneaky")
	{
	}

	// Token: 0x060045BB RID: 17851 RVA: 0x001C6378 File Offset: 0x001C4578
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value)
		{
			return "cc_bar";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value)
		{
			return "cc_abandoned";
		}
		return "cc16";
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x001C63DC File Offset: 0x001C45DC
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "cc_abandoned", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_tidyUp", new bool?(false)).Value)
		{
			return "tidy";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_unboarded", new bool?(false)).Value)
		{
			return "ub";
		}
		return null;
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x001C6450 File Offset: 0x001C4650
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		string text = "global:cc_sneaky";
		if (string.Equals(A_2, "cc_abandoned", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_tidyUp", new bool?(false)).Value)
			{
				text += ":tidy";
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_unboarded", new bool?(false)).Value)
			{
				text += ":ub";
			}
		}
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			aspect.y6()[ddq.ay] = new bt4(text);
		}
	}
}
