using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A0D RID: 2573
[eiz("XPBLPIRKP")]
[Serializable]
public sealed class b4w : bdw, ISerializable
{
	// Token: 0x06003D4B RID: 15691 RVA: 0x0016D178 File Offset: 0x0016B378
	private b4w(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D4C RID: 15692 RVA: 0x0016D180 File Offset: 0x0016B380
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D4D RID: 15693 RVA: 0x0016D184 File Offset: 0x0016B384
	public b4w()
	{
	}

	// Token: 0x06003D4E RID: 15694 RVA: 0x0016D190 File Offset: 0x0016B390
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId.Contains("pirate"))
					{
						c5x.h.b.aa().a(null, null, false);
					}
				}
			}
		}
	}
}
