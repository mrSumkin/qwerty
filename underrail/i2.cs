using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B49 RID: 2889
[eiz("DCCIIBAD")]
[Serializable]
public sealed class i2 : cze, ISerializable
{
	// Token: 0x06004258 RID: 16984 RVA: 0x0019B5A4 File Offset: 0x001997A4
	private i2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004259 RID: 16985 RVA: 0x0019B5B0 File Offset: 0x001997B0
	public i2()
	{
	}

	// Token: 0x0600425A RID: 16986 RVA: 0x0019B5B8 File Offset: 0x001997B8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dc_iris_startBattle", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dc_iris_completeBattle", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.e3)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["npc_dc_iris_completeBattle"] = true;
		}
	}
}
