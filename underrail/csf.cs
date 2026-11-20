using System;

// Token: 0x02000C21 RID: 3105
public sealed class csf : jn
{
	// Token: 0x06004654 RID: 18004 RVA: 0x001CF820 File Offset: 0x001CDA20
	public csf() : base("rasso3_cutscene", "creature\\characters\\support\\tch_rassophoreTalk")
	{
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x001CF834 File Offset: 0x001CDA34
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_entry_cutsceneOver", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value)
		{
			return "tch-entry";
		}
		return null;
	}
}
