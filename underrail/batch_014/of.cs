using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B6E RID: 2926
[eiz("FOGMSSJ")]
[Serializable]
public sealed class of : cze, ISerializable
{
	// Token: 0x060042F9 RID: 17145 RVA: 0x001A28E0 File Offset: 0x001A0AE0
	private of(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042FA RID: 17146 RVA: 0x001A28EC File Offset: 0x001A0AEC
	public of()
	{
	}

	// Token: 0x060042FB RID: 17147 RVA: 0x001A28F8 File Offset: 0x001A0AF8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			serviceOrThrow.aqu().r()["loc_fo_supersteelWaitingForPickup"] = false;
			List<fv> list = serviceOrThrow.aqu().r()["loc_fo_supersteelPlates"] as List<fv>;
			if (list != null)
			{
				mk mk = new mk();
				mk.GiveTo = bvl.d;
				foreach (fv a_ in list)
				{
					mk.StaticItems.z3(a_, true);
				}
				mk.ym(null, null, null);
			}
			serviceOrThrow.aqu().r().RemoveProperty("loc_fo_supersteelPlates");
		}
	}
}
