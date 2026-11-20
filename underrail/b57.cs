using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B32 RID: 2866
[eiz("GSFWR1")]
[Serializable]
public sealed class b57 : cze, ISerializable
{
	// Token: 0x06004209 RID: 16905 RVA: 0x00199550 File Offset: 0x00197750
	private b57(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x0019955C File Offset: 0x0019775C
	public b57()
	{
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x00199568 File Offset: 0x00197768
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.a7, asp.a, h.a, null, true, false, false);
				bv.a(asp.a, asp.a9, h.d, null, true, false, false);
			}
		}
	}
}
