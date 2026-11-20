using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000941 RID: 2369
[eiz("XPBLLEDFR")]
[Serializable]
public sealed class cik : bdw, ISerializable
{
	// Token: 0x060039FA RID: 14842 RVA: 0x00156EA8 File Offset: 0x001550A8
	private cik(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x00156EB0 File Offset: 0x001550B0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x00156EB4 File Offset: 0x001550B4
	public cik()
	{
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x00156EC0 File Offset: 0x001550C0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.f5 || c5x.h.b.aa().FactionId == asp.f6))
					{
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}
}
