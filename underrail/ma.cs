using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A90 RID: 2704
[eiz("LUCBW")]
[Serializable]
public sealed class ma : cze, ISerializable
{
	// Token: 0x06003F76 RID: 16246 RVA: 0x00180D74 File Offset: 0x0017EF74
	private ma(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F77 RID: 16247 RVA: 0x00180D80 File Offset: 0x0017EF80
	public ma()
	{
	}

	// Token: 0x06003F78 RID: 16248 RVA: 0x00180D8C File Offset: 0x0017EF8C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_hephaestusCrewCompleted", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.ay)
				{
					serviceOrThrow.aqu().r()["loc_hephaestus_clearBurrowers_warehouse"] = false;
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_hephaestus_clearBurrowers_warehouse"] = true;
		}
	}
}
