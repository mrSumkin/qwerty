using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B31 RID: 2865
[eiz("GSFWH1")]
[Serializable]
public sealed class d4v : cze, ISerializable
{
	// Token: 0x06004206 RID: 16902 RVA: 0x001994E4 File Offset: 0x001976E4
	private d4v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x001994F0 File Offset: 0x001976F0
	public d4v()
	{
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x001994FC File Offset: 0x001976FC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.a, asp.a9, h.a, null, true, false, false);
			}
		}
	}
}
