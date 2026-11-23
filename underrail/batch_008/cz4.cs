using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A03 RID: 2563
[eiz("XPBLDASOM")]
[Serializable]
public sealed class cz4 : bdw, ISerializable
{
	// Token: 0x06003D21 RID: 15649 RVA: 0x0016BAD0 File Offset: 0x00169CD0
	private cz4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D22 RID: 15650 RVA: 0x0016BAD8 File Offset: 0x00169CD8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D23 RID: 15651 RVA: 0x0016BADC File Offset: 0x00169CDC
	public cz4()
	{
	}

	// Token: 0x06003D24 RID: 15652 RVA: 0x0016BAE8 File Offset: 0x00169CE8
	public void av(c1a A_0, cyt A_1)
	{
		foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				@is.b((c5x)b0b);
			}
		}
	}
}
