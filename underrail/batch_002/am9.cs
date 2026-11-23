using System;
using Ouroboros.Common.Data;

// Token: 0x02000689 RID: 1673
public static class am9
{
	// Token: 0x06002AEA RID: 10986 RVA: 0x000F58E4 File Offset: 0x000F3AE4
	private static PropertyCollection e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			return serviceOrThrow.aqu().r();
		}
		return new PropertyCollection();
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x000F5914 File Offset: 0x000F3B14
	public static bool d()
	{
		return am9.e().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value;
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x000F5940 File Offset: 0x000F3B40
	public static bool c()
	{
		return am9.e().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value;
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x000F596C File Offset: 0x000F3B6C
	public static bool b()
	{
		return am9.e().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x000F5998 File Offset: 0x000F3B98
	public static bool a()
	{
		return am9.e().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
	}
}
