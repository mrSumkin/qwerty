using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AD7 RID: 2775
[eiz("XPBLAZCJ")]
[Serializable]
public sealed class c63 : cze, ISerializable
{
	// Token: 0x060040B7 RID: 16567 RVA: 0x0018A6C4 File Offset: 0x001888C4
	private c63(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040B8 RID: 16568 RVA: 0x0018A6D0 File Offset: 0x001888D0
	public c63()
	{
	}

	// Token: 0x060040B9 RID: 16569 RVA: 0x0018A6DC File Offset: 0x001888DC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_camp_wipedOut", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
		{
			string name = "loc_" + serviceOrThrow.aqw().y8() + "_aegisCleared";
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && (d4n.b.aa().FactionId == asp.f5 || d4n.b.aa().FactionId == asp.f7 || d4n.b.aa().FactionId == asp.f6))
					{
						return;
					}
				}
				serviceOrThrow.aqu().r()[name] = true;
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_le_camp_numberOfAegisZonesCleared", new int?(0)).Value;
				serviceOrThrow.aqu().r()["loc_xpbl_le_camp_numberOfAegisZonesCleared"] = ++num;
				if (num >= 3)
				{
					new ain().ym(null, null, null);
					serviceOrThrow.aqu().r()["loc_xpbl_le_camp_wipedOut"] = true;
					serviceOrThrow.aqz().atb("xpbl_expeditionNoMore", true);
				}
			}
		}
	}
}
