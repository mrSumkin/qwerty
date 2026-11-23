using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B53 RID: 2899
[eiz("RNDGEBBRSE")]
[Serializable]
public sealed class ccd : cze, ISerializable
{
	// Token: 0x06004282 RID: 17026 RVA: 0x0019CB54 File Offset: 0x0019AD54
	private ccd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x0019CB60 File Offset: 0x0019AD60
	public ccd()
	{
	}

	// Token: 0x06004284 RID: 17028 RVA: 0x0019CB6C File Offset: 0x0019AD6C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c5x c5x = new ar7(new Guid("182d3dbd-b4d9-46bb-83e2-0bf89a2085c8"), A_0.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.h.b.aa().Gear.h().a(null, true);
			}
		}
	}
}
