using System;

// Token: 0x02000C22 RID: 3106
public sealed class dvk : jn
{
	// Token: 0x06004656 RID: 18006 RVA: 0x001CF890 File Offset: 0x001CDA90
	public dvk() : base("rasso2_cutscene", "creature\\characters\\support\\tch_rassophore2")
	{
	}

	// Token: 0x06004657 RID: 18007 RVA: 0x001CF8A4 File Offset: 0x001CDAA4
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_entry_cutsceneOver", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value)
		{
			return "tch-entry";
		}
		return null;
	}
}
