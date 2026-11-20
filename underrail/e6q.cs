using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000994 RID: 2452
[eiz("UPDOFDG")]
[Serializable]
public sealed class e6q : bdw, ISerializable
{
	// Token: 0x06003B4C RID: 15180 RVA: 0x0015F714 File Offset: 0x0015D914
	private e6q(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B4D RID: 15181 RVA: 0x0015F71C File Offset: 0x0015D91C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B4E RID: 15182 RVA: 0x0015F720 File Offset: 0x0015D920
	public e6q()
	{
	}

	// Token: 0x06003B4F RID: 15183 RVA: 0x0015F72C File Offset: 0x0015D92C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("up5") != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.dc)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
			}
		}
	}
}
