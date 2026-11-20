using System;

// Token: 0x02000C10 RID: 3088
public sealed class dbz : jn
{
	// Token: 0x0600460F RID: 17935 RVA: 0x001CAB54 File Offset: 0x001C8D54
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004610 RID: 17936 RVA: 0x001CAB5C File Offset: 0x001C8D5C
	public dbz() : base("xpbl_grim", "creature\\characters\\xpbl\\Captain")
	{
	}

	// Token: 0x06004611 RID: 17937 RVA: 0x001CAB70 File Offset: 0x001C8D70
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_interrogatingProfessor", new bool?(false)).Value)
		{
			return "xpbl_e3";
		}
		return "xpbl_g2_InnerShip";
	}
}
