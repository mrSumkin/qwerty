using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020008DF RID: 2271
[eiz("PCCNPP")]
[Serializable]
public class bvn : c13, ISerializable
{
	// Token: 0x06003868 RID: 14440 RVA: 0x0014E894 File Offset: 0x0014CA94
	private bvn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x0014E89C File Offset: 0x0014CA9C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600386A RID: 14442 RVA: 0x0014E8A0 File Offset: 0x0014CAA0
	public List<c5x> ok(string A_0, IEnumerable<csd> A_1)
	{
		gx gx = new gx();
		List<c5x> list = new List<c5x>();
		List<cze> list2 = new List<cze>();
		x6 x = new x6();
		x.a(true);
		x.a(1);
		x.a("faction_protectorate_coreCity_jetSkiersKilled");
		list2.Add(x);
		List<cze> a_ = list2;
		if (A_1 != null)
		{
			foreach (csd a_2 in A_1)
			{
				c5x c5x = gx.a(a_2, new int?(10), "Protectorate_Jetski", null, asp.bg, null, "support\\xpbl\\pr_jetPatrols1", false, a_, false);
				if (c5x != null)
				{
					list.Add(c5x);
				}
			}
		}
		return list;
	}

	// Token: 0x0600386B RID: 14443 RVA: 0x0014E95C File Offset: 0x0014CB5C
	public bvn()
	{
	}
}
