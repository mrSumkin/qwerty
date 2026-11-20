using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020008DD RID: 2269
[eiz("GJNPP")]
[Serializable]
public class ciy : c13, ISerializable
{
	// Token: 0x0600385F RID: 14431 RVA: 0x0014E624 File Offset: 0x0014C824
	private ciy(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003860 RID: 14432 RVA: 0x0014E62C File Offset: 0x0014C82C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003861 RID: 14433 RVA: 0x0014E630 File Offset: 0x0014C830
	public List<c5x> ok(string A_0, IEnumerable<csd> A_1)
	{
		List<c5x> list = new List<c5x>();
		if (A_1 != null)
		{
			gx gx = new gx();
			foreach (csd a_ in A_1)
			{
				c5x c5x = gx.a(a_, new int?(10), "Pirates_Jetski", null, asp.ft, null, "support\\xpbl\\pir_jets1", false, null, false);
				if (c5x != null)
				{
					bfe.a(c5x, 1f, 0.9f);
					bfe.a(c5x, false);
					list.Add(c5x);
				}
			}
		}
		return list;
	}

	// Token: 0x06003862 RID: 14434 RVA: 0x0014E6DC File Offset: 0x0014C8DC
	public ciy()
	{
	}
}
