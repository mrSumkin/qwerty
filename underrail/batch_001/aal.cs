using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200095A RID: 2394
[eiz("UPDRSIR")]
[Serializable]
public sealed class aal : bdw, ISerializable
{
	// Token: 0x06003A62 RID: 14946 RVA: 0x0015A200 File Offset: 0x00158400
	private aal(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A63 RID: 14947 RVA: 0x0015A208 File Offset: 0x00158408
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A64 RID: 14948 RVA: 0x0015A20C File Offset: 0x0015840C
	public aal()
	{
	}

	// Token: 0x06003A65 RID: 14949 RVA: 0x0015A218 File Offset: 0x00158418
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			if (A_0.n("up10") != null)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.br)
						{
							d4n.b.a8().w();
							d4n.b.a8().an();
						}
					}
				}
			}
		}
	}
}
