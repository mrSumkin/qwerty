using System;

// Token: 0x02000BF6 RID: 3062
public sealed class im : jn
{
	// Token: 0x060045B2 RID: 17842 RVA: 0x001C6008 File Offset: 0x001C4208
	public im() : base("cc_vivian", "creature\\characters\\cc_vivian")
	{
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x001C601C File Offset: 0x001C421C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_vivian_meetAfterElevator", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_vivian_enterElevator", new bool?(false)).Value)
		{
			return "cc_bcf1";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jkk_helpVivianRepairsStarted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_vivian_enterElevator", new bool?(false)).Value)
		{
			return "cc_utility";
		}
		return "cc20";
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x001C60C8 File Offset: 0x001C42C8
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "cc_bcf1", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_vivian_enterElevator", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_vivian_sentToPullLever", new bool?(false)).Value)
		{
			return "FromElevator";
		}
		return "repair";
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x001C613C File Offset: 0x001C433C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (aspect != null && bn != null)
		{
			if (string.Equals(A_2, "cc_bcf1", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.ay] = new bt4("global:cc_vivian:repair");
				bn.b().Equals(false);
				return;
			}
			if (string.Equals(A_2, "cc_utility", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.ay] = new bt4("global:cc_vivian");
				bn.b().Equals(true);
				return;
			}
			aspect.y6()[ddq.ay] = new bt4("global:cc_vivian");
			bn.b().Equals(true);
		}
	}
}
