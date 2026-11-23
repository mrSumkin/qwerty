using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A99 RID: 2713
[eiz("LUSROACA")]
[Serializable]
public sealed class awa : cze, ISerializable
{
	// Token: 0x06003F94 RID: 16276 RVA: 0x00182094 File Offset: 0x00180294
	private awa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x001820A0 File Offset: 0x001802A0
	public awa()
	{
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x001820AC File Offset: 0x001802AC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROStarted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_b30_clearedProtectorate", new bool?(false)).Value)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.bh)
				{
					return;
				}
			}
			serviceOrThrow.aqu().r()["loc_b30_clearedProtectorate"] = true;
		}
	}
}
