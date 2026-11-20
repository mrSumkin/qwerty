using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B55 RID: 2901
[eiz("CVW17XSSJ")]
[Serializable]
public sealed class ccz : cze, ISerializable
{
	// Token: 0x06004288 RID: 17032 RVA: 0x0019CC8C File Offset: 0x0019AE8C
	private ccz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004289 RID: 17033 RVA: 0x0019CC98 File Offset: 0x0019AE98
	public ccz()
	{
	}

	// Token: 0x0600428A RID: 17034 RVA: 0x0019CCA4 File Offset: 0x0019AEA4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cvw17x_coilSpidersSpawned", new bool?(false)).Value)
		{
			c1a c1a = serviceOrThrow.aqw();
			int num = 0;
			bu6 service = bpo.GetService<bu6>();
			if (service != null)
			{
				num = (int)service.aq2();
			}
			foreach (csd csd in Enumerable.ToList<csd>(c1a.Waypoints))
			{
				if (csd.Name.StartsWith("spawnSpider"))
				{
					c5x c5x;
					if (num > 0)
					{
						c5x = vq.a("creatures\\greaterCoilSpider", csd, false);
						num--;
					}
					else
					{
						c5x = vq.a("creatures\\coilSpider", csd, false);
					}
					if (c5x != null && c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name);
					}
				}
			}
			serviceOrThrow.aqu().r()["loc_cvw17x_coilSpidersSpawned"] = true;
			dwc dwc = new dwc();
			dwc.a(new Guid("5ca9c51a-3d92-41ad-9e1f-4a14ad3744f1"));
			dwc.a(new bt4("dispatchSpiders"));
			dwc.ym(serviceOrThrow.aqu().v().b(), null, null);
		}
	}
}
