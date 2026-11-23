using System;

// Token: 0x02000BFD RID: 3069
public sealed class w2 : jn
{
	// Token: 0x060045C9 RID: 17865 RVA: 0x001C6B7C File Offset: 0x001C4D7C
	public w2() : base("fo_accident", "creature\\characters\\support\\fo_murderAgent")
	{
	}

	// Token: 0x060045CA RID: 17866 RVA: 0x001C6B90 File Offset: 0x001C4D90
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_melted", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_electrocuted", new bool?(false)).Value)
		{
			return "fo4";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_ranOver", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_exploded", new bool?(false)).Value)
		{
			return "fom1";
		}
		return null;
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x001C6C38 File Offset: 0x001C4E38
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "fo4", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_melted", new bool?(false)).Value)
			{
				return "metal";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_electrocuted", new bool?(false)).Value)
			{
				return "furnace";
			}
			return null;
		}
		else
		{
			if (!string.Equals(A_1, "fom1", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_ranOver", new bool?(false)).Value)
			{
				return "cart";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_exploded", new bool?(false)).Value)
			{
				return "tnt";
			}
			return null;
		}
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x001C6D10 File Offset: 0x001C4F10
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "fo4", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_melted", new bool?(false)).Value)
			{
				aspect.y6()[ddq.ay] = new bt4("global:fo_accident:metal");
			}
			if (string.Equals(A_2, "fo4", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_electrocuted", new bool?(false)).Value)
			{
				aspect.y6()[ddq.ay] = new bt4("global:fo_accident:furnace");
			}
			if (string.Equals(A_2, "fom1", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_ranOver", new bool?(false)).Value)
			{
				aspect.y6()[ddq.ay] = new bt4("global:fo_accident:cart");
			}
			if (string.Equals(A_2, "fom1", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_exploded", new bool?(false)).Value)
			{
				aspect.y6()[ddq.ay] = new bt4("global:fo_accident:tnt");
			}
		}
	}
}
