using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B38 RID: 2872
[eiz("D10")]
[Serializable]
public sealed class byy : cze, ISerializable
{
	// Token: 0x0600421E RID: 16926 RVA: 0x0019A020 File Offset: 0x00198220
	private byy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600421F RID: 16927 RVA: 0x0019A02C File Offset: 0x0019822C
	public byy()
	{
	}

	// Token: 0x06004220 RID: 16928 RVA: 0x0019A038 File Offset: 0x00198238
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b4b service = bpo.GetService<b4b>();
		bool flag = false;
		if (service != null && service.yn() != null && service.yn().Zones.Count > 0)
		{
			aud aud = service.yn().Zones[0].n("si2");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x != null && c5x.j == cgy.b && c5x.h.b != null)
					{
						for (int i = 1; i <= 5; i++)
						{
							csd csd = aud.Zone.g("d" + i.ToString());
							if (csd != null)
							{
								csd.e();
								if (csd.Tile != null && !aw1.a(null, csd.Tile, false, null))
								{
									new d8g(null, c5x, new bt4(csd.Name), null, !flag, null, null, null, null).ym(null, null, null);
									flag = true;
								}
							}
						}
					}
				}
			}
		}
	}
}
