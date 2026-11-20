using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A8C RID: 2700
[eiz("UFMOJ")]
[Serializable]
public sealed class day : cze, ISerializable
{
	// Token: 0x06003F66 RID: 16230 RVA: 0x0018068C File Offset: 0x0017E88C
	private day(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x00180698 File Offset: 0x0017E898
	public day()
	{
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x001806A4 File Offset: 0x0017E8A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && A_0 != null && A_0.Zone != null)
		{
			bool flag = false;
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b != null && d4n.b.aa().FactionId.StartsWith("faceless", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					break;
				}
			}
			bfc bfc = serviceOrThrow.ar0(serviceOrThrow.aqu().c().b(), serviceOrThrow.aqu());
			if (flag)
			{
				new dvn(bfc.Id, "Faceless").ym(null, null, null);
				return;
			}
			new dvn(bfc.Id, null).ym(null, null, null);
		}
	}
}
