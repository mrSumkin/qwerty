using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B3E RID: 2878
[eiz("TCHHGS")]
[Serializable]
public sealed class b0i : cze, ISerializable
{
	// Token: 0x06004237 RID: 16951 RVA: 0x0019A738 File Offset: 0x00198938
	private b0i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x0019A744 File Offset: 0x00198944
	public b0i()
	{
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x0019A750 File Offset: 0x00198950
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().n("tch-entry") != null)
		{
			cky cky = serviceOrThrow.aqu().ac().abu(asp.a, asp.es);
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_entry_hostileWithTchortists", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_allowedPassage", new bool?(false)).Value;
			if (cky.a == h.a && !value)
			{
				serviceOrThrow.aqu().r()["loc_tch_allowedPassage"] = false;
				serviceOrThrow.aqu().r()["loc_tch_entry_hostileWithTchortists"] = false;
			}
		}
	}
}
