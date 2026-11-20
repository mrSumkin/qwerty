using System;

// Token: 0x02000BF9 RID: 3065
public sealed class asm : jn
{
	// Token: 0x060045BE RID: 17854 RVA: 0x001C64FC File Offset: 0x001C46FC
	public asm() : base("cc_mykola", "creature\\characters\\cc_mykola")
	{
	}

	// Token: 0x060045BF RID: 17855 RVA: 0x001C6510 File Offset: 0x001C4710
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_mykola_goesToRepair", new bool?(false)).Value)
		{
			return "cc_abandoned";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_mykola_goesToRepair", new bool?(false)).Value)
		{
			return "cc16";
		}
		return "cc9";
	}

	// Token: 0x060045C0 RID: 17856 RVA: 0x001C65BC File Offset: 0x001C47BC
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "cc_abandoned", StringComparison.OrdinalIgnoreCase))
		{
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
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value)
			{
				return "tunFixed";
			}
			return null;
		}
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x001C667C File Offset: 0x001C487C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		string text = "global:cc_mykola";
		if (string.Equals(A_2, "cc16", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value)
		{
			text += ":tunFixed";
		}
		if (string.Equals(A_2, "cc_abandoned", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value)
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
