using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B26 RID: 2854
[eiz("XPBLLUXDHCC")]
[Serializable]
public sealed class am : cze, ISerializable
{
	// Token: 0x060041DA RID: 16858 RVA: 0x0019767C File Offset: 0x0019587C
	private am(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041DB RID: 16859 RVA: 0x00197688 File Offset: 0x00195888
	public am()
	{
	}

	// Token: 0x060041DC RID: 16860 RVA: 0x00197690 File Offset: 0x00195890
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lux_dh_allCatsKilled", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.fp)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_lux_dh_allCatsKilled"] = true;
		}
	}
}
