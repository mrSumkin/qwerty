using System;

// Token: 0x02000C03 RID: 3075
public sealed class dok : jn
{
	// Token: 0x060045DB RID: 17883 RVA: 0x001C73F8 File Offset: 0x001C55F8
	public dok() : base("fo_dan", "creature\\characters\\fo_dan")
	{
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x001C740C File Offset: 0x001C560C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_helpGorskyInCC", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value)
			{
				return "cc_abandoned";
			}
			return "cc16";
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_helpedFinalFight", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_fo1_finalCutsceneEnded", new bool?(false)).Value)
			{
				return "fo1";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
			{
				return "fo2";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_helpedFinalFight", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_helpGorskyInCC", new bool?(false)).Value)
			{
				return "fo5";
			}
			return "fo2";
		}
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x001C7578 File Offset: 0x001C5778
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && string.Equals(A_2, "fo5", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = "foundry_the_chosen_few";
			}
			string text = "global:fo_dan";
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
			bm6 aspect2 = A_0.GetAspect<bm6>();
			if (aspect2 != null)
			{
				aspect2.y6()[ddq.ay] = new bt4(text);
			}
		}
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x001C7658 File Offset: 0x001C5858
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
}
