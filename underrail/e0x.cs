using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200096F RID: 2415
[eiz("DCSSR2")]
[Serializable]
public sealed class e0x : bdw, ISerializable
{
	// Token: 0x06003AB7 RID: 15031 RVA: 0x0015C590 File Offset: 0x0015A790
	private e0x(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AB8 RID: 15032 RVA: 0x0015C598 File Offset: 0x0015A798
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AB9 RID: 15033 RVA: 0x0015C59C File Offset: 0x0015A79C
	public e0x()
	{
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x0015C5A8 File Offset: 0x0015A7A8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("dc-res3");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "dc-res3_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
