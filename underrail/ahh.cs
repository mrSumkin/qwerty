using System;

// Token: 0x02000BD7 RID: 3031
public sealed class ahh : jn
{
	// Token: 0x06004554 RID: 17748 RVA: 0x001C2E38 File Offset: 0x001C1038
	public ahh() : base("dc_fl_commander", "creature\\characters\\dc-flcom")
	{
	}

	// Token: 0x06004555 RID: 17749 RVA: 0x001C2E50 File Offset: 0x001C1050
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_dc_fl_cubeResolved", new bool?(false)).Value)
		{
			return "dc-de2";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value)
		{
			return "dc-flo";
		}
		return null;
	}
}
