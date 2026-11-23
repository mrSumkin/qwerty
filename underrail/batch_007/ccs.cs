using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E5A RID: 7770
public static class ccs
{
	// Token: 0x0600AC3D RID: 44093 RVA: 0x003F9310 File Offset: 0x003F7510
	static ccs()
	{
		ccs.a[SpecialCategory.None] = "nothing";
		ccs.a[SpecialCategory.DirtyKick] = "Dirty Kick";
		ccs.a[SpecialCategory.CookedShot] = "Cooked Shot";
	}

	// Token: 0x0400401C RID: 16412
	public static readonly Dictionary<SpecialCategory, string> a = new Dictionary<SpecialCategory, string>();
}
