using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B27 RID: 2855
[eiz("XPBLUPDHCM")]
[Serializable]
public sealed class awv : cze, ISerializable
{
	// Token: 0x060041DD RID: 16861 RVA: 0x001977A0 File Offset: 0x001959A0
	private awv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041DE RID: 16862 RVA: 0x001977AC File Offset: 0x001959AC
	public awv()
	{
	}

	// Token: 0x060041DF RID: 16863 RVA: 0x001977B8 File Offset: 0x001959B8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_up_dh_allMutantsKilled", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.@as)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_up_dh_allMutantsKilled"] = true;
		}
	}
}
