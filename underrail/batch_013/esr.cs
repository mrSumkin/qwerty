using System;

// Token: 0x02000C23 RID: 3107
public sealed class esr : jn
{
	// Token: 0x06004658 RID: 18008 RVA: 0x001CF900 File Offset: 0x001CDB00
	public esr() : base("rasso1_cutscene", "creature\\characters\\support\\tch_rassophore1")
	{
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x001CF914 File Offset: 0x001CDB14
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_entry_cutsceneOver", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value)
		{
			return "tch-entry";
		}
		return null;
	}
}
