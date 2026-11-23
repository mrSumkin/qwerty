using System;

// Token: 0x02000BD0 RID: 3024
public sealed class deo : jn
{
	// Token: 0x06004541 RID: 17729 RVA: 0x001C25F4 File Offset: 0x001C07F4
	public deo() : base("cc_tchortistInvestigator", "creature\\characters\\cc_tchortistInvestigator")
	{
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x001C260C File Offset: 0x001C080C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_tchortistInvestigatorDead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("cc_acidHunters_secretEntranceKnown", new bool?(false)).Value)
		{
			return null;
		}
		int value = A_0.r().GetPrimitivePropertyValue<int>("npc_cc_crook_leadingPos", new int?(0)).Value;
		if (value == 0 && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_crook_retreat", new bool?(false)).Value)
		{
			return "cc4";
		}
		if (value == 1)
		{
			return "CC_passage";
		}
		return null;
	}

	// Token: 0x06004543 RID: 17731 RVA: 0x001C26C0 File Offset: 0x001C08C0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 is c5x && A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_crook_retreat", new bool?(false)).Value)
		{
			if (A_2.Equals("CC4"))
			{
				A_1.r()["npc_cc_crook_leadingPos"] = 1;
			}
			if (A_2.Equals("CC_passage"))
			{
				A_1.r()["npc_cc_crook_leadingPos"] = 2;
			}
		}
	}
}
