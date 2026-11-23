using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B71 RID: 2929
[eiz("FOMFH")]
[Serializable]
public sealed class b33 : cze, ISerializable
{
	// Token: 0x06004305 RID: 17157 RVA: 0x001A2C70 File Offset: 0x001A0E70
	private b33(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004306 RID: 17158 RVA: 0x001A2C7C File Offset: 0x001A0E7C
	public b33()
	{
	}

	// Token: 0x06004307 RID: 17159 RVA: 0x001A2C88 File Offset: 0x001A0E88
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			(serviceOrThrow.aqu().ac() as bv9).a(asp.cz, asp.a, h.a, null, true, false, false);
		}
	}
}
