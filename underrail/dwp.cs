using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AB0 RID: 2736
[eiz("TCHMU1LC")]
[Serializable]
public sealed class dwp : cze, ISerializable
{
	// Token: 0x06003FF0 RID: 16368 RVA: 0x00184234 File Offset: 0x00182434
	private dwp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x00184240 File Offset: 0x00182440
	public dwp()
	{
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x00184248 File Offset: 0x00182448
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_mu1_clearedLunatics", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.bw)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_tch_mu1_clearedLunatics"] = true;
		}
	}
}
