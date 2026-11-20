using System;

// Token: 0x02000BD9 RID: 3033
public sealed class af8 : jn
{
	// Token: 0x06004559 RID: 17753 RVA: 0x001C2FD0 File Offset: 0x001C11D0
	public af8() : base("tch_samuel", "creature\\characters\\tch_samuel")
	{
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x001C2FE4 File Offset: 0x001C11E4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_tch_investigateFacelessCompleted", new bool?(false)).Value)
		{
			return "tch-rit";
		}
		return "tch-mil";
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x001C3020 File Offset: 0x001C1220
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (string.Equals(A_2, "tch-rit", StringComparison.OrdinalIgnoreCase))
		{
			A_1.r()["npc_tch_samuel_met"] = true;
		}
	}
}
