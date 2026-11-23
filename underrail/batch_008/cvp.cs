using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000939 RID: 2361
[eiz("TCHU1CW")]
[Serializable]
public sealed class cvp : bdw, ISerializable
{
	// Token: 0x060039DA RID: 14810 RVA: 0x00156230 File Offset: 0x00154430
	private cvp(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039DB RID: 14811 RVA: 0x00156238 File Offset: 0x00154438
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039DC RID: 14812 RVA: 0x0015623C File Offset: 0x0015443C
	public cvp()
	{
	}

	// Token: 0x060039DD RID: 14813 RVA: 0x00156248 File Offset: 0x00154448
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-util1");
		if (aud != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().FactionId.StartsWith("tchortists"))
				{
					c5x.h.b.a(null, false);
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-util1_l2") + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
