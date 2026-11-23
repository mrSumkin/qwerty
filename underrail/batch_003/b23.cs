using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200095D RID: 2397
[eiz("GMSDEAC")]
[Serializable]
public sealed class b23 : bdw, ISerializable
{
	// Token: 0x06003A6E RID: 14958 RVA: 0x0015A4A8 File Offset: 0x001586A8
	private b23(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A6F RID: 14959 RVA: 0x0015A4B0 File Offset: 0x001586B0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A70 RID: 14960 RVA: 0x0015A4B4 File Offset: 0x001586B4
	public b23()
	{
	}

	// Token: 0x06003A71 RID: 14961 RVA: 0x0015A4C0 File Offset: 0x001586C0
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("rkl2");
			if (aud != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == aju.x && c5x.h.b != null && !c5x.h.b.aa().b(d8o.e))
					{
						uk uk = new uk();
						uk.c(true);
						uk.ym(null, c5x, null);
					}
				}
			}
		}
	}
}
