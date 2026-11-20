using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200099F RID: 2463
[eiz("JYDPSAD")]
[Serializable]
public sealed class dgt : bdw, ISerializable
{
	// Token: 0x06003B78 RID: 15224 RVA: 0x00160158 File Offset: 0x0015E358
	private dgt(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B79 RID: 15225 RVA: 0x00160160 File Offset: 0x0015E360
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B7A RID: 15226 RVA: 0x00160164 File Offset: 0x0015E364
	public dgt()
	{
	}

	// Token: 0x06003B7B RID: 15227 RVA: 0x00160170 File Offset: 0x0015E370
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.Areas[0];
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null && serviceOrThrow != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.bh)
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
