using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B4F RID: 2895
[eiz("DCMPWBJ")]
[Serializable]
public sealed class cxb : cze, ISerializable
{
	// Token: 0x0600426E RID: 17006 RVA: 0x0019C344 File Offset: 0x0019A544
	private cxb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600426F RID: 17007 RVA: 0x0019C350 File Offset: 0x0019A550
	public cxb()
	{
	}

	// Token: 0x06004270 RID: 17008 RVA: 0x0019C35C File Offset: 0x0019A55C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null && A_0.Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dc_irisStatus");
			string name = "loc_dc_" + A_0.Zone.y8() + "_zonePacified";
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value;
			if (classPropertyValue == "converted" || (classPropertyValue == "disabled" && !value))
			{
				foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
				{
					if (d4n.b != null && d4n.b.aa().FactionId == asp.e1)
					{
						d4n.b.aa().c(asp.a);
						if (d4n.b.a8().t.b != null)
						{
							new bzv(d4n.b.a8().t.b.y6()).h();
						}
					}
				}
				serviceOrThrow.aqu().r()[name] = true;
			}
		}
	}
}
