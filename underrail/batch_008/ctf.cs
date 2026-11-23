using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009DA RID: 2522
[eiz("RSFGH")]
[Serializable]
public sealed class ctf : bdw, ISerializable
{
	// Token: 0x06003C63 RID: 15459 RVA: 0x00165F94 File Offset: 0x00164194
	private ctf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x00165F9C File Offset: 0x0016419C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x00165FA0 File Offset: 0x001641A0
	public ctf()
	{
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x00165FAC File Offset: 0x001641AC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			aud aud = A_0.n("jy8");
			if (aud != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null)
					{
						if (c5x.h.b.aa().FactionId == asp.ab)
						{
							c5x.w();
							c5x.an();
						}
						else if (c5x.h.b.aa().FactionId == asp.y)
						{
							c5x.h.b.aa().FactionId = asp.n;
						}
					}
				}
			}
		}
	}
}
