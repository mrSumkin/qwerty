using System;

// Token: 0x02000BE2 RID: 3042
public sealed class doa : jn
{
	// Token: 0x06004577 RID: 17783 RVA: 0x001C3A30 File Offset: 0x001C1C30
	public doa() : base("tch_denzil", "creature\\characters\\tch_denzil")
	{
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x001C3A44 File Offset: 0x001C1C44
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("faction_tchortists_joined", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_samuel_sentDenzilAway", new bool?(false)).Value)
		{
			return "tch-mil";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_samuel_sentDenzilAway", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_followDenzilInside", new bool?(false)).Value)
		{
			return "tch-entry";
		}
		return null;
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x001C3B10 File Offset: 0x001C1D10
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "tch-entry", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_entry_cutsceneOver", new bool?(false)).Value)
		{
			return "hallway";
		}
		return "front";
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x001C3B60 File Offset: 0x001C1D60
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "tch-entry", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_tch_entry_cutsceneOver", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:tch_denzil:front");
					return;
				}
				aspect.y6()[ddq.ay] = new bt4("global:tch_denzil:hallway");
				return;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:tch_denzil");
			}
		}
	}
}
