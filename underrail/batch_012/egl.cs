using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A98 RID: 2712
[eiz("LUSROFA")]
[Serializable]
public sealed class egl : cze, ISerializable
{
	// Token: 0x06003F91 RID: 16273 RVA: 0x00181F58 File Offset: 0x00180158
	private egl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F92 RID: 16274 RVA: 0x00181F64 File Offset: 0x00180164
	public egl()
	{
	}

	// Token: 0x06003F93 RID: 16275 RVA: 0x00181F6C File Offset: 0x0018016C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_b31_clearedProtectorate", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.bh && !d4n.b.aa().Passive)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_b31_clearedProtectorate"] = true;
		}
	}
}
