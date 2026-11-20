using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A8F RID: 2703
[eiz("LUCBHL")]
[Serializable]
public sealed class bz7 : cze, ISerializable
{
	// Token: 0x06003F73 RID: 16243 RVA: 0x00180C2C File Offset: 0x0017EE2C
	private bz7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F74 RID: 16244 RVA: 0x00180C38 File Offset: 0x0017EE38
	public bz7()
	{
	}

	// Token: 0x06003F75 RID: 16245 RVA: 0x00180C44 File Offset: 0x0017EE44
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
					serviceOrThrow.aqu().r()["loc_hephaestus_clearBurrowers_main"] = false;
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_hephaestus_clearBurrowers_main"] = true;
		}
	}
}
