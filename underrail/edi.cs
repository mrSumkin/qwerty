using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B2F RID: 2863
[eiz("GSFWR2")]
[Serializable]
public sealed class edi : cze, ISerializable
{
	// Token: 0x06004200 RID: 16896 RVA: 0x001991DC File Offset: 0x001973DC
	private edi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004201 RID: 16897 RVA: 0x001991E8 File Offset: 0x001973E8
	public edi()
	{
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x001991F4 File Offset: 0x001973F4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.a7, asp.a, h.a, null, true, false, false);
				bv.a(asp.a8, asp.a, h.a, null, true, false, false);
				bv.a(asp.a, asp.a9, h.d, null, true, false, false);
			}
		}
	}
}
