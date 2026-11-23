using System;

// Token: 0x02000BED RID: 3053
public sealed class ahp : jn
{
	// Token: 0x0600459D RID: 17821 RVA: 0x001C4F70 File Offset: 0x001C3170
	public ahp() : base("fd_hutch", "creature\\characters\\fd_hutch")
	{
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x001C4F88 File Offset: 0x001C3188
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_GetEquipmentFromJunkyardStarted", new bool?(false)).Value)
		{
			return "jyfd";
		}
		return "lup-b3";
	}
}
