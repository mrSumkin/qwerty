using System;
using System.Runtime.Serialization;

// Token: 0x02000915 RID: 2325
[eiz("CCDBCFS")]
[Serializable]
public sealed class lk : bdw, ISerializable
{
	// Token: 0x06003943 RID: 14659 RVA: 0x0015300C File Offset: 0x0015120C
	private lk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003944 RID: 14660 RVA: 0x00153014 File Offset: 0x00151214
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003945 RID: 14661 RVA: 0x00153018 File Offset: 0x00151218
	public lk()
	{
	}

	// Token: 0x06003946 RID: 14662 RVA: 0x00153024 File Offset: 0x00151224
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc_bcf2");
		if (aud != null)
		{
			foreach (b0b b0b in aud.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().FactionId == "monsters" && c5x.h.b.aa().b(d8o.e) && c5x.y8() != "Kamikaze Bot")
				{
					cgh.b(c5x);
					c5x.h.b.aa().c(asp.a);
					c5x.h.b.aa().FactionId = "neutral";
				}
			}
		}
	}
}
