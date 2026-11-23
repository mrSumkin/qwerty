using System;

// Token: 0x02000C4C RID: 3148
public sealed class e6a : jn
{
	// Token: 0x060046D4 RID: 18132 RVA: 0x001D3C50 File Offset: 0x001D1E50
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046D5 RID: 18133 RVA: 0x001D3C58 File Offset: 0x001D1E58
	public e6a() : base("xpbl_sneak", "creature\\characters\\support\\xpbl\\pir_pirateSneak")
	{
	}

	// Token: 0x060046D6 RID: 18134 RVA: 0x001D3C6C File Offset: 0x001D1E6C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_goAlone", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyDocksAtRig", new bool?(false)).Value)
		{
			return "cvw27";
		}
		return null;
	}
}
