using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A4C RID: 2636
[eiz("FKJ")]
[Serializable]
public sealed class cyn : cze, ISerializable
{
	// Token: 0x06003E6A RID: 15978 RVA: 0x00178D74 File Offset: 0x00176F74
	private cyn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E6B RID: 15979 RVA: 0x00178D80 File Offset: 0x00176F80
	public cyn()
	{
	}

	// Token: 0x06003E6C RID: 15980 RVA: 0x00178D8C File Offset: 0x00176F8C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 is c5x)
		{
			cwt cwt = null;
			if (A_2 != null && A_2.ContainsKey("killingBlow"))
			{
				cwt = (A_2["killingBlow"] as cwt);
			}
			if (cwt != null && cwt.i != null && cwt.i.b == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null)
				{
					serviceOrThrow.aqu().r()["global_facelessKilled"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_facelessKilled", new int?(0)).Value + 1;
				}
			}
		}
	}
}
