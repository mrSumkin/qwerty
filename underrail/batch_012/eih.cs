using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020008DB RID: 2267
[eiz("BENPP")]
[Serializable]
public class eih : c13, ISerializable
{
	// Token: 0x06003856 RID: 14422 RVA: 0x0014E10C File Offset: 0x0014C30C
	private eih(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003857 RID: 14423 RVA: 0x0014E114 File Offset: 0x0014C314
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003858 RID: 14424 RVA: 0x0014E118 File Offset: 0x0014C318
	public List<c5x> ok(string A_0, IEnumerable<csd> A_1)
	{
		List<c5x> list = new List<c5x>();
		if (A_1 != null)
		{
			gx gx = new gx();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			List<cze> list2 = new List<cze>();
			string a_ = asp.ae;
			if (serviceOrThrow != null)
			{
				List<cze> list3 = list2;
				x6 x = new x6();
				x.a(true);
				x.a(1);
				x.a("loc_" + serviceOrThrow.aqw().y8() + "_blackEelJetSkiersKilled");
				list3.Add(x);
				if (serviceOrThrow.aqw().y8().StartsWith("xpbl_rig"))
				{
					a_ = asp.gg;
				}
			}
			foreach (csd a_2 in A_1)
			{
				c5x c5x = gx.a(a_2, new int?(15), "Generic_Jetski", "Чёрный угорь", a_, "Sailors", "support\\xpbl\\jy_eel_jet1", true, list2, false);
				if (c5x != null)
				{
					if (c5x.h.b != null)
					{
						coh coh = new d48(ez2.CreateDefinitonProvider<x2>("oddities\\blackEelInsignia"));
						if (coh != null)
						{
							c5x.h.b.aa().Bag.z3(coh, true);
						}
					}
					bfe.a(c5x, 1f, 0.85f);
					bfe.a(c5x, false);
					list.Add(c5x);
				}
			}
		}
		return list;
	}

	// Token: 0x06003859 RID: 14425 RVA: 0x0014E28C File Offset: 0x0014C48C
	public eih()
	{
	}
}
