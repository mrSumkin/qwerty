using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A49 RID: 2633
[eiz("DCFLOFC")]
[Serializable]
public sealed class dwn : cze, ISerializable
{
	// Token: 0x06003E59 RID: 15961 RVA: 0x001784C4 File Offset: 0x001766C4
	private dwn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x001784D0 File Offset: 0x001766D0
	public dwn()
	{
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x001784DC File Offset: 0x001766DC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-flo_killedFaceless", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && (d4n.b.aa().FactionId == asp.ch || d4n.b.aa().FactionId == asp.ci))
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_dc-flo_killedFaceless"] = true;
		}
	}
}
