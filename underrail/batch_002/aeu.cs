using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009AB RID: 2475
[eiz("RCSPE")]
[Serializable]
public sealed class aeu : bdw, ISerializable
{
	// Token: 0x06003BA8 RID: 15272 RVA: 0x0016127C File Offset: 0x0015F47C
	private aeu(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BA9 RID: 15273 RVA: 0x00161284 File Offset: 0x0015F484
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BAA RID: 15274 RVA: 0x00161288 File Offset: 0x0015F488
	public aeu()
	{
	}

	// Token: 0x06003BAB RID: 15275 RVA: 0x00161294 File Offset: 0x0015F494
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b12");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b12_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
