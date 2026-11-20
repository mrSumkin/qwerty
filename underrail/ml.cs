using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AB6 RID: 2742
[eiz("UPULWSJ")]
[Serializable]
public sealed class ml : cze, ISerializable
{
	// Token: 0x0600400C RID: 16396 RVA: 0x00184A90 File Offset: 0x00182C90
	private ml(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x00184A9C File Offset: 0x00182C9C
	public ml()
	{
	}

	// Token: 0x0600400E RID: 16398 RVA: 0x00184AA8 File Offset: 0x00182CA8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				bool flag = false;
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null && d4n.b.aa().FactionId == asp.bp && d4n.b.aa().a(serviceOrThrow.aqu().ac(), asp.a) == h.a)
					{
						flag = true;
					}
				}
				serviceOrThrow.aqu().r()["epioneLabMadeHostile"] = flag;
			}
		}
	}
}
