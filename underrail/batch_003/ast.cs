using System;
using System.Collections.Generic;

// Token: 0x020004BC RID: 1212
public static class ast
{
	// Token: 0x06001EFD RID: 7933 RVA: 0x000ABCE8 File Offset: 0x000A9EE8
	public static bool a(Version A_0)
	{
		return dm9.d.Major != A_0.Major || A_0 > dm9.d;
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x000ABD0C File Offset: 0x000A9F0C
	public static bool a(Version A_0, List<string> A_1)
	{
		if (dm9.d.Major != A_0.Major && dm9.d >= A_0)
		{
			return true;
		}
		HashSet<string> hashSet = dk2.b();
		foreach (string text in A_1)
		{
			if (!hashSet.Contains(text))
			{
				return true;
			}
		}
		return false;
	}
}
