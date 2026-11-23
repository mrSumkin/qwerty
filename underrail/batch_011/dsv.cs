using System;

// Token: 0x02000BD5 RID: 3029
public sealed class dsv : jn
{
	// Token: 0x0600454F RID: 17743 RVA: 0x001C2D40 File Offset: 0x001C0F40
	public dsv() : base("fo_marcos", "creature\\characters\\fo_marcos")
	{
	}

	// Token: 0x06004550 RID: 17744 RVA: 0x001C2D54 File Offset: 0x001C0F54
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_fom1_marcosDead", new bool?(false)).Value)
		{
			return "fom8";
		}
		return null;
	}
}
