using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000995 RID: 2453
[eiz("UPDDFD")]
[Serializable]
public sealed class ehn : bdw, ISerializable
{
	// Token: 0x06003B50 RID: 15184 RVA: 0x0015F814 File Offset: 0x0015DA14
	private ehn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B51 RID: 15185 RVA: 0x0015F81C File Offset: 0x0015DA1C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x0015F820 File Offset: 0x0015DA20
	public ehn()
	{
	}

	// Token: 0x06003B53 RID: 15187 RVA: 0x0015F82C File Offset: 0x0015DA2C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("up5-pas") != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.dd)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
			}
		}
	}
}
