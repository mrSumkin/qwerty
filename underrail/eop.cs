using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010FD RID: 4349
[eiz("H09")]
[Serializable]
public sealed class eop : cze, ISerializable
{
	// Token: 0x06005C41 RID: 23617 RVA: 0x0027793C File Offset: 0x00275B3C
	private eop(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x00277948 File Offset: 0x00275B48
	public eop()
	{
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x00277950 File Offset: 0x00275B50
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			serviceOrThrow.aqu().v().Defense.a(10000, null, null, true, false, false, null);
		}
	}
}
