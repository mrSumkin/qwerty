using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AC5 RID: 2757
[eiz("XPHWUEBMOJ")]
[Serializable]
public sealed class br8 : cze, ISerializable
{
	// Token: 0x0600403C RID: 16444 RVA: 0x00186ED0 File Offset: 0x001850D0
	private br8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600403D RID: 16445 RVA: 0x00186EDC File Offset: 0x001850DC
	public br8()
	{
	}

	// Token: 0x0600403E RID: 16446 RVA: 0x00186EE8 File Offset: 0x001850E8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() == null || service == null || serviceOrThrow.aqu().v() == null)
		{
			return;
		}
		bool flag = false;
		if (serviceOrThrow.aqu().v().IsInCombat)
		{
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b != null && d4n.b.aa().FactionId.StartsWith("exoBase", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					break;
				}
			}
		}
		bfc bfc = serviceOrThrow.ar0(serviceOrThrow.aqu().c().b(), serviceOrThrow.aqu());
		if (flag)
		{
			new dvn(bfc.Id, "xphw_BaseCombat").ym(null, null, null);
			return;
		}
		new dvn(bfc.Id, null).ym(null, null, null);
	}
}
