using System;

// Token: 0x02000BF7 RID: 3063
public sealed class ca1 : jn
{
	// Token: 0x060045B6 RID: 17846 RVA: 0x001C620C File Offset: 0x001C440C
	public ca1() : base("cc_ola", "creature\\characters\\cc_ola")
	{
	}

	// Token: 0x060045B7 RID: 17847 RVA: 0x001C6220 File Offset: 0x001C4420
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_ola_goToSewers", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_ola_unlockSewer", new bool?(false)).Value)
		{
			return "cc_s5";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_bogdan_dead", new bool?(false)).Value)
		{
			return "cc20";
		}
		return null;
	}

	// Token: 0x060045B8 RID: 17848 RVA: 0x001C62A4 File Offset: 0x001C44A4
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "cc20", StringComparison.OrdinalIgnoreCase) && A_0.r().GetPrimitivePropertyValue<bool>("quest_jkk_helpVivianRepairsCompleted", new bool?(false)).Value)
		{
			return "promoted";
		}
		return null;
	}

	// Token: 0x060045B9 RID: 17849 RVA: 0x001C62EC File Offset: 0x001C44EC
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		string text = "global:cc_ola";
		if (string.Equals(A_2, "cc20", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("quest_jkk_helpVivianRepairsCompleted", new bool?(false)).Value)
		{
			text += ":promoted";
		}
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			aspect.y6()[ddq.ay] = new bt4(text);
		}
	}
}
