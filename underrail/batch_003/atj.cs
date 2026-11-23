using System;

// Token: 0x02000BF1 RID: 3057
public sealed class atj : jn
{
	// Token: 0x060045A8 RID: 17832 RVA: 0x001C5964 File Offset: 0x001C3B64
	public atj() : base("fo_todor", "creature\\characters\\fo_todor")
	{
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x001C5978 File Offset: 0x001C3B78
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_todor_released", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_todor_escaped", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_prison_escapeWithKilledGuards", new bool?(false)).Value)
			{
				return null;
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_todor_talkAfterRescue", new bool?(false)).Value)
			{
				return "lu-c2";
			}
			return null;
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_gaveFirstMissions", new bool?(false)).Value)
			{
				return "fo_prison";
			}
			return null;
		}
	}
}
