using System;
using System.Collections.Generic;

// Token: 0x020005A1 RID: 1441
public sealed class cac : cz7
{
	// Token: 0x06002641 RID: 9793 RVA: 0x000D85B4 File Offset: 0x000D67B4
	public void ae2(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().y8() == "cc_arena")
		{
			Dictionary<string, int> dictionary = this.a(serviceOrThrow.aqu());
			if (A_0 == eyy.aq)
			{
				int num;
				dictionary.TryGetValue(A_0, out num);
				num = (dictionary[A_0] = num + 1);
				return;
			}
			dictionary[A_0] = 1;
		}
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x000D8634 File Offset: 0x000D6834
	public void ae3(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().y8() == "cc_arena")
		{
			Dictionary<string, int> dictionary = this.a(serviceOrThrow.aqu());
			int num;
			dictionary.TryGetValue(A_0, out num);
			num++;
			dictionary[A_0] = num;
		}
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x000D8698 File Offset: 0x000D6898
	private Dictionary<string, int> a(cyt A_0)
	{
		Dictionary<string, int> dictionary = A_0.r()["arenaStats"] as Dictionary<string, int>;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, int>();
			A_0.r()["arenaStats"] = dictionary;
		}
		return dictionary;
	}
}
