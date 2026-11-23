using System;

// Token: 0x02000BF3 RID: 3059
public sealed class eac : jn
{
	// Token: 0x060045AC RID: 17836 RVA: 0x001C5AE0 File Offset: 0x001C3CE0
	public eac() : base("cc_ohad", "creature\\characters\\cc_ohad")
	{
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x001C5AF4 File Offset: 0x001C3CF4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_gaveFirstMissions", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_watch_DanielArdaCompleted", new bool?(false)).Value)
		{
			return "cc_cityEnter";
		}
		return null;
	}
}
