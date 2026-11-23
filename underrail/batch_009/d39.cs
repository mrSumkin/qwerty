using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x020007CE RID: 1998
public static class d39
{
	// Token: 0x0600321F RID: 12831 RVA: 0x00134894 File Offset: 0x00132A94
	public static Dictionary<PlayerHouseElement, string> a(cyt A_0, string A_1 = null)
	{
		string name = "cc_ph_houseState" + A_1;
		Dictionary<PlayerHouseElement, string> dictionary = A_0.r().GetClassPropertyValue<Dictionary<PlayerHouseElement, string>>(name);
		if (dictionary == null)
		{
			dictionary = new Dictionary<PlayerHouseElement, string>();
			A_0.r()[name] = dictionary;
		}
		return dictionary;
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x001348D4 File Offset: 0x00132AD4
	public static HashSet<string> a(cyt A_0)
	{
		HashSet<string> hashSet = A_0.r().GetClassPropertyValue<HashSet<string>>("cc_ph_ownedItems");
		if (hashSet == null)
		{
			hashSet = new HashSet<string>();
			A_0.r()["cc_ph_ownedItems"] = hashSet;
		}
		return hashSet;
	}
}
