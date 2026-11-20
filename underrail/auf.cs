using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A88 RID: 2696
[eiz("TCHWW5FC")]
[Serializable]
public sealed class auf : cze, ISerializable
{
	// Token: 0x06003F5A RID: 16218 RVA: 0x0017FC24 File Offset: 0x0017DE24
	private auf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x0017FC30 File Offset: 0x0017DE30
	public auf()
	{
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x0017FC3C File Offset: 0x0017DE3C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_killedWestWingFaceless", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.cg)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_tch_killedWestWingFaceless"] = true;
		}
	}
}
