using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009B2 RID: 2482
[eiz("JYRSP")]
[Serializable]
public sealed class cc7 : bdw, ISerializable
{
	// Token: 0x06003BC4 RID: 15300 RVA: 0x00161A04 File Offset: 0x0015FC04
	private cc7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x00161A0C File Offset: 0x0015FC0C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BC6 RID: 15302 RVA: 0x00161A10 File Offset: 0x0015FC10
	public cc7()
	{
	}

	// Token: 0x06003BC7 RID: 15303 RVA: 0x00161A1C File Offset: 0x0015FC1C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			foreach (aud aud in A_0.Areas)
			{
				if (aud != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.ab)
						{
							c5x.w();
							c5x.an();
						}
					}
				}
			}
		}
	}
}
